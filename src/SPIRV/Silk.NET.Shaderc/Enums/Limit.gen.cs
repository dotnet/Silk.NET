// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_shaderc_L108_C9")]
    [NativeName("Name", "shaderc_limit")]
    public enum Limit : int
    {
        [NativeName("Name", "shaderc_limit_max_lights")]
        MaxLights = 0x0,
        [NativeName("Name", "shaderc_limit_max_clip_planes")]
        MaxClipPlanes = 0x1,
        [NativeName("Name", "shaderc_limit_max_texture_units")]
        MaxTextureUnits = 0x2,
        [NativeName("Name", "shaderc_limit_max_texture_coords")]
        MaxTextureCoords = 0x3,
        [NativeName("Name", "shaderc_limit_max_vertex_attribs")]
        MaxVertexAttribs = 0x4,
        [NativeName("Name", "shaderc_limit_max_vertex_uniform_components")]
        MaxVertexUniformComponents = 0x5,
        [NativeName("Name", "shaderc_limit_max_varying_floats")]
        MaxVaryingFloats = 0x6,
        [NativeName("Name", "shaderc_limit_max_vertex_texture_image_units")]
        MaxVertexTextureImageUnits = 0x7,
        [NativeName("Name", "shaderc_limit_max_combined_texture_image_units")]
        MaxCombinedTextureImageUnits = 0x8,
        [NativeName("Name", "shaderc_limit_max_texture_image_units")]
        MaxTextureImageUnits = 0x9,
        [NativeName("Name", "shaderc_limit_max_fragment_uniform_components")]
        MaxFragmentUniformComponents = 0xA,
        [NativeName("Name", "shaderc_limit_max_draw_buffers")]
        MaxDrawBuffers = 0xB,
        [NativeName("Name", "shaderc_limit_max_vertex_uniform_vectors")]
        MaxVertexUniformVectors = 0xC,
        [NativeName("Name", "shaderc_limit_max_varying_vectors")]
        MaxVaryingVectors = 0xD,
        [NativeName("Name", "shaderc_limit_max_fragment_uniform_vectors")]
        MaxFragmentUniformVectors = 0xE,
        [NativeName("Name", "shaderc_limit_max_vertex_output_vectors")]
        MaxVertexOutputVectors = 0xF,
        [NativeName("Name", "shaderc_limit_max_fragment_input_vectors")]
        MaxFragmentInputVectors = 0x10,
        [NativeName("Name", "shaderc_limit_min_program_texel_offset")]
        MinProgramTexelOffset = 0x11,
        [NativeName("Name", "shaderc_limit_max_program_texel_offset")]
        MaxProgramTexelOffset = 0x12,
        [NativeName("Name", "shaderc_limit_max_clip_distances")]
        MaxClipDistances = 0x13,
        [NativeName("Name", "shaderc_limit_max_compute_work_group_count_x")]
        MaxComputeWorkGroupCountX = 0x14,
        [NativeName("Name", "shaderc_limit_max_compute_work_group_count_y")]
        MaxComputeWorkGroupCountY = 0x15,
        [NativeName("Name", "shaderc_limit_max_compute_work_group_count_z")]
        MaxComputeWorkGroupCountZ = 0x16,
        [NativeName("Name", "shaderc_limit_max_compute_work_group_size_x")]
        MaxComputeWorkGroupSizeX = 0x17,
        [NativeName("Name", "shaderc_limit_max_compute_work_group_size_y")]
        MaxComputeWorkGroupSizeY = 0x18,
        [NativeName("Name", "shaderc_limit_max_compute_work_group_size_z")]
        MaxComputeWorkGroupSizeZ = 0x19,
        [NativeName("Name", "shaderc_limit_max_compute_uniform_components")]
        MaxComputeUniformComponents = 0x1A,
        [NativeName("Name", "shaderc_limit_max_compute_texture_image_units")]
        MaxComputeTextureImageUnits = 0x1B,
        [NativeName("Name", "shaderc_limit_max_compute_image_uniforms")]
        MaxComputeImageUniforms = 0x1C,
        [NativeName("Name", "shaderc_limit_max_compute_atomic_counters")]
        MaxComputeAtomicCounters = 0x1D,
        [NativeName("Name", "shaderc_limit_max_compute_atomic_counter_buffers")]
        MaxComputeAtomicCounterBuffers = 0x1E,
        [NativeName("Name", "shaderc_limit_max_varying_components")]
        MaxVaryingComponents = 0x1F,
        [NativeName("Name", "shaderc_limit_max_vertex_output_components")]
        MaxVertexOutputComponents = 0x20,
        [NativeName("Name", "shaderc_limit_max_geometry_input_components")]
        MaxGeometryInputComponents = 0x21,
        [NativeName("Name", "shaderc_limit_max_geometry_output_components")]
        MaxGeometryOutputComponents = 0x22,
        [NativeName("Name", "shaderc_limit_max_fragment_input_components")]
        MaxFragmentInputComponents = 0x23,
        [NativeName("Name", "shaderc_limit_max_image_units")]
        MaxImageUnits = 0x24,
        [NativeName("Name", "shaderc_limit_max_combined_image_units_and_fragment_outputs")]
        MaxCombinedImageUnitsAndFragmentOutputs = 0x25,
        [NativeName("Name", "shaderc_limit_max_combined_shader_output_resources")]
        MaxCombinedShaderOutputResources = 0x26,
        [NativeName("Name", "shaderc_limit_max_image_samples")]
        MaxImageSamples = 0x27,
        [NativeName("Name", "shaderc_limit_max_vertex_image_uniforms")]
        MaxVertexImageUniforms = 0x28,
        [NativeName("Name", "shaderc_limit_max_tess_control_image_uniforms")]
        MaxTessControlImageUniforms = 0x29,
        [NativeName("Name", "shaderc_limit_max_tess_evaluation_image_uniforms")]
        MaxTessEvaluationImageUniforms = 0x2A,
        [NativeName("Name", "shaderc_limit_max_geometry_image_uniforms")]
        MaxGeometryImageUniforms = 0x2B,
        [NativeName("Name", "shaderc_limit_max_fragment_image_uniforms")]
        MaxFragmentImageUniforms = 0x2C,
        [NativeName("Name", "shaderc_limit_max_combined_image_uniforms")]
        MaxCombinedImageUniforms = 0x2D,
        [NativeName("Name", "shaderc_limit_max_geometry_texture_image_units")]
        MaxGeometryTextureImageUnits = 0x2E,
        [NativeName("Name", "shaderc_limit_max_geometry_output_vertices")]
        MaxGeometryOutputVertices = 0x2F,
        [NativeName("Name", "shaderc_limit_max_geometry_total_output_components")]
        MaxGeometryTotalOutputComponents = 0x30,
        [NativeName("Name", "shaderc_limit_max_geometry_uniform_components")]
        MaxGeometryUniformComponents = 0x31,
        [NativeName("Name", "shaderc_limit_max_geometry_varying_components")]
        MaxGeometryVaryingComponents = 0x32,
        [NativeName("Name", "shaderc_limit_max_tess_control_input_components")]
        MaxTessControlInputComponents = 0x33,
        [NativeName("Name", "shaderc_limit_max_tess_control_output_components")]
        MaxTessControlOutputComponents = 0x34,
        [NativeName("Name", "shaderc_limit_max_tess_control_texture_image_units")]
        MaxTessControlTextureImageUnits = 0x35,
        [NativeName("Name", "shaderc_limit_max_tess_control_uniform_components")]
        MaxTessControlUniformComponents = 0x36,
        [NativeName("Name", "shaderc_limit_max_tess_control_total_output_components")]
        MaxTessControlTotalOutputComponents = 0x37,
        [NativeName("Name", "shaderc_limit_max_tess_evaluation_input_components")]
        MaxTessEvaluationInputComponents = 0x38,
        [NativeName("Name", "shaderc_limit_max_tess_evaluation_output_components")]
        MaxTessEvaluationOutputComponents = 0x39,
        [NativeName("Name", "shaderc_limit_max_tess_evaluation_texture_image_units")]
        MaxTessEvaluationTextureImageUnits = 0x3A,
        [NativeName("Name", "shaderc_limit_max_tess_evaluation_uniform_components")]
        MaxTessEvaluationUniformComponents = 0x3B,
        [NativeName("Name", "shaderc_limit_max_tess_patch_components")]
        MaxTessPatchComponents = 0x3C,
        [NativeName("Name", "shaderc_limit_max_patch_vertices")]
        MaxPatchVertices = 0x3D,
        [NativeName("Name", "shaderc_limit_max_tess_gen_level")]
        MaxTessGenLevel = 0x3E,
        [NativeName("Name", "shaderc_limit_max_viewports")]
        MaxViewports = 0x3F,
        [NativeName("Name", "shaderc_limit_max_vertex_atomic_counters")]
        MaxVertexAtomicCounters = 0x40,
        [NativeName("Name", "shaderc_limit_max_tess_control_atomic_counters")]
        MaxTessControlAtomicCounters = 0x41,
        [NativeName("Name", "shaderc_limit_max_tess_evaluation_atomic_counters")]
        MaxTessEvaluationAtomicCounters = 0x42,
        [NativeName("Name", "shaderc_limit_max_geometry_atomic_counters")]
        MaxGeometryAtomicCounters = 0x43,
        [NativeName("Name", "shaderc_limit_max_fragment_atomic_counters")]
        MaxFragmentAtomicCounters = 0x44,
        [NativeName("Name", "shaderc_limit_max_combined_atomic_counters")]
        MaxCombinedAtomicCounters = 0x45,
        [NativeName("Name", "shaderc_limit_max_atomic_counter_bindings")]
        MaxAtomicCounterBindings = 0x46,
        [NativeName("Name", "shaderc_limit_max_vertex_atomic_counter_buffers")]
        MaxVertexAtomicCounterBuffers = 0x47,
        [NativeName("Name", "shaderc_limit_max_tess_control_atomic_counter_buffers")]
        MaxTessControlAtomicCounterBuffers = 0x48,
        [NativeName("Name", "shaderc_limit_max_tess_evaluation_atomic_counter_buffers")]
        MaxTessEvaluationAtomicCounterBuffers = 0x49,
        [NativeName("Name", "shaderc_limit_max_geometry_atomic_counter_buffers")]
        MaxGeometryAtomicCounterBuffers = 0x4A,
        [NativeName("Name", "shaderc_limit_max_fragment_atomic_counter_buffers")]
        MaxFragmentAtomicCounterBuffers = 0x4B,
        [NativeName("Name", "shaderc_limit_max_combined_atomic_counter_buffers")]
        MaxCombinedAtomicCounterBuffers = 0x4C,
        [NativeName("Name", "shaderc_limit_max_atomic_counter_buffer_size")]
        MaxAtomicCounterBufferSize = 0x4D,
        [NativeName("Name", "shaderc_limit_max_transform_feedback_buffers")]
        MaxTransformFeedbackBuffers = 0x4E,
        [NativeName("Name", "shaderc_limit_max_transform_feedback_interleaved_components")]
        MaxTransformFeedbackInterleavedComponents = 0x4F,
        [NativeName("Name", "shaderc_limit_max_cull_distances")]
        MaxCullDistances = 0x50,
        [NativeName("Name", "shaderc_limit_max_combined_clip_and_cull_distances")]
        MaxCombinedClipAndCullDistances = 0x51,
        [NativeName("Name", "shaderc_limit_max_samples")]
        MaxSamples = 0x52,
        [NativeName("Name", "shaderc_limit_max_mesh_output_vertices_nv")]
        MaxMeshOutputVerticesNv = 0x53,
        [NativeName("Name", "shaderc_limit_max_mesh_output_primitives_nv")]
        MaxMeshOutputPrimitivesNv = 0x54,
        [NativeName("Name", "shaderc_limit_max_mesh_work_group_size_x_nv")]
        MaxMeshWorkGroupSizeXNv = 0x55,
        [NativeName("Name", "shaderc_limit_max_mesh_work_group_size_y_nv")]
        MaxMeshWorkGroupSizeYNv = 0x56,
        [NativeName("Name", "shaderc_limit_max_mesh_work_group_size_z_nv")]
        MaxMeshWorkGroupSizeZNv = 0x57,
        [NativeName("Name", "shaderc_limit_max_task_work_group_size_x_nv")]
        MaxTaskWorkGroupSizeXNv = 0x58,
        [NativeName("Name", "shaderc_limit_max_task_work_group_size_y_nv")]
        MaxTaskWorkGroupSizeYNv = 0x59,
        [NativeName("Name", "shaderc_limit_max_task_work_group_size_z_nv")]
        MaxTaskWorkGroupSizeZNv = 0x5A,
        [NativeName("Name", "shaderc_limit_max_mesh_view_count_nv")]
        MaxMeshViewCountNv = 0x5B,
        [NativeName("Name", "shaderc_limit_max_mesh_output_vertices_ext")]
        MaxMeshOutputVerticesExt = 0x5C,
        [NativeName("Name", "shaderc_limit_max_mesh_output_primitives_ext")]
        MaxMeshOutputPrimitivesExt = 0x5D,
        [NativeName("Name", "shaderc_limit_max_mesh_work_group_size_x_ext")]
        MaxMeshWorkGroupSizeXExt = 0x5E,
        [NativeName("Name", "shaderc_limit_max_mesh_work_group_size_y_ext")]
        MaxMeshWorkGroupSizeYExt = 0x5F,
        [NativeName("Name", "shaderc_limit_max_mesh_work_group_size_z_ext")]
        MaxMeshWorkGroupSizeZExt = 0x60,
        [NativeName("Name", "shaderc_limit_max_task_work_group_size_x_ext")]
        MaxTaskWorkGroupSizeXExt = 0x61,
        [NativeName("Name", "shaderc_limit_max_task_work_group_size_y_ext")]
        MaxTaskWorkGroupSizeYExt = 0x62,
        [NativeName("Name", "shaderc_limit_max_task_work_group_size_z_ext")]
        MaxTaskWorkGroupSizeZExt = 0x63,
        [NativeName("Name", "shaderc_limit_max_mesh_view_count_ext")]
        MaxMeshViewCountExt = 0x64,
        [NativeName("Name", "shaderc_limit_max_dual_source_draw_buffers_ext")]
        MaxDualSourceDrawBuffersExt = 0x65,
    }
}
