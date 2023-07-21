// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WCS_DEVICE_VCGT_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_VCGT_CAPABILITIES"]/*' />
public partial struct WCS_DEVICE_VCGT_CAPABILITIES
{
    /// <include file='WCS_DEVICE_VCGT_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_VCGT_CAPABILITIES.Size"]/*' />
    public uint Size;

    /// <include file='WCS_DEVICE_VCGT_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_VCGT_CAPABILITIES.SupportsVcgt"]/*' />
    public BOOL SupportsVcgt;
}
