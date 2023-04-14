// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvReflectFormat")]
    public enum ReflectFormat : int
    {
        [NativeName("Name", "SPV_REFLECT_FORMAT_UNDEFINED")]
        Undefined = 0x0,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32_UINT")]
        R32Uint = 0x62,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32_SINT")]
        R32Sint = 0x63,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32_SFLOAT")]
        R32Sfloat = 0x64,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32_UINT")]
        R32G32Uint = 0x65,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32_SINT")]
        R32G32Sint = 0x66,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32_SFLOAT")]
        R32G32Sfloat = 0x67,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32B32_UINT")]
        R32G32B32Uint = 0x68,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32B32_SINT")]
        R32G32B32Sint = 0x69,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32B32_SFLOAT")]
        R32G32B32Sfloat = 0x6A,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32B32A32_UINT")]
        R32G32B32A32Uint = 0x6B,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32B32A32_SINT")]
        R32G32B32A32Sint = 0x6C,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R32G32B32A32_SFLOAT")]
        R32G32B32A32Sfloat = 0x6D,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64_UINT")]
        R64Uint = 0x6E,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64_SINT")]
        R64Sint = 0x6F,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64_SFLOAT")]
        R64Sfloat = 0x70,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64_UINT")]
        R64G64Uint = 0x71,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64_SINT")]
        R64G64Sint = 0x72,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64_SFLOAT")]
        R64G64Sfloat = 0x73,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64B64_UINT")]
        R64G64B64Uint = 0x74,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64B64_SINT")]
        R64G64B64Sint = 0x75,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64B64_SFLOAT")]
        R64G64B64Sfloat = 0x76,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64B64A64_UINT")]
        R64G64B64A64Uint = 0x77,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64B64A64_SINT")]
        R64G64B64A64Sint = 0x78,
        [NativeName("Name", "SPV_REFLECT_FORMAT_R64G64B64A64_SFLOAT")]
        R64G64B64A64Sfloat = 0x79,
    }
}
