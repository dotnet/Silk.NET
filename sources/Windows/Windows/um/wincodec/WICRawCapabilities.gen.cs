// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICRawCapabilities.xml' path='doc/member[@name="WICRawCapabilities"]/*' />
public enum WICRawCapabilities
{
    /// <include file='WICRawCapabilities.xml' path='doc/member[@name="WICRawCapabilities.WICRawCapabilityNotSupported"]/*' />
    WICRawCapabilityNotSupported = 0,

    /// <include file='WICRawCapabilities.xml' path='doc/member[@name="WICRawCapabilities.WICRawCapabilityGetSupported"]/*' />
    WICRawCapabilityGetSupported = 0x1,

    /// <include file='WICRawCapabilities.xml' path='doc/member[@name="WICRawCapabilities.WICRawCapabilityFullySupported"]/*' />
    WICRawCapabilityFullySupported = 0x2,

    /// <include file='WICRawCapabilities.xml' path='doc/member[@name="WICRawCapabilities.WICRAWCAPABILITIES_FORCE_DWORD"]/*' />
    WICRAWCAPABILITIES_FORCE_DWORD = 0x7fffffff,
}
