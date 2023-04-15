// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvExecutionModel_")]
    public enum ExecutionModel : int
    {
        [NativeName("Name", "SpvExecutionModelVertex")]
        Vertex = 0x0,
        [NativeName("Name", "SpvExecutionModelTessellationControl")]
        TessellationControl = 0x1,
        [NativeName("Name", "SpvExecutionModelTessellationEvaluation")]
        TessellationEvaluation = 0x2,
        [NativeName("Name", "SpvExecutionModelGeometry")]
        Geometry = 0x3,
        [NativeName("Name", "SpvExecutionModelFragment")]
        Fragment = 0x4,
        [NativeName("Name", "SpvExecutionModelGLCompute")]
        GLCompute = 0x5,
        [NativeName("Name", "SpvExecutionModelKernel")]
        Kernel = 0x6,
        [NativeName("Name", "SpvExecutionModelTaskNV")]
        TaskNV = 0x1493,
        [NativeName("Name", "SpvExecutionModelMeshNV")]
        MeshNV = 0x1494,
        [NativeName("Name", "SpvExecutionModelRayGenerationKHR")]
        RayGenerationKhr = 0x14C1,
        [NativeName("Name", "SpvExecutionModelRayGenerationNV")]
        RayGenerationNV = 0x14C1,
        [NativeName("Name", "SpvExecutionModelIntersectionKHR")]
        IntersectionKhr = 0x14C2,
        [NativeName("Name", "SpvExecutionModelIntersectionNV")]
        IntersectionNV = 0x14C2,
        [NativeName("Name", "SpvExecutionModelAnyHitKHR")]
        AnyHitKhr = 0x14C3,
        [NativeName("Name", "SpvExecutionModelAnyHitNV")]
        AnyHitNV = 0x14C3,
        [NativeName("Name", "SpvExecutionModelClosestHitKHR")]
        ClosestHitKhr = 0x14C4,
        [NativeName("Name", "SpvExecutionModelClosestHitNV")]
        ClosestHitNV = 0x14C4,
        [NativeName("Name", "SpvExecutionModelMissKHR")]
        MissKhr = 0x14C5,
        [NativeName("Name", "SpvExecutionModelMissNV")]
        MissNV = 0x14C5,
        [NativeName("Name", "SpvExecutionModelCallableKHR")]
        CallableKhr = 0x14C6,
        [NativeName("Name", "SpvExecutionModelCallableNV")]
        CallableNV = 0x14C6,
        [NativeName("Name", "SpvExecutionModelTaskEXT")]
        TaskExt = 0x14F4,
        [NativeName("Name", "SpvExecutionModelMeshEXT")]
        MeshExt = 0x14F5,
        [NativeName("Name", "SpvExecutionModelMax")]
        Max = 0x7FFFFFFF,
    }
}
