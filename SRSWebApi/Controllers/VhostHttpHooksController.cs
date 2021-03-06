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
    /// vhosthttphooks接口类
    /// </summary>
    [ApiController]
    [Route("")]
    public class VhostHttpHooksController
    {
        /// <summary>
        /// 删除HttpHooks配置
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostHttpHooks/DeleteVhostHttpHooks")]
        public JsonResult DeleteVhostHttpHooks(string deviceId, string vhostDomain)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostHttpHooksApis.DeleteVhostHttpHooks(srsManager, vhostDomain, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取Vhost中的HttpHooks
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/VhostHttpHooks/GetVhostHttpHooks")]
        public JsonResult GetVhostHttpHooks(string deviceId, string vhostDomain)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostHttpHooksApis.GetVhostHttpHooks(srsManager, vhostDomain, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 设置HttpHooks
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="httpHooks"></param>
        /// <param name="createIfNotFound"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostHttpHooks/SetVhostHttpHooks")]
        public JsonResult SetVhostHttpHooks(string deviceId, string vhostDomain, HttpHooks httpHooks,
            bool createIfNotFound = false)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostHttpHooksApis.SetVhostHttpHooks(srsManager, vhostDomain, httpHooks, out ResponseStruct rs,
                createIfNotFound);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 创建HttpHooks
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="httpHooks"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostHttpHooks/CreateVhostHttpHooks")]
        public JsonResult CreateVhostHttpHooks(string deviceId, string vhostDomain, HttpHooks httpHooks)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostHttpHooksApis.CreateVhostHttpHooks(srsManager, vhostDomain, httpHooks, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
    }
}