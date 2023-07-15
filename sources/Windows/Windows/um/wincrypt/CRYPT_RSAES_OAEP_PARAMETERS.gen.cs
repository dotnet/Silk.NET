// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_RSAES_OAEP_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSAES_OAEP_PARAMETERS"]/*'/>
public partial struct CRYPT_RSAES_OAEP_PARAMETERS
{
    /// <include file='CRYPT_RSAES_OAEP_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSAES_OAEP_PARAMETERS.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='CRYPT_RSAES_OAEP_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSAES_OAEP_PARAMETERS.MaskGenAlgorithm"]/*'/>
    public CRYPT_MASK_GEN_ALGORITHM MaskGenAlgorithm;
    /// <include file='CRYPT_RSAES_OAEP_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSAES_OAEP_PARAMETERS.PSourceAlgorithm"]/*'/>
    public CRYPT_PSOURCE_ALGORITHM PSourceAlgorithm;
}