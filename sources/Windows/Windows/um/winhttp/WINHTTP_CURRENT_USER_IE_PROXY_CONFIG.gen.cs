// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.xml' path='doc/member[@name="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG"]/*'/>
public unsafe partial struct WINHTTP_CURRENT_USER_IE_PROXY_CONFIG
{
    /// <include file='WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.xml' path='doc/member[@name="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.fAutoDetect"]/*'/>
    public BOOL fAutoDetect;
    /// <include file='WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.xml' path='doc/member[@name="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.lpszAutoConfigUrl"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszAutoConfigUrl;
    /// <include file='WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.xml' path='doc/member[@name="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.lpszProxy"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszProxy;
    /// <include file='WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.xml' path='doc/member[@name="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG.lpszProxyBypass"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszProxyBypass;
}