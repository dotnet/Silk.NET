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
    [NativeName("Name", "D3D12_FEATURE_DATA_FEATURE_LEVELS")]
    public unsafe partial struct FeatureDataFeatureLevels
    {
        public FeatureDataFeatureLevels
        (
            uint numFeatureLevels = default,
            Silk.NET.Core.Native.FeatureLevel* pFeatureLevelsRequested = default,
            Silk.NET.Core.Native.FeatureLevel maxSupportedFeatureLevel = default
        )
        {
            NumFeatureLevels = numFeatureLevels;
            PFeatureLevelsRequested = pFeatureLevelsRequested;
            MaxSupportedFeatureLevel = maxSupportedFeatureLevel;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumFeatureLevels")]
        public uint NumFeatureLevels;

        [NativeName("Type", "const D3D_FEATURE_LEVEL *")]
        [NativeName("Type.Name", "const D3D_FEATURE_LEVEL *")]
        [NativeName("Name", "pFeatureLevelsRequested")]
        public Silk.NET.Core.Native.FeatureLevel* PFeatureLevelsRequested;

        [NativeName("Type", "D3D_FEATURE_LEVEL")]
        [NativeName("Type.Name", "D3D_FEATURE_LEVEL")]
        [NativeName("Name", "MaxSupportedFeatureLevel")]
        public Silk.NET.Core.Native.FeatureLevel MaxSupportedFeatureLevel;
    }
}
