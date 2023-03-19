// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_DEVICE_TYPE")]
    public enum HDDeviceType : int
    {
        [Obsolete("Deprecated in favour of \"Hardware\"")]
        [NativeName("Name", "DXVAHD_DEVICE_TYPE_HARDWARE")]
        HDDeviceTypeHardware = 0x0,
        [Obsolete("Deprecated in favour of \"Software\"")]
        [NativeName("Name", "DXVAHD_DEVICE_TYPE_SOFTWARE")]
        HDDeviceTypeSoftware = 0x1,
        [Obsolete("Deprecated in favour of \"Reference\"")]
        [NativeName("Name", "DXVAHD_DEVICE_TYPE_REFERENCE")]
        HDDeviceTypeReference = 0x2,
        [Obsolete("Deprecated in favour of \"Other\"")]
        [NativeName("Name", "DXVAHD_DEVICE_TYPE_OTHER")]
        HDDeviceTypeOther = 0x3,
        [NativeName("Name", "DXVAHD_DEVICE_TYPE_HARDWARE")]
        Hardware = 0x0,
        [NativeName("Name", "DXVAHD_DEVICE_TYPE_SOFTWARE")]
        Software = 0x1,
        [NativeName("Name", "DXVAHD_DEVICE_TYPE_REFERENCE")]
        Reference = 0x2,
        [NativeName("Name", "DXVAHD_DEVICE_TYPE_OTHER")]
        Other = 0x3,
    }
}
