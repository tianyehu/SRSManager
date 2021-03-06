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
    /// vhosthttpremux接口类
    /// </summary>
    [ApiController]
    [Route("")]
    public class VhostHttpRemux
    {
        /// <summary>
        /// 删除HttpRemux配置
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostHttpRemux/DeleteVhostHttpRemux")]
        public JsonResult DeleteVhostHttpRemux(string deviceId, string vhostDomain)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostHttpRemuxApis.DeleteVhostHttpRemux(srsManager, vhostDomain, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取Vhost中的HttpRemux
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/VhostHttpRemux/GetVhostHttpRemux")]
        public JsonResult GetVhostHttpRemux(string deviceId, string vhostDomain)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostHttpRemuxApis.GetVhostHttpRemux(srsManager, vhostDomain, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 设置HttpRemux
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="httpRemux"></param>
        /// <param name="createIfNotFound"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostHttpRemux/SetVhostHttpRemux")]
        public JsonResult SetVhostHttpRemux(string deviceId, string vhostDomain, HttpRemux httpRemux,
            bool createIfNotFound = false)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostHttpRemuxApis.SetVhostHttpRemux(srsManager, vhostDomain, httpRemux, out ResponseStruct rs,
                createIfNotFound);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 创建HttpRemux
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="httpRemux"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostHttpRemux/CreateVhostHttpRemux")]
        public JsonResult CreateVhostHttpRemux(string deviceId, string vhostDomain, HttpRemux httpRemux)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostHttpRemuxApis.CreateVhostHttpRemux(srsManager, vhostDomain, httpRemux, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
    }
}