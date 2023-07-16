// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_PASSWORD_CREDENTIALSW.xml' path='doc/member[@name="CRYPT_PASSWORD_CREDENTIALSW"]/*'/>
public unsafe partial struct CRYPT_PASSWORD_CREDENTIALSW
{
    /// <include file='CRYPT_PASSWORD_CREDENTIALSW.xml' path='doc/member[@name="CRYPT_PASSWORD_CREDENTIALSW.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_PASSWORD_CREDENTIALSW.xml' path='doc/member[@name="CRYPT_PASSWORD_CREDENTIALSW.pszUsername"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszUsername;
    /// <include file='CRYPT_PASSWORD_CREDENTIALSW.xml' path='doc/member[@name="CRYPT_PASSWORD_CREDENTIALSW.pszPassword"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszPassword;
}