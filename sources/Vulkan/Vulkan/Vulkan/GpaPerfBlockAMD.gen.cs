// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaPerfBlockAMD")]
[SupportedApiProfile("vulkan")]
public enum GpaPerfBlockAMD : uint
{
    [NativeName("VK_GPA_PERF_BLOCK_CPF_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Cpf = 0,

    [NativeName("VK_GPA_PERF_BLOCK_IA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Ia = 1,

    [NativeName("VK_GPA_PERF_BLOCK_VGT_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Vgt = 2,

    [NativeName("VK_GPA_PERF_BLOCK_PA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Pa = 3,

    [NativeName("VK_GPA_PERF_BLOCK_SC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Sc = 4,

    [NativeName("VK_GPA_PERF_BLOCK_SPI_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Spi = 5,

    [NativeName("VK_GPA_PERF_BLOCK_SQ_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Sq = 6,

    [NativeName("VK_GPA_PERF_BLOCK_SX_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Sx = 7,

    [NativeName("VK_GPA_PERF_BLOCK_TA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Ta = 8,

    [NativeName("VK_GPA_PERF_BLOCK_TD_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Td = 9,

    [NativeName("VK_GPA_PERF_BLOCK_TCP_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Tcp = 10,

    [NativeName("VK_GPA_PERF_BLOCK_TCC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Tcc = 11,

    [NativeName("VK_GPA_PERF_BLOCK_TCA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Tca = 12,

    [NativeName("VK_GPA_PERF_BLOCK_DB_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Db = 13,

    [NativeName("VK_GPA_PERF_BLOCK_CB_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Cb = 14,

    [NativeName("VK_GPA_PERF_BLOCK_GDS_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gds = 15,

    [NativeName("VK_GPA_PERF_BLOCK_SRBM_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Srbm = 16,

    [NativeName("VK_GPA_PERF_BLOCK_GRBM_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Grbm = 17,

    [NativeName("VK_GPA_PERF_BLOCK_GRBM_SE_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    GrbmSe = 18,

    [NativeName("VK_GPA_PERF_BLOCK_RLC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Rlc = 19,

    [NativeName("VK_GPA_PERF_BLOCK_DMA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Dma = 20,

    [NativeName("VK_GPA_PERF_BLOCK_MC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Mc = 21,

    [NativeName("VK_GPA_PERF_BLOCK_CPG_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Cpg = 22,

    [NativeName("VK_GPA_PERF_BLOCK_CPC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Cpc = 23,

    [NativeName("VK_GPA_PERF_BLOCK_WD_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Wd = 24,

    [NativeName("VK_GPA_PERF_BLOCK_TCS_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Tcs = 25,

    [NativeName("VK_GPA_PERF_BLOCK_ATC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Atc = 26,

    [NativeName("VK_GPA_PERF_BLOCK_ATC_L2_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    AtcL2 = 27,

    [NativeName("VK_GPA_PERF_BLOCK_MC_VM_L2_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    McVmL2 = 28,

    [NativeName("VK_GPA_PERF_BLOCK_EA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Ea = 29,

    [NativeName("VK_GPA_PERF_BLOCK_RPB_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Rpb = 30,

    [NativeName("VK_GPA_PERF_BLOCK_RMI_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Rmi = 31,

    [NativeName("VK_GPA_PERF_BLOCK_UMCCH_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Umcch = 32,

    [NativeName("VK_GPA_PERF_BLOCK_GE_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Ge = 33,

    [NativeName("VK_GPA_PERF_BLOCK_GL1A_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gl1A = 34,

    [NativeName("VK_GPA_PERF_BLOCK_GL1C_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gl1C = 35,

    [NativeName("VK_GPA_PERF_BLOCK_GL1CG_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gl1Cg = 36,

    [NativeName("VK_GPA_PERF_BLOCK_GL2A_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gl2A = 37,

    [NativeName("VK_GPA_PERF_BLOCK_GL2C_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gl2C = 38,

    [NativeName("VK_GPA_PERF_BLOCK_CHA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Cha = 39,

    [NativeName("VK_GPA_PERF_BLOCK_CHC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Chc = 40,

    [NativeName("VK_GPA_PERF_BLOCK_CHCG_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Chcg = 41,

    [NativeName("VK_GPA_PERF_BLOCK_GUS_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gus = 42,

    [NativeName("VK_GPA_PERF_BLOCK_GCR_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gcr = 43,

    [NativeName("VK_GPA_PERF_BLOCK_PH_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Ph = 44,

    [NativeName("VK_GPA_PERF_BLOCK_UTCL1_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Utcl1 = 45,

    [NativeName("VK_GPA_PERF_BLOCK_GE_DIST_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    GeDist = 46,

    [NativeName("VK_GPA_PERF_BLOCK_GE_SE_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    GeSe = 47,

    [NativeName("VK_GPA_PERF_BLOCK_DF_MALL_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    DfMall = 48,

    [NativeName("VK_GPA_PERF_BLOCK_SQ_WGP_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    SqWgp = 49,

    [NativeName("VK_GPA_PERF_BLOCK_PC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Pc = 50,

    [NativeName("VK_GPA_PERF_BLOCK_GL1XA_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gl1Xa = 51,

    [NativeName("VK_GPA_PERF_BLOCK_GL1XC_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Gl1Xc = 52,

    [NativeName("VK_GPA_PERF_BLOCK_WGS_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Wgs = 53,

    [NativeName("VK_GPA_PERF_BLOCK_EACPWD_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Eacpwd = 54,

    [NativeName("VK_GPA_PERF_BLOCK_EASE_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Ease = 55,

    [NativeName("VK_GPA_PERF_BLOCK_RLCUSER_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Rlcuser = 56,

    [NativeName("VK_GPA_PERF_BLOCK_GE1_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Ge1 = Ge,

    [NativeName("VK_GPA_PERF_BLOCK_RLCLOCAL_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_gpa_interface"],
        ImpliesSets = [
            "VK_AMD_gpa_interface+VK_KHR_get_physical_device_properties2",
            "VK_AMD_gpa_interface+VK_VERSION_1_1",
        ]
    )]
    Rlclocal = Rlcuser,
}
