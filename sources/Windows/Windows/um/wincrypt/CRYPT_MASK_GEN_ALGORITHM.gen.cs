// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_MASK_GEN_ALGORITHM.xml' path='doc/member[@name="CRYPT_MASK_GEN_ALGORITHM"]/*'/>
public unsafe partial struct CRYPT_MASK_GEN_ALGORITHM
{
    /// <include file='CRYPT_MASK_GEN_ALGORITHM.xml' path='doc/member[@name="CRYPT_MASK_GEN_ALGORITHM.pszObjId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;
    /// <include file='CRYPT_MASK_GEN_ALGORITHM.xml' path='doc/member[@name="CRYPT_MASK_GEN_ALGORITHM.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
}