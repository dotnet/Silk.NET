// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_CREDENTIALS.xml' path='doc/member[@name="CRYPT_CREDENTIALS"]/*'/>
public unsafe partial struct CRYPT_CREDENTIALS
{
    /// <include file='CRYPT_CREDENTIALS.xml' path='doc/member[@name="CRYPT_CREDENTIALS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_CREDENTIALS.xml' path='doc/member[@name="CRYPT_CREDENTIALS.pszCredentialsOid"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszCredentialsOid;
    /// <include file='CRYPT_CREDENTIALS.xml' path='doc/member[@name="CRYPT_CREDENTIALS.pvCredentials"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pvCredentials;
}