// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_ALGORITHM_IDENTIFIER.xml' path='doc/member[@name="CRYPT_ALGORITHM_IDENTIFIER"]/*'/>
public unsafe partial struct CRYPT_ALGORITHM_IDENTIFIER
{
    /// <include file='CRYPT_ALGORITHM_IDENTIFIER.xml' path='doc/member[@name="CRYPT_ALGORITHM_IDENTIFIER.pszObjId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;
    /// <include file='CRYPT_ALGORITHM_IDENTIFIER.xml' path='doc/member[@name="CRYPT_ALGORITHM_IDENTIFIER.Parameters"]/*'/>
    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Parameters;
}