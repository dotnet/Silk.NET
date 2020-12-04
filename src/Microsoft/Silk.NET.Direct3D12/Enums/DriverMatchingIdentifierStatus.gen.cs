// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS")]
    public enum DriverMatchingIdentifierStatus
    {
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_COMPATIBLE_WITH_DEVICE")]
        DriverMatchingIdentifierCompatibleWithDevice = 0x0,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_UNSUPPORTED_TYPE")]
        DriverMatchingIdentifierUnsupportedType = 0x1,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_UNRECOGNIZED")]
        DriverMatchingIdentifierUnrecognized = 0x2,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_VERSION")]
        DriverMatchingIdentifierIncompatibleVersion = 0x3,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_TYPE")]
        DriverMatchingIdentifierIncompatibleType = 0x4,
    }
}
