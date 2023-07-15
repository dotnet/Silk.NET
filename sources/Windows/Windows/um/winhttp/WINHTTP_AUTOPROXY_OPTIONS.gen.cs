// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_AUTOPROXY_OPTIONS.xml' path='doc/member[@name="WINHTTP_AUTOPROXY_OPTIONS"]/*'/>
public unsafe partial struct WINHTTP_AUTOPROXY_OPTIONS
{
    /// <include file='WINHTTP_AUTOPROXY_OPTIONS.xml' path='doc/member[@name="WINHTTP_AUTOPROXY_OPTIONS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='WINHTTP_AUTOPROXY_OPTIONS.xml' path='doc/member[@name="WINHTTP_AUTOPROXY_OPTIONS.dwAutoDetectFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAutoDetectFlags;
    /// <include file='WINHTTP_AUTOPROXY_OPTIONS.xml' path='doc/member[@name="WINHTTP_AUTOPROXY_OPTIONS.lpszAutoConfigUrl"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszAutoConfigUrl;
    /// <include file='WINHTTP_AUTOPROXY_OPTIONS.xml' path='doc/member[@name="WINHTTP_AUTOPROXY_OPTIONS.lpvReserved"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpvReserved;
    /// <include file='WINHTTP_AUTOPROXY_OPTIONS.xml' path='doc/member[@name="WINHTTP_AUTOPROXY_OPTIONS.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='WINHTTP_AUTOPROXY_OPTIONS.xml' path='doc/member[@name="WINHTTP_AUTOPROXY_OPTIONS.fAutoLogonIfChallenged"]/*'/>
    public BOOL fAutoLogonIfChallenged;
}