// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_RSA_SSA_PSS_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSA_SSA_PSS_PARAMETERS"]/*'/>
public partial struct CRYPT_RSA_SSA_PSS_PARAMETERS
{
    /// <include file='CRYPT_RSA_SSA_PSS_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSA_SSA_PSS_PARAMETERS.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='CRYPT_RSA_SSA_PSS_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSA_SSA_PSS_PARAMETERS.MaskGenAlgorithm"]/*'/>
    public CRYPT_MASK_GEN_ALGORITHM MaskGenAlgorithm;
    /// <include file='CRYPT_RSA_SSA_PSS_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSA_SSA_PSS_PARAMETERS.dwSaltLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSaltLength;
    /// <include file='CRYPT_RSA_SSA_PSS_PARAMETERS.xml' path='doc/member[@name="CRYPT_RSA_SSA_PSS_PARAMETERS.dwTrailerField"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTrailerField;
}