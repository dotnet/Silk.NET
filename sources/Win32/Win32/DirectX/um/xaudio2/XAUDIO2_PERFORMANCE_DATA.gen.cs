// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_PERFORMANCE_DATA
{
    [NativeTypeName("UINT64")]
    public ulong AudioCyclesSinceLastQuery;

    [NativeTypeName("UINT64")]
    public ulong TotalCyclesSinceLastQuery;

    [NativeTypeName("UINT32")]
    public uint MinimumCyclesPerQuantum;

    [NativeTypeName("UINT32")]
    public uint MaximumCyclesPerQuantum;

    [NativeTypeName("UINT32")]
    public uint MemoryUsageInBytes;

    [NativeTypeName("UINT32")]
    public uint CurrentLatencyInSamples;

    [NativeTypeName("UINT32")]
    public uint GlitchesSinceEngineStarted;

    [NativeTypeName("UINT32")]
    public uint ActiveSourceVoiceCount;

    [NativeTypeName("UINT32")]
    public uint TotalSourceVoiceCount;

    [NativeTypeName("UINT32")]
    public uint ActiveSubmixVoiceCount;

    [NativeTypeName("UINT32")]
    public uint ActiveResamplerCount;

    [NativeTypeName("UINT32")]
    public uint ActiveMatrixMixCount;

    [NativeTypeName("UINT32")]
    public uint ActiveXmaSourceVoices;

    [NativeTypeName("UINT32")]
    public uint ActiveXmaStreams;
}
