// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [Flags]
    [NativeName("Name", "SpvReflectTypeFlagBits")]
    public enum ReflectTypeFlagBits : int
    {
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_UNDEFINED")]
        Undefined = 0x0,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_VOID")]
        Void = 0x1,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_BOOL")]
        Bool = 0x2,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_INT")]
        Int = 0x4,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_FLOAT")]
        Float = 0x8,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_VECTOR")]
        Vector = 0x100,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_MATRIX")]
        Matrix = 0x200,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_EXTERNAL_IMAGE")]
        ExternalImage = 0x10000,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_EXTERNAL_SAMPLER")]
        ExternalSampler = 0x20000,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_EXTERNAL_SAMPLED_IMAGE")]
        ExternalSampledImage = 0x40000,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_EXTERNAL_BLOCK")]
        ExternalBlock = 0x80000,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_EXTERNAL_ACCELERATION_STRUCTURE")]
        ExternalAccelerationStructure = 0x100000,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_EXTERNAL_MASK")]
        ExternalMask = 0xFF0000,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_STRUCT")]
        Struct = 0x10000000,
        [NativeName("Name", "SPV_REFLECT_TYPE_FLAG_ARRAY")]
        Array = 0x20000000,
    }
}
