// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WCS_DEVICE_CAPABILITIES_TYPE.xml' path='doc/member[@name="WCS_DEVICE_CAPABILITIES_TYPE"]/*' />
public enum WCS_DEVICE_CAPABILITIES_TYPE
{
    /// <include file='WCS_DEVICE_CAPABILITIES_TYPE.xml' path='doc/member[@name="WCS_DEVICE_CAPABILITIES_TYPE.VideoCardGammaTable"]/*' />
    VideoCardGammaTable = 1,

    /// <include file='WCS_DEVICE_CAPABILITIES_TYPE.xml' path='doc/member[@name="WCS_DEVICE_CAPABILITIES_TYPE.MicrosoftHardwareColorV2"]/*' />
    MicrosoftHardwareColorV2 = 2,
}
