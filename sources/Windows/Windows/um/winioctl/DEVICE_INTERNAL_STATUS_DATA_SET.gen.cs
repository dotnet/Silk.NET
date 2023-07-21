// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEVICE_INTERNAL_STATUS_DATA_SET.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_SET"]/*' />
public enum DEVICE_INTERNAL_STATUS_DATA_SET
{
    /// <include file='DEVICE_INTERNAL_STATUS_DATA_SET.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_SET.DeviceStatusDataSetUndefined"]/*' />
    DeviceStatusDataSetUndefined = 0,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_SET.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_SET.DeviceStatusDataSet1"]/*' />
    DeviceStatusDataSet1,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_SET.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_SET.DeviceStatusDataSet2"]/*' />
    DeviceStatusDataSet2,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_SET.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_SET.DeviceStatusDataSet3"]/*' />
    DeviceStatusDataSet3,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_SET.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_SET.DeviceStatusDataSet4"]/*' />
    DeviceStatusDataSet4,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_SET.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_SET.DeviceStatusDataSetMax"]/*' />
    DeviceStatusDataSetMax,
}
