// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Converters.Constructors;

namespace Silk.NET.BuildTools.Overloading;

public class OpenCLUngroupCompatOverloader : ISimpleParameterOverloader, IPostProcessingSimpleOverloader
{
    public bool TryGetParameterVariant(Parameter parameter, out Parameter varied, Profile profile)
    {
        var project = profile.Projects
            .FirstOrDefault
            (
                x => x.Value.Enums.Any(y => y.Name == parameter.Type.Name) &&
                     x.Value.Enums.Any(y => y.NativeName == "CLenum")
            )
            .Value;

        if (project is null)
        {
            varied = null;
            return false;
        }

        var ungrouped = project.Enums.First(x => x.NativeName == "CLenum");

        varied = new ParameterSignatureBuilder(parameter)
            .WithType
            (
                new TypeSignatureBuilder(parameter.Type).WithName
                    (
                        _originalTypemaps.TryGetValue(parameter.Type.OriginalName, out var name) ? name : ungrouped.Name
                    )
                    .Build()
            )
            .Build();
        return true;
    }

    public void Finalize(Function function, Profile profile)
    {
        var ungrouped = function.Parameters.Select
            (
                x =>
                (
                    profile.Projects.FirstOrDefault(y => y.Value.Enums.Any(z => z.NativeName == x.Type.OriginalName))
                        .Value?
                        .Enums
                        .FirstOrDefault(y => y.NativeName == "CLenum"),
                    profile.Projects.Select(y => y.Value.Enums.FirstOrDefault(z => z.NativeName == x.Type.OriginalName))
                        .FirstOrDefault(y => y is not null),
                    x.Type
                )
            )
            .Where(x => x.Item1 is not null)
            .Select
            (
                x => (x.Item1.Name, x.Item2?.Name ?? x.Type.OriginalName, !x.Item2?.EnumBaseType.Name.Contains("int"))
            )
            .ToArray();

        if (ungrouped.Length == 0)
        {
            return;
        }
        
        var msg = string.Format
        (
            OpenCLConstructor.UngroupedDeprecationMessage,
            string.Join(", ", ungrouped.Select(x => x.Item1).Distinct()),
            string.Join(", ", ungrouped.Select(x => x.Item2).Distinct())
        );

        function.Attributes.Add
        (
            new Attribute
            {
                Name = "Obsolete",
                Arguments = new List<string>
                {
                    msg,
                    ungrouped.Any(x => x.Item3 ?? true).ToString().ToLower()
                }
            }
        );
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Below is the type mappings exactly as they were in Silk.NET 2.15 modulo any parameters that evaluated to CLenum
    // which are commented out. This is because not all enum parameters actually mapped to enums in 2.15, and we'd want
    // to recreate that to minimize breakage !!! DO NOT MODIFY !!! DO NOT MODIFY !!! DO NOT MODIFY !!! DO NOT MODIFY !!!
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    private static readonly Dictionary<string, string> _originalTypemaps = new()
    {
        { "cl_GLsync", "nint" },
        { "cl_accelerator_intel", "nint" },
        { "cl_platform_id", "nint" },
        { "cl_device_id", "nint" },
        { "cl_context", "nint" },
        { "cl_command_queue", "nint" },
        { "cl_mem", "nint" },
        { "cl_program", "nint" },
        { "cl_kernel", "nint" },
        { "cl_event", "nint" },
        { "cl_sampler", "nint" },
        { "cl_GLint", "int" },
        { "cl_GLenum", "uint" },
        { "cl_GLuint", "uint" },
        { "cl_d3d11_device_source_khr", "uint" },
        { "cl_d3d11_device_set_khr", "uint" },
        { "cl_dx9_media_adapter_type_khr", "uint" },
        { "cl_dx9_media_adapter_set_khr", "uint" },
        { "cl_d3d10_device_source_khr", "uint" },
        { "cl_d3d10_device_set_khr", "uint" },
        { "cl_dx9_device_source_intel", "uint" },
        { "cl_dx9_device_set_intel", "uint" },
        { "cl_accelerator_type_intel", "uint" },
        { "cl_accelerator_info_intel", "uint" },
        { "cl_diagnostics_verbose_level", "uint" },
        { "cl_va_api_device_source_intel", "uint" },
        { "cl_va_api_device_set_intel", "uint" },
        { "CLeglImageKHR", "nint" },
        { "CLeglDisplayKHR", "nint" },
        { "CLeglSyncKHR", "nint" },
        { "cl_egl_image_properties_khr", "nint" },
        { "cl_device_partition_property_ext", "ulong" },
        //{ "cl_mem_migration_flags_ext", "CLenum" },
        { "cl_image_pitch_info_qcom", "uint" },
        { "cl_image_format", "uint" },
        { "cl_queue_priority_khr", "uint" },
        { "cl_queue_throttle_khr", "uint" },
        { "cl_import_properties_arm", "nint" },
        //{ "cl_svm_mem_flags_arm", "CLenum" },
        { "cl_kernel_exec_info_arm", "uint" },
        //{ "cl_device_svm_capabilities_arm", "CLenum" },
        { "cl_gl_context_info", "uint" },
        { "cl_gl_object_type", "uint" },
        { "cl_gl_texture_info", "uint" },
        { "cl_gl_platform_info", "uint" },
        { "cl_bool", "bool" },
        { "CLenum", "ulong" },
        //{ "cl_device_type", "CLenum" },
        { "cl_platform_info", "uint" },
        { "cl_device_info", "uint" },
        //{ "cl_device_fp_config", "CLenum" },
        { "cl_device_mem_cache_type", "uint" },
        { "cl_device_local_mem_type", "uint" },
        //{ "cl_device_exec_capabilities", "CLenum" },
        //{ "cl_device_svm_capabilities", "CLenum" },
        //{ "cl_command_queue_properties", "CLenum" },
        { "cl_device_partition_property", "nint" },
        //{ "cl_device_affinity_domain", "CLenum" },
        { "cl_context_properties", "nint" },
        { "cl_context_info", "uint" },
        //{ "cl_queue_properties", "CLenum" },
        //{ "cl_queue_properties_khr", "CLenum" },
        { "cl_command_queue_info", "uint" },
        { "cl_channel_order", "uint" },
        { "cl_channel_type", "uint" },
        //{ "cl_mem_flags", "CLenum" },
        //{ "cl_svm_mem_flags", "CLenum" },
        { "cl_mem_object_type", "uint" },
        { "cl_mem_info", "uint" },
        //{ "cl_mem_migration_flags", "CLenum" },
        { "cl_image_info", "uint" },
        { "cl_buffer_create_type", "uint" },
        { "cl_addressing_mode", "uint" },
        { "cl_filter_mode", "uint" },
        { "cl_sampler_info", "uint" },
        //{ "cl_map_flags", "CLenum" },
        { "cl_pipe_properties", "nint" },
        { "cl_pipe_info", "uint" },
        { "cl_program_info", "uint" },
        { "cl_program_build_info", "uint" },
        { "cl_program_binary_type", "uint" },
        { "cl_build_status", "int" },
        { "cl_kernel_info", "uint" },
        { "cl_kernel_arg_info", "uint" },
        { "cl_kernel_arg_address_qualifier", "uint" },
        { "cl_kernel_arg_access_qualifier", "uint" },
        //{ "cl_kernel_arg_type_qualifier", "CLenum" },
        { "cl_kernel_work_group_info", "uint" },
        { "cl_kernel_sub_group_info", "uint" },
        { "cl_event_info", "uint" },
        { "cl_command_type", "uint" },
        { "cl_profiling_info", "uint" },
        //{ "cl_sampler_properties", "CLenum" },
        { "cl_kernel_exec_info", "uint" },
        //{ "cl_device_unified_shared_memory_capabilities_intel", "CLenum" },
        //{ "cl_mem_properties_intel", "CLenum" },
        //{ "cl_mem_alloc_flags_intel", "CLenum" },
        { "cl_mem_info_intel", "uint" },
        { "cl_unified_shared_memory_type_intel", "uint" },
        //{ "cl_mem_migration_flags_intel", "CLenum" },
        { "cl_mem_advice_intel", "uint" },
        { "cl_version", "uint" },
        //{ "cl_mem_properties", "CLenum" },
        //{ "cl_mipmap_filter_mode_img", "CLenum" },
        //{ "cl_command_queue_capabilities_intel", "CLenum" },
        { "cl_icd_dispatch", "void" },
        { "cl_layer_info", "uint" },
        { "cl_semaphore_khr", "nint" },
        { "cl_semaphore_properties_khr", "ulong" },
        //{ "cl_semaphore_info_khr", "CLenum" },
        //{ "cl_semaphore_type_khr", "CLenum" },
        { "cl_semaphore_payload_khr", "ulong" },
        { "cl_external_semaphore_handle_type_khr", "uint" },
        { "cl_external_memory_handle_type_khr", "uint" },
        //{ "cl_device_command_buffer_capabilities_khr", "cl_bitfield" },
        { "cl_sync_point_khr", "uint" },
        { "cl_command_buffer_info_khr", "uint" },
        { "cl_command_buffer_state_khr", "uint" },
        { "cl_command_buffer_properties_khr", "ulong" },
        //{ "cl_command_buffer_flags_khr", "cl_bitfield" },
        { "cl_ndrange_kernel_command_properties_khr", "ulong" },
        { "cl_mutable_command_khr", "nint" },
        { "cl_command_buffer_khr", "nint" }
    };
}
