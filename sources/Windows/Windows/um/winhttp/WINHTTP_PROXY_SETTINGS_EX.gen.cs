// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX"]/*'/>
public unsafe partial struct WINHTTP_PROXY_SETTINGS_EX
{
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.ullGenerationId"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullGenerationId;
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.ullFlags"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.pcwszAutoconfigUrl"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pcwszAutoconfigUrl;
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.pcwszProxy"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pcwszProxy;
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.pcwszSecureProxy"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pcwszSecureProxy;
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.cProxyBypasses"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cProxyBypasses;
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.rgpcwszProxyBypasses"]/*'/>
    [NativeTypeName("PCWSTR *")]
    public ushort** rgpcwszProxyBypasses;
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.dwInterfaceIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInterfaceIndex;
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.pcwszConnectionName"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pcwszConnectionName;
}