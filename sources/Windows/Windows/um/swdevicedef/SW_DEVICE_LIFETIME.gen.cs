// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/swdevicedef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SW_DEVICE_LIFETIME.xml' path='doc/member[@name="SW_DEVICE_LIFETIME"]/*' />
public enum SW_DEVICE_LIFETIME
{
    /// <include file='SW_DEVICE_LIFETIME.xml' path='doc/member[@name="SW_DEVICE_LIFETIME.SWDeviceLifetimeHandle"]/*' />
    SWDeviceLifetimeHandle,

    /// <include file='SW_DEVICE_LIFETIME.xml' path='doc/member[@name="SW_DEVICE_LIFETIME.SWDeviceLifetimeParentPresent"]/*' />
    SWDeviceLifetimeParentPresent,

    /// <include file='SW_DEVICE_LIFETIME.xml' path='doc/member[@name="SW_DEVICE_LIFETIME.SWDeviceLifetimeMax"]/*' />
    SWDeviceLifetimeMax,
}
