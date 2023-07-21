// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEVICE_POWER_STATE.xml' path='doc/member[@name="DEVICE_POWER_STATE"]/*' />
public enum DEVICE_POWER_STATE
{
    /// <include file='DEVICE_POWER_STATE.xml' path='doc/member[@name="DEVICE_POWER_STATE.PowerDeviceUnspecified"]/*' />
    PowerDeviceUnspecified = 0,

    /// <include file='DEVICE_POWER_STATE.xml' path='doc/member[@name="DEVICE_POWER_STATE.PowerDeviceD0"]/*' />
    PowerDeviceD0,

    /// <include file='DEVICE_POWER_STATE.xml' path='doc/member[@name="DEVICE_POWER_STATE.PowerDeviceD1"]/*' />
    PowerDeviceD1,

    /// <include file='DEVICE_POWER_STATE.xml' path='doc/member[@name="DEVICE_POWER_STATE.PowerDeviceD2"]/*' />
    PowerDeviceD2,

    /// <include file='DEVICE_POWER_STATE.xml' path='doc/member[@name="DEVICE_POWER_STATE.PowerDeviceD3"]/*' />
    PowerDeviceD3,

    /// <include file='DEVICE_POWER_STATE.xml' path='doc/member[@name="DEVICE_POWER_STATE.PowerDeviceMaximum"]/*' />
    PowerDeviceMaximum,
}
