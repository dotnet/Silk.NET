// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_ZONED_DEVICE_TYPES.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_TYPES"]/*' />
public enum STORAGE_ZONED_DEVICE_TYPES
{
    /// <include file='STORAGE_ZONED_DEVICE_TYPES.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_TYPES.ZonedDeviceTypeUnknown"]/*' />
    ZonedDeviceTypeUnknown = 0,

    /// <include file='STORAGE_ZONED_DEVICE_TYPES.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_TYPES.ZonedDeviceTypeHostManaged"]/*' />
    ZonedDeviceTypeHostManaged,

    /// <include file='STORAGE_ZONED_DEVICE_TYPES.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_TYPES.ZonedDeviceTypeHostAware"]/*' />
    ZonedDeviceTypeHostAware,

    /// <include file='STORAGE_ZONED_DEVICE_TYPES.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_TYPES.ZonedDeviceTypeDeviceManaged"]/*' />
    ZonedDeviceTypeDeviceManaged,
}
