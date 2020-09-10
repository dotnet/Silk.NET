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
    public enum FeatureLevel
    {
        [NativeName("Name", "D3D_FEATURE_LEVEL_1_0_CORE")]
        FeatureLevel10Core = 0x1000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_1")]
        FeatureLevel91 = 0x9100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_2")]
        FeatureLevel92 = 0x9200,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_3")]
        FeatureLevel93 = 0x9300,
        [NativeName("Name", "D3D_FEATURE_LEVEL_10_0")]
        FeatureLevel100 = 0xA000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_10_1")]
        FeatureLevel101 = 0xA100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_11_0")]
        FeatureLevel110 = 0xB000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_11_1")]
        FeatureLevel111 = 0xB100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_0")]
        FeatureLevel120 = 0xC000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_1")]
        FeatureLevel121 = 0xC100,
    }
}
