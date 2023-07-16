// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SAMPLE_PROTECTION_VERSION.xml' path='doc/member[@name="SAMPLE_PROTECTION_VERSION"]/*'/>
public enum SAMPLE_PROTECTION_VERSION
{
    /// <include file='SAMPLE_PROTECTION_VERSION.xml' path='doc/member[@name="SAMPLE_PROTECTION_VERSION.SAMPLE_PROTECTION_VERSION_NO"]/*'/>
    SAMPLE_PROTECTION_VERSION_NO = 0,
    /// <include file='SAMPLE_PROTECTION_VERSION.xml' path='doc/member[@name="SAMPLE_PROTECTION_VERSION.SAMPLE_PROTECTION_VERSION_BASIC_LOKI"]/*'/>
    SAMPLE_PROTECTION_VERSION_BASIC_LOKI = 1,
    /// <include file='SAMPLE_PROTECTION_VERSION.xml' path='doc/member[@name="SAMPLE_PROTECTION_VERSION.SAMPLE_PROTECTION_VERSION_SCATTER"]/*'/>
    SAMPLE_PROTECTION_VERSION_SCATTER = 2,
    /// <include file='SAMPLE_PROTECTION_VERSION.xml' path='doc/member[@name="SAMPLE_PROTECTION_VERSION.SAMPLE_PROTECTION_VERSION_RC4"]/*'/>
    SAMPLE_PROTECTION_VERSION_RC4 = 3,
    /// <include file='SAMPLE_PROTECTION_VERSION.xml' path='doc/member[@name="SAMPLE_PROTECTION_VERSION.SAMPLE_PROTECTION_VERSION_AES128CTR"]/*'/>
    SAMPLE_PROTECTION_VERSION_AES128CTR = 4,
}