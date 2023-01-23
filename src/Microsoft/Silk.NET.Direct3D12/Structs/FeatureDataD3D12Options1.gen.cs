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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS1")]
    public unsafe partial struct FeatureDataD3D12Options1
    {
        public FeatureDataD3D12Options1
        (
            Silk.NET.Core.Bool32? waveOps = null,
            uint? waveLaneCountMin = null,
            uint? waveLaneCountMax = null,
            uint? totalLaneCount = null,
            Silk.NET.Core.Bool32? expandedComputeResourceStates = null,
            Silk.NET.Core.Bool32? int64ShaderOps = null
        ) : this()
        {
            if (waveOps is not null)
            {
                WaveOps = waveOps.Value;
            }

            if (waveLaneCountMin is not null)
            {
                WaveLaneCountMin = waveLaneCountMin.Value;
            }

            if (waveLaneCountMax is not null)
            {
                WaveLaneCountMax = waveLaneCountMax.Value;
            }

            if (totalLaneCount is not null)
            {
                TotalLaneCount = totalLaneCount.Value;
            }

            if (expandedComputeResourceStates is not null)
            {
                ExpandedComputeResourceStates = expandedComputeResourceStates.Value;
            }

            if (int64ShaderOps is not null)
            {
                Int64ShaderOps = int64ShaderOps.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "WaveOps")]
        public Silk.NET.Core.Bool32 WaveOps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "WaveLaneCountMin")]
        public uint WaveLaneCountMin;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "WaveLaneCountMax")]
        public uint WaveLaneCountMax;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TotalLaneCount")]
        public uint TotalLaneCount;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExpandedComputeResourceStates")]
        public Silk.NET.Core.Bool32 ExpandedComputeResourceStates;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Int64ShaderOps")]
        public Silk.NET.Core.Bool32 Int64ShaderOps;
    }
}
