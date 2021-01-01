// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_FEATURE_LEVEL")]
    public enum D3DFeatureLevel : int
    {
        [NativeName("Name", "D3D_FEATURE_LEVEL_1_0_CORE")]
        D3DFeatureLevel10Core = 0x1000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_1")]
        D3DFeatureLevel91 = 0x9100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_2")]
        D3DFeatureLevel92 = 0x9200,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_3")]
        D3DFeatureLevel93 = 0x9300,
        [NativeName("Name", "D3D_FEATURE_LEVEL_10_0")]
        D3DFeatureLevel100 = 0xA000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_10_1")]
        D3DFeatureLevel101 = 0xA100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_11_0")]
        D3DFeatureLevel110 = 0xB000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_11_1")]
        D3DFeatureLevel111 = 0xB100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_0")]
        D3DFeatureLevel120 = 0xC000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_1")]
        D3DFeatureLevel121 = 0xC100,
    }
}
