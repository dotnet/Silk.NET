// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_resource_type")]
    public enum ResourceType : int
    {
        [NativeName("Name", "SPVC_RESOURCE_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_UNIFORM_BUFFER")]
        UniformBuffer = 0x1,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_STORAGE_BUFFER")]
        StorageBuffer = 0x2,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_STAGE_INPUT")]
        StageInput = 0x3,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_STAGE_OUTPUT")]
        StageOutput = 0x4,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_SUBPASS_INPUT")]
        SubpassInput = 0x5,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_STORAGE_IMAGE")]
        StorageImage = 0x6,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_SAMPLED_IMAGE")]
        SampledImage = 0x7,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_ATOMIC_COUNTER")]
        AtomicCounter = 0x8,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_PUSH_CONSTANT")]
        PushConstant = 0x9,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_SEPARATE_IMAGE")]
        SeparateImage = 0xA,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_SEPARATE_SAMPLERS")]
        SeparateSamplers = 0xB,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_ACCELERATION_STRUCTURE")]
        AccelerationStructure = 0xC,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_RAY_QUERY")]
        RayQuery = 0xD,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_SHADER_RECORD_BUFFER")]
        ShaderRecordBuffer = 0xE,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_GL_PLAIN_UNIFORM")]
        GLPlainUniform = 0xF,
        [NativeName("Name", "SPVC_RESOURCE_TYPE_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
