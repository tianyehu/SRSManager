﻿using System.Net;
using Microsoft.AspNetCore.Mvc;
using SRSApis.SRSManager;
using SRSApis.SRSManager.Apis;
using SRSConfFile.SRSConfClass;
using SRSManageCommon;
using SRSWebApi.Attributes;

namespace SRSWebApi.Controllers
{
    /// <summary>
    /// vhostsecurity接口类
    /// </summary>
    [ApiController]
    [Route("")]
    public class VhostSecurityController
    {
        /// <summary>
        /// 删除Security配置
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostSecurity/DeleteVhostSecurity")]
        public JsonResult DeleteVhostSecurity(string deviceId, string vhostDomain)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostSecurityApis.DeleteVhostSecurity(srsManager, vhostDomain, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取Vhost中的Security
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/VhostSecurity/GetVhostSecurity")]
        public JsonResult GetVhostSecurity(string deviceId, string vhostDomain)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostSecurityApis.GetVhostSecurity(srsManager, vhostDomain, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 设置Security
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="security"></param>
        /// <param name="createIfNotFound"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostSecurity/SetVhostSecurity")]
        public JsonResult SetVhostSecurity(string deviceId, string vhostDomain, Security security,
            bool createIfNotFound = false)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostSecurityApis.SetVhostSecurity(srsManager, vhostDomain, security, out ResponseStruct rs,
                createIfNotFound);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 创建Security
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="security"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostSecurity/CreateVhostSecurity")]
        public JsonResult CreateVhostSecurity(string deviceId, string vhostDomain, Security security)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostSecurityApis.CreateVhostSecurity(srsManager, vhostDomain, security, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
    }
}