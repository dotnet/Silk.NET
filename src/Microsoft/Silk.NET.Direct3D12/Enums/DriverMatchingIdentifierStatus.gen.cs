// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS")]
    public enum DriverMatchingIdentifierStatus : int
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
