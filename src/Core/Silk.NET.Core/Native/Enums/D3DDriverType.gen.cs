// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_DRIVER_TYPE")]
    public enum D3DDriverType : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D_DRIVER_TYPE_UNKNOWN")]
        D3DDriverTypeUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Hardware\"")]
        [NativeName("Name", "D3D_DRIVER_TYPE_HARDWARE")]
        D3DDriverTypeHardware = 0x1,
        [Obsolete("Deprecated in favour of \"Reference\"")]
        [NativeName("Name", "D3D_DRIVER_TYPE_REFERENCE")]
        D3DDriverTypeReference = 0x2,
        [Obsolete("Deprecated in favour of \"Null\"")]
        [NativeName("Name", "D3D_DRIVER_TYPE_NULL")]
        D3DDriverTypeNull = 0x3,
        [Obsolete("Deprecated in favour of \"Software\"")]
        [NativeName("Name", "D3D_DRIVER_TYPE_SOFTWARE")]
        D3DDriverTypeSoftware = 0x4,
        [Obsolete("Deprecated in favour of \"Warp\"")]
        [NativeName("Name", "D3D_DRIVER_TYPE_WARP")]
        D3DDriverTypeWarp = 0x5,
        [NativeName("Name", "D3D_DRIVER_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D_DRIVER_TYPE_HARDWARE")]
        Hardware = 0x1,
        [NativeName("Name", "D3D_DRIVER_TYPE_REFERENCE")]
        Reference = 0x2,
        [NativeName("Name", "D3D_DRIVER_TYPE_NULL")]
        Null = 0x3,
        [NativeName("Name", "D3D_DRIVER_TYPE_SOFTWARE")]
        Software = 0x4,
        [NativeName("Name", "D3D_DRIVER_TYPE_WARP")]
        Warp = 0x5,
    }
}
