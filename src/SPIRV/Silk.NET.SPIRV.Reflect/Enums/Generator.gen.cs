// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "SpvReflectGenerator")]
    public enum Generator : int
    {
        [NativeName("Name", "SPV_REFLECT_GENERATOR_KHRONOS_LLVM_SPIRV_TRANSLATOR")]
        KhronosLlvmSpirvTranslator = 0x6,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_KHRONOS_SPIRV_TOOLS_ASSEMBLER")]
        KhronosSpirvToolsAssembler = 0x7,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_KHRONOS_GLSLANG_REFERENCE_FRONT_END")]
        KhronosGlslangReferenceFrontEnd = 0x8,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_GOOGLE_SHADERC_OVER_GLSLANG")]
        GoogleShadercOverGlslang = 0xD,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_GOOGLE_SPIREGG")]
        GoogleSpiregg = 0xE,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_GOOGLE_RSPIRV")]
        GoogleRspirv = 0xF,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_X_LEGEND_MESA_MESAIR_SPIRV_TRANSLATOR")]
        XLegendMesaMesairSpirvTranslator = 0x10,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_KHRONOS_SPIRV_TOOLS_LINKER")]
        KhronosSpirvToolsLinker = 0x11,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_WINE_VKD3D_SHADER_COMPILER")]
        WineVkd3DShaderCompiler = 0x12,
        [NativeName("Name", "SPV_REFLECT_GENERATOR_CLAY_CLAY_SHADER_COMPILER")]
        ClayClayShaderCompiler = 0x13,
    }
}
