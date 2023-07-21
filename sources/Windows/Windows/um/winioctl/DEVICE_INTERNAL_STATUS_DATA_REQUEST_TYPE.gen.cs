// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE"]/*' />
public enum DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE
{
    /// <include file='DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.DeviceInternalStatusDataRequestTypeUndefined"]/*' />
    DeviceInternalStatusDataRequestTypeUndefined = 0,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.DeviceCurrentInternalStatusDataHeader"]/*' />
    DeviceCurrentInternalStatusDataHeader,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.DeviceCurrentInternalStatusData"]/*' />
    DeviceCurrentInternalStatusData,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.DeviceSavedInternalStatusDataHeader"]/*' />
    DeviceSavedInternalStatusDataHeader,

    /// <include file='DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE.DeviceSavedInternalStatusData"]/*' />
    DeviceSavedInternalStatusData,
}
