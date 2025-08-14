// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    public unsafe partial class Cross : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_C_API_VERSION_MAJOR")]
        public const int CApiVersionMajor = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_C_API_VERSION_MINOR")]
        public const int CApiVersionMinor = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_C_API_VERSION_PATCH")]
        public const int CApiVersionPatch = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_COMPILER_OPTION_COMMON_BIT")]
        public const int CompilerOptionCommonBit = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_COMPILER_OPTION_GLSL_BIT")]
        public const int CompilerOptionGlslBit = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_COMPILER_OPTION_HLSL_BIT")]
        public const int CompilerOptionHlslBit = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_COMPILER_OPTION_MSL_BIT")]
        public const int CompilerOptionMslBit = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_COMPILER_OPTION_LANG_BITS")]
        public const int CompilerOptionLangBits = unchecked((int) 0xF000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_COMPILER_OPTION_ENUM_BITS")]
        public const int CompilerOptionEnumBits = unchecked((int) 0xFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_MSL_PUSH_CONSTANT_BINDING")]
        public const int MslPushConstantBinding = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_MSL_AUX_BUFFER_STRUCT_VERSION")]
        public const int MslAuxBufferStructVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SPVC_HLSL_PUSH_CONSTANT_BINDING")]
        public const int HlslPushConstantBinding = unchecked((int) 0x0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_version")]
        public unsafe partial void GetVersion(uint* major, uint* minor, uint* patch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_version")]
        public unsafe partial void GetVersion(uint* major, uint* minor, ref uint patch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_version")]
        public unsafe partial void GetVersion(uint* major, ref uint minor, uint* patch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_version")]
        public unsafe partial void GetVersion(uint* major, ref uint minor, ref uint patch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_version")]
        public unsafe partial void GetVersion(ref uint major, uint* minor, uint* patch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_version")]
        public unsafe partial void GetVersion(ref uint major, uint* minor, ref uint patch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_version")]
        public unsafe partial void GetVersion(ref uint major, ref uint minor, uint* patch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_version")]
        public partial void GetVersion(ref uint major, ref uint minor, ref uint patch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_get_commit_revision_and_timestamp")]
        public unsafe partial byte* GetCommitRevisionAndTimestamp();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_get_commit_revision_and_timestamp")]
        public partial string GetCommitRevisionAndTimestampS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_vertex_attribute_init")]
        public unsafe partial void MslVertexAttributeInit(MslVertexAttribute* attr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_vertex_attribute_init")]
        public partial void MslVertexAttributeInit(ref MslVertexAttribute attr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_shader_interface_var_init")]
        public unsafe partial void MslShaderInterfaceVarInit(MslShaderInterfaceVar* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_shader_interface_var_init")]
        public partial void MslShaderInterfaceVarInit(ref MslShaderInterfaceVar var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 357, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_shader_input_init")]
        public unsafe partial void MslShaderInputInit(MslShaderInterfaceVar* input);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 357, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_shader_input_init")]
        public partial void MslShaderInputInit(ref MslShaderInterfaceVar input);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_shader_interface_var_init_2")]
        public unsafe partial void MslShaderInterfaceVarInit2(MslShaderInterfaceVar2* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_shader_interface_var_init_2")]
        public partial void MslShaderInterfaceVarInit2(ref MslShaderInterfaceVar2 var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_resource_binding_init")]
        public unsafe partial void MslResourceBindingInit(MslResourceBinding* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_resource_binding_init")]
        public partial void MslResourceBindingInit(ref MslResourceBinding binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 413, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_resource_binding_init_2")]
        public unsafe partial void MslResourceBindingInit2(MslResourceBinding2* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 413, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_resource_binding_init_2")]
        public partial void MslResourceBindingInit2(ref MslResourceBinding2 binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 425, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_get_aux_buffer_struct_version")]
        public partial uint MslGetAuxBufferStructVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_constexpr_sampler_init")]
        public unsafe partial void MslConstexprSamplerInit(MslConstexprSampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_constexpr_sampler_init")]
        public partial void MslConstexprSamplerInit(ref MslConstexprSampler sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_sampler_ycbcr_conversion_init")]
        public unsafe partial void MslSamplerYcbcrConversionInit(MslSamplerYcbcrConversion* conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_msl_sampler_ycbcr_conversion_init")]
        public partial void MslSamplerYcbcrConversionInit(ref MslSamplerYcbcrConversion conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_hlsl_resource_binding_init")]
        public unsafe partial void HlslResourceBindingInit(HlslResourceBinding* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_hlsl_resource_binding_init")]
        public partial void HlslResourceBindingInit(ref HlslResourceBinding binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_create")]
        public unsafe partial Result ContextCreate(Context** context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_create")]
        public unsafe partial Result ContextCreate(ref Context* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 764, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_destroy")]
        public unsafe partial void ContextDestroy(Context* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 767, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_release_allocations")]
        public unsafe partial void ContextReleaseAllocations(Context* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 770, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_get_last_error_string")]
        public unsafe partial byte* ContextGetLastErrorString(Context* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 770, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_context_get_last_error_string")]
        public unsafe partial string ContextGetLastErrorStringS(Context* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 774, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_set_error_callback")]
        public unsafe partial void ContextSetErrorCallback(Context* context, PfnErrorCallback cb, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 774, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_set_error_callback")]
        public unsafe partial void ContextSetErrorCallback<T0>(Context* context, PfnErrorCallback cb, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_parse_spirv")]
        public unsafe partial Result ContextParseSpirv(Context* context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* spirv, nuint word_count, ParsedIr** parsed_ir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_parse_spirv")]
        public unsafe partial Result ContextParseSpirv(Context* context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* spirv, nuint word_count, ref ParsedIr* parsed_ir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_parse_spirv")]
        public unsafe partial Result ContextParseSpirv(Context* context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint spirv, nuint word_count, ParsedIr** parsed_ir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_parse_spirv")]
        public unsafe partial Result ContextParseSpirv(Context* context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint spirv, nuint word_count, ref ParsedIr* parsed_ir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_create_compiler")]
        public unsafe partial Result ContextCreateCompiler(Context* context, Backend backend, ParsedIr* parsed_ir, CaptureMode mode, Compiler** compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_context_create_compiler")]
        public unsafe partial Result ContextCreateCompiler(Context* context, Backend backend, ParsedIr* parsed_ir, CaptureMode mode, ref Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 789, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_current_id_bound")]
        public unsafe partial uint CompilerGetCurrentIdBound(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 792, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_create_compiler_options")]
        public unsafe partial Result CompilerCreateCompilerOptions(Compiler* compiler, CompilerOptions** options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 792, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_create_compiler_options")]
        public unsafe partial Result CompilerCreateCompilerOptions(Compiler* compiler, ref CompilerOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 795, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_options_set_bool")]
        public unsafe partial Result CompilerOptionsSetBool(CompilerOptions* options, CompilerOption option, byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 797, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_options_set_uint")]
        public unsafe partial Result CompilerOptionsSetUint(CompilerOptions* options, CompilerOption option, uint value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_install_compiler_options")]
        public unsafe partial Result CompilerInstallCompilerOptions(Compiler* compiler, CompilerOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 804, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_compile")]
        public unsafe partial Result CompilerCompile(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 804, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_compile")]
        public unsafe partial Result CompilerCompile(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 807, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_add_header_line")]
        public unsafe partial Result CompilerAddHeaderLine(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* line);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 807, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_add_header_line")]
        public unsafe partial Result CompilerAddHeaderLine(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte line);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 807, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_add_header_line")]
        public unsafe partial Result CompilerAddHeaderLine(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string line);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 808, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_require_extension")]
        public unsafe partial Result CompilerRequireExtension(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* ext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 808, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_require_extension")]
        public unsafe partial Result CompilerRequireExtension(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte ext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 808, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_require_extension")]
        public unsafe partial Result CompilerRequireExtension(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 24 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_num_required_extensions")]
        public unsafe partial nuint CompilerGetNumRequiredExtensions(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_required_extension")]
        public unsafe partial byte* CompilerGetRequiredExtension(Compiler* compiler, nuint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_required_extension")]
        public unsafe partial string CompilerGetRequiredExtensionS(Compiler* compiler, nuint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_flatten_buffer_block")]
        public unsafe partial Result CompilerFlattenBufferBlock(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 813, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_variable_is_depth_or_compare")]
        public unsafe partial byte CompilerVariableIsDepthOrCompare(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 815, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_mask_stage_output_by_location")]
        public unsafe partial Result CompilerMaskStageOutputByLocation(Compiler* compiler, uint location, uint component);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_mask_stage_output_by_builtin")]
        public unsafe partial Result CompilerMaskStageOutputByBuiltin(Compiler* compiler, Silk.NET.SPIRV.BuiltIn builtin);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 823, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_set_root_constants_layout")]
        public unsafe partial Result CompilerHlslSetRootConstantsLayout(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HlslRootConstants* constant_info, nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 823, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_set_root_constants_layout")]
        public unsafe partial Result CompilerHlslSetRootConstantsLayout(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HlslRootConstants constant_info, nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 826, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_add_vertex_attribute_remap")]
        public unsafe partial Result CompilerHlslAddVertexAttributeRemap(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HlslVertexAttributeRemap* remap, nuint remaps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 826, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_add_vertex_attribute_remap")]
        public unsafe partial Result CompilerHlslAddVertexAttributeRemap(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HlslVertexAttributeRemap remap, nuint remaps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_remap_num_workgroups_builtin")]
        public unsafe partial uint CompilerHlslRemapNumWorkgroupsBuiltin(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 831, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_set_resource_binding_flags")]
        public unsafe partial Result CompilerHlslSetResourceBindingFlags(Compiler* compiler, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_add_resource_binding")]
        public unsafe partial Result CompilerHlslAddResourceBinding(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HlslResourceBinding* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_add_resource_binding")]
        public unsafe partial Result CompilerHlslAddResourceBinding(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HlslResourceBinding binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 836, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_hlsl_is_resource_used")]
        public unsafe partial byte CompilerHlslIsResourceUsed(Compiler* compiler, Silk.NET.SPIRV.ExecutionModel model, uint set, uint binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_is_rasterization_disabled")]
        public unsafe partial byte CompilerMslIsRasterizationDisabled(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 848, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_needs_aux_buffer")]
        public unsafe partial byte CompilerMslNeedsAuxBuffer(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 849, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_needs_swizzle_buffer")]
        public unsafe partial byte CompilerMslNeedsSwizzleBuffer(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_needs_buffer_size_buffer")]
        public unsafe partial byte CompilerMslNeedsBufferSizeBuffer(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 852, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_needs_output_buffer")]
        public unsafe partial byte CompilerMslNeedsOutputBuffer(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_needs_patch_output_buffer")]
        public unsafe partial byte CompilerMslNeedsPatchOutputBuffer(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_needs_input_threadgroup_mem")]
        public unsafe partial byte CompilerMslNeedsInputThreadgroupMem(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 855, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_vertex_attribute")]
        public unsafe partial Result CompilerMslAddVertexAttribute(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslVertexAttribute* attrs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 855, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_vertex_attribute")]
        public unsafe partial Result CompilerMslAddVertexAttribute(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslVertexAttribute attrs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 858, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_resource_binding")]
        public unsafe partial Result CompilerMslAddResourceBinding(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslResourceBinding* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 858, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_resource_binding")]
        public unsafe partial Result CompilerMslAddResourceBinding(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslResourceBinding binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 860, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_resource_binding_2")]
        public unsafe partial Result CompilerMslAddResourceBinding2(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslResourceBinding2* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 860, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_resource_binding_2")]
        public unsafe partial Result CompilerMslAddResourceBinding2(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslResourceBinding2 binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 863, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_shader_input")]
        public unsafe partial Result CompilerMslAddShaderInput(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslShaderInterfaceVar* input);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 863, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_shader_input")]
        public unsafe partial Result CompilerMslAddShaderInput(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslShaderInterfaceVar input);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 865, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_shader_input_2")]
        public unsafe partial Result CompilerMslAddShaderInput2(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslShaderInterfaceVar2* input);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 865, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_shader_input_2")]
        public unsafe partial Result CompilerMslAddShaderInput2(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslShaderInterfaceVar2 input);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 868, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_shader_output")]
        public unsafe partial Result CompilerMslAddShaderOutput(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslShaderInterfaceVar* output);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 868, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_shader_output")]
        public unsafe partial Result CompilerMslAddShaderOutput(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslShaderInterfaceVar output);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_shader_output_2")]
        public unsafe partial Result CompilerMslAddShaderOutput2(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslShaderInterfaceVar2* output);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_shader_output_2")]
        public unsafe partial Result CompilerMslAddShaderOutput2(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslShaderInterfaceVar2 output);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 872, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_discrete_descriptor_set")]
        public unsafe partial Result CompilerMslAddDiscreteDescriptorSet(Compiler* compiler, uint desc_set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_set_argument_buffer_device_address_space")]
        public unsafe partial Result CompilerMslSetArgumentBufferDeviceAddressSpace(Compiler* compiler, uint desc_set, byte device_address);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_is_vertex_attribute_used")]
        public unsafe partial byte CompilerMslIsVertexAttributeUsed(Compiler* compiler, uint location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_is_shader_input_used")]
        public unsafe partial byte CompilerMslIsShaderInputUsed(Compiler* compiler, uint location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 878, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_is_shader_output_used")]
        public unsafe partial byte CompilerMslIsShaderOutputUsed(Compiler* compiler, uint location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_is_resource_used")]
        public unsafe partial byte CompilerMslIsResourceUsed(Compiler* compiler, Silk.NET.SPIRV.ExecutionModel model, uint set, uint binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 884, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler")]
        public unsafe partial Result CompilerMslRemapConstexprSampler(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslConstexprSampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 884, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler")]
        public unsafe partial Result CompilerMslRemapConstexprSampler(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslConstexprSampler sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerByBinding(Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslConstexprSampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerByBinding(Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslConstexprSampler sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 886, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_ycbcr")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerYcbcr(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslConstexprSampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslSamplerYcbcrConversion* conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 886, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_ycbcr")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerYcbcr(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslConstexprSampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslSamplerYcbcrConversion conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 886, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_ycbcr")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerYcbcr(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslConstexprSampler sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslSamplerYcbcrConversion* conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 886, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_ycbcr")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerYcbcr(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslConstexprSampler sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslSamplerYcbcrConversion conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 887, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerByBindingYcbcr(Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslConstexprSampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslSamplerYcbcrConversion* conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 887, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerByBindingYcbcr(Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslConstexprSampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslSamplerYcbcrConversion conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 887, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerByBindingYcbcr(Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslConstexprSampler sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslSamplerYcbcrConversion* conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 887, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr")]
        public unsafe partial Result CompilerMslRemapConstexprSamplerByBindingYcbcr(Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslConstexprSampler sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MslSamplerYcbcrConversion conv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 888, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_set_fragment_output_components")]
        public unsafe partial Result CompilerMslSetFragmentOutputComponents(Compiler* compiler, uint location, uint components);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_get_automatic_resource_binding")]
        public unsafe partial uint CompilerMslGetAutomaticResourceBinding(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_get_automatic_resource_binding_secondary")]
        public unsafe partial uint CompilerMslGetAutomaticResourceBindingSecondary(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_dynamic_buffer")]
        public unsafe partial Result CompilerMslAddDynamicBuffer(Compiler* compiler, uint desc_set, uint binding, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 895, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_add_inline_uniform_block")]
        public unsafe partial Result CompilerMslAddInlineUniformBlock(Compiler* compiler, uint desc_set, uint binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 897, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_set_combined_sampler_suffix")]
        public unsafe partial Result CompilerMslSetCombinedSamplerSuffix(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* suffix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 897, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_set_combined_sampler_suffix")]
        public unsafe partial Result CompilerMslSetCombinedSamplerSuffix(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte suffix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 897, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_set_combined_sampler_suffix")]
        public unsafe partial Result CompilerMslSetCombinedSamplerSuffix(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string suffix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 898, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_msl_get_combined_sampler_suffix")]
        public unsafe partial byte* CompilerMslGetCombinedSamplerSuffix(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 898, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_msl_get_combined_sampler_suffix")]
        public unsafe partial string CompilerMslGetCombinedSamplerSuffixS(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 904, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_active_interface_variables")]
        public unsafe partial Result CompilerGetActiveInterfaceVariables(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Set** set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 904, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_active_interface_variables")]
        public unsafe partial Result CompilerGetActiveInterfaceVariables(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Set* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 905, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_enabled_interface_variables")]
        public unsafe partial Result CompilerSetEnabledInterfaceVariables(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Set* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_create_shader_resources")]
        public unsafe partial Result CompilerCreateShaderResources(Compiler* compiler, Resources** resources);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_create_shader_resources")]
        public unsafe partial Result CompilerCreateShaderResources(Compiler* compiler, ref Resources* resources);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 907, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_create_shader_resources_for_active_variables")]
        public unsafe partial Result CompilerCreateShaderResourcesForActiveVariables(Compiler* compiler, Resources** resources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Set* active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 907, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_create_shader_resources_for_active_variables")]
        public unsafe partial Result CompilerCreateShaderResourcesForActiveVariables(Compiler* compiler, ref Resources* resources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Set* active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_resources_get_resource_list_for_type")]
        public unsafe partial Result ResourcesGetResourceListForType(Resources* resources, ResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectedResource** resource_list, nuint* resource_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_resources_get_resource_list_for_type")]
        public unsafe partial Result ResourcesGetResourceListForType(Resources* resources, ResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectedResource** resource_list, ref nuint resource_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_resources_get_resource_list_for_type")]
        public unsafe partial Result ResourcesGetResourceListForType(Resources* resources, ResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectedResource* resource_list, nuint* resource_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_resources_get_resource_list_for_type")]
        public unsafe partial Result ResourcesGetResourceListForType(Resources* resources, ResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectedResource* resource_list, ref nuint resource_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 914, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_resources_get_builtin_resource_list_for_type")]
        public unsafe partial Result ResourcesGetBuiltinResourceListForType(Resources* resources, BuiltinResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectedBuiltinResource** resource_list, nuint* resource_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 914, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_resources_get_builtin_resource_list_for_type")]
        public unsafe partial Result ResourcesGetBuiltinResourceListForType(Resources* resources, BuiltinResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectedBuiltinResource** resource_list, ref nuint resource_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 914, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_resources_get_builtin_resource_list_for_type")]
        public unsafe partial Result ResourcesGetBuiltinResourceListForType(Resources* resources, BuiltinResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectedBuiltinResource* resource_list, nuint* resource_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 914, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_resources_get_builtin_resource_list_for_type")]
        public unsafe partial Result ResourcesGetBuiltinResourceListForType(Resources* resources, BuiltinResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectedBuiltinResource* resource_list, ref nuint resource_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_decoration")]
        public unsafe partial void CompilerSetDecoration(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration, uint argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 925, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_decoration_string")]
        public unsafe partial void CompilerSetDecorationString(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 925, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_decoration_string")]
        public unsafe partial void CompilerSetDecorationString(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 925, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_decoration_string")]
        public unsafe partial void CompilerSetDecorationString(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_name")]
        public unsafe partial void CompilerSetName(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_name")]
        public unsafe partial void CompilerSetName(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_name")]
        public unsafe partial void CompilerSetName(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_member_decoration")]
        public unsafe partial void CompilerSetMemberDecoration(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration, uint argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_member_decoration_string")]
        public unsafe partial void CompilerSetMemberDecorationString(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_member_decoration_string")]
        public unsafe partial void CompilerSetMemberDecorationString(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_member_decoration_string")]
        public unsafe partial void CompilerSetMemberDecorationString(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 933, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_member_name")]
        public unsafe partial void CompilerSetMemberName(Compiler* compiler, uint id, uint member_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 933, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_member_name")]
        public unsafe partial void CompilerSetMemberName(Compiler* compiler, uint id, uint member_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 933, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_member_name")]
        public unsafe partial void CompilerSetMemberName(Compiler* compiler, uint id, uint member_index, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string argument);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 935, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_unset_decoration")]
        public unsafe partial void CompilerUnsetDecoration(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 936, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_unset_member_decoration")]
        public unsafe partial void CompilerUnsetMemberDecoration(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_has_decoration")]
        public unsafe partial byte CompilerHasDecoration(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_has_member_decoration")]
        public unsafe partial byte CompilerHasMemberDecoration(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 942, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_name")]
        public unsafe partial byte* CompilerGetName(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 942, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_name")]
        public unsafe partial string CompilerGetNameS(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 943, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_decoration")]
        public unsafe partial uint CompilerGetDecoration(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 944, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_decoration_string")]
        public unsafe partial byte* CompilerGetDecorationString(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 944, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_decoration_string")]
        public unsafe partial string CompilerGetDecorationStringS(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 946, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_member_decoration")]
        public unsafe partial uint CompilerGetMemberDecoration(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 948, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_member_decoration_string")]
        public unsafe partial byte* CompilerGetMemberDecorationString(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 948, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_member_decoration_string")]
        public unsafe partial string CompilerGetMemberDecorationStringS(Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 950, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_member_name")]
        public unsafe partial byte* CompilerGetMemberName(Compiler* compiler, uint id, uint member_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 950, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_member_name")]
        public unsafe partial string CompilerGetMemberNameS(Compiler* compiler, uint id, uint member_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 956, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_entry_points")]
        public unsafe partial Result CompilerGetEntryPoints(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EntryPoint** entry_points, nuint* num_entry_points);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 956, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_entry_points")]
        public unsafe partial Result CompilerGetEntryPoints(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EntryPoint** entry_points, ref nuint num_entry_points);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 956, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_entry_points")]
        public unsafe partial Result CompilerGetEntryPoints(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EntryPoint* entry_points, nuint* num_entry_points);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 956, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_entry_points")]
        public unsafe partial Result CompilerGetEntryPoints(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EntryPoint* entry_points, ref nuint num_entry_points);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_entry_point")]
        public unsafe partial Result CompilerSetEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_entry_point")]
        public unsafe partial Result CompilerSetEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_entry_point")]
        public unsafe partial Result CompilerSetEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_rename_entry_point")]
        public unsafe partial Result CompilerRenameEntryPoint(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string new_name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_cleansed_entry_point_name")]
        public unsafe partial byte* CompilerGetCleansedEntryPointName(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_cleansed_entry_point_name")]
        public unsafe partial string CompilerGetCleansedEntryPointNameS(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_cleansed_entry_point_name")]
        public unsafe partial byte* CompilerGetCleansedEntryPointName(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_cleansed_entry_point_name")]
        public unsafe partial string CompilerGetCleansedEntryPointNameS(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_cleansed_entry_point_name")]
        public unsafe partial byte* CompilerGetCleansedEntryPointName(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_cleansed_entry_point_name")]
        public unsafe partial string CompilerGetCleansedEntryPointNameS(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Silk.NET.SPIRV.ExecutionModel model);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 965, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_execution_mode")]
        public unsafe partial void CompilerSetExecutionMode(Compiler* compiler, Silk.NET.SPIRV.ExecutionMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_unset_execution_mode")]
        public unsafe partial void CompilerUnsetExecutionMode(Compiler* compiler, Silk.NET.SPIRV.ExecutionMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 967, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_set_execution_mode_with_arguments")]
        public unsafe partial void CompilerSetExecutionModeWithArguments(Compiler* compiler, Silk.NET.SPIRV.ExecutionMode mode, uint arg0, uint arg1, uint arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 969, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_execution_modes")]
        public unsafe partial Result CompilerGetExecutionModes(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.ExecutionMode** modes, nuint* num_modes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 969, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_execution_modes")]
        public unsafe partial Result CompilerGetExecutionModes(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.ExecutionMode** modes, ref nuint num_modes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 969, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_execution_modes")]
        public unsafe partial Result CompilerGetExecutionModes(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.SPIRV.ExecutionMode* modes, nuint* num_modes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 969, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_execution_modes")]
        public unsafe partial Result CompilerGetExecutionModes(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.SPIRV.ExecutionMode* modes, ref nuint num_modes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_execution_mode_argument")]
        public unsafe partial uint CompilerGetExecutionModeArgument(Compiler* compiler, Silk.NET.SPIRV.ExecutionMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 972, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_execution_mode_argument_by_index")]
        public unsafe partial uint CompilerGetExecutionModeArgumentByIndex(Compiler* compiler, Silk.NET.SPIRV.ExecutionMode mode, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 974, Column 35 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_execution_model")]
        public unsafe partial Silk.NET.SPIRV.ExecutionModel CompilerGetExecutionModel(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 975, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_update_active_builtins")]
        public unsafe partial void CompilerUpdateActiveBuiltins(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 976, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_has_active_builtin")]
        public unsafe partial byte CompilerHasActiveBuiltin(Compiler* compiler, Silk.NET.SPIRV.BuiltIn builtin, Silk.NET.SPIRV.StorageClass storage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_type_handle")]
        public unsafe partial CrossType* CompilerGetTypeHandle(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 30 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_base_type_id")]
        public unsafe partial uint TypeGetBaseTypeId([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 31 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_basetype")]
        public unsafe partial Basetype TypeGetBasetype([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_bit_width")]
        public unsafe partial uint TypeGetBitWidth([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 992, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_vector_size")]
        public unsafe partial uint TypeGetVectorSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_columns")]
        public unsafe partial uint TypeGetColumns([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_num_array_dimensions")]
        public unsafe partial uint TypeGetNumArrayDimensions([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_array_dimension_is_literal")]
        public unsafe partial byte TypeArrayDimensionIsLiteral([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint dimension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 23 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_array_dimension")]
        public unsafe partial uint TypeGetArrayDimension([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint dimension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 997, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_num_member_types")]
        public unsafe partial uint TypeGetNumMemberTypes([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 998, Column 30 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_member_type")]
        public unsafe partial uint TypeGetMemberType([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 999, Column 33 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_storage_class")]
        public unsafe partial Silk.NET.SPIRV.StorageClass TypeGetStorageClass([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1002, Column 30 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_image_sampled_type")]
        public unsafe partial uint TypeGetImageSampledType([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 24 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_image_dimension")]
        public unsafe partial Silk.NET.SPIRV.Dim TypeGetImageDimension([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1004, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_image_is_depth")]
        public unsafe partial byte TypeGetImageIsDepth([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_image_arrayed")]
        public unsafe partial byte TypeGetImageArrayed([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1006, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_image_multisampled")]
        public unsafe partial byte TypeGetImageMultisampled([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1007, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_image_is_storage")]
        public unsafe partial byte TypeGetImageIsStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1008, Column 32 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_image_storage_format")]
        public unsafe partial Silk.NET.SPIRV.ImageFormat TypeGetImageStorageFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 36 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_type_get_image_access_qualifier")]
        public unsafe partial Silk.NET.SPIRV.AccessQualifier TypeGetImageAccessQualifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1015, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_struct_size")]
        public unsafe partial Result CompilerGetDeclaredStructSize(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* struct_type, nuint* size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1015, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_struct_size")]
        public unsafe partial Result CompilerGetDeclaredStructSize(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* struct_type, ref nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_struct_size_runtime_array")]
        public unsafe partial Result CompilerGetDeclaredStructSizeRuntimeArray(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* struct_type, nuint array_size, nuint* size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_struct_size_runtime_array")]
        public unsafe partial Result CompilerGetDeclaredStructSizeRuntimeArray(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* struct_type, nuint array_size, ref nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1018, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_struct_member_size")]
        public unsafe partial Result CompilerGetDeclaredStructMemberSize(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, nuint* size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1018, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_struct_member_size")]
        public unsafe partial Result CompilerGetDeclaredStructMemberSize(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, ref nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_type_struct_member_offset")]
        public unsafe partial Result CompilerTypeStructMemberOffset(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, uint* offset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_type_struct_member_offset")]
        public unsafe partial Result CompilerTypeStructMemberOffset(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, ref uint offset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1022, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_type_struct_member_array_stride")]
        public unsafe partial Result CompilerTypeStructMemberArrayStride(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, uint* stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1022, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_type_struct_member_array_stride")]
        public unsafe partial Result CompilerTypeStructMemberArrayStride(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, ref uint stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1024, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_type_struct_member_matrix_stride")]
        public unsafe partial Result CompilerTypeStructMemberMatrixStride(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, uint* stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1024, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_type_struct_member_matrix_stride")]
        public unsafe partial Result CompilerTypeStructMemberMatrixStride(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, ref uint stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1031, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_build_dummy_sampler_for_combined_images")]
        public unsafe partial Result CompilerBuildDummySamplerForCombinedImages(Compiler* compiler, uint* id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1031, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_build_dummy_sampler_for_combined_images")]
        public unsafe partial Result CompilerBuildDummySamplerForCombinedImages(Compiler* compiler, ref uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_build_combined_image_samplers")]
        public unsafe partial Result CompilerBuildCombinedImageSamplers(Compiler* compiler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_combined_image_samplers")]
        public unsafe partial Result CompilerGetCombinedImageSamplers(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinedImageSampler** samplers, nuint* num_samplers);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_combined_image_samplers")]
        public unsafe partial Result CompilerGetCombinedImageSamplers(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinedImageSampler** samplers, ref nuint num_samplers);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_combined_image_samplers")]
        public unsafe partial Result CompilerGetCombinedImageSamplers(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CombinedImageSampler* samplers, nuint* num_samplers);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_combined_image_samplers")]
        public unsafe partial Result CompilerGetCombinedImageSamplers(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CombinedImageSampler* samplers, ref nuint num_samplers);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1041, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_specialization_constants")]
        public unsafe partial Result CompilerGetSpecializationConstants(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationConstant** constants, nuint* num_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1041, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_specialization_constants")]
        public unsafe partial Result CompilerGetSpecializationConstants(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationConstant** constants, ref nuint num_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1041, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_specialization_constants")]
        public unsafe partial Result CompilerGetSpecializationConstants(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationConstant* constants, nuint* num_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1041, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_specialization_constants")]
        public unsafe partial Result CompilerGetSpecializationConstants(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationConstant* constants, ref nuint num_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 31 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_constant_handle")]
        public unsafe partial Constant* CompilerGetConstantHandle(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1047, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
        public unsafe partial uint CompilerGetWorkGroupSizeSpecializationConstants(Compiler* compiler, SpecializationConstant* x, SpecializationConstant* y, SpecializationConstant* z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1047, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
        public unsafe partial uint CompilerGetWorkGroupSizeSpecializationConstants(Compiler* compiler, SpecializationConstant* x, SpecializationConstant* y, ref SpecializationConstant z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1047, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
        public unsafe partial uint CompilerGetWorkGroupSizeSpecializationConstants(Compiler* compiler, SpecializationConstant* x, ref SpecializationConstant y, SpecializationConstant* z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1047, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
        public unsafe partial uint CompilerGetWorkGroupSizeSpecializationConstants(Compiler* compiler, SpecializationConstant* x, ref SpecializationConstant y, ref SpecializationConstant z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1047, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
        public unsafe partial uint CompilerGetWorkGroupSizeSpecializationConstants(Compiler* compiler, ref SpecializationConstant x, SpecializationConstant* y, SpecializationConstant* z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1047, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
        public unsafe partial uint CompilerGetWorkGroupSizeSpecializationConstants(Compiler* compiler, ref SpecializationConstant x, SpecializationConstant* y, ref SpecializationConstant z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1047, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
        public unsafe partial uint CompilerGetWorkGroupSizeSpecializationConstants(Compiler* compiler, ref SpecializationConstant x, ref SpecializationConstant y, SpecializationConstant* z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1047, Column 34 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
        public unsafe partial uint CompilerGetWorkGroupSizeSpecializationConstants(Compiler* compiler, ref SpecializationConstant x, ref SpecializationConstant y, ref SpecializationConstant z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1056, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_active_buffer_ranges")]
        public unsafe partial Result CompilerGetActiveBufferRanges(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferRange** ranges, nuint* num_ranges);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1056, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_active_buffer_ranges")]
        public unsafe partial Result CompilerGetActiveBufferRanges(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferRange** ranges, ref nuint num_ranges);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1056, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_active_buffer_ranges")]
        public unsafe partial Result CompilerGetActiveBufferRanges(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferRange* ranges, nuint* num_ranges);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1056, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_active_buffer_ranges")]
        public unsafe partial Result CompilerGetActiveBufferRanges(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferRange* ranges, ref nuint num_ranges);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1067, Column 23 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_fp16")]
        public unsafe partial float ConstantGetScalarFp16(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 23 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_fp32")]
        public unsafe partial float ConstantGetScalarFp32(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1069, Column 24 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_fp64")]
        public unsafe partial double ConstantGetScalarFp64(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1070, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_u32")]
        public unsafe partial uint ConstantGetScalarU32(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1071, Column 21 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_i32")]
        public unsafe partial int ConstantGetScalarI32(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1072, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_u16")]
        public unsafe partial uint ConstantGetScalarU16(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1073, Column 21 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_i16")]
        public unsafe partial int ConstantGetScalarI16(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1074, Column 26 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_u8")]
        public unsafe partial uint ConstantGetScalarU8(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1075, Column 21 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_i8")]
        public unsafe partial int ConstantGetScalarI8(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_subconstants")]
        public unsafe partial void ConstantGetSubconstants(Constant* constant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** constituents, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_subconstants")]
        public unsafe partial void ConstantGetSubconstants(Constant* constant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** constituents, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_subconstants")]
        public unsafe partial void ConstantGetSubconstants(Constant* constant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* constituents, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_subconstants")]
        public unsafe partial void ConstantGetSubconstants(Constant* constant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint* constituents, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_u64")]
        public unsafe partial ulong ConstantGetScalarU64(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1078, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_scalar_i64")]
        public unsafe partial long ConstantGetScalarI64(Constant* constant, uint column, uint row);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 30 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_get_type")]
        public unsafe partial uint ConstantGetType(Constant* constant);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1084, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_fp16")]
        public unsafe partial void ConstantSetScalarFp16(Constant* constant, uint column, uint row, ushort value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_fp32")]
        public unsafe partial void ConstantSetScalarFp32(Constant* constant, uint column, uint row, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1086, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_fp64")]
        public unsafe partial void ConstantSetScalarFp64(Constant* constant, uint column, uint row, double value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1087, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_u32")]
        public unsafe partial void ConstantSetScalarU32(Constant* constant, uint column, uint row, uint value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1088, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_i32")]
        public unsafe partial void ConstantSetScalarI32(Constant* constant, uint column, uint row, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1089, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_u64")]
        public unsafe partial void ConstantSetScalarU64(Constant* constant, uint column, uint row, ulong value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1090, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_i64")]
        public unsafe partial void ConstantSetScalarI64(Constant* constant, uint column, uint row, long value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1091, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_u16")]
        public unsafe partial void ConstantSetScalarU16(Constant* constant, uint column, uint row, ushort value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_i16")]
        public unsafe partial void ConstantSetScalarI16(Constant* constant, uint column, uint row, short value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1093, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_u8")]
        public unsafe partial void ConstantSetScalarU8(Constant* constant, uint column, uint row, byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1094, Column 22 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_constant_set_scalar_i8")]
        public unsafe partial void ConstantSetScalarI8(Constant* constant, uint column, uint row, byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1100, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_binary_offset_for_decoration")]
        public unsafe partial byte CompilerGetBinaryOffsetForDecoration(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration, uint* word_offset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1100, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_binary_offset_for_decoration")]
        public unsafe partial byte CompilerGetBinaryOffsetForDecoration(Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration, ref uint word_offset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_buffer_is_hlsl_counter_buffer")]
        public unsafe partial byte CompilerBufferIsHlslCounterBuffer(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1106, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_buffer_get_hlsl_counter_buffer")]
        public unsafe partial byte CompilerBufferGetHlslCounterBuffer(Compiler* compiler, uint id, uint* counter_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1106, Column 27 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_buffer_get_hlsl_counter_buffer")]
        public unsafe partial byte CompilerBufferGetHlslCounterBuffer(Compiler* compiler, uint id, ref uint counter_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1109, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_capabilities")]
        public unsafe partial Result CompilerGetDeclaredCapabilities(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.Capability** capabilities, nuint* num_capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1109, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_capabilities")]
        public unsafe partial Result CompilerGetDeclaredCapabilities(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.Capability** capabilities, ref nuint num_capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1109, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_capabilities")]
        public unsafe partial Result CompilerGetDeclaredCapabilities(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.SPIRV.Capability* capabilities, nuint* num_capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1109, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_capabilities")]
        public unsafe partial Result CompilerGetDeclaredCapabilities(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.SPIRV.Capability* capabilities, ref nuint num_capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1112, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_extensions")]
        public unsafe partial Result CompilerGetDeclaredExtensions(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte*** extensions, nuint* num_extensions);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1112, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_extensions")]
        public unsafe partial Result CompilerGetDeclaredExtensions(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte*** extensions, ref nuint num_extensions);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1112, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_extensions")]
        public unsafe partial Result CompilerGetDeclaredExtensions(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte** extensions, nuint* num_extensions);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1112, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_declared_extensions")]
        public unsafe partial Result CompilerGetDeclaredExtensions(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte** extensions, ref nuint num_extensions);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1115, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_remapped_declared_block_name")]
        public unsafe partial byte* CompilerGetRemappedDeclaredBlockName(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1115, Column 29 in spirv_cross_c.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvc_compiler_get_remapped_declared_block_name")]
        public unsafe partial string CompilerGetRemappedDeclaredBlockNameS(Compiler* compiler, uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_buffer_block_decorations")]
        public unsafe partial Result CompilerGetBufferBlockDecorations(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.Decoration** decorations, nuint* num_decorations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_buffer_block_decorations")]
        public unsafe partial Result CompilerGetBufferBlockDecorations(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.Decoration** decorations, ref nuint num_decorations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_buffer_block_decorations")]
        public unsafe partial Result CompilerGetBufferBlockDecorations(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.SPIRV.Decoration* decorations, nuint* num_decorations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 29 in spirv_cross_c.h")]
        [NativeApi(EntryPoint = "spvc_compiler_get_buffer_block_decorations")]
        public unsafe partial Result CompilerGetBufferBlockDecorations(Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.SPIRV.Decoration* decorations, ref nuint num_decorations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 804, Column 29 in spirv_cross_c.h")]
        public unsafe Result CompilerCompile(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] sourceSa)
        {
            // StringArrayOverloader
            var source = (byte**) SilkMarshal.StringArrayToPtr(sourceSa);
            var ret = CompilerCompile(compiler, source);
            SilkMarshal.CopyPtrToStringArray((nint) source, sourceSa);
            SilkMarshal.Free((nint) source);
            return ret;
        }


        public Cross(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

