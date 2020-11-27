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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS2")]
    public unsafe partial struct FeatureDataD3D12Options2
    {
        public FeatureDataD3D12Options2
        (
            int? depthBoundsTestSupported = null,
            ProgrammableSamplePositionsTier? programmableSamplePositionsTier = null
        ) : this()
        {
            if (depthBoundsTestSupported is not null)
            {
                DepthBoundsTestSupported = depthBoundsTestSupported.Value;
            }

            if (programmableSamplePositionsTier is not null)
            {
                ProgrammableSamplePositionsTier = programmableSamplePositionsTier.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthBoundsTestSupported")]
        public int DepthBoundsTestSupported;

        [NativeName("Type", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER")]
        [NativeName("Type.Name", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER")]
        [NativeName("Name", "ProgrammableSamplePositionsTier")]
        public ProgrammableSamplePositionsTier ProgrammableSamplePositionsTier;
    }
}
