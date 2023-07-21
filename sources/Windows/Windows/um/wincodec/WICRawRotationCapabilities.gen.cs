// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICRawRotationCapabilities.xml' path='doc/member[@name="WICRawRotationCapabilities"]/*' />
public enum WICRawRotationCapabilities
{
    /// <include file='WICRawRotationCapabilities.xml' path='doc/member[@name="WICRawRotationCapabilities.WICRawRotationCapabilityNotSupported"]/*' />
    WICRawRotationCapabilityNotSupported = 0,

    /// <include file='WICRawRotationCapabilities.xml' path='doc/member[@name="WICRawRotationCapabilities.WICRawRotationCapabilityGetSupported"]/*' />
    WICRawRotationCapabilityGetSupported = 0x1,

    /// <include file='WICRawRotationCapabilities.xml' path='doc/member[@name="WICRawRotationCapabilities.WICRawRotationCapabilityNinetyDegreesSupported"]/*' />
    WICRawRotationCapabilityNinetyDegreesSupported = 0x2,

    /// <include file='WICRawRotationCapabilities.xml' path='doc/member[@name="WICRawRotationCapabilities.WICRawRotationCapabilityFullySupported"]/*' />
    WICRawRotationCapabilityFullySupported = 0x3,

    /// <include file='WICRawRotationCapabilities.xml' path='doc/member[@name="WICRawRotationCapabilities.WICRAWROTATIONCAPABILITIES_FORCE_DWORD"]/*' />
    WICRAWROTATIONCAPABILITIES_FORCE_DWORD = 0x7fffffff,
}
