// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MFSampleEncryptionProtectionScheme.xml' path='doc/member[@name="MFSampleEncryptionProtectionScheme"]/*'/>
[SupportedOSPlatform("windows10.0.16299.0")]
public enum MFSampleEncryptionProtectionScheme
{
    /// <include file='MFSampleEncryptionProtectionScheme.xml' path='doc/member[@name="MFSampleEncryptionProtectionScheme.MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_NONE"]/*'/>
    MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_NONE = 0,
    /// <include file='MFSampleEncryptionProtectionScheme.xml' path='doc/member[@name="MFSampleEncryptionProtectionScheme.MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_AES_CTR"]/*'/>
    MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_AES_CTR = 1,
    /// <include file='MFSampleEncryptionProtectionScheme.xml' path='doc/member[@name="MFSampleEncryptionProtectionScheme.MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_AES_CBC"]/*'/>
    MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_AES_CBC = 2,
}