// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WINHTTP_CREDS.xml' path='doc/member[@name="WINHTTP_CREDS"]/*'/>
public unsafe partial struct WINHTTP_CREDS
{
    /// <include file='WINHTTP_CREDS.xml' path='doc/member[@name="WINHTTP_CREDS.lpszUserName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszUserName;
    /// <include file='WINHTTP_CREDS.xml' path='doc/member[@name="WINHTTP_CREDS.lpszPassword"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszPassword;
    /// <include file='WINHTTP_CREDS.xml' path='doc/member[@name="WINHTTP_CREDS.lpszRealm"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszRealm;
    /// <include file='WINHTTP_CREDS.xml' path='doc/member[@name="WINHTTP_CREDS.dwAuthScheme"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAuthScheme;
    /// <include file='WINHTTP_CREDS.xml' path='doc/member[@name="WINHTTP_CREDS.lpszHostName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszHostName;
    /// <include file='WINHTTP_CREDS.xml' path='doc/member[@name="WINHTTP_CREDS.dwPort"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPort;
}