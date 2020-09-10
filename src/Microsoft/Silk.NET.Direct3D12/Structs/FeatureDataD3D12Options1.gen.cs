// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            int waveOps = default,
            uint waveLaneCountMin = default,
            uint waveLaneCountMax = default,
            uint totalLaneCount = default,
            int expandedComputeResourceStates = default,
            int int64ShaderOps = default
        )
        {
            WaveOps = waveOps;
            WaveLaneCountMin = waveLaneCountMin;
            WaveLaneCountMax = waveLaneCountMax;
            TotalLaneCount = totalLaneCount;
            ExpandedComputeResourceStates = expandedComputeResourceStates;
            Int64ShaderOps = int64ShaderOps;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "WaveOps")]
        public int WaveOps;

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
        public int ExpandedComputeResourceStates;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Int64ShaderOps")]
        public int Int64ShaderOps;
    }
}
