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
    [NativeName("Name", "D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS")]
    public unsafe partial struct FeatureDataMultisampleQualityLevels
    {
        public FeatureDataMultisampleQualityLevels
        (
            Silk.NET.DXGI.Format format = default,
            uint sampleCount = default,
            MultisampleQualityLevelFlags flags = default,
            uint numQualityLevels = default
        )
        {
            Format = format;
            SampleCount = sampleCount;
            Flags = flags;
            NumQualityLevels = numQualityLevels;
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SampleCount")]
        public uint SampleCount;

        [NativeName("Type", "D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS")]
        [NativeName("Type.Name", "D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS")]
        [NativeName("Name", "Flags")]
        public MultisampleQualityLevelFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumQualityLevels")]
        public uint NumQualityLevels;
    }
}
