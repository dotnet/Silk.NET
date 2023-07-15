// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_ATTRIBUTE.xml' path='doc/member[@name="CRYPT_ATTRIBUTE"]/*'/>
public unsafe partial struct CRYPT_ATTRIBUTE
{
    /// <include file='CRYPT_ATTRIBUTE.xml' path='doc/member[@name="CRYPT_ATTRIBUTE.pszObjId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;
    /// <include file='CRYPT_ATTRIBUTE.xml' path='doc/member[@name="CRYPT_ATTRIBUTE.cValue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cValue;
    /// <include file='CRYPT_ATTRIBUTE.xml' path='doc/member[@name="CRYPT_ATTRIBUTE.rgValue"]/*'/>
    [NativeTypeName("PCRYPT_ATTR_BLOB")]
    public CRYPT_DATA_BLOB* rgValue;
}