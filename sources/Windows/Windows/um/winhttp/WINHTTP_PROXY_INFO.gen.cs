// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_PROXY_INFO.xml' path='doc/member[@name="WINHTTP_PROXY_INFO"]/*'/>
public unsafe partial struct WINHTTP_PROXY_INFO
{
    /// <include file='WINHTTP_PROXY_INFO.xml' path='doc/member[@name="WINHTTP_PROXY_INFO.dwAccessType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAccessType;
    /// <include file='WINHTTP_PROXY_INFO.xml' path='doc/member[@name="WINHTTP_PROXY_INFO.lpszProxy"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszProxy;
    /// <include file='WINHTTP_PROXY_INFO.xml' path='doc/member[@name="WINHTTP_PROXY_INFO.lpszProxyBypass"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszProxyBypass;
}