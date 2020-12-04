// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_DRIVER_TYPE")]
    public enum D3DDriverType
    {
        [NativeName("Name", "D3D_DRIVER_TYPE_UNKNOWN")]
        D3DDriverTypeUnknown = 0x0,
        [NativeName("Name", "D3D_DRIVER_TYPE_HARDWARE")]
        D3DDriverTypeHardware = 0x1,
        [NativeName("Name", "D3D_DRIVER_TYPE_REFERENCE")]
        D3DDriverTypeReference = 0x2,
        [NativeName("Name", "D3D_DRIVER_TYPE_NULL")]
        D3DDriverTypeNull = 0x3,
        [NativeName("Name", "D3D_DRIVER_TYPE_SOFTWARE")]
        D3DDriverTypeSoftware = 0x4,
        [NativeName("Name", "D3D_DRIVER_TYPE_WARP")]
        D3DDriverTypeWarp = 0x5,
    }
}
