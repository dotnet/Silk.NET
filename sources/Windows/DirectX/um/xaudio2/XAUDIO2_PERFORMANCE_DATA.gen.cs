// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_PERFORMANCE_DATA
{
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.AudioCyclesSinceLastQuery"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong AudioCyclesSinceLastQuery;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.TotalCyclesSinceLastQuery"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong TotalCyclesSinceLastQuery;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.MinimumCyclesPerQuantum"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MinimumCyclesPerQuantum;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.MaximumCyclesPerQuantum"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MaximumCyclesPerQuantum;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.MemoryUsageInBytes"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MemoryUsageInBytes;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.CurrentLatencyInSamples"]/*'/>
    [NativeTypeName("UINT32")]
    public uint CurrentLatencyInSamples;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.GlitchesSinceEngineStarted"]/*'/>
    [NativeTypeName("UINT32")]
    public uint GlitchesSinceEngineStarted;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.ActiveSourceVoiceCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ActiveSourceVoiceCount;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.TotalSourceVoiceCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint TotalSourceVoiceCount;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.ActiveSubmixVoiceCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ActiveSubmixVoiceCount;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.ActiveResamplerCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ActiveResamplerCount;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.ActiveMatrixMixCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ActiveMatrixMixCount;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.ActiveXmaSourceVoices"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ActiveXmaSourceVoices;
    /// <include file='XAUDIO2_PERFORMANCE_DATA.xml' path='doc/member[@name="XAUDIO2_PERFORMANCE_DATA.ActiveXmaStreams"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ActiveXmaStreams;
}