// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_SUPPORTED_ALGORITHM_INFO.xml' path='doc/member[@name="CERT_SUPPORTED_ALGORITHM_INFO"]/*'/>
public partial struct CERT_SUPPORTED_ALGORITHM_INFO
{
    /// <include file='CERT_SUPPORTED_ALGORITHM_INFO.xml' path='doc/member[@name="CERT_SUPPORTED_ALGORITHM_INFO.Algorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER Algorithm;
    /// <include file='CERT_SUPPORTED_ALGORITHM_INFO.xml' path='doc/member[@name="CERT_SUPPORTED_ALGORITHM_INFO.IntendedKeyUsage"]/*'/>
    public CRYPT_BIT_BLOB IntendedKeyUsage;
    /// <include file='CERT_SUPPORTED_ALGORITHM_INFO.xml' path='doc/member[@name="CERT_SUPPORTED_ALGORITHM_INFO.IntendedCertPolicies"]/*'/>
    public CERT_POLICIES_INFO IntendedCertPolicies;
}