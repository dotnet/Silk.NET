// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PROCESSOR
{
    [NativeTypeName("#define PROCESSOR_INTEL_386 386")]
    public const int PROCESSOR_INTEL_386 = 386;
    [NativeTypeName("#define PROCESSOR_INTEL_486 486")]
    public const int PROCESSOR_INTEL_486 = 486;
    [NativeTypeName("#define PROCESSOR_INTEL_PENTIUM 586")]
    public const int PROCESSOR_INTEL_PENTIUM = 586;
    [NativeTypeName("#define PROCESSOR_INTEL_IA64 2200")]
    public const int PROCESSOR_INTEL_IA64 = 2200;
    [NativeTypeName("#define PROCESSOR_AMD_X8664 8664")]
    public const int PROCESSOR_AMD_X8664 = 8664;
    [NativeTypeName("#define PROCESSOR_MIPS_R4000 4000")]
    public const int PROCESSOR_MIPS_R4000 = 4000;
    [NativeTypeName("#define PROCESSOR_ALPHA_21064 21064")]
    public const int PROCESSOR_ALPHA_21064 = 21064;
    [NativeTypeName("#define PROCESSOR_PPC_601 601")]
    public const int PROCESSOR_PPC_601 = 601;
    [NativeTypeName("#define PROCESSOR_PPC_603 603")]
    public const int PROCESSOR_PPC_603 = 603;
    [NativeTypeName("#define PROCESSOR_PPC_604 604")]
    public const int PROCESSOR_PPC_604 = 604;
    [NativeTypeName("#define PROCESSOR_PPC_620 620")]
    public const int PROCESSOR_PPC_620 = 620;
    [NativeTypeName("#define PROCESSOR_HITACHI_SH3 10003")]
    public const int PROCESSOR_HITACHI_SH3 = 10003;
    [NativeTypeName("#define PROCESSOR_HITACHI_SH3E 10004")]
    public const int PROCESSOR_HITACHI_SH3E = 10004;
    [NativeTypeName("#define PROCESSOR_HITACHI_SH4 10005")]
    public const int PROCESSOR_HITACHI_SH4 = 10005;
    [NativeTypeName("#define PROCESSOR_MOTOROLA_821 821")]
    public const int PROCESSOR_MOTOROLA_821 = 821;
    [NativeTypeName("#define PROCESSOR_SHx_SH3 103")]
    public const int PROCESSOR_SHx_SH3 = 103;
    [NativeTypeName("#define PROCESSOR_SHx_SH4 104")]
    public const int PROCESSOR_SHx_SH4 = 104;
    [NativeTypeName("#define PROCESSOR_STRONGARM 2577")]
    public const int PROCESSOR_STRONGARM = 2577;
    [NativeTypeName("#define PROCESSOR_ARM720 1824")]
    public const int PROCESSOR_ARM720 = 1824;
    [NativeTypeName("#define PROCESSOR_ARM820 2080")]
    public const int PROCESSOR_ARM820 = 2080;
    [NativeTypeName("#define PROCESSOR_ARM920 2336")]
    public const int PROCESSOR_ARM920 = 2336;
    [NativeTypeName("#define PROCESSOR_ARM_7TDMI 70001")]
    public const int PROCESSOR_ARM_7TDMI = 70001;
    [NativeTypeName("#define PROCESSOR_OPTIL 0x494f")]
    public const int PROCESSOR_OPTIL = 0x494f;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_INTEL 0")]
    public const int PROCESSOR_ARCHITECTURE_INTEL = 0;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_MIPS 1")]
    public const int PROCESSOR_ARCHITECTURE_MIPS = 1;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ALPHA 2")]
    public const int PROCESSOR_ARCHITECTURE_ALPHA = 2;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_PPC 3")]
    public const int PROCESSOR_ARCHITECTURE_PPC = 3;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_SHX 4")]
    public const int PROCESSOR_ARCHITECTURE_SHX = 4;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM 5")]
    public const int PROCESSOR_ARCHITECTURE_ARM = 5;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA64 6")]
    public const int PROCESSOR_ARCHITECTURE_IA64 = 6;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ALPHA64 7")]
    public const int PROCESSOR_ARCHITECTURE_ALPHA64 = 7;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_MSIL 8")]
    public const int PROCESSOR_ARCHITECTURE_MSIL = 8;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_AMD64 9")]
    public const int PROCESSOR_ARCHITECTURE_AMD64 = 9;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 10")]
    public const int PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 = 10;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_NEUTRAL 11")]
    public const int PROCESSOR_ARCHITECTURE_NEUTRAL = 11;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM64 12")]
    public const int PROCESSOR_ARCHITECTURE_ARM64 = 12;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64 13")]
    public const int PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64 = 13;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA32_ON_ARM64 14")]
    public const int PROCESSOR_ARCHITECTURE_IA32_ON_ARM64 = 14;
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_UNKNOWN 0xFFFF")]
    public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF;
    [NativeTypeName("#define PROCESSOR_THROTTLE_DISABLED 0")]
    public const int PROCESSOR_THROTTLE_DISABLED = 0;
    [NativeTypeName("#define PROCESSOR_THROTTLE_ENABLED 1")]
    public const int PROCESSOR_THROTTLE_ENABLED = 1;
    [NativeTypeName("#define PROCESSOR_THROTTLE_AUTOMATIC 2")]
    public const int PROCESSOR_THROTTLE_AUTOMATIC = 2;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_POLICY_DISABLED 0")]
    public const int PROCESSOR_PERF_BOOST_POLICY_DISABLED = 0;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_POLICY_MAX 100")]
    public const int PROCESSOR_PERF_BOOST_POLICY_MAX = 100;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_DISABLED 0")]
    public const int PROCESSOR_PERF_BOOST_MODE_DISABLED = 0;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_ENABLED 1")]
    public const int PROCESSOR_PERF_BOOST_MODE_ENABLED = 1;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE 2")]
    public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE = 2;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED 3")]
    public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED = 3;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE 4")]
    public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE = 4;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED 5")]
    public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED = 5;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED 6")]
    public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED = 6;
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_MAX PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED")]
    public const int PROCESSOR_PERF_BOOST_MODE_MAX = 6;
    [NativeTypeName("#define PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED 0")]
    public const int PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED = 0;
    [NativeTypeName("#define PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED 1")]
    public const int PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED = 1;
    [NativeTypeName("#define PROCESSOR_PERF_PERFORMANCE_PREFERENCE 0xff")]
    public const int PROCESSOR_PERF_PERFORMANCE_PREFERENCE = 0xff;
    [NativeTypeName("#define PROCESSOR_PERF_ENERGY_PREFERENCE 0")]
    public const int PROCESSOR_PERF_ENERGY_PREFERENCE = 0;
    [NativeTypeName("#define PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW 0")]
    public const int PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW = 0;
    [NativeTypeName("#define PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW 1270000000")]
    public const int PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW = 1270000000;
    [NativeTypeName("#define PROCESSOR_DUTY_CYCLING_DISABLED 0")]
    public const int PROCESSOR_DUTY_CYCLING_DISABLED = 0;
    [NativeTypeName("#define PROCESSOR_DUTY_CYCLING_ENABLED 1")]
    public const int PROCESSOR_DUTY_CYCLING_ENABLED = 1;
    [NativeTypeName("#define PROCESSOR_IDLESTATE_POLICY_COUNT 0x3")]
    public const int PROCESSOR_IDLESTATE_POLICY_COUNT = 0x3;
}