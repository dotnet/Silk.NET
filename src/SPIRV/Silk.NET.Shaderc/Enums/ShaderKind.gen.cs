// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_shaderc_L36_C9")]
    [NativeName("Name", "shaderc_shader_kind")]
    public enum ShaderKind : int
    {
        [NativeName("Name", "shaderc_vertex_shader")]
        VertexShader = 0x0,
        [NativeName("Name", "shaderc_fragment_shader")]
        FragmentShader = 0x1,
        [NativeName("Name", "shaderc_compute_shader")]
        ComputeShader = 0x2,
        [NativeName("Name", "shaderc_geometry_shader")]
        GeometryShader = 0x3,
        [NativeName("Name", "shaderc_tess_control_shader")]
        TessControlShader = 0x4,
        [NativeName("Name", "shaderc_tess_evaluation_shader")]
        TessEvaluationShader = 0x5,
        [NativeName("Name", "shaderc_glsl_vertex_shader")]
        GlslVertexShader = 0x0,
        [NativeName("Name", "shaderc_glsl_fragment_shader")]
        GlslFragmentShader = 0x1,
        [NativeName("Name", "shaderc_glsl_compute_shader")]
        GlslComputeShader = 0x2,
        [NativeName("Name", "shaderc_glsl_geometry_shader")]
        GlslGeometryShader = 0x3,
        [NativeName("Name", "shaderc_glsl_tess_control_shader")]
        GlslTessControlShader = 0x4,
        [NativeName("Name", "shaderc_glsl_tess_evaluation_shader")]
        GlslTessEvaluationShader = 0x5,
        [NativeName("Name", "shaderc_glsl_infer_from_source")]
        GlslInferFromSource = 0x6,
        [NativeName("Name", "shaderc_glsl_default_vertex_shader")]
        GlslDefaultVertexShader = 0x7,
        [NativeName("Name", "shaderc_glsl_default_fragment_shader")]
        GlslDefaultFragmentShader = 0x8,
        [NativeName("Name", "shaderc_glsl_default_compute_shader")]
        GlslDefaultComputeShader = 0x9,
        [NativeName("Name", "shaderc_glsl_default_geometry_shader")]
        GlslDefaultGeometryShader = 0xA,
        [NativeName("Name", "shaderc_glsl_default_tess_control_shader")]
        GlslDefaultTessControlShader = 0xB,
        [NativeName("Name", "shaderc_glsl_default_tess_evaluation_shader")]
        GlslDefaultTessEvaluationShader = 0xC,
        [NativeName("Name", "shaderc_spirv_assembly")]
        SpirvAssembly = 0xD,
        [NativeName("Name", "shaderc_raygen_shader")]
        RaygenShader = 0xE,
        [NativeName("Name", "shaderc_anyhit_shader")]
        AnyhitShader = 0xF,
        [NativeName("Name", "shaderc_closesthit_shader")]
        ClosesthitShader = 0x10,
        [NativeName("Name", "shaderc_miss_shader")]
        MissShader = 0x11,
        [NativeName("Name", "shaderc_intersection_shader")]
        IntersectionShader = 0x12,
        [NativeName("Name", "shaderc_callable_shader")]
        CallableShader = 0x13,
        [NativeName("Name", "shaderc_glsl_raygen_shader")]
        GlslRaygenShader = 0xE,
        [NativeName("Name", "shaderc_glsl_anyhit_shader")]
        GlslAnyhitShader = 0xF,
        [NativeName("Name", "shaderc_glsl_closesthit_shader")]
        GlslClosesthitShader = 0x10,
        [NativeName("Name", "shaderc_glsl_miss_shader")]
        GlslMissShader = 0x11,
        [NativeName("Name", "shaderc_glsl_intersection_shader")]
        GlslIntersectionShader = 0x12,
        [NativeName("Name", "shaderc_glsl_callable_shader")]
        GlslCallableShader = 0x13,
        [NativeName("Name", "shaderc_glsl_default_raygen_shader")]
        GlslDefaultRaygenShader = 0x14,
        [NativeName("Name", "shaderc_glsl_default_anyhit_shader")]
        GlslDefaultAnyhitShader = 0x15,
        [NativeName("Name", "shaderc_glsl_default_closesthit_shader")]
        GlslDefaultClosesthitShader = 0x16,
        [NativeName("Name", "shaderc_glsl_default_miss_shader")]
        GlslDefaultMissShader = 0x17,
        [NativeName("Name", "shaderc_glsl_default_intersection_shader")]
        GlslDefaultIntersectionShader = 0x18,
        [NativeName("Name", "shaderc_glsl_default_callable_shader")]
        GlslDefaultCallableShader = 0x19,
        [NativeName("Name", "shaderc_task_shader")]
        TaskShader = 0x1A,
        [NativeName("Name", "shaderc_mesh_shader")]
        MeshShader = 0x1B,
        [NativeName("Name", "shaderc_glsl_task_shader")]
        GlslTaskShader = 0x1A,
        [NativeName("Name", "shaderc_glsl_mesh_shader")]
        GlslMeshShader = 0x1B,
        [NativeName("Name", "shaderc_glsl_default_task_shader")]
        GlslDefaultTaskShader = 0x1C,
        [NativeName("Name", "shaderc_glsl_default_mesh_shader")]
        GlslDefaultMeshShader = 0x1D,
    }
}
