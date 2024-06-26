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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1Segmentation")]
    public unsafe partial struct StdVideoAV1Segmentation
    {
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "FeatureEnabled")]
        public fixed byte FeatureEnabled[8];
        [NativeName("Type", "int16_t[8][8]")]
        [NativeName("Type.Name", "int16_t[8][8]")]
        [NativeName("Name", "FeatureData")]
        public fixed short FeatureData[64];
    }
}
