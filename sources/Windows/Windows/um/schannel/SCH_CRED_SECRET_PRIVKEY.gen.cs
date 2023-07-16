// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCH_CRED_SECRET_PRIVKEY.xml' path='doc/member[@name="SCH_CRED_SECRET_PRIVKEY"]/*'/>
public unsafe partial struct SCH_CRED_SECRET_PRIVKEY
{
    /// <include file='SCH_CRED_SECRET_PRIVKEY.xml' path='doc/member[@name="SCH_CRED_SECRET_PRIVKEY.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='SCH_CRED_SECRET_PRIVKEY.xml' path='doc/member[@name="SCH_CRED_SECRET_PRIVKEY.pPrivateKey"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pPrivateKey;
    /// <include file='SCH_CRED_SECRET_PRIVKEY.xml' path='doc/member[@name="SCH_CRED_SECRET_PRIVKEY.cbPrivateKey"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbPrivateKey;
    /// <include file='SCH_CRED_SECRET_PRIVKEY.xml' path='doc/member[@name="SCH_CRED_SECRET_PRIVKEY.pszPassword"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* pszPassword;
}