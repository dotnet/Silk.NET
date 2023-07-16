// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='eTlsHashAlgorithm.xml' path='doc/member[@name="eTlsHashAlgorithm"]/*'/>
public enum eTlsHashAlgorithm
{
    /// <include file='eTlsHashAlgorithm.xml' path='doc/member[@name="eTlsHashAlgorithm.TlsHashAlgorithm_None"]/*'/>
    TlsHashAlgorithm_None = 0,
    /// <include file='eTlsHashAlgorithm.xml' path='doc/member[@name="eTlsHashAlgorithm.TlsHashAlgorithm_Md5"]/*'/>
    TlsHashAlgorithm_Md5 = 1,
    /// <include file='eTlsHashAlgorithm.xml' path='doc/member[@name="eTlsHashAlgorithm.TlsHashAlgorithm_Sha1"]/*'/>
    TlsHashAlgorithm_Sha1 = 2,
    /// <include file='eTlsHashAlgorithm.xml' path='doc/member[@name="eTlsHashAlgorithm.TlsHashAlgorithm_Sha224"]/*'/>
    TlsHashAlgorithm_Sha224 = 3,
    /// <include file='eTlsHashAlgorithm.xml' path='doc/member[@name="eTlsHashAlgorithm.TlsHashAlgorithm_Sha256"]/*'/>
    TlsHashAlgorithm_Sha256 = 4,
    /// <include file='eTlsHashAlgorithm.xml' path='doc/member[@name="eTlsHashAlgorithm.TlsHashAlgorithm_Sha384"]/*'/>
    TlsHashAlgorithm_Sha384 = 5,
    /// <include file='eTlsHashAlgorithm.xml' path='doc/member[@name="eTlsHashAlgorithm.TlsHashAlgorithm_Sha512"]/*'/>
    TlsHashAlgorithm_Sha512 = 6,
}