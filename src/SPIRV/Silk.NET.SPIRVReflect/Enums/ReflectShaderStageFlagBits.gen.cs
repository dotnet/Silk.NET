// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [Flags]
    [NativeName("Name", "SpvReflectShaderStageFlagBits")]
    public enum ReflectShaderStageFlagBits : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_VERTEX_BIT")]
        VertexBit = 0x1,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_TESSELLATION_CONTROL_BIT")]
        TessellationControlBit = 0x2,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_TESSELLATION_EVALUATION_BIT")]
        TessellationEvaluationBit = 0x4,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_GEOMETRY_BIT")]
        GeometryBit = 0x8,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_FRAGMENT_BIT")]
        FragmentBit = 0x10,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_COMPUTE_BIT")]
        ComputeBit = 0x20,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_TASK_BIT_NV")]
        TaskBitNV = 0x40,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_TASK_BIT_EXT")]
        TaskBitExt = 0x40,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_MESH_BIT_NV")]
        MeshBitNV = 0x80,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_MESH_BIT_EXT")]
        MeshBitExt = 0x80,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_RAYGEN_BIT_KHR")]
        RaygenBitKhr = 0x100,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_ANY_HIT_BIT_KHR")]
        AnyHitBitKhr = 0x200,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_CLOSEST_HIT_BIT_KHR")]
        ClosestHitBitKhr = 0x400,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_MISS_BIT_KHR")]
        MissBitKhr = 0x800,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_INTERSECTION_BIT_KHR")]
        IntersectionBitKhr = 0x1000,
        [NativeName("Name", "SPV_REFLECT_SHADER_STAGE_CALLABLE_BIT_KHR")]
        CallableBitKhr = 0x2000,
    }
}
