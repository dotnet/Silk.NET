// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/swdevicedef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='SW_DEVICE_CAPABILITIES.xml' path='doc/member[@name="SW_DEVICE_CAPABILITIES"]/*' />
[Flags]
public enum SW_DEVICE_CAPABILITIES
{
    /// <include file='SW_DEVICE_CAPABILITIES.xml' path='doc/member[@name="SW_DEVICE_CAPABILITIES.SWDeviceCapabilitiesNone"]/*' />
    SWDeviceCapabilitiesNone = 0x00000000,

    /// <include file='SW_DEVICE_CAPABILITIES.xml' path='doc/member[@name="SW_DEVICE_CAPABILITIES.SWDeviceCapabilitiesRemovable"]/*' />
    SWDeviceCapabilitiesRemovable = 0x00000001,

    /// <include file='SW_DEVICE_CAPABILITIES.xml' path='doc/member[@name="SW_DEVICE_CAPABILITIES.SWDeviceCapabilitiesSilentInstall"]/*' />
    SWDeviceCapabilitiesSilentInstall = 0x00000002,

    /// <include file='SW_DEVICE_CAPABILITIES.xml' path='doc/member[@name="SW_DEVICE_CAPABILITIES.SWDeviceCapabilitiesNoDisplayInUI"]/*' />
    SWDeviceCapabilitiesNoDisplayInUI = 0x00000004,

    /// <include file='SW_DEVICE_CAPABILITIES.xml' path='doc/member[@name="SW_DEVICE_CAPABILITIES.SWDeviceCapabilitiesDriverRequired"]/*' />
    SWDeviceCapabilitiesDriverRequired = 0x00000008,
}
