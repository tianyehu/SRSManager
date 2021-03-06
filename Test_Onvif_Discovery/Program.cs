﻿using System;
using System.Collections.Generic;
using SRSManageCommon;


namespace Test_Onvif_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "192.168.2.164";
            var username = "admin";
            var password = "";
            OnvifMonitor onvif = null;
            try
            {
                onvif = new OnvifMonitor(host, username, password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                onvif = null;
            }

            if (onvif != null)
            {
                onvif.InitMonitor().Wait();
                if (onvif.OnvifProfileList != null)
                    foreach (var st in onvif.OnvifProfileList)
                    {
                        Console.WriteLine(st.MediaUrl);
                    }

                if (onvif.MediaSourceInfoList != null)
                    foreach (var media in onvif.MediaSourceInfoList)
                    {
                        Console.WriteLine(media.ToString());
                    }

                Console.WriteLine("input cmd");
                string cmd = "";


                List<string> ls = onvif.GetProfileTokenList();


                while (true)
                {
                    float pp = -99999;
                    ResponsePosition pos = null;
                    cmd = Console.ReadLine();
                    cmd = cmd.ToUpper().Trim();
                    if (cmd.Contains("EXIT")) break;
                    switch (cmd)
                    {
                        case "UP":
                            if (onvif.PtzMove(ls[0], PtzMoveDir.UP, out pos))
                            {
                                Console.WriteLine(pos.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "DOWN":
                            if (onvif.PtzMove(ls[0], PtzMoveDir.DOWN, out pos))
                            {
                                Console.WriteLine(pos.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "LEFT":
                            if (onvif.PtzMove(ls[0], PtzMoveDir.LEFT, out pos))
                            {
                                Console.WriteLine(pos.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "RIGHT":
                            if (onvif.PtzMove(ls[0], PtzMoveDir.RIGHT, out pos))
                            {
                                Console.WriteLine(pos.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "UPLEFT":
                            if (onvif.PtzMove(ls[0], PtzMoveDir.UPLEFT, out pos))
                            {
                                Console.WriteLine(pos.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "UPRIGHT":
                            if (onvif.PtzMove(ls[0], PtzMoveDir.UPRIGHT, out pos))
                            {
                                Console.WriteLine(pos.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "DOWNLEFT":
                            if (onvif.PtzMove(ls[0], PtzMoveDir.DOWNLEFT, out pos))
                            {
                                Console.WriteLine(pos.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "DOWNRIGHT":
                            if (onvif.PtzMove(ls[0], PtzMoveDir.DOWNRIGHT, out pos))
                            {
                                Console.WriteLine(pos.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "Z+":
                            if (onvif.PtzZoom(ls[0], 0, out pp))
                            {
                                Console.WriteLine(pp.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "Z-":
                            if (onvif.PtzZoom(ls[0], -1, out pp))
                            {
                                Console.WriteLine(pp.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "MOVE":
                            ResponsePosition ppos = new ResponsePosition();
                            ppos.X = 0.05f;
                            ppos.Y = 0f;
                            ppos.Z = 0f;
                            ResponsePosition ppp = null;
                            if (onvif.PtzMoveKeep(ls[0], ppos, out ppp))
                            {
                                Console.WriteLine(ppp.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                        case "STOP":
                            ResponsePosition pppp = null;
                            if (onvif.PtzMoveKeepStop(ls[0], out pppp))
                            {
                                Console.WriteLine(pppp.ToString());
                            }
                            else
                            {
                                Console.WriteLine("not support");
                            }

                            break;
                    }
                }
            }
        }
    }
}