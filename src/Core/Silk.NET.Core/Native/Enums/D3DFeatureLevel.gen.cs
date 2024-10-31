// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_FEATURE_LEVEL")]
    public enum D3DFeatureLevel : int
    {
        [Obsolete("Deprecated in favour of \"Level10Generic\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_1_0_GENERIC")]
        D3DFeatureLevel10Generic = 0x100,
        [Obsolete("Deprecated in favour of \"Level10Core\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_1_0_CORE")]
        D3DFeatureLevel10Core = 0x1000,
        [Obsolete("Deprecated in favour of \"Level91\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_1")]
        D3DFeatureLevel91 = 0x9100,
        [Obsolete("Deprecated in favour of \"Level92\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_2")]
        D3DFeatureLevel92 = 0x9200,
        [Obsolete("Deprecated in favour of \"Level93\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_3")]
        D3DFeatureLevel93 = 0x9300,
        [Obsolete("Deprecated in favour of \"Level100\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_10_0")]
        D3DFeatureLevel100 = 0xA000,
        [Obsolete("Deprecated in favour of \"Level101\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_10_1")]
        D3DFeatureLevel101 = 0xA100,
        [Obsolete("Deprecated in favour of \"Level110\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_11_0")]
        D3DFeatureLevel110 = 0xB000,
        [Obsolete("Deprecated in favour of \"Level111\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_11_1")]
        D3DFeatureLevel111 = 0xB100,
        [Obsolete("Deprecated in favour of \"Level120\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_0")]
        D3DFeatureLevel120 = 0xC000,
        [Obsolete("Deprecated in favour of \"Level121\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_1")]
        D3DFeatureLevel121 = 0xC100,
        [Obsolete("Deprecated in favour of \"Level122\"")]
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_2")]
        D3DFeatureLevel122 = 0xC200,
        [NativeName("Name", "D3D_FEATURE_LEVEL_1_0_GENERIC")]
        Level10Generic = 0x100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_1_0_CORE")]
        Level10Core = 0x1000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_1")]
        Level91 = 0x9100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_2")]
        Level92 = 0x9200,
        [NativeName("Name", "D3D_FEATURE_LEVEL_9_3")]
        Level93 = 0x9300,
        [NativeName("Name", "D3D_FEATURE_LEVEL_10_0")]
        Level100 = 0xA000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_10_1")]
        Level101 = 0xA100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_11_0")]
        Level110 = 0xB000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_11_1")]
        Level111 = 0xB100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_0")]
        Level120 = 0xC000,
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_1")]
        Level121 = 0xC100,
        [NativeName("Name", "D3D_FEATURE_LEVEL_12_2")]
        Level122 = 0xC200,
    }
}
