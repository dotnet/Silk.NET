// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WINHTTP_PROXY_SETTINGS
{
    [NativeTypeName("DWORD")]
    public uint dwStructSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwCurrentSettingsVersion;

    [NativeTypeName("PWSTR")]
    public ushort* pwszConnectionName;

    [NativeTypeName("PWSTR")]
    public ushort* pwszProxy;

    [NativeTypeName("PWSTR")]
    public ushort* pwszProxyBypass;

    [NativeTypeName("PWSTR")]
    public ushort* pwszAutoconfigUrl;

    [NativeTypeName("PWSTR")]
    public ushort* pwszAutoconfigSecondaryUrl;

    [NativeTypeName("DWORD")]
    public uint dwAutoDiscoveryFlags;

    [NativeTypeName("PWSTR")]
    public ushort* pwszLastKnownGoodAutoConfigUrl;

    [NativeTypeName("DWORD")]
    public uint dwAutoconfigReloadDelayMins;
    public FILETIME ftLastKnownDetectTime;

    [NativeTypeName("DWORD")]
    public uint dwDetectedInterfaceIpCount;

    [NativeTypeName("PDWORD")]
    public uint* pdwDetectedInterfaceIp;

    [NativeTypeName("DWORD")]
    public uint cNetworkKeys;

    [NativeTypeName("PWINHTTP_PROXY_NETWORKING_KEY")]
    public WINHTTP_PROXY_NETWORKING_KEY* pNetworkKeys;
}
