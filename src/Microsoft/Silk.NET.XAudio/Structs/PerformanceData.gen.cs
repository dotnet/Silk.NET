// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "XAUDIO2_PERFORMANCE_DATA")]
    public unsafe partial struct PerformanceData
    {
        public PerformanceData
        (
            ulong? audioCyclesSinceLastQuery = null,
            ulong? totalCyclesSinceLastQuery = null,
            uint? minimumCyclesPerQuantum = null,
            uint? maximumCyclesPerQuantum = null,
            uint? memoryUsageInBytes = null,
            uint? currentLatencyInSamples = null,
            uint? glitchesSinceEngineStarted = null,
            uint? activeSourceVoiceCount = null,
            uint? totalSourceVoiceCount = null,
            uint? activeSubmixVoiceCount = null,
            uint? activeResamplerCount = null,
            uint? activeMatrixMixCount = null,
            uint? activeXmaSourceVoices = null,
            uint? activeXmaStreams = null
        ) : this()
        {
            if (audioCyclesSinceLastQuery is not null)
            {
                AudioCyclesSinceLastQuery = audioCyclesSinceLastQuery.Value;
            }

            if (totalCyclesSinceLastQuery is not null)
            {
                TotalCyclesSinceLastQuery = totalCyclesSinceLastQuery.Value;
            }

            if (minimumCyclesPerQuantum is not null)
            {
                MinimumCyclesPerQuantum = minimumCyclesPerQuantum.Value;
            }

            if (maximumCyclesPerQuantum is not null)
            {
                MaximumCyclesPerQuantum = maximumCyclesPerQuantum.Value;
            }

            if (memoryUsageInBytes is not null)
            {
                MemoryUsageInBytes = memoryUsageInBytes.Value;
            }

            if (currentLatencyInSamples is not null)
            {
                CurrentLatencyInSamples = currentLatencyInSamples.Value;
            }

            if (glitchesSinceEngineStarted is not null)
            {
                GlitchesSinceEngineStarted = glitchesSinceEngineStarted.Value;
            }

            if (activeSourceVoiceCount is not null)
            {
                ActiveSourceVoiceCount = activeSourceVoiceCount.Value;
            }

            if (totalSourceVoiceCount is not null)
            {
                TotalSourceVoiceCount = totalSourceVoiceCount.Value;
            }

            if (activeSubmixVoiceCount is not null)
            {
                ActiveSubmixVoiceCount = activeSubmixVoiceCount.Value;
            }

            if (activeResamplerCount is not null)
            {
                ActiveResamplerCount = activeResamplerCount.Value;
            }

            if (activeMatrixMixCount is not null)
            {
                ActiveMatrixMixCount = activeMatrixMixCount.Value;
            }

            if (activeXmaSourceVoices is not null)
            {
                ActiveXmaSourceVoices = activeXmaSourceVoices.Value;
            }

            if (activeXmaStreams is not null)
            {
                ActiveXmaStreams = activeXmaStreams.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "AudioCyclesSinceLastQuery")]
        public ulong AudioCyclesSinceLastQuery;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "TotalCyclesSinceLastQuery")]
        public ulong TotalCyclesSinceLastQuery;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "MinimumCyclesPerQuantum")]
        public uint MinimumCyclesPerQuantum;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "MaximumCyclesPerQuantum")]
        public uint MaximumCyclesPerQuantum;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "MemoryUsageInBytes")]
        public uint MemoryUsageInBytes;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "CurrentLatencyInSamples")]
        public uint CurrentLatencyInSamples;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "GlitchesSinceEngineStarted")]
        public uint GlitchesSinceEngineStarted;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "ActiveSourceVoiceCount")]
        public uint ActiveSourceVoiceCount;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "TotalSourceVoiceCount")]
        public uint TotalSourceVoiceCount;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "ActiveSubmixVoiceCount")]
        public uint ActiveSubmixVoiceCount;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "ActiveResamplerCount")]
        public uint ActiveResamplerCount;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "ActiveMatrixMixCount")]
        public uint ActiveMatrixMixCount;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "ActiveXmaSourceVoices")]
        public uint ActiveXmaSourceVoices;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "ActiveXmaStreams")]
        public uint ActiveXmaStreams;
    }
}
