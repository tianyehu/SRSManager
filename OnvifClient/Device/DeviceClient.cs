﻿using Mictlanix.DotNet.Onvif.Common;

namespace Mictlanix.DotNet.Onvif.Device
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
        ConfigurationName = "Mictlanix.DotNet.Onvif.Device.Device")]
    public interface Device
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetServices",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetServicesResponse> GetServicesAsync(
            Mictlanix.DotNet.Onvif.Device.GetServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetServiceCapabilities", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "Capabilities")]
        System.Threading.Tasks.Task<DeviceServiceCapabilities> GetServiceCapabilitiesAsync();

        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetDeviceInformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDeviceInformationResponse>
            GetDeviceInformationAsync(Mictlanix.DotNet.Onvif.Device.GetDeviceInformationRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetSystemDateAndTime", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetSystemDateAndTimeAsync(SetDateTimeType DateTimeType, bool DaylightSavings,
            TimeZone TimeZone, DateTime UTCDateTime);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemDateAndTime", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "SystemDateAndTime")]
        System.Threading.Tasks.Task<SystemDateTime> GetSystemDateAndTimeAsync();

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetSystemFactoryDefault", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetSystemFactoryDefaultAsync(FactoryDefaultType FactoryDefault);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/UpgradeSystemFirmware", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "Message")]
        System.Threading.Tasks.Task<string> UpgradeSystemFirmwareAsync(AttachmentData Firmware);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SystemReboot",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "Message")]
        System.Threading.Tasks.Task<string> SystemRebootAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/RestoreSystem",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.RestoreSystemResponse> RestoreSystemAsync(
            Mictlanix.DotNet.Onvif.Device.RestoreSystemRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemBackup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetSystemBackupResponse> GetSystemBackupAsync(
            Mictlanix.DotNet.Onvif.Device.GetSystemBackupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemLog",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "SystemLog")]
        System.Threading.Tasks.Task<SystemLog> GetSystemLogAsync(SystemLogType LogType);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemSupportInformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "SupportInformation")]
        System.Threading.Tasks.Task<SupportInformation> GetSystemSupportInformationAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetScopes",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetScopesResponse> GetScopesAsync(
            Mictlanix.DotNet.Onvif.Device.GetScopesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetScopes",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetScopesResponse> SetScopesAsync(
            Mictlanix.DotNet.Onvif.Device.SetScopesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/AddScopes",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.AddScopesResponse> AddScopesAsync(
            Mictlanix.DotNet.Onvif.Device.AddScopesRequest request);

        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/RemoveScopes",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.RemoveScopesResponse> RemoveScopesAsync(
            Mictlanix.DotNet.Onvif.Device.RemoveScopesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetDiscoveryMode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "DiscoveryMode")]
        System.Threading.Tasks.Task<DiscoveryMode> GetDiscoveryModeAsync();

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetDiscoveryMode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetDiscoveryModeAsync(DiscoveryMode DiscoveryMode);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetRemoteDiscoveryMode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "RemoteDiscoveryMode")]
        System.Threading.Tasks.Task<DiscoveryMode> GetRemoteDiscoveryModeAsync();

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetRemoteDiscoveryMode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRemoteDiscoveryModeAsync(DiscoveryMode RemoteDiscoveryMode);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetDPAddresses", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDPAddressesResponse> GetDPAddressesAsync(
            Mictlanix.DotNet.Onvif.Device.GetDPAddressesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetDPAddresses", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDPAddressesResponse> SetDPAddressesAsync(
            Mictlanix.DotNet.Onvif.Device.SetDPAddressesRequest request);

        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetEndpointReference", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetEndpointReferenceResponse>
            GetEndpointReferenceAsync(Mictlanix.DotNet.Onvif.Device.GetEndpointReferenceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetRemoteUser",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "RemoteUser")]
        System.Threading.Tasks.Task<RemoteUser> GetRemoteUserAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetRemoteUser",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRemoteUserAsync(RemoteUser RemoteUser);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetUsers",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetUsersResponse> GetUsersAsync(
            Mictlanix.DotNet.Onvif.Device.GetUsersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/CreateUsers",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.CreateUsersResponse> CreateUsersAsync(
            Mictlanix.DotNet.Onvif.Device.CreateUsersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/DeleteUsers",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteUsersResponse> DeleteUsersAsync(
            Mictlanix.DotNet.Onvif.Device.DeleteUsersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetUser",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetUserResponse> SetUserAsync(
            Mictlanix.DotNet.Onvif.Device.SetUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetWsdlUrl",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetWsdlUrlResponse> GetWsdlUrlAsync(
            Mictlanix.DotNet.Onvif.Device.GetWsdlUrlRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetCapabilities", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCapabilitiesResponse> GetCapabilitiesAsync(
            Mictlanix.DotNet.Onvif.Device.GetCapabilitiesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetHostname",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "HostnameInformation")]
        System.Threading.Tasks.Task<HostnameInformation> GetHostnameAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetHostname",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetHostnameResponse> SetHostnameAsync(
            Mictlanix.DotNet.Onvif.Device.SetHostnameRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetHostnameFromDHCP", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "RebootNeeded")]
        System.Threading.Tasks.Task<bool> SetHostnameFromDHCPAsync(bool FromDHCP);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDNS",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "DNSInformation")]
        System.Threading.Tasks.Task<DNSInformation> GetDNSAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetDNS",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDNSResponse> SetDNSAsync(
            Mictlanix.DotNet.Onvif.Device.SetDNSRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetNTP",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "NTPInformation")]
        System.Threading.Tasks.Task<NTPInformation> GetNTPAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetNTP",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNTPResponse> SetNTPAsync(
            Mictlanix.DotNet.Onvif.Device.SetNTPRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDynamicDNS",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "DynamicDNSInformation")]
        System.Threading.Tasks.Task<DynamicDNSInformation> GetDynamicDNSAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetDynamicDNS",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDynamicDNSResponse> SetDynamicDNSAsync(
            Mictlanix.DotNet.Onvif.Device.SetDynamicDNSRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetNetworkInterfaces", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetNetworkInterfacesResponse>
            GetNetworkInterfacesAsync(Mictlanix.DotNet.Onvif.Device.GetNetworkInterfacesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetNetworkInterfaces", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "RebootNeeded")]
        System.Threading.Tasks.Task<bool> SetNetworkInterfacesAsync(string InterfaceToken,
            NetworkInterfaceSetConfiguration NetworkInterface);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetNetworkProtocols", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetNetworkProtocolsResponse> GetNetworkProtocolsAsync(
            Mictlanix.DotNet.Onvif.Device.GetNetworkProtocolsRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetNetworkProtocols", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNetworkProtocolsResponse> SetNetworkProtocolsAsync(
            Mictlanix.DotNet.Onvif.Device.SetNetworkProtocolsRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetNetworkDefaultGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "NetworkGateway")]
        System.Threading.Tasks.Task<NetworkGateway> GetNetworkDefaultGatewayAsync();

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetNetworkDefaultGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNetworkDefaultGatewayResponse>
            SetNetworkDefaultGatewayAsync(Mictlanix.DotNet.Onvif.Device.SetNetworkDefaultGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetZeroConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "ZeroConfiguration")]
        System.Threading.Tasks.Task<NetworkZeroConfiguration> GetZeroConfigurationAsync();

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetZeroConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetZeroConfigurationAsync(string InterfaceToken, bool Enabled);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetIPAddressFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "IPAddressFilter")]
        System.Threading.Tasks.Task<IPAddressFilter> GetIPAddressFilterAsync();

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetIPAddressFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetIPAddressFilterAsync(IPAddressFilter IPAddressFilter);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/AddIPAddressFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddIPAddressFilterAsync(IPAddressFilter IPAddressFilter);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/RemoveIPAddressFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveIPAddressFilterAsync(IPAddressFilter IPAddressFilter);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetAccessPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "PolicyFile")]
        System.Threading.Tasks.Task<BinaryData> GetAccessPolicyAsync();

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetAccessPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAccessPolicyAsync(BinaryData PolicyFile);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/CreateCertificate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.CreateCertificateResponse> CreateCertificateAsync(
            Mictlanix.DotNet.Onvif.Device.CreateCertificateRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetCertificates", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificatesResponse> GetCertificatesAsync(
            Mictlanix.DotNet.Onvif.Device.GetCertificatesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetCertificatesStatus", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificatesStatusResponse>
            GetCertificatesStatusAsync(Mictlanix.DotNet.Onvif.Device.GetCertificatesStatusRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetCertificatesStatus", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetCertificatesStatusResponse>
            SetCertificatesStatusAsync(Mictlanix.DotNet.Onvif.Device.SetCertificatesStatusRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/DeleteCertificates", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteCertificatesResponse> DeleteCertificatesAsync(
            Mictlanix.DotNet.Onvif.Device.DeleteCertificatesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetPkcs10Request", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetPkcs10RequestResponse> GetPkcs10RequestAsync(
            Mictlanix.DotNet.Onvif.Device.GetPkcs10RequestRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/LoadCertificates", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCertificatesResponse> LoadCertificatesAsync(
            Mictlanix.DotNet.Onvif.Device.LoadCertificatesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetClientCertificateMode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "Enabled")]
        System.Threading.Tasks.Task<bool> GetClientCertificateModeAsync();

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetClientCertificateMode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetClientCertificateModeAsync(bool Enabled);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetRelayOutputs", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetRelayOutputsResponse> GetRelayOutputsAsync(
            Mictlanix.DotNet.Onvif.Device.GetRelayOutputsRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetRelayOutputSettings", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task
            SetRelayOutputSettingsAsync(string RelayOutputToken, RelayOutputSettings Properties);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetRelayOutputState", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRelayOutputStateAsync(string RelayOutputToken, RelayLogicalState LogicalState);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SendAuxiliaryCommand", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "AuxiliaryCommandResponse")]
        System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string AuxiliaryCommand);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetCACertificates", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCACertificatesResponse> GetCACertificatesAsync(
            Mictlanix.DotNet.Onvif.Device.GetCACertificatesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/LoadCertificateWithPrivateKey", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCertificateWithPrivateKeyResponse>
            LoadCertificateWithPrivateKeyAsync(
                Mictlanix.DotNet.Onvif.Device.LoadCertificateWithPrivateKeyRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetCertificateInformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificateInformationResponse>
            GetCertificateInformationAsync(Mictlanix.DotNet.Onvif.Device.GetCertificateInformationRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/LoadCACertificates", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCACertificatesResponse> LoadCACertificatesAsync(
            Mictlanix.DotNet.Onvif.Device.LoadCACertificatesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/CreateDot1XConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task CreateDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetDot1XConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetDot1XConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "Dot1XConfiguration")]
        System.Threading.Tasks.Task<Dot1XConfiguration> GetDot1XConfigurationAsync(string Dot1XConfigurationToken);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetDot1XConfigurations", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDot1XConfigurationsResponse>
            GetDot1XConfigurationsAsync(Mictlanix.DotNet.Onvif.Device.GetDot1XConfigurationsRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/DeleteDot1XConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteDot1XConfigurationResponse>
            DeleteDot1XConfigurationAsync(Mictlanix.DotNet.Onvif.Device.DeleteDot1XConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetDot11Capabilities", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDot11CapabilitiesResponse>
            GetDot11CapabilitiesAsync(Mictlanix.DotNet.Onvif.Device.GetDot11CapabilitiesRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetDot11Status", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "Status")]
        System.Threading.Tasks.Task<Dot11Status> GetDot11StatusAsync(string InterfaceToken);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/ScanAvailableDot11Networks", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.ScanAvailableDot11NetworksResponse>
            ScanAvailableDot11NetworksAsync(Mictlanix.DotNet.Onvif.Device.ScanAvailableDot11NetworksRequest request);

        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemUris",
            ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetSystemUrisResponse> GetSystemUrisAsync(
            Mictlanix.DotNet.Onvif.Device.GetSystemUrisRequest request);

        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/StartFirmwareUpgrade", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.StartFirmwareUpgradeResponse>
            StartFirmwareUpgradeAsync(Mictlanix.DotNet.Onvif.Device.StartFirmwareUpgradeRequest request);

        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/StartSystemRestore", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.StartSystemRestoreResponse> StartSystemRestoreAsync(
            Mictlanix.DotNet.Onvif.Device.StartSystemRestoreRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetStorageConfigurations", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetStorageConfigurationsResponse>
            GetStorageConfigurationsAsync(Mictlanix.DotNet.Onvif.Device.GetStorageConfigurationsRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/CreateStorageConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "Token")]
        System.Threading.Tasks.Task<string> CreateStorageConfigurationAsync(
            StorageConfigurationData StorageConfiguration);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetStorageConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "StorageConfiguration")]
        System.Threading.Tasks.Task<StorageConfiguration> GetStorageConfigurationAsync(string Token);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetStorageConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetStorageConfigurationAsync(StorageConfiguration StorageConfiguration);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/DeleteStorageConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task DeleteStorageConfigurationAsync(string Token);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/GetGeoLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetGeoLocationResponse> GetGeoLocationAsync(
            Mictlanix.DotNet.Onvif.Device.GetGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/SetGeoLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetGeoLocationResponse> SetGeoLocationAsync(
            Mictlanix.DotNet.Onvif.Device.SetGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(
            Action = "http://www.onvif.org/ver10/device/wsdl/DeleteGeoLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteGeoLocationResponse> DeleteGeoLocationAsync(
            Mictlanix.DotNet.Onvif.Device.DeleteGeoLocationRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetServices",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetServicesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public bool IncludeCapability;

        public GetServicesRequest()
        {
        }

        public GetServicesRequest(bool IncludeCapability)
        {
            this.IncludeCapability = IncludeCapability;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetServicesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetServicesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Service")]
        public Service[] Service;

        public GetServicesResponse()
        {
        }

        public GetServicesResponse(Service[] Service)
        {
            this.Service = Service;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDeviceInformation",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetDeviceInformationRequest
    {
        public GetDeviceInformationRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDeviceInformationResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetDeviceInformationResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 2)]
        public string FirmwareVersion;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 4)]
        public string HardwareId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public string Manufacturer;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        public string Model;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 3)]
        public string SerialNumber;

        public GetDeviceInformationResponse()
        {
        }

        public GetDeviceInformationResponse(string Manufacturer, string Model, string FirmwareVersion,
            string SerialNumber, string HardwareId)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.FirmwareVersion = FirmwareVersion;
            this.SerialNumber = SerialNumber;
            this.HardwareId = HardwareId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "RestoreSystem",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class RestoreSystemRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("BackupFiles")]
        public BackupFile[] BackupFiles;

        public RestoreSystemRequest()
        {
        }

        public RestoreSystemRequest(BackupFile[] BackupFiles)
        {
            this.BackupFiles = BackupFiles;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "RestoreSystemResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class RestoreSystemResponse
    {
        public RestoreSystemResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetSystemBackup",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetSystemBackupRequest
    {
        public GetSystemBackupRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetSystemBackupResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetSystemBackupResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("BackupFiles")]
        public BackupFile[] BackupFiles;

        public GetSystemBackupResponse()
        {
        }

        public GetSystemBackupResponse(BackupFile[] BackupFiles)
        {
            this.BackupFiles = BackupFiles;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetScopes",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetScopesRequest
    {
        public GetScopesRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetScopesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetScopesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Scopes")]
        public Scope[] Scopes;

        public GetScopesResponse()
        {
        }

        public GetScopesResponse(Scope[] Scopes)
        {
            this.Scopes = Scopes;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetScopes",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetScopesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Scopes", DataType = "anyURI")]
        public string[] Scopes;

        public SetScopesRequest()
        {
        }

        public SetScopesRequest(string[] Scopes)
        {
            this.Scopes = Scopes;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetScopesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetScopesResponse
    {
        public SetScopesResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddScopes",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class AddScopesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType = "anyURI")]
        public string[] ScopeItem;

        public AddScopesRequest()
        {
        }

        public AddScopesRequest(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddScopesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class AddScopesResponse
    {
        public AddScopesResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "RemoveScopes",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class RemoveScopesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType = "anyURI")]
        public string[] ScopeItem;

        public RemoveScopesRequest()
        {
        }

        public RemoveScopesRequest(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "RemoveScopesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class RemoveScopesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType = "anyURI")]
        public string[] ScopeItem;

        public RemoveScopesResponse()
        {
        }

        public RemoveScopesResponse(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDPAddresses",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetDPAddressesRequest
    {
        public GetDPAddressesRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDPAddressesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetDPAddressesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("DPAddress")]
        public NetworkHost[] DPAddress;

        public GetDPAddressesResponse()
        {
        }

        public GetDPAddressesResponse(NetworkHost[] DPAddress)
        {
            this.DPAddress = DPAddress;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetDPAddresses",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetDPAddressesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("DPAddress")]
        public NetworkHost[] DPAddress;

        public SetDPAddressesRequest()
        {
        }

        public SetDPAddressesRequest(NetworkHost[] DPAddress)
        {
            this.DPAddress = DPAddress;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetDPAddressesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetDPAddressesResponse
    {
        public SetDPAddressesResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetEndpointReference",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetEndpointReferenceRequest
    {
        public GetEndpointReferenceRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetEndpointReferenceResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetEndpointReferenceResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public string GUID;

        public GetEndpointReferenceResponse()
        {
        }

        public GetEndpointReferenceResponse(string GUID, System.Xml.Linq.XElement[] Any)
        {
            this.GUID = GUID;
            this.Any = Any;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetUsers",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetUsersRequest
    {
        public GetUsersRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetUsersResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetUsersResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("User")]
        public User[] User;

        public GetUsersResponse()
        {
        }

        public GetUsersResponse(User[] User)
        {
            this.User = User;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CreateUsers",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class CreateUsersRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("User")]
        public User[] User;

        public CreateUsersRequest()
        {
        }

        public CreateUsersRequest(User[] User)
        {
            this.User = User;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CreateUsersResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class CreateUsersResponse
    {
        public CreateUsersResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteUsers",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class DeleteUsersRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Username")]
        public string[] Username;

        public DeleteUsersRequest()
        {
        }

        public DeleteUsersRequest(string[] Username)
        {
            this.Username = Username;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteUsersResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class DeleteUsersResponse
    {
        public DeleteUsersResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetUser",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetUserRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("User")]
        public User[] User;

        public SetUserRequest()
        {
        }

        public SetUserRequest(User[] User)
        {
            this.User = User;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetUserResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetUserResponse
    {
        public SetUserResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetWsdlUrl",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetWsdlUrlRequest
    {
        public GetWsdlUrlRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetWsdlUrlResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetWsdlUrlResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string WsdlUrl;

        public GetWsdlUrlResponse()
        {
        }

        public GetWsdlUrlResponse(string WsdlUrl)
        {
            this.WsdlUrl = WsdlUrl;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCapabilities",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCapabilitiesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public CapabilityCategory[] Category;

        public GetCapabilitiesRequest()
        {
        }

        public GetCapabilitiesRequest(CapabilityCategory[] Category)
        {
            this.Category = Category;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCapabilitiesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCapabilitiesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public Capabilities Capabilities;

        public GetCapabilitiesResponse()
        {
        }

        public GetCapabilitiesResponse(Capabilities Capabilities)
        {
            this.Capabilities = Capabilities;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetHostname",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetHostnameRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Name;

        public SetHostnameRequest()
        {
        }

        public SetHostnameRequest(string Name)
        {
            this.Name = Name;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetHostnameResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetHostnameResponse
    {
        public SetHostnameResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetDNS",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetDNSRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("SearchDomain", DataType = "token")]
        public string[] SearchDomain;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute("DNSManual")]
        public IPAddress[] DNSManual;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public bool FromDHCP;


        public SetDNSRequest()
        {
        }

        public SetDNSRequest(bool FromDHCP, string[] SearchDomain, IPAddress[] DNSManual)
        {
            this.FromDHCP = FromDHCP;
            this.SearchDomain = SearchDomain;
            this.DNSManual = DNSManual;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetDNSResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetDNSResponse
    {
        public SetDNSResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetNTP",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetNTPRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public bool FromDHCP;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("NTPManual")]
        public NetworkHost[] NTPManual;

        public SetNTPRequest()
        {
        }

        public SetNTPRequest(bool FromDHCP, NetworkHost[] NTPManual)
        {
            this.FromDHCP = FromDHCP;
            this.NTPManual = NTPManual;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetNTPResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetNTPResponse
    {
        public SetNTPResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetDynamicDNS",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetDynamicDNSRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Name;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string TTL;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public DynamicDNSType Type;

        public SetDynamicDNSRequest()
        {
        }

        public SetDynamicDNSRequest(DynamicDNSType Type, string Name, string TTL)
        {
            this.Type = Type;
            this.Name = Name;
            this.TTL = TTL;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetDynamicDNSResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetDynamicDNSResponse
    {
        public SetDynamicDNSResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetNetworkInterfaces",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetNetworkInterfacesRequest
    {
        public GetNetworkInterfacesRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetNetworkInterfacesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetNetworkInterfacesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("NetworkInterfaces")]
        public NetworkInterface[] NetworkInterfaces;

        public GetNetworkInterfacesResponse()
        {
        }

        public GetNetworkInterfacesResponse(NetworkInterface[] NetworkInterfaces)
        {
            this.NetworkInterfaces = NetworkInterfaces;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetNetworkProtocols",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetNetworkProtocolsRequest
    {
        public GetNetworkProtocolsRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetNetworkProtocolsResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetNetworkProtocolsResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("NetworkProtocols")]
        public NetworkProtocol[] NetworkProtocols;

        public GetNetworkProtocolsResponse()
        {
        }

        public GetNetworkProtocolsResponse(NetworkProtocol[] NetworkProtocols)
        {
            this.NetworkProtocols = NetworkProtocols;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetNetworkProtocols",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetNetworkProtocolsRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("NetworkProtocols")]
        public NetworkProtocol[] NetworkProtocols;

        public SetNetworkProtocolsRequest()
        {
        }

        public SetNetworkProtocolsRequest(NetworkProtocol[] NetworkProtocols)
        {
            this.NetworkProtocols = NetworkProtocols;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetNetworkProtocolsResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetNetworkProtocolsResponse
    {
        public SetNetworkProtocolsResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetNetworkDefaultGateway",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetNetworkDefaultGatewayRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("IPv4Address", DataType = "token")]
        public string[] IPv4Address;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("IPv6Address", DataType = "token")]
        public string[] IPv6Address;

        public SetNetworkDefaultGatewayRequest()
        {
        }

        public SetNetworkDefaultGatewayRequest(string[] IPv4Address, string[] IPv6Address)
        {
            this.IPv4Address = IPv4Address;
            this.IPv6Address = IPv6Address;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetNetworkDefaultGatewayResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetNetworkDefaultGatewayResponse
    {
        public SetNetworkDefaultGatewayResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CreateCertificate",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class CreateCertificateRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string CertificateID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        public string Subject;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 3)]
        public System.DateTime ValidNotAfter;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 2)]
        public System.DateTime ValidNotBefore;

        public CreateCertificateRequest()
        {
        }

        public CreateCertificateRequest(string CertificateID, string Subject, System.DateTime ValidNotBefore,
            System.DateTime ValidNotAfter)
        {
            this.CertificateID = CertificateID;
            this.Subject = Subject;
            this.ValidNotBefore = ValidNotBefore;
            this.ValidNotAfter = ValidNotAfter;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CreateCertificateResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class CreateCertificateResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public Certificate NvtCertificate;

        public CreateCertificateResponse()
        {
        }

        public CreateCertificateResponse(Certificate NvtCertificate)
        {
            this.NvtCertificate = NvtCertificate;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCertificates",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCertificatesRequest
    {
        public GetCertificatesRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCertificatesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCertificatesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("NvtCertificate")]
        public Certificate[] NvtCertificate;

        public GetCertificatesResponse()
        {
        }

        public GetCertificatesResponse(Certificate[] NvtCertificate)
        {
            this.NvtCertificate = NvtCertificate;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCertificatesStatus",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCertificatesStatusRequest
    {
        public GetCertificatesStatusRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCertificatesStatusResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCertificatesStatusResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateStatus")]
        public CertificateStatus[] CertificateStatus;

        public GetCertificatesStatusResponse()
        {
        }

        public GetCertificatesStatusResponse(CertificateStatus[] CertificateStatus)
        {
            this.CertificateStatus = CertificateStatus;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetCertificatesStatus",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetCertificatesStatusRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateStatus")]
        public CertificateStatus[] CertificateStatus;

        public SetCertificatesStatusRequest()
        {
        }

        public SetCertificatesStatusRequest(CertificateStatus[] CertificateStatus)
        {
            this.CertificateStatus = CertificateStatus;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetCertificatesStatusResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetCertificatesStatusResponse
    {
        public SetCertificatesStatusResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteCertificates",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class DeleteCertificatesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateID", DataType = "token")]
        public string[] CertificateID;

        public DeleteCertificatesRequest()
        {
        }

        public DeleteCertificatesRequest(string[] CertificateID)
        {
            this.CertificateID = CertificateID;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteCertificatesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class DeleteCertificatesResponse
    {
        public DeleteCertificatesResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetPkcs10Request",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetPkcs10RequestRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 2)]
        public BinaryData Attributes;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string CertificateID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        public string Subject;

        public GetPkcs10RequestRequest()
        {
        }

        public GetPkcs10RequestRequest(string CertificateID, string Subject, BinaryData Attributes)
        {
            this.CertificateID = CertificateID;
            this.Subject = Subject;
            this.Attributes = Attributes;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetPkcs10RequestResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetPkcs10RequestResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public BinaryData Pkcs10Request;

        public GetPkcs10RequestResponse()
        {
        }

        public GetPkcs10RequestResponse(BinaryData Pkcs10Request)
        {
            this.Pkcs10Request = Pkcs10Request;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "LoadCertificates",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class LoadCertificatesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("NVTCertificate")]
        public Certificate[] NVTCertificate;

        public LoadCertificatesRequest()
        {
        }

        public LoadCertificatesRequest(Certificate[] NVTCertificate)
        {
            this.NVTCertificate = NVTCertificate;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "LoadCertificatesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class LoadCertificatesResponse
    {
        public LoadCertificatesResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetRelayOutputs",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetRelayOutputsRequest
    {
        public GetRelayOutputsRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetRelayOutputsResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetRelayOutputsResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RelayOutputs")]
        public RelayOutput[] RelayOutputs;

        public GetRelayOutputsResponse()
        {
        }

        public GetRelayOutputsResponse(RelayOutput[] RelayOutputs)
        {
            this.RelayOutputs = RelayOutputs;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCACertificates",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCACertificatesRequest
    {
        public GetCACertificatesRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCACertificatesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCACertificatesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CACertificate")]
        public Certificate[] CACertificate;

        public GetCACertificatesResponse()
        {
        }

        public GetCACertificatesResponse(Certificate[] CACertificate)
        {
            this.CACertificate = CACertificate;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "LoadCertificateWithPrivateKey",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class LoadCertificateWithPrivateKeyRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateWithPrivateKey")]
        public CertificateWithPrivateKey[] CertificateWithPrivateKey;

        public LoadCertificateWithPrivateKeyRequest()
        {
        }

        public LoadCertificateWithPrivateKeyRequest(CertificateWithPrivateKey[] CertificateWithPrivateKey)
        {
            this.CertificateWithPrivateKey = CertificateWithPrivateKey;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "LoadCertificateWithPrivateKeyResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class LoadCertificateWithPrivateKeyResponse
    {
        public LoadCertificateWithPrivateKeyResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCertificateInformation",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCertificateInformationRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string CertificateID;

        public GetCertificateInformationRequest()
        {
        }

        public GetCertificateInformationRequest(string CertificateID)
        {
            this.CertificateID = CertificateID;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCertificateInformationResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetCertificateInformationResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public CertificateInformation CertificateInformation;

        public GetCertificateInformationResponse()
        {
        }

        public GetCertificateInformationResponse(CertificateInformation CertificateInformation)
        {
            this.CertificateInformation = CertificateInformation;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "LoadCACertificates",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class LoadCACertificatesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CACertificate")]
        public Certificate[] CACertificate;

        public LoadCACertificatesRequest()
        {
        }

        public LoadCACertificatesRequest(Certificate[] CACertificate)
        {
            this.CACertificate = CACertificate;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "LoadCACertificatesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class LoadCACertificatesResponse
    {
        public LoadCACertificatesResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDot1XConfigurations",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetDot1XConfigurationsRequest
    {
        public GetDot1XConfigurationsRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDot1XConfigurationsResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetDot1XConfigurationsResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Dot1XConfiguration")]
        public Dot1XConfiguration[] Dot1XConfiguration;

        public GetDot1XConfigurationsResponse()
        {
        }

        public GetDot1XConfigurationsResponse(Dot1XConfiguration[] Dot1XConfiguration)
        {
            this.Dot1XConfiguration = Dot1XConfiguration;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteDot1XConfiguration",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class DeleteDot1XConfigurationRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Dot1XConfigurationToken")]
        public string[] Dot1XConfigurationToken;

        public DeleteDot1XConfigurationRequest()
        {
        }

        public DeleteDot1XConfigurationRequest(string[] Dot1XConfigurationToken)
        {
            this.Dot1XConfigurationToken = Dot1XConfigurationToken;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteDot1XConfigurationResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class DeleteDot1XConfigurationResponse
    {
        public DeleteDot1XConfigurationResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDot11Capabilities",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetDot11CapabilitiesRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;

        public GetDot11CapabilitiesRequest()
        {
        }

        public GetDot11CapabilitiesRequest(System.Xml.Linq.XElement[] Any)
        {
            this.Any = Any;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDot11CapabilitiesResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetDot11CapabilitiesResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public Dot11Capabilities Capabilities;

        public GetDot11CapabilitiesResponse()
        {
        }

        public GetDot11CapabilitiesResponse(Dot11Capabilities Capabilities)
        {
            this.Capabilities = Capabilities;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ScanAvailableDot11Networks",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class ScanAvailableDot11NetworksRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        public string InterfaceToken;

        public ScanAvailableDot11NetworksRequest()
        {
        }

        public ScanAvailableDot11NetworksRequest(string InterfaceToken)
        {
            this.InterfaceToken = InterfaceToken;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ScanAvailableDot11NetworksResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class ScanAvailableDot11NetworksResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Networks")]
        public Dot11AvailableNetworks[] Networks;

        public ScanAvailableDot11NetworksResponse()
        {
        }

        public ScanAvailableDot11NetworksResponse(Dot11AvailableNetworks[] Networks)
        {
            this.Networks = Networks;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetSystemUris",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetSystemUrisRequest
    {
        public GetSystemUrisRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetSystemUrisResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetSystemUrisResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 3)]
        public GetSystemUrisResponseExtension Extension;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string SupportInfoUri;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string SystemBackupUri;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SystemLog", Namespace = "http://www.onvif.org/ver10/schema",
            IsNullable = false)]
        public SystemLogUri[] SystemLogUris;

        public GetSystemUrisResponse()
        {
        }

        public GetSystemUrisResponse(SystemLogUri[] SystemLogUris, string SupportInfoUri, string SystemBackupUri,
            GetSystemUrisResponseExtension Extension)
        {
            this.SystemLogUris = SystemLogUris;
            this.SupportInfoUri = SupportInfoUri;
            this.SystemBackupUri = SystemBackupUri;
            this.Extension = Extension;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "StartFirmwareUpgrade",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class StartFirmwareUpgradeRequest
    {
        public StartFirmwareUpgradeRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "StartFirmwareUpgradeResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class StartFirmwareUpgradeResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string UploadUri;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string UploadDelay;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string ExpectedDownTime;


        public StartFirmwareUpgradeResponse()
        {
        }

        public StartFirmwareUpgradeResponse(string UploadUri, string UploadDelay, string ExpectedDownTime)
        {
            this.UploadUri = UploadUri;
            this.UploadDelay = UploadDelay;
            this.ExpectedDownTime = ExpectedDownTime;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "StartSystemRestore",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class StartSystemRestoreRequest
    {
        public StartSystemRestoreRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "StartSystemRestoreResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class StartSystemRestoreResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string UploadUri;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string ExpectedDownTime;


        public StartSystemRestoreResponse()
        {
        }

        public StartSystemRestoreResponse(string UploadUri, string ExpectedDownTime)
        {
            this.UploadUri = UploadUri;
            this.ExpectedDownTime = ExpectedDownTime;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetStorageConfigurations",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetStorageConfigurationsRequest
    {
        public GetStorageConfigurationsRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetStorageConfigurationsResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetStorageConfigurationsResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("StorageConfigurations")]
        public StorageConfiguration[] StorageConfigurations;

        public GetStorageConfigurationsResponse()
        {
        }

        public GetStorageConfigurationsResponse(StorageConfiguration[] StorageConfigurations)
        {
            this.StorageConfigurations = StorageConfigurations;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetGeoLocation",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetGeoLocationRequest
    {
        public GetGeoLocationRequest()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetGeoLocationResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class GetGeoLocationResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public LocationEntity[] Location;

        public GetGeoLocationResponse()
        {
        }

        public GetGeoLocationResponse(LocationEntity[] Location)
        {
            this.Location = Location;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetGeoLocation",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetGeoLocationRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public LocationEntity[] Location;

        public SetGeoLocationRequest()
        {
        }

        public SetGeoLocationRequest(LocationEntity[] Location)
        {
            this.Location = Location;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SetGeoLocationResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class SetGeoLocationResponse
    {
        public SetGeoLocationResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteGeoLocation",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class DeleteGeoLocationRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl",
            Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public LocationEntity[] Location;

        public DeleteGeoLocationRequest()
        {
        }

        public DeleteGeoLocationRequest(LocationEntity[] Location)
        {
            this.Location = Location;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteGeoLocationResponse",
        WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
    public partial class DeleteGeoLocationResponse
    {
        public DeleteGeoLocationResponse()
        {
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public interface DeviceChannel : Mictlanix.DotNet.Onvif.Device.Device, System.ServiceModel.IClientChannel
    {}

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public partial class DeviceClient : System.ServiceModel.ClientBase<Mictlanix.DotNet.Onvif.Device.Device>,
        Mictlanix.DotNet.Onvif.Device.Device
    {
        internal DeviceClient(System.ServiceModel.Channels.Binding binding,
            System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetServicesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetServicesAsync(
                Mictlanix.DotNet.Onvif.Device.GetServicesRequest request)
        {
            return base.Channel.GetServicesAsync(request);
        }

        public System.Threading.Tasks.Task<DeviceServiceCapabilities> GetServiceCapabilitiesAsync()
        {
            return base.Channel.GetServiceCapabilitiesAsync();
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDeviceInformationResponse>
            GetDeviceInformationAsync(Mictlanix.DotNet.Onvif.Device.GetDeviceInformationRequest request)
        {
            return base.Channel.GetDeviceInformationAsync(request);
        }

        public System.Threading.Tasks.Task SetSystemDateAndTimeAsync(SetDateTimeType DateTimeType, bool DaylightSavings,
            TimeZone TimeZone, DateTime UTCDateTime)
        {
            return base.Channel.SetSystemDateAndTimeAsync(DateTimeType, DaylightSavings, TimeZone, UTCDateTime);
        }

        public System.Threading.Tasks.Task<SystemDateTime> GetSystemDateAndTimeAsync()
        {
            return base.Channel.GetSystemDateAndTimeAsync();
        }

        public System.Threading.Tasks.Task SetSystemFactoryDefaultAsync(FactoryDefaultType FactoryDefault)
        {
            return base.Channel.SetSystemFactoryDefaultAsync(FactoryDefault);
        }

        public System.Threading.Tasks.Task<string> UpgradeSystemFirmwareAsync(AttachmentData Firmware)
        {
            return base.Channel.UpgradeSystemFirmwareAsync(Firmware);
        }

        public System.Threading.Tasks.Task<string> SystemRebootAsync()
        {
            return base.Channel.SystemRebootAsync();
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.RestoreSystemResponse>
            Mictlanix.DotNet.Onvif.Device.Device.RestoreSystemAsync(
                Mictlanix.DotNet.Onvif.Device.RestoreSystemRequest request)
        {
            return base.Channel.RestoreSystemAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetSystemBackupResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetSystemBackupAsync(
                Mictlanix.DotNet.Onvif.Device.GetSystemBackupRequest request)
        {
            return base.Channel.GetSystemBackupAsync(request);
        }

        public System.Threading.Tasks.Task<SystemLog> GetSystemLogAsync(SystemLogType LogType)
        {
            return base.Channel.GetSystemLogAsync(LogType);
        }

        public System.Threading.Tasks.Task<SupportInformation> GetSystemSupportInformationAsync()
        {
            return base.Channel.GetSystemSupportInformationAsync();
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetScopesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetScopesAsync(Mictlanix.DotNet.Onvif.Device.GetScopesRequest request)
        {
            return base.Channel.GetScopesAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetScopesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.SetScopesAsync(Mictlanix.DotNet.Onvif.Device.SetScopesRequest request)
        {
            return base.Channel.SetScopesAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.AddScopesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.AddScopesAsync(Mictlanix.DotNet.Onvif.Device.AddScopesRequest request)
        {
            return base.Channel.AddScopesAsync(request);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.RemoveScopesResponse> RemoveScopesAsync(
            Mictlanix.DotNet.Onvif.Device.RemoveScopesRequest request)
        {
            return base.Channel.RemoveScopesAsync(request);
        }

        public System.Threading.Tasks.Task<DiscoveryMode> GetDiscoveryModeAsync()
        {
            return base.Channel.GetDiscoveryModeAsync();
        }

        public System.Threading.Tasks.Task SetDiscoveryModeAsync(DiscoveryMode DiscoveryMode)
        {
            return base.Channel.SetDiscoveryModeAsync(DiscoveryMode);
        }

        public System.Threading.Tasks.Task<DiscoveryMode> GetRemoteDiscoveryModeAsync()
        {
            return base.Channel.GetRemoteDiscoveryModeAsync();
        }

        public System.Threading.Tasks.Task SetRemoteDiscoveryModeAsync(DiscoveryMode RemoteDiscoveryMode)
        {
            return base.Channel.SetRemoteDiscoveryModeAsync(RemoteDiscoveryMode);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDPAddressesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetDPAddressesAsync(
                Mictlanix.DotNet.Onvif.Device.GetDPAddressesRequest request)
        {
            return base.Channel.GetDPAddressesAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDPAddressesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.SetDPAddressesAsync(
                Mictlanix.DotNet.Onvif.Device.SetDPAddressesRequest request)
        {
            return base.Channel.SetDPAddressesAsync(request);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetEndpointReferenceResponse>
            GetEndpointReferenceAsync(Mictlanix.DotNet.Onvif.Device.GetEndpointReferenceRequest request)
        {
            return base.Channel.GetEndpointReferenceAsync(request);
        }

        public System.Threading.Tasks.Task<RemoteUser> GetRemoteUserAsync()
        {
            return base.Channel.GetRemoteUserAsync();
        }

        public System.Threading.Tasks.Task SetRemoteUserAsync(RemoteUser RemoteUser)
        {
            return base.Channel.SetRemoteUserAsync(RemoteUser);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetUsersResponse> Mictlanix.DotNet.Onvif.Device.Device
            .GetUsersAsync(Mictlanix.DotNet.Onvif.Device.GetUsersRequest request)
        {
            return base.Channel.GetUsersAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.CreateUsersResponse>
            Mictlanix.DotNet.Onvif.Device.Device.CreateUsersAsync(
                Mictlanix.DotNet.Onvif.Device.CreateUsersRequest request)
        {
            return base.Channel.CreateUsersAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteUsersResponse>
            Mictlanix.DotNet.Onvif.Device.Device.DeleteUsersAsync(
                Mictlanix.DotNet.Onvif.Device.DeleteUsersRequest request)
        {
            return base.Channel.DeleteUsersAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetUserResponse> Mictlanix.DotNet.Onvif.Device.Device.
            SetUserAsync(Mictlanix.DotNet.Onvif.Device.SetUserRequest request)
        {
            return base.Channel.SetUserAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetWsdlUrlResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetWsdlUrlAsync(
                Mictlanix.DotNet.Onvif.Device.GetWsdlUrlRequest request)
        {
            return base.Channel.GetWsdlUrlAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCapabilitiesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetCapabilitiesAsync(
                Mictlanix.DotNet.Onvif.Device.GetCapabilitiesRequest request)
        {
            return base.Channel.GetCapabilitiesAsync(request);
        }

        public System.Threading.Tasks.Task<HostnameInformation> GetHostnameAsync()
        {
            return base.Channel.GetHostnameAsync();
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetHostnameResponse>
            Mictlanix.DotNet.Onvif.Device.Device.SetHostnameAsync(
                Mictlanix.DotNet.Onvif.Device.SetHostnameRequest request)
        {
            return base.Channel.SetHostnameAsync(request);
        }

        public System.Threading.Tasks.Task<bool> SetHostnameFromDHCPAsync(bool FromDHCP)
        {
            return base.Channel.SetHostnameFromDHCPAsync(FromDHCP);
        }

        public System.Threading.Tasks.Task<DNSInformation> GetDNSAsync()
        {
            return base.Channel.GetDNSAsync();
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDNSResponse> Mictlanix.DotNet.Onvif.Device.Device.
            SetDNSAsync(Mictlanix.DotNet.Onvif.Device.SetDNSRequest request)
        {
            return base.Channel.SetDNSAsync(request);
        }

        public System.Threading.Tasks.Task<NTPInformation> GetNTPAsync()
        {
            return base.Channel.GetNTPAsync();
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNTPResponse> Mictlanix.DotNet.Onvif.Device.Device.
            SetNTPAsync(Mictlanix.DotNet.Onvif.Device.SetNTPRequest request)
        {
            return base.Channel.SetNTPAsync(request);
        }

        public System.Threading.Tasks.Task<DynamicDNSInformation> GetDynamicDNSAsync()
        {
            return base.Channel.GetDynamicDNSAsync();
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDynamicDNSResponse>
            Mictlanix.DotNet.Onvif.Device.Device.SetDynamicDNSAsync(
                Mictlanix.DotNet.Onvif.Device.SetDynamicDNSRequest request)
        {
            return base.Channel.SetDynamicDNSAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetNetworkInterfacesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetNetworkInterfacesAsync(
                Mictlanix.DotNet.Onvif.Device.GetNetworkInterfacesRequest request)
        {
            return base.Channel.GetNetworkInterfacesAsync(request);
        }

        public System.Threading.Tasks.Task<bool> SetNetworkInterfacesAsync(string InterfaceToken,
            NetworkInterfaceSetConfiguration NetworkInterface)
        {
            return base.Channel.SetNetworkInterfacesAsync(InterfaceToken, NetworkInterface);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetNetworkProtocolsResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetNetworkProtocolsAsync(
                Mictlanix.DotNet.Onvif.Device.GetNetworkProtocolsRequest request)
        {
            return base.Channel.GetNetworkProtocolsAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNetworkProtocolsResponse>
            Mictlanix.DotNet.Onvif.Device.Device.SetNetworkProtocolsAsync(
                Mictlanix.DotNet.Onvif.Device.SetNetworkProtocolsRequest request)
        {
            return base.Channel.SetNetworkProtocolsAsync(request);
        }

        public System.Threading.Tasks.Task<NetworkGateway> GetNetworkDefaultGatewayAsync()
        {
            return base.Channel.GetNetworkDefaultGatewayAsync();
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNetworkDefaultGatewayResponse>
            Mictlanix.DotNet.Onvif.Device.Device.SetNetworkDefaultGatewayAsync(
                Mictlanix.DotNet.Onvif.Device.SetNetworkDefaultGatewayRequest request)
        {
            return base.Channel.SetNetworkDefaultGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<NetworkZeroConfiguration> GetZeroConfigurationAsync()
        {
            return base.Channel.GetZeroConfigurationAsync();
        }

        public System.Threading.Tasks.Task SetZeroConfigurationAsync(string InterfaceToken, bool Enabled)
        {
            return base.Channel.SetZeroConfigurationAsync(InterfaceToken, Enabled);
        }

        public System.Threading.Tasks.Task<IPAddressFilter> GetIPAddressFilterAsync()
        {
            return base.Channel.GetIPAddressFilterAsync();
        }

        public System.Threading.Tasks.Task SetIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
        {
            return base.Channel.SetIPAddressFilterAsync(IPAddressFilter);
        }

        public System.Threading.Tasks.Task AddIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
        {
            return base.Channel.AddIPAddressFilterAsync(IPAddressFilter);
        }

        public System.Threading.Tasks.Task RemoveIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
        {
            return base.Channel.RemoveIPAddressFilterAsync(IPAddressFilter);
        }

        public System.Threading.Tasks.Task<BinaryData> GetAccessPolicyAsync()
        {
            return base.Channel.GetAccessPolicyAsync();
        }

        public System.Threading.Tasks.Task SetAccessPolicyAsync(BinaryData PolicyFile)
        {
            return base.Channel.SetAccessPolicyAsync(PolicyFile);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.CreateCertificateResponse>
            Mictlanix.DotNet.Onvif.Device.Device.CreateCertificateAsync(
                Mictlanix.DotNet.Onvif.Device.CreateCertificateRequest request)
        {
            return base.Channel.CreateCertificateAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificatesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetCertificatesAsync(
                Mictlanix.DotNet.Onvif.Device.GetCertificatesRequest request)
        {
            return base.Channel.GetCertificatesAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificatesStatusResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetCertificatesStatusAsync(
                Mictlanix.DotNet.Onvif.Device.GetCertificatesStatusRequest request)
        {
            return base.Channel.GetCertificatesStatusAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetCertificatesStatusResponse>
            Mictlanix.DotNet.Onvif.Device.Device.SetCertificatesStatusAsync(
                Mictlanix.DotNet.Onvif.Device.SetCertificatesStatusRequest request)
        {
            return base.Channel.SetCertificatesStatusAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteCertificatesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.DeleteCertificatesAsync(
                Mictlanix.DotNet.Onvif.Device.DeleteCertificatesRequest request)
        {
            return base.Channel.DeleteCertificatesAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetPkcs10RequestResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetPkcs10RequestAsync(
                Mictlanix.DotNet.Onvif.Device.GetPkcs10RequestRequest request)
        {
            return base.Channel.GetPkcs10RequestAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCertificatesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.LoadCertificatesAsync(
                Mictlanix.DotNet.Onvif.Device.LoadCertificatesRequest request)
        {
            return base.Channel.LoadCertificatesAsync(request);
        }

        public System.Threading.Tasks.Task<bool> GetClientCertificateModeAsync()
        {
            return base.Channel.GetClientCertificateModeAsync();
        }

        public System.Threading.Tasks.Task SetClientCertificateModeAsync(bool Enabled)
        {
            return base.Channel.SetClientCertificateModeAsync(Enabled);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetRelayOutputsResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetRelayOutputsAsync(
                Mictlanix.DotNet.Onvif.Device.GetRelayOutputsRequest request)
        {
            return base.Channel.GetRelayOutputsAsync(request);
        }

        public System.Threading.Tasks.Task SetRelayOutputSettingsAsync(string RelayOutputToken,
            RelayOutputSettings Properties)
        {
            return base.Channel.SetRelayOutputSettingsAsync(RelayOutputToken, Properties);
        }

        public System.Threading.Tasks.Task SetRelayOutputStateAsync(string RelayOutputToken,
            RelayLogicalState LogicalState)
        {
            return base.Channel.SetRelayOutputStateAsync(RelayOutputToken, LogicalState);
        }

        public System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string AuxiliaryCommand)
        {
            return base.Channel.SendAuxiliaryCommandAsync(AuxiliaryCommand);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCACertificatesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetCACertificatesAsync(
                Mictlanix.DotNet.Onvif.Device.GetCACertificatesRequest request)
        {
            return base.Channel.GetCACertificatesAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCertificateWithPrivateKeyResponse>
            Mictlanix.DotNet.Onvif.Device.Device.LoadCertificateWithPrivateKeyAsync(
                Mictlanix.DotNet.Onvif.Device.LoadCertificateWithPrivateKeyRequest request)
        {
            return base.Channel.LoadCertificateWithPrivateKeyAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificateInformationResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetCertificateInformationAsync(
                Mictlanix.DotNet.Onvif.Device.GetCertificateInformationRequest request)
        {
            return base.Channel.GetCertificateInformationAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCACertificatesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.LoadCACertificatesAsync(
                Mictlanix.DotNet.Onvif.Device.LoadCACertificatesRequest request)
        {
            return base.Channel.LoadCACertificatesAsync(request);
        }

        public System.Threading.Tasks.Task CreateDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration)
        {
            return base.Channel.CreateDot1XConfigurationAsync(Dot1XConfiguration);
        }

        public System.Threading.Tasks.Task SetDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration)
        {
            return base.Channel.SetDot1XConfigurationAsync(Dot1XConfiguration);
        }

        public System.Threading.Tasks.Task<Dot1XConfiguration> GetDot1XConfigurationAsync(
            string Dot1XConfigurationToken)
        {
            return base.Channel.GetDot1XConfigurationAsync(Dot1XConfigurationToken);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDot1XConfigurationsResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetDot1XConfigurationsAsync(
                Mictlanix.DotNet.Onvif.Device.GetDot1XConfigurationsRequest request)
        {
            return base.Channel.GetDot1XConfigurationsAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteDot1XConfigurationResponse>
            Mictlanix.DotNet.Onvif.Device.Device.DeleteDot1XConfigurationAsync(
                Mictlanix.DotNet.Onvif.Device.DeleteDot1XConfigurationRequest request)
        {
            return base.Channel.DeleteDot1XConfigurationAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDot11CapabilitiesResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetDot11CapabilitiesAsync(
                Mictlanix.DotNet.Onvif.Device.GetDot11CapabilitiesRequest request)
        {
            return base.Channel.GetDot11CapabilitiesAsync(request);
        }

        public System.Threading.Tasks.Task<Dot11Status> GetDot11StatusAsync(string InterfaceToken)
        {
            return base.Channel.GetDot11StatusAsync(InterfaceToken);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.ScanAvailableDot11NetworksResponse>
            Mictlanix.DotNet.Onvif.Device.Device.ScanAvailableDot11NetworksAsync(
                Mictlanix.DotNet.Onvif.Device.ScanAvailableDot11NetworksRequest request)
        {
            return base.Channel.ScanAvailableDot11NetworksAsync(request);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetSystemUrisResponse> GetSystemUrisAsync(
            Mictlanix.DotNet.Onvif.Device.GetSystemUrisRequest request)
        {
            return base.Channel.GetSystemUrisAsync(request);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.StartFirmwareUpgradeResponse>
            StartFirmwareUpgradeAsync(Mictlanix.DotNet.Onvif.Device.StartFirmwareUpgradeRequest request)
        {
            return base.Channel.StartFirmwareUpgradeAsync(request);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.StartSystemRestoreResponse>
            StartSystemRestoreAsync(Mictlanix.DotNet.Onvif.Device.StartSystemRestoreRequest request)
        {
            return base.Channel.StartSystemRestoreAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetStorageConfigurationsResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetStorageConfigurationsAsync(
                Mictlanix.DotNet.Onvif.Device.GetStorageConfigurationsRequest request)
        {
            return base.Channel.GetStorageConfigurationsAsync(request);
        }

        public System.Threading.Tasks.Task<string> CreateStorageConfigurationAsync(
            StorageConfigurationData StorageConfiguration)
        {
            return base.Channel.CreateStorageConfigurationAsync(StorageConfiguration);
        }

        public System.Threading.Tasks.Task<StorageConfiguration> GetStorageConfigurationAsync(string Token)
        {
            return base.Channel.GetStorageConfigurationAsync(Token);
        }

        public System.Threading.Tasks.Task SetStorageConfigurationAsync(StorageConfiguration StorageConfiguration)
        {
            return base.Channel.SetStorageConfigurationAsync(StorageConfiguration);
        }

        public System.Threading.Tasks.Task DeleteStorageConfigurationAsync(string Token)
        {
            return base.Channel.DeleteStorageConfigurationAsync(Token);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetGeoLocationResponse>
            Mictlanix.DotNet.Onvif.Device.Device.GetGeoLocationAsync(
                Mictlanix.DotNet.Onvif.Device.GetGeoLocationRequest request)
        {
            return base.Channel.GetGeoLocationAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetGeoLocationResponse>
            Mictlanix.DotNet.Onvif.Device.Device.SetGeoLocationAsync(
                Mictlanix.DotNet.Onvif.Device.SetGeoLocationRequest request)
        {
            return base.Channel.SetGeoLocationAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteGeoLocationResponse>
            Mictlanix.DotNet.Onvif.Device.Device.DeleteGeoLocationAsync(
                Mictlanix.DotNet.Onvif.Device.DeleteGeoLocationRequest request)
        {
            return base.Channel.DeleteGeoLocationAsync(request);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetServicesResponse> GetServicesAsync(
            bool IncludeCapability)
        {
            Mictlanix.DotNet.Onvif.Device.GetServicesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetServicesRequest();
            inValue.IncludeCapability = IncludeCapability;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetServicesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.RestoreSystemResponse> RestoreSystemAsync(
            BackupFile[] BackupFiles)
        {
            Mictlanix.DotNet.Onvif.Device.RestoreSystemRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.RestoreSystemRequest();
            inValue.BackupFiles = BackupFiles;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).RestoreSystemAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetSystemBackupResponse> GetSystemBackupAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetSystemBackupRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetSystemBackupRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetSystemBackupAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetScopesResponse> GetScopesAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetScopesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetScopesRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetScopesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetScopesResponse> SetScopesAsync(
            string[] Scopes)
        {
            Mictlanix.DotNet.Onvif.Device.SetScopesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.SetScopesRequest();
            inValue.Scopes = Scopes;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetScopesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.AddScopesResponse> AddScopesAsync(
            string[] ScopeItem)
        {
            Mictlanix.DotNet.Onvif.Device.AddScopesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.AddScopesRequest();
            inValue.ScopeItem = ScopeItem;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).AddScopesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDPAddressesResponse> GetDPAddressesAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetDPAddressesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetDPAddressesRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetDPAddressesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDPAddressesResponse> SetDPAddressesAsync(
            NetworkHost[] DPAddress)
        {
            Mictlanix.DotNet.Onvif.Device.SetDPAddressesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.SetDPAddressesRequest();
            inValue.DPAddress = DPAddress;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetDPAddressesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetUsersResponse> GetUsersAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetUsersRequest inValue = new Mictlanix.DotNet.Onvif.Device.GetUsersRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetUsersAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.CreateUsersResponse> CreateUsersAsync(
            User[] User)
        {
            Mictlanix.DotNet.Onvif.Device.CreateUsersRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.CreateUsersRequest();
            inValue.User = User;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).CreateUsersAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteUsersResponse> DeleteUsersAsync(
            string[] Username)
        {
            Mictlanix.DotNet.Onvif.Device.DeleteUsersRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.DeleteUsersRequest();
            inValue.Username = Username;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).DeleteUsersAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetUserResponse> SetUserAsync(User[] User)
        {
            Mictlanix.DotNet.Onvif.Device.SetUserRequest inValue = new Mictlanix.DotNet.Onvif.Device.SetUserRequest();
            inValue.User = User;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetUserAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetWsdlUrlResponse> GetWsdlUrlAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetWsdlUrlRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetWsdlUrlRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetWsdlUrlAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCapabilitiesResponse> GetCapabilitiesAsync(
            CapabilityCategory[] Category)
        {
            Mictlanix.DotNet.Onvif.Device.GetCapabilitiesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetCapabilitiesRequest();
            inValue.Category = Category;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetCapabilitiesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetHostnameResponse> SetHostnameAsync(
            string Name)
        {
            Mictlanix.DotNet.Onvif.Device.SetHostnameRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.SetHostnameRequest();
            inValue.Name = Name;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetHostnameAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDNSResponse> SetDNSAsync(bool FromDHCP,
            string[] SearchDomain, IPAddress[] DNSManual)
        {
            Mictlanix.DotNet.Onvif.Device.SetDNSRequest inValue = new Mictlanix.DotNet.Onvif.Device.SetDNSRequest();
            inValue.FromDHCP = FromDHCP;
            inValue.SearchDomain = SearchDomain;
            inValue.DNSManual = DNSManual;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetDNSAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNTPResponse> SetNTPAsync(bool FromDHCP,
            NetworkHost[] NTPManual)
        {
            Mictlanix.DotNet.Onvif.Device.SetNTPRequest inValue = new Mictlanix.DotNet.Onvif.Device.SetNTPRequest();
            inValue.FromDHCP = FromDHCP;
            inValue.NTPManual = NTPManual;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetNTPAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetDynamicDNSResponse> SetDynamicDNSAsync(
            DynamicDNSType Type, string Name, string TTL)
        {
            Mictlanix.DotNet.Onvif.Device.SetDynamicDNSRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.SetDynamicDNSRequest();
            inValue.Type = Type;
            inValue.Name = Name;
            inValue.TTL = TTL;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetDynamicDNSAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetNetworkInterfacesResponse>
            GetNetworkInterfacesAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetNetworkInterfacesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetNetworkInterfacesRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetNetworkInterfacesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetNetworkProtocolsResponse>
            GetNetworkProtocolsAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetNetworkProtocolsRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetNetworkProtocolsRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetNetworkProtocolsAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNetworkProtocolsResponse>
            SetNetworkProtocolsAsync(NetworkProtocol[] NetworkProtocols)
        {
            Mictlanix.DotNet.Onvif.Device.SetNetworkProtocolsRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.SetNetworkProtocolsRequest();
            inValue.NetworkProtocols = NetworkProtocols;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetNetworkProtocolsAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetNetworkDefaultGatewayResponse>
            SetNetworkDefaultGatewayAsync(string[] IPv4Address, string[] IPv6Address)
        {
            Mictlanix.DotNet.Onvif.Device.SetNetworkDefaultGatewayRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.SetNetworkDefaultGatewayRequest();
            inValue.IPv4Address = IPv4Address;
            inValue.IPv6Address = IPv6Address;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetNetworkDefaultGatewayAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.CreateCertificateResponse>
            CreateCertificateAsync(string CertificateID, string Subject, System.DateTime ValidNotBefore,
                System.DateTime ValidNotAfter)
        {
            Mictlanix.DotNet.Onvif.Device.CreateCertificateRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.CreateCertificateRequest();
            inValue.CertificateID = CertificateID;
            inValue.Subject = Subject;
            inValue.ValidNotBefore = ValidNotBefore;
            inValue.ValidNotAfter = ValidNotAfter;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).CreateCertificateAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificatesResponse> GetCertificatesAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetCertificatesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetCertificatesRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetCertificatesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificatesStatusResponse>
            GetCertificatesStatusAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetCertificatesStatusRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetCertificatesStatusRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetCertificatesStatusAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetCertificatesStatusResponse>
            SetCertificatesStatusAsync(CertificateStatus[] CertificateStatus)
        {
            Mictlanix.DotNet.Onvif.Device.SetCertificatesStatusRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.SetCertificatesStatusRequest();
            inValue.CertificateStatus = CertificateStatus;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetCertificatesStatusAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteCertificatesResponse>
            DeleteCertificatesAsync(string[] CertificateID)
        {
            Mictlanix.DotNet.Onvif.Device.DeleteCertificatesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.DeleteCertificatesRequest();
            inValue.CertificateID = CertificateID;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).DeleteCertificatesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetPkcs10RequestResponse>
            GetPkcs10RequestAsync(string CertificateID, string Subject, BinaryData Attributes)
        {
            Mictlanix.DotNet.Onvif.Device.GetPkcs10RequestRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetPkcs10RequestRequest();
            inValue.CertificateID = CertificateID;
            inValue.Subject = Subject;
            inValue.Attributes = Attributes;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetPkcs10RequestAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCertificatesResponse>
            LoadCertificatesAsync(Certificate[] NVTCertificate)
        {
            Mictlanix.DotNet.Onvif.Device.LoadCertificatesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.LoadCertificatesRequest();
            inValue.NVTCertificate = NVTCertificate;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).LoadCertificatesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetRelayOutputsResponse> GetRelayOutputsAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetRelayOutputsRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetRelayOutputsRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetRelayOutputsAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCACertificatesResponse>
            GetCACertificatesAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetCACertificatesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetCACertificatesRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetCACertificatesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCertificateWithPrivateKeyResponse>
            LoadCertificateWithPrivateKeyAsync(CertificateWithPrivateKey[] CertificateWithPrivateKey)
        {
            Mictlanix.DotNet.Onvif.Device.LoadCertificateWithPrivateKeyRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.LoadCertificateWithPrivateKeyRequest();
            inValue.CertificateWithPrivateKey = CertificateWithPrivateKey;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).LoadCertificateWithPrivateKeyAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetCertificateInformationResponse>
            GetCertificateInformationAsync(string CertificateID)
        {
            Mictlanix.DotNet.Onvif.Device.GetCertificateInformationRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetCertificateInformationRequest();
            inValue.CertificateID = CertificateID;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetCertificateInformationAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.LoadCACertificatesResponse>
            LoadCACertificatesAsync(Certificate[] CACertificate)
        {
            Mictlanix.DotNet.Onvif.Device.LoadCACertificatesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.LoadCACertificatesRequest();
            inValue.CACertificate = CACertificate;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).LoadCACertificatesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDot1XConfigurationsResponse>
            GetDot1XConfigurationsAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetDot1XConfigurationsRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetDot1XConfigurationsRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetDot1XConfigurationsAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteDot1XConfigurationResponse>
            DeleteDot1XConfigurationAsync(string[] Dot1XConfigurationToken)
        {
            Mictlanix.DotNet.Onvif.Device.DeleteDot1XConfigurationRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.DeleteDot1XConfigurationRequest();
            inValue.Dot1XConfigurationToken = Dot1XConfigurationToken;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).DeleteDot1XConfigurationAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetDot11CapabilitiesResponse>
            GetDot11CapabilitiesAsync(System.Xml.Linq.XElement[] Any)
        {
            Mictlanix.DotNet.Onvif.Device.GetDot11CapabilitiesRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetDot11CapabilitiesRequest();
            inValue.Any = Any;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetDot11CapabilitiesAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.ScanAvailableDot11NetworksResponse>
            ScanAvailableDot11NetworksAsync(string InterfaceToken)
        {
            Mictlanix.DotNet.Onvif.Device.ScanAvailableDot11NetworksRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.ScanAvailableDot11NetworksRequest();
            inValue.InterfaceToken = InterfaceToken;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).ScanAvailableDot11NetworksAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetStorageConfigurationsResponse>
            GetStorageConfigurationsAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetStorageConfigurationsRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetStorageConfigurationsRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetStorageConfigurationsAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.GetGeoLocationResponse> GetGeoLocationAsync()
        {
            Mictlanix.DotNet.Onvif.Device.GetGeoLocationRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.GetGeoLocationRequest();
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).GetGeoLocationAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.SetGeoLocationResponse> SetGeoLocationAsync(
            LocationEntity[] Location)
        {
            Mictlanix.DotNet.Onvif.Device.SetGeoLocationRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.SetGeoLocationRequest();
            inValue.Location = Location;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).SetGeoLocationAsync(inValue);
        }

        public System.Threading.Tasks.Task<Mictlanix.DotNet.Onvif.Device.DeleteGeoLocationResponse>
            DeleteGeoLocationAsync(LocationEntity[] Location)
        {
            Mictlanix.DotNet.Onvif.Device.DeleteGeoLocationRequest inValue =
                new Mictlanix.DotNet.Onvif.Device.DeleteGeoLocationRequest();
            inValue.Location = Location;
            return ((Mictlanix.DotNet.Onvif.Device.Device) (this)).DeleteGeoLocationAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(
                ((System.ServiceModel.ICommunicationObject) (this)).BeginOpen(null, null),
                new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject) (this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(
                ((System.ServiceModel.ICommunicationObject) (this)).BeginClose(null, null),
                new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject) (this)).EndClose));
        }
    }
}