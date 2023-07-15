// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SEALING_SIGNATURE_ATTRIBUTE.xml' path='doc/member[@name="SEALING_SIGNATURE_ATTRIBUTE"]/*'/>
public partial struct SEALING_SIGNATURE_ATTRIBUTE
{
    /// <include file='SEALING_SIGNATURE_ATTRIBUTE.xml' path='doc/member[@name="SEALING_SIGNATURE_ATTRIBUTE.version"]/*'/>
    [NativeTypeName("ULONG")]
    public uint version;
    /// <include file='SEALING_SIGNATURE_ATTRIBUTE.xml' path='doc/member[@name="SEALING_SIGNATURE_ATTRIBUTE.signerIndex"]/*'/>
    [NativeTypeName("ULONG")]
    public uint signerIndex;
    /// <include file='SEALING_SIGNATURE_ATTRIBUTE.xml' path='doc/member[@name="SEALING_SIGNATURE_ATTRIBUTE.signatureAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER signatureAlgorithm;
    /// <include file='SEALING_SIGNATURE_ATTRIBUTE.xml' path='doc/member[@name="SEALING_SIGNATURE_ATTRIBUTE.encryptedDigest"]/*'/>
    [NativeTypeName("CRYPT_DIGEST_BLOB")]
    public CRYPT_DATA_BLOB encryptedDigest;
}