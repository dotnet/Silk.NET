// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.Git;
using Octokit;
using Octokit.Internal;
using static Nuke.Common.IO.CompressionTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.HttpTasks;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.GitHub.GitHubTasks;

partial class Build {
    const string ShadercBuildScript = @"
const std = @import(""std"");
const fs = std.fs;

const spirv_tools_root = ""third_party/spirv-tools/"";
const root_glslang_path = ""third_party/glslang/"";

const grammar_processing_script = spirv_tools_root ++ ""utils/generate_grammar_tables.py"";

const spirv_headers_include_dir = ""third_party/spirv-headers/include/"";
const debuginfo_grammar_json_file = spirv_headers_include_dir ++ ""spirv/unified1/extinst.debuginfo.grammar.json"";
const glsl_grammar_file = spirv_headers_include_dir ++ ""spirv/unified1/extinst.glsl.std.450.grammar.json"";
const opencl_grammar_file = spirv_headers_include_dir ++ ""spirv/unified1/extinst.opencl.std.100.grammar.json"";
const cldebuginfo100_grammar_json_file = spirv_headers_include_dir ++ ""spirv/unified1/extinst.opencl.debuginfo.100.grammar.json"";
const vkdebuginfo100_grammar_json_file = spirv_headers_include_dir ++ ""spirv/unified1/extinst.nonsemantic.shader.debuginfo.100.grammar.json"";

var flags = &.{ ""-std=c++17"", ""-fPIC"" };

fn spvtoolsExtinstLangHeaders(b: *std.Build, comptime name: []const u8, comptime grammar_file: []const u8) *std.Build.Step.Run {
    return b.addSystemCommand(&.{
        ""python3"",
        spirv_tools_root ++ ""utils/generate_language_headers.py"",
        ""--extinst-grammar="" ++ grammar_file,
        ""--extinst-output-path="" ++ spirv_tools_root ++ ""source/"" ++ name ++ "".h"",
    });
}

fn spvtoolsVendorTables(
    b: *std.Build,
    comptime vendor_table: []const u8,
    comptime operand_kind_prefix: []const u8,
) *std.Build.Step.Run {
    return b.addSystemCommand(&.{
        ""python3"",
        grammar_processing_script,
        ""--extinst-vendor-grammar="" ++ spirv_headers_include_dir ++ ""spirv/unified1/extinst."" ++ vendor_table ++ "".grammar.json"",
        ""--vendor-insts-output="" ++ spirv_tools_root ++ ""source/"" ++ vendor_table ++ "".insts.inc"",
        ""--vendor-operand-kind-prefix="" ++ operand_kind_prefix,
    });
}

fn spvTools(b: *std.Build, target: std.Build.ResolvedTarget, optimize: std.builtin.OptimizeMode) *std.Build.Step.Compile {
    const generate_grammar_files_step = b.addSystemCommand(&.{
        ""python3"",
        grammar_processing_script,
        ""--spirv-core-grammar="" ++ spirv_headers_include_dir ++ ""spirv/unified1/spirv.core.grammar.json"",
        ""--extinst-debuginfo-grammar="" ++ debuginfo_grammar_json_file,
        ""--extinst-cldebuginfo100-grammar="" ++ cldebuginfo100_grammar_json_file,
        ""--extension-enum-output="" ++ spirv_tools_root ++ ""source/extension_enum.inc"",
        ""--enum-string-mapping-output="" ++ spirv_tools_root ++ ""source/enum_string_mapping.inc"",
        ""--output-language=c++"",
    });

    const generate_spirv_core_tables = b.addSystemCommand(&.{
        ""python3"",
        grammar_processing_script,
        ""--spirv-core-grammar="" ++ spirv_headers_include_dir ++ ""spirv/unified1/spirv.core.grammar.json"",
        ""--extinst-debuginfo-grammar="" ++ debuginfo_grammar_json_file,
        ""--extinst-cldebuginfo100-grammar="" ++ cldebuginfo100_grammar_json_file,
        ""--core-insts-output="" ++ spirv_tools_root ++ ""source/core.insts-unified1.inc"",
        ""--operand-kinds-output="" ++ spirv_tools_root ++ ""source/operand.kinds-unified1.inc"",
        ""--output-language=c++"",
    });

    const generate_glsl_tables = b.addSystemCommand(&.{
        ""python3"",
        grammar_processing_script,
        ""--extinst-glsl-grammar="" ++ glsl_grammar_file,
        ""--glsl-insts-output="" ++ spirv_tools_root ++ ""source/glsl.std.450.insts.inc"",
        ""--output-language=c++"",
    });

    const generate_opencl_tables = b.addSystemCommand(&.{
        ""python3"",
        grammar_processing_script,
        ""--extinst-opencl-grammar="" ++ opencl_grammar_file,
        ""--opencl-insts-output="" ++ spirv_tools_root ++ ""source/opencl.std.insts.inc"",
    });

    const process_spirv_xml = b.addSystemCommand(&.{
        ""python3"",
        spirv_tools_root ++ ""utils/generate_registry_tables.py"",
        ""--xml="" ++ spirv_headers_include_dir ++ ""spirv/spir-v.xml"",
        ""--generator-output="" ++ spirv_tools_root ++ ""source/generators.inc"",
    });

    const generate_spirv_tools_build_version = b.addSystemCommand(&.{
        ""python3"",
        spirv_tools_root ++ ""utils/update_build_version.py"",
        spirv_tools_root ++ ""CHANGES"",
        spirv_tools_root ++ ""source/build-version.inc"",
    });

    const debug_info_header = spvtoolsExtinstLangHeaders(b, ""DebugInfo"", debuginfo_grammar_json_file);
    const cl_debug_info_header_100 = spvtoolsExtinstLangHeaders(b, ""OpenCLDebugInfo100"", cldebuginfo100_grammar_json_file);
    const non_semantic_shader_debug_info_100 = spvtoolsExtinstLangHeaders(b, ""NonSemanticShaderDebugInfo100"", vkdebuginfo100_grammar_json_file);

    const spirv_tools: *std.Build.Step.Compile = b.addStaticLibrary(.{
        .name = ""spirv_tools"",
        .target = target,
        .optimize = optimize,
    });
    spirv_tools.linkLibC();
    spirv_tools.linkLibCpp();

    spirv_tools.step.dependOn(&generate_glsl_tables.step);
    spirv_tools.step.dependOn(&generate_opencl_tables.step);
    spirv_tools.step.dependOn(&generate_spirv_core_tables.step);
    spirv_tools.step.dependOn(&generate_grammar_files_step.step);

    spirv_tools.step.dependOn(&process_spirv_xml.step);
    spirv_tools.step.dependOn(&generate_spirv_tools_build_version.step);

    //All the vendor tables
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""spv-amd-shader-explicit-vertex-parameter"", """").step);
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""spv-amd-shader-trinary-minmax"", """").step);
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""spv-amd-gcn-shader"", """").step);
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""spv-amd-shader-ballot"", """").step);
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""debuginfo"", """").step);
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""opencl.debuginfo.100"", ""CLDEBUG100_"").step);
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""nonsemantic.shader.debuginfo.100"", ""SHDEBUG100_"").step);
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""nonsemantic.clspvreflection"", """").step);
    spirv_tools.step.dependOn(&spvtoolsVendorTables(b, ""nonsemantic.vkspreflection"", """").step);

    //them headers
    spirv_tools.step.dependOn(&debug_info_header.step);
    spirv_tools.step.dependOn(&cl_debug_info_header_100.step);
    spirv_tools.step.dependOn(&non_semantic_shader_debug_info_100.step);

    spirv_tools.addIncludePath(b.path(spirv_tools_root ++ ""include""));
    spirv_tools.addIncludePath(b.path(spirv_tools_root ++ ""source""));
    spirv_tools.addIncludePath(b.path(spirv_tools_root));

    spirv_tools.addIncludePath(b.path(""third_party/spirv-headers/include/""));

    spirv_tools.addCSourceFiles(.{
        .files = &.{
            spirv_tools_root ++ ""source/util/bit_vector.cpp"",
            spirv_tools_root ++ ""source/util/parse_number.cpp"",
            spirv_tools_root ++ ""source/util/string_utils.cpp"",
            spirv_tools_root ++ ""source/assembly_grammar.cpp"",
            spirv_tools_root ++ ""source/binary.cpp"",
            spirv_tools_root ++ ""source/diagnostic.cpp"",
            spirv_tools_root ++ ""source/disassemble.cpp"",
            spirv_tools_root ++ ""source/enum_string_mapping.cpp"",
            spirv_tools_root ++ ""source/ext_inst.cpp"",
            spirv_tools_root ++ ""source/extensions.cpp"",
            spirv_tools_root ++ ""source/libspirv.cpp"",
            spirv_tools_root ++ ""source/name_mapper.cpp"",
            spirv_tools_root ++ ""source/opcode.cpp"",
            spirv_tools_root ++ ""source/operand.cpp"",
            spirv_tools_root ++ ""source/parsed_operand.cpp"",
            spirv_tools_root ++ ""source/print.cpp"",
            spirv_tools_root ++ ""source/software_version.cpp"",
            spirv_tools_root ++ ""source/spirv_endian.cpp"",
            spirv_tools_root ++ ""source/spirv_fuzzer_options.cpp"",
            spirv_tools_root ++ ""source/spirv_optimizer_options.cpp"",
            spirv_tools_root ++ ""source/spirv_reducer_options.cpp"",
            spirv_tools_root ++ ""source/spirv_target_env.cpp"",
            spirv_tools_root ++ ""source/spirv_validator_options.cpp"",
            spirv_tools_root ++ ""source/table.cpp"",
            spirv_tools_root ++ ""source/text.cpp"",
            spirv_tools_root ++ ""source/text_handler.cpp"",
            spirv_tools_root ++ ""source/val/validate.cpp"",
            spirv_tools_root ++ ""source/val/validate_adjacency.cpp"",
            spirv_tools_root ++ ""source/val/validate_annotation.cpp"",
            spirv_tools_root ++ ""source/val/validate_arithmetics.cpp"",
            spirv_tools_root ++ ""source/val/validate_atomics.cpp"",
            spirv_tools_root ++ ""source/val/validate_barriers.cpp"",
            spirv_tools_root ++ ""source/val/validate_bitwise.cpp"",
            spirv_tools_root ++ ""source/val/validate_builtins.cpp"",
            spirv_tools_root ++ ""source/val/validate_capability.cpp"",
            spirv_tools_root ++ ""source/val/validate_cfg.cpp"",
            spirv_tools_root ++ ""source/val/validate_composites.cpp"",
            spirv_tools_root ++ ""source/val/validate_constants.cpp"",
            spirv_tools_root ++ ""source/val/validate_conversion.cpp"",
            spirv_tools_root ++ ""source/val/validate_debug.cpp"",
            spirv_tools_root ++ ""source/val/validate_decorations.cpp"",
            spirv_tools_root ++ ""source/val/validate_derivatives.cpp"",
            spirv_tools_root ++ ""source/val/validate_extensions.cpp"",
            spirv_tools_root ++ ""source/val/validate_execution_limitations.cpp"",
            spirv_tools_root ++ ""source/val/validate_function.cpp"",
            spirv_tools_root ++ ""source/val/validate_id.cpp"",
            spirv_tools_root ++ ""source/val/validate_image.cpp"",
            spirv_tools_root ++ ""source/val/validate_interfaces.cpp"",
            spirv_tools_root ++ ""source/val/validate_instruction.cpp"",
            spirv_tools_root ++ ""source/val/validate_layout.cpp"",
            spirv_tools_root ++ ""source/val/validate_literals.cpp"",
            spirv_tools_root ++ ""source/val/validate_logicals.cpp"",
            spirv_tools_root ++ ""source/val/validate_memory.cpp"",
            spirv_tools_root ++ ""source/val/validate_memory_semantics.cpp"",
            spirv_tools_root ++ ""source/val/validate_mesh_shading.cpp"",
            spirv_tools_root ++ ""source/val/validate_misc.cpp"",
            spirv_tools_root ++ ""source/val/validate_mode_setting.cpp"",
            spirv_tools_root ++ ""source/val/validate_non_uniform.cpp"",
            spirv_tools_root ++ ""source/val/validate_primitives.cpp"",
            spirv_tools_root ++ ""source/val/validate_ray_query.cpp"",
            spirv_tools_root ++ ""source/val/validate_ray_tracing.cpp"",
            spirv_tools_root ++ ""source/val/validate_ray_tracing_reorder.cpp"",
            spirv_tools_root ++ ""source/val/validate_scopes.cpp"",
            spirv_tools_root ++ ""source/val/validate_small_type_uses.cpp"",
            spirv_tools_root ++ ""source/val/validate_type.cpp"",
            spirv_tools_root ++ ""source/val/basic_block.cpp"",
            spirv_tools_root ++ ""source/val/construct.cpp"",
            spirv_tools_root ++ ""source/val/function.cpp"",
            spirv_tools_root ++ ""source/val/instruction.cpp"",
            spirv_tools_root ++ ""source/val/validation_state.cpp"",
            //opt folder
            spirv_tools_root ++ ""source/opt/fix_func_call_arguments.cpp"",
            spirv_tools_root ++ ""source/opt/aggressive_dead_code_elim_pass.cpp"",
            spirv_tools_root ++ ""source/opt/amd_ext_to_khr.cpp"",
            spirv_tools_root ++ ""source/opt/analyze_live_input_pass.cpp"",
            spirv_tools_root ++ ""source/opt/basic_block.cpp"",
            spirv_tools_root ++ ""source/opt/block_merge_pass.cpp"",
            spirv_tools_root ++ ""source/opt/block_merge_util.cpp"",
            spirv_tools_root ++ ""source/opt/build_module.cpp"",
            spirv_tools_root ++ ""source/opt/ccp_pass.cpp"",
            spirv_tools_root ++ ""source/opt/cfg_cleanup_pass.cpp"",
            spirv_tools_root ++ ""source/opt/cfg.cpp"",
            spirv_tools_root ++ ""source/opt/code_sink.cpp"",
            spirv_tools_root ++ ""source/opt/combine_access_chains.cpp"",
            spirv_tools_root ++ ""source/opt/compact_ids_pass.cpp"",
            spirv_tools_root ++ ""source/opt/composite.cpp"",
            spirv_tools_root ++ ""source/opt/const_folding_rules.cpp"",
            spirv_tools_root ++ ""source/opt/constants.cpp"",
            spirv_tools_root ++ ""source/opt/control_dependence.cpp"",
            spirv_tools_root ++ ""source/opt/convert_to_sampled_image_pass.cpp"",
            spirv_tools_root ++ ""source/opt/convert_to_half_pass.cpp"",
            spirv_tools_root ++ ""source/opt/copy_prop_arrays.cpp"",
            spirv_tools_root ++ ""source/opt/dataflow.cpp"",
            spirv_tools_root ++ ""source/opt/dead_branch_elim_pass.cpp"",
            spirv_tools_root ++ ""source/opt/dead_insert_elim_pass.cpp"",
            spirv_tools_root ++ ""source/opt/dead_variable_elimination.cpp"",
            spirv_tools_root ++ ""source/opt/decoration_manager.cpp"",
            spirv_tools_root ++ ""source/opt/debug_info_manager.cpp"",
            spirv_tools_root ++ ""source/opt/def_use_manager.cpp"",
            spirv_tools_root ++ ""source/opt/desc_sroa.cpp"",
            spirv_tools_root ++ ""source/opt/desc_sroa_util.cpp"",
            spirv_tools_root ++ ""source/opt/dominator_analysis.cpp"",
            spirv_tools_root ++ ""source/opt/dominator_tree.cpp"",
            spirv_tools_root ++ ""source/opt/eliminate_dead_constant_pass.cpp"",
            spirv_tools_root ++ ""source/opt/eliminate_dead_functions_pass.cpp"",
            spirv_tools_root ++ ""source/opt/eliminate_dead_functions_util.cpp"",
            spirv_tools_root ++ ""source/opt/eliminate_dead_io_components_pass.cpp"",
            spirv_tools_root ++ ""source/opt/eliminate_dead_members_pass.cpp"",
            spirv_tools_root ++ ""source/opt/eliminate_dead_output_stores_pass.cpp"",
            spirv_tools_root ++ ""source/opt/feature_manager.cpp"",
            spirv_tools_root ++ ""source/opt/fix_storage_class.cpp"",
            spirv_tools_root ++ ""source/opt/flatten_decoration_pass.cpp"",
            spirv_tools_root ++ ""source/opt/fold.cpp"",
            spirv_tools_root ++ ""source/opt/folding_rules.cpp"",
            spirv_tools_root ++ ""source/opt/fold_spec_constant_op_and_composite_pass.cpp"",
            spirv_tools_root ++ ""source/opt/freeze_spec_constant_value_pass.cpp"",
            spirv_tools_root ++ ""source/opt/function.cpp"",
            spirv_tools_root ++ ""source/opt/graphics_robust_access_pass.cpp"",
            spirv_tools_root ++ ""source/opt/if_conversion.cpp"",
            spirv_tools_root ++ ""source/opt/inline_exhaustive_pass.cpp"",
            spirv_tools_root ++ ""source/opt/inline_opaque_pass.cpp"",
            spirv_tools_root ++ ""source/opt/inline_pass.cpp"",
            spirv_tools_root ++ ""source/opt/inst_bindless_check_pass.cpp"",
            spirv_tools_root ++ ""source/opt/inst_buff_addr_check_pass.cpp"",
            spirv_tools_root ++ ""source/opt/inst_debug_printf_pass.cpp"",
            spirv_tools_root ++ ""source/opt/instruction.cpp"",
            spirv_tools_root ++ ""source/opt/instruction_list.cpp"",
            spirv_tools_root ++ ""source/opt/instrument_pass.cpp"",
            spirv_tools_root ++ ""source/opt/interface_var_sroa.cpp"",
            spirv_tools_root ++ ""source/opt/interp_fixup_pass.cpp"",
            spirv_tools_root ++ ""source/opt/ir_context.cpp"",
            spirv_tools_root ++ ""source/opt/ir_loader.cpp"",
            spirv_tools_root ++ ""source/opt/licm_pass.cpp"",
            spirv_tools_root ++ ""source/opt/liveness.cpp"",
            spirv_tools_root ++ ""source/opt/modify_maximal_reconvergence.cpp"",
            spirv_tools_root ++ ""source/opt/local_access_chain_convert_pass.cpp"",
            spirv_tools_root ++ ""source/opt/local_redundancy_elimination.cpp"",
            spirv_tools_root ++ ""source/opt/local_single_block_elim_pass.cpp"",
            spirv_tools_root ++ ""source/opt/local_single_store_elim_pass.cpp"",
            spirv_tools_root ++ ""source/opt/loop_dependence.cpp"",
            spirv_tools_root ++ ""source/opt/loop_dependence_helpers.cpp"",
            spirv_tools_root ++ ""source/opt/loop_descriptor.cpp"",
            spirv_tools_root ++ ""source/opt/loop_fission.cpp"",
            spirv_tools_root ++ ""source/opt/loop_fusion.cpp"",
            spirv_tools_root ++ ""source/opt/loop_fusion_pass.cpp"",
            spirv_tools_root ++ ""source/opt/loop_peeling.cpp"",
            spirv_tools_root ++ ""source/opt/loop_utils.cpp"",
            spirv_tools_root ++ ""source/opt/loop_unroller.cpp"",
            spirv_tools_root ++ ""source/opt/loop_unswitch_pass.cpp"",
            spirv_tools_root ++ ""source/opt/mem_pass.cpp"",
            spirv_tools_root ++ ""source/opt/merge_return_pass.cpp"",
            spirv_tools_root ++ ""source/opt/module.cpp"",
            spirv_tools_root ++ ""source/opt/optimizer.cpp"",
            spirv_tools_root ++ ""source/opt/pass.cpp"",
            spirv_tools_root ++ ""source/opt/pass_manager.cpp"",
            spirv_tools_root ++ ""source/opt/private_to_local_pass.cpp"",
            spirv_tools_root ++ ""source/opt/propagator.cpp"",
            spirv_tools_root ++ ""source/opt/reduce_load_size.cpp"",
            spirv_tools_root ++ ""source/opt/redundancy_elimination.cpp"",
            spirv_tools_root ++ ""source/opt/register_pressure.cpp"",
            spirv_tools_root ++ ""source/opt/relax_float_ops_pass.cpp"",
            spirv_tools_root ++ ""source/opt/remove_dontinline_pass.cpp"",
            spirv_tools_root ++ ""source/opt/remove_duplicates_pass.cpp"",
            spirv_tools_root ++ ""source/opt/remove_unused_interface_variables_pass.cpp"",
            spirv_tools_root ++ ""source/opt/replace_desc_array_access_using_var_index.cpp"",
            spirv_tools_root ++ ""source/opt/replace_invalid_opc.cpp"",
            spirv_tools_root ++ ""source/opt/scalar_analysis.cpp"",
            spirv_tools_root ++ ""source/opt/scalar_analysis_simplification.cpp"",
            spirv_tools_root ++ ""source/opt/scalar_replacement_pass.cpp"",
            spirv_tools_root ++ ""source/opt/set_spec_constant_default_value_pass.cpp"",
            spirv_tools_root ++ ""source/opt/simplification_pass.cpp"",
            spirv_tools_root ++ ""source/opt/spread_volatile_semantics.cpp"",
            spirv_tools_root ++ ""source/opt/ssa_rewrite_pass.cpp"",
            spirv_tools_root ++ ""source/opt/strength_reduction_pass.cpp"",
            spirv_tools_root ++ ""source/opt/strip_debug_info_pass.cpp"",
            spirv_tools_root ++ ""source/opt/strip_nonsemantic_info_pass.cpp"",
            spirv_tools_root ++ ""source/opt/struct_cfg_analysis.cpp"",
            spirv_tools_root ++ ""source/opt/type_manager.cpp"",
            spirv_tools_root ++ ""source/opt/types.cpp"",
            spirv_tools_root ++ ""source/opt/unify_const_pass.cpp"",
            spirv_tools_root ++ ""source/opt/upgrade_memory_model.cpp"",
            spirv_tools_root ++ ""source/opt/value_number_table.cpp"",
            spirv_tools_root ++ ""source/opt/vector_dce.cpp"",
            spirv_tools_root ++ ""source/opt/workaround1209.cpp"",
            spirv_tools_root ++ ""source/opt/wrap_opkill.cpp"",
            spirv_tools_root ++ ""source/opt/trim_capabilities_pass.cpp"",
            spirv_tools_root ++ ""source/opt/switch_descriptorset_pass.cpp"",
            spirv_tools_root ++ ""source/opt/invocation_interlock_placement_pass.cpp"",
            //reduce
            spirv_tools_root ++ ""source/reduce/change_operand_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/change_operand_to_undef_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/conditional_branch_to_simple_conditional_branch_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/conditional_branch_to_simple_conditional_branch_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/merge_blocks_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/merge_blocks_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/operand_to_const_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/operand_to_undef_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/operand_to_dominating_id_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/reducer.cpp"",
            spirv_tools_root ++ ""source/reduce/reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/reduction_pass.cpp"",
            spirv_tools_root ++ ""source/reduce/reduction_util.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_block_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_block_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_function_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_function_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_instruction_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_selection_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_selection_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_struct_member_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_unused_instruction_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/remove_unused_struct_member_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/simple_conditional_branch_to_branch_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/simple_conditional_branch_to_branch_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/structured_construct_to_block_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/structured_construct_to_block_reduction_opportunity_finder.cpp"",
            spirv_tools_root ++ ""source/reduce/structured_loop_to_selection_reduction_opportunity.cpp"",
            spirv_tools_root ++ ""source/reduce/structured_loop_to_selection_reduction_opportunity_finder.cpp"",
            //link
            spirv_tools_root ++ ""source/link/linker.cpp"",
            //lint
            spirv_tools_root ++ ""source/lint/linter.cpp"",
            spirv_tools_root ++ ""source/lint/linter.cpp"",
            spirv_tools_root ++ ""source/lint/lint_divergent_derivatives.cpp"",
            spirv_tools_root ++ ""source/lint/divergence_analysis.cpp"",
            //diff
            spirv_tools_root ++ ""source/diff/diff.cpp"",
        },
        .flags = flags,
    });

    return spirv_tools;
}

fn glslangLib(b: *std.Build, target: std.Build.ResolvedTarget, optimize: std.builtin.OptimizeMode) *std.Build.Step.Compile {
    const glslang: *std.Build.Step.Compile = b.addStaticLibrary(.{
        .name = ""glslang"",
        .target = target,
        .optimize = optimize,
    });
    glslang.linkLibC();
    glslang.linkLibCpp();

    glslang.addIncludePath(b.path(root_glslang_path ++ ""Include""));
    glslang.addIncludePath(b.path(root_glslang_path));

    glslang.defineCMacro(""ENABLE_HLSL"", ""1"");

    glslang.addCSourceFiles(.{
        .files = &.{
            root_glslang_path ++ ""glslang/MachineIndependent/glslang_tab.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/attribute.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/Constant.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/iomapper.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/InfoSink.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/Initialize.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/IntermTraverse.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/Intermediate.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/ParseContextBase.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/ParseHelper.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/PoolAlloc.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/RemoveTree.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/Scan.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/ShaderLang.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/SpirvIntrinsics.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/SymbolTable.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/Versions.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/intermOut.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/limits.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/linkValidate.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/parseConst.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/reflection.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/preprocessor/Pp.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/preprocessor/PpAtom.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/preprocessor/PpContext.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/preprocessor/PpScanner.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/preprocessor/PpTokens.cpp"",
            root_glslang_path ++ ""glslang/MachineIndependent/propagateNoContraction.cpp"",
            root_glslang_path ++ ""glslang/HLSL/hlslAttributes.cpp"",
            root_glslang_path ++ ""glslang/HLSL/hlslParseHelper.cpp"",
            root_glslang_path ++ ""glslang/HLSL/hlslScanContext.cpp"",
            root_glslang_path ++ ""glslang/HLSL/hlslOpMap.cpp"",
            root_glslang_path ++ ""glslang/HLSL/hlslTokenStream.cpp"",
            root_glslang_path ++ ""glslang/HLSL/hlslGrammar.cpp"",
            root_glslang_path ++ ""glslang/HLSL/hlslParseables.cpp"",
            root_glslang_path ++ ""glslang/GenericCodeGen/CodeGen.cpp"",
            root_glslang_path ++ ""glslang/GenericCodeGen/Link.cpp"",
        },
        .flags = flags,
    });

    if (target.result.os.tag == .windows) {
        glslang.addCSourceFiles(.{ .files = &.{root_glslang_path ++ ""glslang/OSDependent/Windows/ossource.cpp""}, .flags = flags });
    }
    //This assumption is wrong, but anything that isnt windows is basically unix :^)
    else {
        glslang.addCSourceFiles(.{ .files = &.{root_glslang_path ++ ""glslang/OSDependent/Unix/ossource.cpp""}, .flags = flags });
    }

    glslang.addCSourceFiles(.{
        .files = &.{
            root_glslang_path ++ ""SPIRV/GlslangToSpv.cpp"",
            root_glslang_path ++ ""SPIRV/InReadableOrder.cpp"",
            root_glslang_path ++ ""SPIRV/Logger.cpp"",
            root_glslang_path ++ ""SPIRV/SpvBuilder.cpp"",
            root_glslang_path ++ ""SPIRV/SpvPostProcess.cpp"",
            root_glslang_path ++ ""SPIRV/doc.cpp"",
            root_glslang_path ++ ""SPIRV/SpvTools.cpp"",
            root_glslang_path ++ ""SPIRV/disassemble.cpp"",
            root_glslang_path ++ ""SPIRV/CInterface/spirv_c_interface.cpp"",
        },
        .flags = flags,
    });

    const generate_build_info = b.addSystemCommand(&.{
        ""python3"",
        root_glslang_path ++ ""build_info.py"",
        root_glslang_path,
        ""-i"", root_glslang_path ++ ""build_info.h.tmpl"", //input
        ""-o"", root_glslang_path ++ ""Include/glslang/build_info.h"", //output
    });

    glslang.step.dependOn(&generate_build_info.step);

    return glslang;
}

pub fn build(b: *std.Build) void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    const glslang = glslangLib(b, target, optimize);

    const spirv_tools = spvTools(b, target, optimize);

    const shaderc_util: *std.Build.Step.Compile = b.addStaticLibrary(.{
        .name = ""shaderc_shared"",
        .target = target,
        .optimize = optimize,
    });
    shaderc_util.linkLibC();
    shaderc_util.linkLibCpp();
    shaderc_util.addIncludePath(b.path(""libshaderc/include""));
    shaderc_util.addIncludePath(b.path(""libshaderc_util/include""));

    shaderc_util.addIncludePath(b.path(""third_party/glslang""));
    shaderc_util.addIncludePath(b.path(""third_party/spirv-tools/include""));
    shaderc_util.addIncludePath(b.path(""third_party/spirv-headers/include/""));

    shaderc_util.defineCMacro(""ENABLE_HLSL"", ""1"");

    shaderc_util.addCSourceFiles(.{
        .files = &.{
            ""libshaderc_util/src/args.cc"",
            ""libshaderc_util/src/compiler.cc"",
            ""libshaderc_util/src/file_finder.cc"",
            ""libshaderc_util/src/io_shaderc.cc"",
            ""libshaderc_util/src/message.cc"",
            ""libshaderc_util/src/resources.cc"",
            ""libshaderc_util/src/shader_stage.cc"",
            ""libshaderc_util/src/spirv_tools_wrapper.cc"",
            ""libshaderc_util/src/version_profile.cc"",
        },
        .flags = flags,
    });

    const shaderc: *std.Build.Step.Compile = b.addSharedLibrary(.{
        .name = ""shaderc_shared"",
        .target = target,
        .optimize = optimize,
    });
    shaderc.defineCMacro(""SHADERC_SHAREDLIB"", ""1"");
    shaderc.defineCMacro(""SHADERC_IMPLEMENTATION"", ""1"");
    shaderc.linkLibC();
    shaderc.linkLibCpp();
    shaderc.linkLibrary(shaderc_util);
    shaderc.linkLibrary(spirv_tools);
    shaderc.linkLibrary(glslang);

    //On release builds, lets strip the binary to reduce size further
    if (optimize != .Debug) {
        shaderc.root_module.strip = true;
    }

    shaderc.addIncludePath(b.path(""libshaderc/include""));
    shaderc.addIncludePath(b.path(""libshaderc_util/include""));

    shaderc.addIncludePath(b.path(""third_party/glslang""));
    shaderc.addIncludePath(b.path(""third_party/spirv-tools/include""));
    shaderc.addIncludePath(b.path(""third_party/spirv-headers/include/""));

    shaderc.addCSourceFiles(.{
        .files = &.{
            ""libshaderc/src/shaderc.cc"",
        },
        .flags = flags,
    });

    b.installArtifact(shaderc);
}
";

    AbsolutePath ShadercPath => RootDirectory / "build" / "submodules" / "shaderc";

    Target Shaderc => CommonTarget
        (
        x => x.Before(Compile)
        .After(Clean)
        .Executes
        (
        () =>
        {
            var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Shaderc.Native" / "runtimes";

            File.WriteAllText(ShadercPath / "build.zig", ShadercBuildScript);

            //Clone all the deps for shaderc
            InheritedShell("python3 ./git-sync-deps", ShadercPath / "utils").AssertZeroExitCode();

            const string libname = "shaderc_shared";

            const string optimizeMode = "-Doptimize=ReleaseFast";

            //Build shaderc for Linux x86_64
            InheritedShell($"zig build \"-Dtarget=x86_64-linux-gnu.2.17\" {optimizeMode}", ShadercPath).AssertZeroExitCode();
            CopyFile(ShadercPath / "zig-out" / "lib" / $"lib{libname}.so", runtimes / "linux-x64" / "native" / $"lib{libname}.so", FileExistsPolicy.Overwrite);

            //Build shaderc for Linux ARM
            InheritedShell($"zig build \"-Dtarget=arm-linux-gnueabihf.2.17\" {optimizeMode}", ShadercPath).AssertZeroExitCode();
            CopyFile(ShadercPath / "zig-out" / "lib" / $"lib{libname}.so", runtimes / "linux-arm" / "native" / $"lib{libname}.so", FileExistsPolicy.Overwrite);

            //Build shaderc for Linux ARM64
            InheritedShell($"zig build \"-Dtarget=aarch64-linux-gnu.2.17\" {optimizeMode}", ShadercPath).AssertZeroExitCode();
            CopyFile(ShadercPath / "zig-out" / "lib" / $"lib{libname}.so", runtimes / "linux-arm64" / "native" / $"lib{libname}.so", FileExistsPolicy.Overwrite);

            //Build shaderc for Windows x86
            InheritedShell($"zig build -Dtarget=x86-windows-gnu {optimizeMode}", ShadercPath).AssertZeroExitCode();
            CopyFile(ShadercPath / "zig-out" / "bin" / $"{libname}.dll", runtimes / "win-x86" / "native" / $"{libname}.dll", FileExistsPolicy.Overwrite);

            //Build shaderc for Windows x86_64
            InheritedShell($"zig build -Dtarget=x86_64-windows-gnu {optimizeMode}", ShadercPath).AssertZeroExitCode();
            CopyFile(ShadercPath / "zig-out" / "bin" / $"{libname}.dll", runtimes / "win-x64" / "native" / $"{libname}.dll", FileExistsPolicy.Overwrite);

            //Build shaderc for Windows ARM64
            InheritedShell($"zig build -Dtarget=aarch64-windows-gnu {optimizeMode}", ShadercPath).AssertZeroExitCode();
            CopyFile(ShadercPath / "zig-out" / "bin" / $"{libname}.dll", runtimes / "win-arm64" / "native" / $"{libname}.dll", FileExistsPolicy.Overwrite);

            //Build shaderc for MacOS x86_64
            InheritedShell($"zig build -Dtarget=x86_64-macos {optimizeMode}", ShadercPath).AssertZeroExitCode();
            CopyFile(ShadercPath / "zig-out" / "lib" / $"lib{libname}.dylib", runtimes / "osx-x64" / "native" / $"lib{libname}.dylib", FileExistsPolicy.Overwrite);

            //Build shaderc for MacOS ARM64
            InheritedShell($"zig build -Dtarget=aarch64-macos {optimizeMode}", ShadercPath).AssertZeroExitCode();
            CopyFile(ShadercPath / "zig-out" / "lib" / $"lib{libname}.dylib", runtimes / "osx-arm64" / "native" / $"lib{libname}.dylib", FileExistsPolicy.Overwrite);

            PrUpdatedNativeBinary("Shaderc");
        }
        )
    );
}
