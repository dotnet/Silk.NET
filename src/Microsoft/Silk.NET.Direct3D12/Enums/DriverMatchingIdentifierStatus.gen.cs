// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS")]
    public enum DriverMatchingIdentifierStatus : int
    {
        [Obsolete("Deprecated in favour of \"CompatibleWithDevice\"")]
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_COMPATIBLE_WITH_DEVICE")]
        DriverMatchingIdentifierCompatibleWithDevice = 0x0,
        [Obsolete("Deprecated in favour of \"UnsupportedType\"")]
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_UNSUPPORTED_TYPE")]
        DriverMatchingIdentifierUnsupportedType = 0x1,
        [Obsolete("Deprecated in favour of \"Unrecognized\"")]
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_UNRECOGNIZED")]
        DriverMatchingIdentifierUnrecognized = 0x2,
        [Obsolete("Deprecated in favour of \"IncompatibleVersion\"")]
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_VERSION")]
        DriverMatchingIdentifierIncompatibleVersion = 0x3,
        [Obsolete("Deprecated in favour of \"IncompatibleType\"")]
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_TYPE")]
        DriverMatchingIdentifierIncompatibleType = 0x4,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_COMPATIBLE_WITH_DEVICE")]
        CompatibleWithDevice = 0x0,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_UNSUPPORTED_TYPE")]
        UnsupportedType = 0x1,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_UNRECOGNIZED")]
        Unrecognized = 0x2,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_VERSION")]
        IncompatibleVersion = 0x3,
        [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_TYPE")]
        IncompatibleType = 0x4,
    }
}
