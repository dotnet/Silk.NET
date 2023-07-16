// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PF
{
    [NativeTypeName("#define PF_TEMPORAL_LEVEL_1 _MM_HINT_T0")]
    public const int PF_TEMPORAL_LEVEL_1 = 1;
    [NativeTypeName("#define PF_TEMPORAL_LEVEL_2 _MM_HINT_T1")]
    public const int PF_TEMPORAL_LEVEL_2 = 2;
    [NativeTypeName("#define PF_TEMPORAL_LEVEL_3 _MM_HINT_T2")]
    public const int PF_TEMPORAL_LEVEL_3 = 3;
    [NativeTypeName("#define PF_NON_TEMPORAL_LEVEL_ALL _MM_HINT_NTA")]
    public const int PF_NON_TEMPORAL_LEVEL_ALL = 0;
    [NativeTypeName("#define PF_FLOATING_POINT_PRECISION_ERRATA 0")]
    public const int PF_FLOATING_POINT_PRECISION_ERRATA = 0;
    [NativeTypeName("#define PF_FLOATING_POINT_EMULATED 1")]
    public const int PF_FLOATING_POINT_EMULATED = 1;
    [NativeTypeName("#define PF_COMPARE_EXCHANGE_DOUBLE 2")]
    public const int PF_COMPARE_EXCHANGE_DOUBLE = 2;
    [NativeTypeName("#define PF_MMX_INSTRUCTIONS_AVAILABLE 3")]
    public const int PF_MMX_INSTRUCTIONS_AVAILABLE = 3;
    [NativeTypeName("#define PF_PPC_MOVEMEM_64BIT_OK 4")]
    public const int PF_PPC_MOVEMEM_64BIT_OK = 4;
    [NativeTypeName("#define PF_ALPHA_BYTE_INSTRUCTIONS 5")]
    public const int PF_ALPHA_BYTE_INSTRUCTIONS = 5;
    [NativeTypeName("#define PF_XMMI_INSTRUCTIONS_AVAILABLE 6")]
    public const int PF_XMMI_INSTRUCTIONS_AVAILABLE = 6;
    [NativeTypeName("#define PF_3DNOW_INSTRUCTIONS_AVAILABLE 7")]
    public const int PF_3DNOW_INSTRUCTIONS_AVAILABLE = 7;
    [NativeTypeName("#define PF_RDTSC_INSTRUCTION_AVAILABLE 8")]
    public const int PF_RDTSC_INSTRUCTION_AVAILABLE = 8;
    [NativeTypeName("#define PF_PAE_ENABLED 9")]
    public const int PF_PAE_ENABLED = 9;
    [NativeTypeName("#define PF_XMMI64_INSTRUCTIONS_AVAILABLE 10")]
    public const int PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10;
    [NativeTypeName("#define PF_SSE_DAZ_MODE_AVAILABLE 11")]
    public const int PF_SSE_DAZ_MODE_AVAILABLE = 11;
    [NativeTypeName("#define PF_NX_ENABLED 12")]
    public const int PF_NX_ENABLED = 12;
    [NativeTypeName("#define PF_SSE3_INSTRUCTIONS_AVAILABLE 13")]
    public const int PF_SSE3_INSTRUCTIONS_AVAILABLE = 13;
    [NativeTypeName("#define PF_COMPARE_EXCHANGE128 14")]
    public const int PF_COMPARE_EXCHANGE128 = 14;
    [NativeTypeName("#define PF_COMPARE64_EXCHANGE128 15")]
    public const int PF_COMPARE64_EXCHANGE128 = 15;
    [NativeTypeName("#define PF_CHANNELS_ENABLED 16")]
    public const int PF_CHANNELS_ENABLED = 16;
    [NativeTypeName("#define PF_XSAVE_ENABLED 17")]
    public const int PF_XSAVE_ENABLED = 17;
    [NativeTypeName("#define PF_ARM_VFP_32_REGISTERS_AVAILABLE 18")]
    public const int PF_ARM_VFP_32_REGISTERS_AVAILABLE = 18;
    [NativeTypeName("#define PF_ARM_NEON_INSTRUCTIONS_AVAILABLE 19")]
    public const int PF_ARM_NEON_INSTRUCTIONS_AVAILABLE = 19;
    [NativeTypeName("#define PF_SECOND_LEVEL_ADDRESS_TRANSLATION 20")]
    public const int PF_SECOND_LEVEL_ADDRESS_TRANSLATION = 20;
    [NativeTypeName("#define PF_VIRT_FIRMWARE_ENABLED 21")]
    public const int PF_VIRT_FIRMWARE_ENABLED = 21;
    [NativeTypeName("#define PF_RDWRFSGSBASE_AVAILABLE 22")]
    public const int PF_RDWRFSGSBASE_AVAILABLE = 22;
    [NativeTypeName("#define PF_FASTFAIL_AVAILABLE 23")]
    public const int PF_FASTFAIL_AVAILABLE = 23;
    [NativeTypeName("#define PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE 24")]
    public const int PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE = 24;
    [NativeTypeName("#define PF_ARM_64BIT_LOADSTORE_ATOMIC 25")]
    public const int PF_ARM_64BIT_LOADSTORE_ATOMIC = 25;
    [NativeTypeName("#define PF_ARM_EXTERNAL_CACHE_AVAILABLE 26")]
    public const int PF_ARM_EXTERNAL_CACHE_AVAILABLE = 26;
    [NativeTypeName("#define PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE 27")]
    public const int PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE = 27;
    [NativeTypeName("#define PF_RDRAND_INSTRUCTION_AVAILABLE 28")]
    public const int PF_RDRAND_INSTRUCTION_AVAILABLE = 28;
    [NativeTypeName("#define PF_ARM_V8_INSTRUCTIONS_AVAILABLE 29")]
    public const int PF_ARM_V8_INSTRUCTIONS_AVAILABLE = 29;
    [NativeTypeName("#define PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE 30")]
    public const int PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE = 30;
    [NativeTypeName("#define PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE 31")]
    public const int PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE = 31;
    [NativeTypeName("#define PF_RDTSCP_INSTRUCTION_AVAILABLE 32")]
    public const int PF_RDTSCP_INSTRUCTION_AVAILABLE = 32;
    [NativeTypeName("#define PF_RDPID_INSTRUCTION_AVAILABLE 33")]
    public const int PF_RDPID_INSTRUCTION_AVAILABLE = 33;
    [NativeTypeName("#define PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE 34")]
    public const int PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE = 34;
    [NativeTypeName("#define PF_MONITORX_INSTRUCTION_AVAILABLE 35")]
    public const int PF_MONITORX_INSTRUCTION_AVAILABLE = 35;
    [NativeTypeName("#define PF_SSSE3_INSTRUCTIONS_AVAILABLE 36")]
    public const int PF_SSSE3_INSTRUCTIONS_AVAILABLE = 36;
    [NativeTypeName("#define PF_SSE4_1_INSTRUCTIONS_AVAILABLE 37")]
    public const int PF_SSE4_1_INSTRUCTIONS_AVAILABLE = 37;
    [NativeTypeName("#define PF_SSE4_2_INSTRUCTIONS_AVAILABLE 38")]
    public const int PF_SSE4_2_INSTRUCTIONS_AVAILABLE = 38;
    [NativeTypeName("#define PF_AVX_INSTRUCTIONS_AVAILABLE 39")]
    public const int PF_AVX_INSTRUCTIONS_AVAILABLE = 39;
    [NativeTypeName("#define PF_AVX2_INSTRUCTIONS_AVAILABLE 40")]
    public const int PF_AVX2_INSTRUCTIONS_AVAILABLE = 40;
    [NativeTypeName("#define PF_AVX512F_INSTRUCTIONS_AVAILABLE 41")]
    public const int PF_AVX512F_INSTRUCTIONS_AVAILABLE = 41;
    [NativeTypeName("#define PF_ERMS_AVAILABLE 42")]
    public const int PF_ERMS_AVAILABLE = 42;
    [NativeTypeName("#define PF_ARM_V82_DP_INSTRUCTIONS_AVAILABLE 43")]
    public const int PF_ARM_V82_DP_INSTRUCTIONS_AVAILABLE = 43;
    [NativeTypeName("#define PF_ARM_V83_JSCVT_INSTRUCTIONS_AVAILABLE 44")]
    public const int PF_ARM_V83_JSCVT_INSTRUCTIONS_AVAILABLE = 44;
    [NativeTypeName("#define PF_ARM_V83_LRCPC_INSTRUCTIONS_AVAILABLE 45")]
    public const int PF_ARM_V83_LRCPC_INSTRUCTIONS_AVAILABLE = 45;
}