using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mictlanix.DotNet.Onvif;
using Mictlanix.DotNet.Onvif.Common;
using Mictlanix.DotNet.Onvif.Device;
using Mictlanix.DotNet.Onvif.Media;
using Mictlanix.DotNet.Onvif.Ptz;

namespace OnvifManager
{
    [Serializable]
    public class ResponsePosition
    {
        private float x; //水平方向位置
        private float y; //垂直方向位置
        private float z; //镜头聚焦

        public override string ToString()
        {
            return string.Format("[x={0:F5},y={1:F5},z={2:F5}]",X, Y, Z);
        }
        
        public float X
        {
            get => x;
            set => x = value;
        }

        public float Y
        {
            get => y;
            set => y = value;
        }

        public float Z
        {
            get => z;
            set => z = value;
        }
    }

    [Serializable]
    public enum Dir
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        UPLEFT,
        UPRIGHT,
        DOWNLEFT,
        DOWNRIGHT
    }

    [Serializable]
    public class OnvifProfile
    {
        private string profileToken;
        private Profile profile;
        private string mediaUrl;
        private bool ptzMoveSupport = false;
        private bool absoluteMove = false;
        private bool relativeMove = false;
        private bool continuousMove = false;

        public string ProfileToken
        {
            get => profileToken;
            set => profileToken = value;
        }

        public Profile Profile
        {
            get => profile;
            set => profile = value;
        }


        public string MediaUrl
        {
            get => mediaUrl;
            set => mediaUrl = value;
        }

        public bool PtzMoveSupport
        {
            get => ptzMoveSupport;
            set => ptzMoveSupport = value;
        }

        public bool AbsoluteMove
        {
            get => absoluteMove;
            set => absoluteMove = value;
        }

        public bool RelativeMove
        {
            get => relativeMove;
            set => relativeMove = value;
        }

        public bool ContinuousMove
        {
            get => continuousMove;
            set => continuousMove = value;
        }
    }

    [Serializable]
    public class MediaSourceInfo
    {
        private string source_token;
        private float framerate;
        private int width;
        private int height;

        public string SourceToken
        {
            get => source_token;
            set => source_token = value;
        }

        public float Framerate
        {
            get => framerate;
            set => framerate = value;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public override string ToString()
        {
            return "VideoSourceToken:" + this.source_token + "\tVideoSourceFrameRate:" + this.framerate.ToString() +
                   "\tVideoSourceResolution.Width:" + this.Width + "\tVideoSourceResolution.Height:" + this.Height;
        }
    }

    [Serializable]
    public class OnvifMonitor
    {
        private string host;
        private string username;
        private string password;
        private List<MediaSourceInfo> mediaSourceInfoList;
        private DeviceClient device;
        private MediaClient media;
        private PTZClient ptz;
        private List<OnvifProfile> onvifProfileList;
        private bool isInited = false;

        public List<MediaSourceInfo> MediaSourceInfoList
        {
            get => mediaSourceInfoList;
            set => mediaSourceInfoList = value;
        }

        public List<OnvifProfile> OnvifProfileList
        {
            get => onvifProfileList;
            set => onvifProfileList = value;
        }

        public string Host
        {
            get => host;
            set => host = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public DeviceClient Device
        {
            get => device;
            set => device = value;
        }

        public MediaClient Media
        {
            get => media;
            set => media = value;
        }

        public PTZClient Ptz
        {
            get => ptz;
            set => ptz = value;
        }


        public bool IsInited
        {
            get => isInited;
            set => isInited = value;
        }

        /// <summary>
        /// 检测ip是否为onvif设备
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CheckOnvifMonitor()
        {
            DeviceClient tmp = null;
            try
            {
                tmp =  OnvifClientFactory.CreateDeviceClientAsync(this.Host, this.Username, this.Password).Result;
            }
            catch
            {
                return false;
            }

            if (tmp == null) return false;
            return true;
        }

        /// <summary>
        /// 构造函数，初始化对象以外同时做监视器检测
        /// </summary>
        /// <param name="host"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <exception cref="Exception"></exception>
        public OnvifMonitor(string host, string username, string password)
        {
            this.host = host;
            this.username = username;
            this.password = password;
            if (!CheckOnvifMonitor().Result)
            {
                throw new Exception("此host非onvif设备");
            }
        }

        /// <summary>
        /// 获取监视器的媒体属性
        /// </summary>
        /// <returns></returns>
        public async Task<bool> GetMediaInfo()
        {
            GetVideoSourcesResponse video_sources = await Media.GetVideoSourcesAsync();
            if (video_sources != null)
            {
                MediaSourceInfoList = new List<MediaSourceInfo>();
                foreach (VideoSource vs in video_sources.VideoSources)
                {
                    MediaSourceInfoList.Add(new MediaSourceInfo()
                    {
                        Framerate = vs.Framerate,
                        Width = vs.Resolution.Width,
                        Height = vs.Resolution.Height,
                        SourceToken = vs.token,
                    });
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// 获取每个profile的rtspurl
        /// </summary>
        /// <param name="p">Profile</param>
        /// <returns></returns>
        private async Task<string> getMediaUrl(Profile p)
        {
            StreamSetup streamSetup = new StreamSetup()
            {
                Stream = StreamType.RTPUnicast,
                Transport = new Transport {Protocol = TransportProtocol.UDP}
            };
            MediaUri mediaUrl = null;
            try
            {
                mediaUrl = await media.GetStreamUriAsync(streamSetup, p.token);
            }
            catch
            {
                return null;
            }

            if (mediaUrl == null) return null;
            return mediaUrl.Uri;
        }

        /// <summary>
        /// 获取profileTonkenList
        /// </summary>
        /// <returns></returns>
        public List<string> GetProfileTokenList()
        {
            List<string> result = null;
            if (OnvifProfileList != null)
            {
                result = new List<string>();
                foreach (var l in OnvifProfileList)
                {
                    result.Add(l.ProfileToken);
                }
            }

            return result;
        }
        /// <summary>
        /// 修改摄像头缩放
        /// </summary>
        /// <param name="profileToken"></param>
        /// <param name="zoomDir">大于等于0为正向调整，小于0为反向调整</param>
        /// <param name="zoom"> 返回当前zoom大小</param>
        /// <returns></returns>

        public bool PtzZoom(string profileToken, int zoomDir, out float zoom)
        {
            try
            {
                OnvifProfile p = OnvifProfileList.FindLast(x =>
                    x.ProfileToken.Trim().ToUpper().Equals(profileToken.Trim().ToUpper()));
                if (p != null && p.PtzMoveSupport && p.RelativeMove)
                {
                    float zz = 0;
                    if (zoomDir >= 0)
                    {
                        zz = 0.05f;
                    }
                    else
                    {
                        zz = -0.05f;
                    }

                    Ptz.RelativeMoveAsync(profileToken, new PTZVector
                    {
                        PanTilt = new Vector2D
                        {
                            x = 0f,
                            y = 0f
                        },
                        Zoom = new Vector1D
                        {
                            x = zz,
                        }
                    }, new PTZSpeed
                    {
                        PanTilt = new Vector2D
                        {
                            x = 1,
                            y = 1
                        },
                        Zoom = new Vector1D
                        {
                            x = 1
                        }
                    }).Wait();
                    var ptz_status = ptz.GetStatusAsync(profileToken).Result;
                    zoom = ptz_status.Position.Zoom.x;
                    return true;
                }

                zoom = -99999;
                return false;
            }
            catch (Exception ex)
            {
                zoom = -99999;
                return false;
            }
        }
        /// <summary>
        /// 控制ptz移动
        /// </summary>
        /// <param name="profileToken"></param>
        /// <param name="dir"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public bool PtzMove(string profileToken, Dir dir, out ResponsePosition pos)
        {
            try
            {
                pos = null;
                OnvifProfile p = OnvifProfileList.FindLast(x =>
                    x.ProfileToken.Trim().ToUpper().Equals(profileToken.Trim().ToUpper()));
                if (p != null && p.PtzMoveSupport && p.RelativeMove)
                {
                    float x = 0;
                    float y = 0;
                    float z = 0;
                    switch (dir)
                    {
                        case Dir.UP:
                            x = 0f;
                            y = -0.05f;
                            z = 0f;
                            break;
                        case Dir.DOWN:
                            x = 0f;
                            y = 0.05f;
                            z = 0f;
                            break;
                        case Dir.LEFT:
                            x = -0.05f;
                            y = 0f;
                            z = 0f;
                            break;
                        case Dir.RIGHT:
                            x = 0.05f;
                            y = 0f;
                            z = 0f;
                            break;
                        case Dir.DOWNLEFT:
                            x = -0.05f;
                            y = 0.05f;
                            z = 0f;
                            break;
                        case Dir.DOWNRIGHT:
                            x = 0.05f;
                            y = 0.05f;
                            z = 0f;
                            break;
                        case Dir.UPLEFT:
                            x = -0.05f;
                            y = -0.05f;
                            z = 0f;
                            break;
                        case Dir.UPRIGHT:
                            x = 0.05f;
                            y = -0.05f;
                            z = 0f;
                            break;
                    }

                    Ptz.RelativeMoveAsync(profileToken, new PTZVector
                    {
                        PanTilt = new Vector2D
                        {
                            x = x,
                            y = y
                        },
                        Zoom = new Vector1D
                        {
                            x = z
                        }
                    }, new PTZSpeed
                    {
                        PanTilt = new Vector2D
                        {
                            x = 1,
                            y = 1
                        },
                        Zoom = new Vector1D
                        {
                            x = 1
                        }
                    }).Wait();

                    var ptz_status = ptz.GetStatusAsync(profileToken).Result;
                    pos = new ResponsePosition()
                    {
                        X = ptz_status.Position.PanTilt.x,
                        Y = ptz_status.Position.PanTilt.y,
                        Z = ptz_status.Position.Zoom.x,
                    };
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                pos = null;
                return false;
            }
        }
/// <summary>
/// 获取摄像头当前位置信息
/// </summary>
/// <param name="profileToken"></param>
/// <returns></returns>
        public ResponsePosition GetPtzPositionStatus(string profileToken)
        {
            try
            {
                var ptz_status = ptz.GetStatusAsync(profileToken).Result;
                ResponsePosition pos = new ResponsePosition()
                {
                    X = ptz_status.Position.PanTilt.x,
                    Y = ptz_status.Position.PanTilt.y,
                    Z = ptz_status.Position.Zoom.x,
                };
                return pos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取ptz支持情况
        /// </summary>
        /// <param name="p">Profile</param>
        /// <returns></returns>
        private bool getPtzMoveSupport(Profile p, out bool absoluteMove, out bool relativeMove, out bool continuousMove)
        {
            try
            {
                absoluteMove = !string.IsNullOrWhiteSpace(p.PTZConfiguration.DefaultAbsolutePantTiltPositionSpace);
                relativeMove = !string.IsNullOrWhiteSpace(p.PTZConfiguration.DefaultRelativePanTiltTranslationSpace);
                continuousMove = !string.IsNullOrWhiteSpace(p.PTZConfiguration.DefaultContinuousPanTiltVelocitySpace);
                if (absoluteMove || relativeMove || continuousMove) return true;
                return false;
            }
            catch (Exception ex)
            {
                absoluteMove = false;
                relativeMove = false;
                continuousMove = false;
                return false;
            }
        }

        /// <summary>
        /// 初始化监视器
        /// </summary>
        /// <returns></returns>
        public async Task InitMonitor()
        {
            try
            {
                Device = OnvifClientFactory.CreateDeviceClientAsync(this.Host, this.Username, this.Password).Result;
                Media = OnvifClientFactory.CreateMediaClientAsync(this.Host, this.Username, this.Password).Result;
                try
                {
                    Ptz = OnvifClientFactory.CreatePTZClientAsync(this.Host, this.Username, this.Password).Result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Ptz = null;
                }

                var profiles = Media.GetProfilesAsync().Result;
                if (profiles != null && profiles.Profiles != null && profiles.Profiles.Length > 0)
                {
                    if (OnvifProfileList == null) OnvifProfileList = new List<OnvifProfile>();
                    foreach (var profile in profiles.Profiles)
                    {
                        if (profile == null) continue;
                        OnvifProfile p = new OnvifProfile();
                        p.Profile = profile;
                        p.ProfileToken = profile.token;
                        OnvifProfileList.Add(p);
                    }
                }

                if (OnvifProfileList != null)
                {
                    for (int i = 0; i <= OnvifProfileList.Count - 1; i++)
                    {
                        if (OnvifProfileList[i] != null)
                        {
                            OnvifProfileList[i].MediaUrl = getMediaUrl(OnvifProfileList[i].Profile).Result;
                            bool a;
                            bool b;
                            bool c;
                            if (Ptz != null)
                            {
                                OnvifProfileList[i].PtzMoveSupport = getPtzMoveSupport(OnvifProfileList[i].Profile,
                                    out a,
                                    out b, out c);
                                OnvifProfileList[i].AbsoluteMove = a;
                                OnvifProfileList[i].RelativeMove = b;
                                OnvifProfileList[i].ContinuousMove = c;
                            }
                        }
                    }
                }

                if (GetMediaInfo().Result)
                {
                    //none to print
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Device = null;
                Media = null;
                ptz = null;
                OnvifProfileList = null;
            }
        }
    }
}