// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_X942_DH_VALIDATION_PARAMS.xml' path='doc/member[@name="CERT_X942_DH_VALIDATION_PARAMS"]/*'/>
public partial struct CERT_X942_DH_VALIDATION_PARAMS
{
    /// <include file='CERT_X942_DH_VALIDATION_PARAMS.xml' path='doc/member[@name="CERT_X942_DH_VALIDATION_PARAMS.seed"]/*'/>
    public CRYPT_BIT_BLOB seed;
    /// <include file='CERT_X942_DH_VALIDATION_PARAMS.xml' path='doc/member[@name="CERT_X942_DH_VALIDATION_PARAMS.pgenCounter"]/*'/>
    [NativeTypeName("DWORD")]
    public uint pgenCounter;
}