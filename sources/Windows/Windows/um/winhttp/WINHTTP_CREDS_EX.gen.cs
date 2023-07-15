// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_CREDS_EX.xml' path='doc/member[@name="WINHTTP_CREDS_EX"]/*'/>
public unsafe partial struct WINHTTP_CREDS_EX
{
    /// <include file='WINHTTP_CREDS_EX.xml' path='doc/member[@name="WINHTTP_CREDS_EX.lpszUserName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszUserName;
    /// <include file='WINHTTP_CREDS_EX.xml' path='doc/member[@name="WINHTTP_CREDS_EX.lpszPassword"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszPassword;
    /// <include file='WINHTTP_CREDS_EX.xml' path='doc/member[@name="WINHTTP_CREDS_EX.lpszRealm"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszRealm;
    /// <include file='WINHTTP_CREDS_EX.xml' path='doc/member[@name="WINHTTP_CREDS_EX.dwAuthScheme"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAuthScheme;
    /// <include file='WINHTTP_CREDS_EX.xml' path='doc/member[@name="WINHTTP_CREDS_EX.lpszHostName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszHostName;
    /// <include file='WINHTTP_CREDS_EX.xml' path='doc/member[@name="WINHTTP_CREDS_EX.dwPort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPort;
    /// <include file='WINHTTP_CREDS_EX.xml' path='doc/member[@name="WINHTTP_CREDS_EX.lpszUrl"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszUrl;
}