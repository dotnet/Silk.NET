// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS"]/*'/>
public unsafe partial struct WINHTTP_PROXY_SETTINGS
{
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.dwStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStructSize;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.dwCurrentSettingsVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrentSettingsVersion;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.pwszConnectionName"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* pwszConnectionName;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.pwszProxy"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* pwszProxy;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.pwszProxyBypass"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* pwszProxyBypass;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.pwszAutoconfigUrl"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* pwszAutoconfigUrl;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.pwszAutoconfigSecondaryUrl"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* pwszAutoconfigSecondaryUrl;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.dwAutoDiscoveryFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAutoDiscoveryFlags;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.pwszLastKnownGoodAutoConfigUrl"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* pwszLastKnownGoodAutoConfigUrl;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.dwAutoconfigReloadDelayMins"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAutoconfigReloadDelayMins;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.ftLastKnownDetectTime"]/*'/>
    public FILETIME ftLastKnownDetectTime;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.dwDetectedInterfaceIpCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDetectedInterfaceIpCount;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.pdwDetectedInterfaceIp"]/*'/>
    [NativeTypeName("PDWORD")]
    public uint* pdwDetectedInterfaceIp;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.cNetworkKeys"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cNetworkKeys;
    /// <include file='WINHTTP_PROXY_SETTINGS.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS.pNetworkKeys"]/*'/>
    [NativeTypeName("PWINHTTP_PROXY_NETWORKING_KEY")]
    public WINHTTP_PROXY_NETWORKING_KEY* pNetworkKeys;
}