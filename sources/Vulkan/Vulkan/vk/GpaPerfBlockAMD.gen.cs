// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaPerfBlockAMD")]
public enum GpaPerfBlockAMD : uint
{
    [NativeName("VK_GPA_PERF_BLOCK_CPF_AMD")]
    Cpf = 0,

    [NativeName("VK_GPA_PERF_BLOCK_IA_AMD")]
    Ia = 1,

    [NativeName("VK_GPA_PERF_BLOCK_VGT_AMD")]
    Vgt = 2,

    [NativeName("VK_GPA_PERF_BLOCK_PA_AMD")]
    Pa = 3,

    [NativeName("VK_GPA_PERF_BLOCK_SC_AMD")]
    Sc = 4,

    [NativeName("VK_GPA_PERF_BLOCK_SPI_AMD")]
    Spi = 5,

    [NativeName("VK_GPA_PERF_BLOCK_SQ_AMD")]
    Sq = 6,

    [NativeName("VK_GPA_PERF_BLOCK_SX_AMD")]
    Sx = 7,

    [NativeName("VK_GPA_PERF_BLOCK_TA_AMD")]
    Ta = 8,

    [NativeName("VK_GPA_PERF_BLOCK_TD_AMD")]
    Td = 9,

    [NativeName("VK_GPA_PERF_BLOCK_TCP_AMD")]
    Tcp = 10,

    [NativeName("VK_GPA_PERF_BLOCK_TCC_AMD")]
    Tcc = 11,

    [NativeName("VK_GPA_PERF_BLOCK_TCA_AMD")]
    Tca = 12,

    [NativeName("VK_GPA_PERF_BLOCK_DB_AMD")]
    Db = 13,

    [NativeName("VK_GPA_PERF_BLOCK_CB_AMD")]
    Cb = 14,

    [NativeName("VK_GPA_PERF_BLOCK_GDS_AMD")]
    Gds = 15,

    [NativeName("VK_GPA_PERF_BLOCK_SRBM_AMD")]
    Srbm = 16,

    [NativeName("VK_GPA_PERF_BLOCK_GRBM_AMD")]
    Grbm = 17,

    [NativeName("VK_GPA_PERF_BLOCK_GRBM_SE_AMD")]
    GrbmSe = 18,

    [NativeName("VK_GPA_PERF_BLOCK_RLC_AMD")]
    Rlc = 19,

    [NativeName("VK_GPA_PERF_BLOCK_DMA_AMD")]
    Dma = 20,

    [NativeName("VK_GPA_PERF_BLOCK_MC_AMD")]
    Mc = 21,

    [NativeName("VK_GPA_PERF_BLOCK_CPG_AMD")]
    Cpg = 22,

    [NativeName("VK_GPA_PERF_BLOCK_CPC_AMD")]
    Cpc = 23,

    [NativeName("VK_GPA_PERF_BLOCK_WD_AMD")]
    Wd = 24,

    [NativeName("VK_GPA_PERF_BLOCK_TCS_AMD")]
    Tcs = 25,

    [NativeName("VK_GPA_PERF_BLOCK_ATC_AMD")]
    Atc = 26,

    [NativeName("VK_GPA_PERF_BLOCK_ATC_L2_AMD")]
    AtcL2 = 27,

    [NativeName("VK_GPA_PERF_BLOCK_MC_VM_L2_AMD")]
    McVmL2 = 28,

    [NativeName("VK_GPA_PERF_BLOCK_EA_AMD")]
    Ea = 29,

    [NativeName("VK_GPA_PERF_BLOCK_RPB_AMD")]
    Rpb = 30,

    [NativeName("VK_GPA_PERF_BLOCK_RMI_AMD")]
    Rmi = 31,

    [NativeName("VK_GPA_PERF_BLOCK_UMCCH_AMD")]
    Umcch = 32,

    [NativeName("VK_GPA_PERF_BLOCK_GE_AMD")]
    Ge = 33,

    [NativeName("VK_GPA_PERF_BLOCK_GL1A_AMD")]
    Gl1A = 34,

    [NativeName("VK_GPA_PERF_BLOCK_GL1C_AMD")]
    Gl1C = 35,

    [NativeName("VK_GPA_PERF_BLOCK_GL1CG_AMD")]
    Gl1Cg = 36,

    [NativeName("VK_GPA_PERF_BLOCK_GL2A_AMD")]
    Gl2A = 37,

    [NativeName("VK_GPA_PERF_BLOCK_GL2C_AMD")]
    Gl2C = 38,

    [NativeName("VK_GPA_PERF_BLOCK_CHA_AMD")]
    Cha = 39,

    [NativeName("VK_GPA_PERF_BLOCK_CHC_AMD")]
    Chc = 40,

    [NativeName("VK_GPA_PERF_BLOCK_CHCG_AMD")]
    Chcg = 41,

    [NativeName("VK_GPA_PERF_BLOCK_GUS_AMD")]
    Gus = 42,

    [NativeName("VK_GPA_PERF_BLOCK_GCR_AMD")]
    Gcr = 43,

    [NativeName("VK_GPA_PERF_BLOCK_PH_AMD")]
    Ph = 44,

    [NativeName("VK_GPA_PERF_BLOCK_UTCL1_AMD")]
    Utcl1 = 45,

    [NativeName("VK_GPA_PERF_BLOCK_GE_DIST_AMD")]
    GeDist = 46,

    [NativeName("VK_GPA_PERF_BLOCK_GE_SE_AMD")]
    GeSe = 47,

    [NativeName("VK_GPA_PERF_BLOCK_DF_MALL_AMD")]
    DfMall = 48,

    [NativeName("VK_GPA_PERF_BLOCK_SQ_WGP_AMD")]
    SqWgp = 49,

    [NativeName("VK_GPA_PERF_BLOCK_PC_AMD")]
    Pc = 50,

    [NativeName("VK_GPA_PERF_BLOCK_GL1XA_AMD")]
    Gl1Xa = 51,

    [NativeName("VK_GPA_PERF_BLOCK_GL1XC_AMD")]
    Gl1Xc = 52,

    [NativeName("VK_GPA_PERF_BLOCK_WGS_AMD")]
    Wgs = 53,

    [NativeName("VK_GPA_PERF_BLOCK_EACPWD_AMD")]
    Eacpwd = 54,

    [NativeName("VK_GPA_PERF_BLOCK_EASE_AMD")]
    Ease = 55,

    [NativeName("VK_GPA_PERF_BLOCK_RLCUSER_AMD")]
    Rlcuser = 56,

    [NativeName("VK_GPA_PERF_BLOCK_GE1_AMD")]
    Ge1 = Ge,

    [NativeName("VK_GPA_PERF_BLOCK_RLCLOCAL_AMD")]
    Rlclocal = Rlcuser,
}
