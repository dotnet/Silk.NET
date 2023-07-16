// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_OBJID_TABLE.xml' path='doc/member[@name="CRYPT_OBJID_TABLE"]/*'/>
public unsafe partial struct CRYPT_OBJID_TABLE
{
    /// <include file='CRYPT_OBJID_TABLE.xml' path='doc/member[@name="CRYPT_OBJID_TABLE.dwAlgId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAlgId;
    /// <include file='CRYPT_OBJID_TABLE.xml' path='doc/member[@name="CRYPT_OBJID_TABLE.pszObjId"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszObjId;
}