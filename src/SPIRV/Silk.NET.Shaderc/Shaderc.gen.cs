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

namespace Silk.NET.Shaderc
{
    public unsafe partial class Shaderc : NativeAPI
    {

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 268, Column 35 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compiler_initialize")]
        public unsafe partial Compiler* CompilerInitialize();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 273, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compiler_release")]
        public unsafe partial void CompilerRelease(Compiler* arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 5 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_initialize")]
        public unsafe partial CompileOptions* CompileOptionsInitialize();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 42 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_clone")]
        public unsafe partial CompileOptions* CompileOptionsClone(CompileOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 296, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_release")]
        public unsafe partial void CompileOptionsRelease(CompileOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_add_macro_definition")]
        public unsafe partial void CompileOptionsAddMacroDefinition(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, nuint value_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_source_language")]
        public unsafe partial void CompileOptionsSetSourceLanguage(CompileOptions* options, SourceLanguage lang);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_generate_debug_info")]
        public unsafe partial void CompileOptionsSetGenerateDebugInfo(CompileOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 324, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_optimization_level")]
        public unsafe partial void CompileOptionsSetOptimizationLevel(CompileOptions* options, OptimizationLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_forced_version_profile")]
        public unsafe partial void CompileOptionsSetForcedVersionProfile(CompileOptions* options, int version, Profile profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_include_callbacks")]
        public unsafe partial void CompileOptionsSetIncludeCallbacks(CompileOptions* options, PfnIncludeResolveFn resolver, PfnIncludeResultReleaseFn result_releaser, void* user_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_include_callbacks")]
        public unsafe partial void CompileOptionsSetIncludeCallbacks<T0>(CompileOptions* options, PfnIncludeResolveFn resolver, PfnIncludeResultReleaseFn result_releaser, ref T0 user_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 392, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_suppress_warnings")]
        public unsafe partial void CompileOptionsSetSuppressWarnings(CompileOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 400, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_target_env")]
        public unsafe partial void CompileOptionsSetTargetEnv(CompileOptions* options, TargetEnv target, uint version);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 410, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_target_spirv")]
        public unsafe partial void CompileOptionsSetTargetSpirv(CompileOptions* options, SpirvVersion version);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 417, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_warnings_as_errors")]
        public unsafe partial void CompileOptionsSetWarningsAsErrors(CompileOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 421, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_limit")]
        public unsafe partial void CompileOptionsSetLimit(CompileOptions* options, Limit limit, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_auto_bind_uniforms")]
        public unsafe partial void CompileOptionsSetAutoBindUniforms(CompileOptions* options, Silk.NET.Core.Bool32 auto_bind);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 431, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_auto_combined_image_sampler")]
        public unsafe partial void CompileOptionsSetAutoCombinedImageSampler(CompileOptions* options, Silk.NET.Core.Bool32 upgrade);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_io_mapping")]
        public unsafe partial void CompileOptionsSetHlslIoMapping(CompileOptions* options, Silk.NET.Core.Bool32 hlsl_iomap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 442, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_offsets")]
        public unsafe partial void CompileOptionsSetHlslOffsets(CompileOptions* options, Silk.NET.Core.Bool32 hlsl_offsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 449, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_binding_base")]
        public unsafe partial void CompileOptionsSetBindingBase(CompileOptions* options, UniformKind kind, uint @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 457, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_binding_base_for_stage")]
        public unsafe partial void CompileOptionsSetBindingBaseForStage(CompileOptions* options, ShaderKind shader_kind, UniformKind kind, uint @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_preserve_bindings")]
        public unsafe partial void CompileOptionsSetPreserveBindings(CompileOptions* options, Silk.NET.Core.Bool32 preserve_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_auto_map_locations")]
        public unsafe partial void CompileOptionsSetAutoMapLocations(CompileOptions* options, Silk.NET.Core.Bool32 auto_map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBindingForStage(CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
        public unsafe partial void CompileOptionsSetHlslRegisterSetAndBinding(CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_functionality1")]
        public unsafe partial void CompileOptionsSetHlslFunctionality1(CompileOptions* options, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_hlsl_16bit_types")]
        public unsafe partial void CompileOptionsSetHlsl16bitTypes(CompileOptions* options, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_vulkan_rules_relaxed")]
        public unsafe partial void CompileOptionsSetVulkanRulesRelaxed(CompileOptions* options, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_invert_y")]
        public unsafe partial void CompileOptionsSetInvertY(CompileOptions* options, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_options_set_nan_clamp")]
        public unsafe partial void CompileOptionsSetNanClamp(CompileOptions* options, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv")]
        public unsafe partial CompilationResult* CompileIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_spv_assembly")]
        public unsafe partial CompilationResult* CompileIntoSpvAssembly(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_compile_into_preprocessed_text")]
        public unsafe partial CompilationResult* CompileIntoPreprocessedText(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_assemble_into_spv")]
        public unsafe partial CompilationResult* AssembleIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_assembly, nuint source_assembly_size, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_assemble_into_spv")]
        public unsafe partial CompilationResult* AssembleIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source_assembly, nuint source_assembly_size, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 45 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_assemble_into_spv")]
        public unsafe partial CompilationResult* AssembleIntoSpv(Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_assembly, nuint source_assembly_size, CompileOptions* additional_options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_result_release")]
        public unsafe partial void ResultRelease(CompilationResult* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 578, Column 23 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_result_get_length")]
        public unsafe partial nuint ResultGetLength(CompilationResult* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 23 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_result_get_num_warnings")]
        public unsafe partial nuint ResultGetNumWarnings(CompilationResult* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 585, Column 23 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_result_get_num_errors")]
        public unsafe partial nuint ResultGetNumErrors(CompilationResult* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 43 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_result_get_compilation_status")]
        public unsafe partial CompilationStatus ResultGetCompilationStatus(CompilationResult* arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 598, Column 28 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_result_get_bytes")]
        public unsafe partial byte* ResultGetBytes(CompilationResult* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 598, Column 28 in shaderc.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "shaderc_result_get_bytes")]
        public unsafe partial string ResultGetBytesS(CompilationResult* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 602, Column 28 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_result_get_error_message")]
        public unsafe partial byte* ResultGetErrorMessage(CompilationResult* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 602, Column 28 in shaderc.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "shaderc_result_get_error_message")]
        public unsafe partial string ResultGetErrorMessageS(CompilationResult* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_get_spv_version")]
        public unsafe partial void GetSpvVersion(uint* version, uint* revision);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_get_spv_version")]
        public unsafe partial void GetSpvVersion(uint* version, ref uint revision);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_get_spv_version")]
        public unsafe partial void GetSpvVersion(ref uint version, uint* revision);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_get_spv_version")]
        public partial void GetSpvVersion(ref uint version, ref uint revision);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int* version, Profile* profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int* version, ref Profile profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, ref int version, Profile* profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, ref int version, ref Profile profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte str, int* version, Profile* profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte str, int* version, ref Profile profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte str, ref int version, Profile* profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte str, ref int version, ref Profile profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int* version, Profile* profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int* version, ref Profile profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public unsafe partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, ref int version, Profile* profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        [NativeApi(EntryPoint = "shaderc_parse_version_profile")]
        public partial Silk.NET.Core.Bool32 ParseVersionProfile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, ref int version, ref Profile profile);


        public Shaderc(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

