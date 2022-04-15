// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_addressing_mode")]
    public enum AddressingMode : int
    {
        [NativeName("Name", "CL_ADDRESS_NONE")]
        AddressNone = 0x1130,
        [NativeName("Name", "CL_ADDRESS_CLAMP_TO_EDGE")]
        AddressClampToEdge = 0x1131,
        [NativeName("Name", "CL_ADDRESS_CLAMP")]
        AddressClamp = 0x1132,
        [NativeName("Name", "CL_ADDRESS_REPEAT")]
        AddressRepeat = 0x1133,
        [NativeName("Name", "CL_ADDRESS_MIRRORED_REPEAT")]
        AddressMirroredRepeat = 0x1134,
    }
}
