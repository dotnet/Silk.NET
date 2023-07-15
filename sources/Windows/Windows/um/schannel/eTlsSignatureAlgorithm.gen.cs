// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eTlsSignatureAlgorithm.xml' path='doc/member[@name="eTlsSignatureAlgorithm"]/*'/>
public enum eTlsSignatureAlgorithm
{
    /// <include file='eTlsSignatureAlgorithm.xml' path='doc/member[@name="eTlsSignatureAlgorithm.TlsSignatureAlgorithm_Anonymous"]/*'/>
    TlsSignatureAlgorithm_Anonymous = 0,
    /// <include file='eTlsSignatureAlgorithm.xml' path='doc/member[@name="eTlsSignatureAlgorithm.TlsSignatureAlgorithm_Rsa"]/*'/>
    TlsSignatureAlgorithm_Rsa = 1,
    /// <include file='eTlsSignatureAlgorithm.xml' path='doc/member[@name="eTlsSignatureAlgorithm.TlsSignatureAlgorithm_Dsa"]/*'/>
    TlsSignatureAlgorithm_Dsa = 2,
    /// <include file='eTlsSignatureAlgorithm.xml' path='doc/member[@name="eTlsSignatureAlgorithm.TlsSignatureAlgorithm_Ecdsa"]/*'/>
    TlsSignatureAlgorithm_Ecdsa = 3,
}