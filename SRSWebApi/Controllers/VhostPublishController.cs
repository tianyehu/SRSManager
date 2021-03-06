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
    /// vhostpublish接口类
    /// </summary>
    [ApiController]
    [Route("")]
    public class VhostPublishController
    {
        /// <summary>
        /// 删除Publish配置
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostPublish/DeleteVhostPublish")]
        public JsonResult DeleteVhostPublish(string deviceId, string vhostDomain)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostPublishApis.DeleteVhostPublish(srsManager, vhostDomain, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 获取Vhost中的Publish
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <returns></returns>
        [HttpGet]
        [AuthVerify]
        [Log]
        [Route("/VhostPublish/GetVhostPublish")]
        public JsonResult GetVhostPublish(string deviceId, string vhostDomain)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostPublishApis.GetVhostPublish(srsManager, vhostDomain, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 设置Publish
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="publish"></param>
        /// <param name="createIfNotFound"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostPublish/SetVhostPublish")]
        public JsonResult SetVhostPublish(string deviceId, string vhostDomain, Publish publish,
            bool createIfNotFound = false)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostPublishApis.SetVhostPublish(srsManager, vhostDomain, publish, out ResponseStruct rs,
                createIfNotFound);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }

        /// <summary>
        /// 创建Publish
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="vhostDomain"></param>
        /// <param name="publish"></param>
        /// <returns></returns>
        [HttpPost]
        [AuthVerify]
        [Log]
        [Route("/VhostPublish/CreateVhostPublish")]
        public JsonResult CreateVhostPublish(string deviceId, string vhostDomain, Publish publish)
        {
            //获取一个SRSManager实例
            SrsManager srsManager = SystemApis.GetSrsManagerInstanceByDeviceId(deviceId);
            if (srsManager == null)
                return new JsonResult("无法找到deviceId对应的SrsManager实例") {StatusCode = (int) HttpStatusCode.NotFound};
            var rt = VhostPublishApis.CreateVhostPublish(srsManager, vhostDomain, publish, out ResponseStruct rs);
            return Program.CommonFunctions.DelApisResult(rt, rs);
        }
    }
}