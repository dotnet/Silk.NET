// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvComponentType_")]
    public enum ComponentType : int
    {
        [NativeName("Name", "SpvComponentTypeFloat16NV")]
        Float16NV = 0x0,
        [NativeName("Name", "SpvComponentTypeFloat32NV")]
        Float32NV = 0x1,
        [NativeName("Name", "SpvComponentTypeFloat64NV")]
        Float64NV = 0x2,
        [NativeName("Name", "SpvComponentTypeSignedInt8NV")]
        SignedInt8NV = 0x3,
        [NativeName("Name", "SpvComponentTypeSignedInt16NV")]
        SignedInt16NV = 0x4,
        [NativeName("Name", "SpvComponentTypeSignedInt32NV")]
        SignedInt32NV = 0x5,
        [NativeName("Name", "SpvComponentTypeSignedInt64NV")]
        SignedInt64NV = 0x6,
        [NativeName("Name", "SpvComponentTypeUnsignedInt8NV")]
        UnsignedInt8NV = 0x7,
        [NativeName("Name", "SpvComponentTypeUnsignedInt16NV")]
        UnsignedInt16NV = 0x8,
        [NativeName("Name", "SpvComponentTypeUnsignedInt32NV")]
        UnsignedInt32NV = 0x9,
        [NativeName("Name", "SpvComponentTypeUnsignedInt64NV")]
        UnsignedInt64NV = 0xA,
        [NativeName("Name", "SpvComponentTypeSignedInt8PackedNV")]
        SignedInt8PackedNV = 0x3BA247F8,
        [NativeName("Name", "SpvComponentTypeUnsignedInt8PackedNV")]
        UnsignedInt8PackedNV = 0x3BA247F9,
        [NativeName("Name", "SpvComponentTypeFloatE4M3NV")]
        FloatE4M3NV = 0x3BA247FA,
        [NativeName("Name", "SpvComponentTypeFloatE5M2NV")]
        FloatE5M2NV = 0x3BA247FB,
        [NativeName("Name", "SpvComponentTypeMax")]
        Max = 0x7FFFFFFF,
    }
}
