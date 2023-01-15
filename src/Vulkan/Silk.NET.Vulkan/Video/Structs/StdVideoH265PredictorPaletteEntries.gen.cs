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
    [NativeName("Name", "StdVideoH265PredictorPaletteEntries")]
    public unsafe partial struct StdVideoH265PredictorPaletteEntries
    {
        [NativeName("Type", "uint16_t[3][128]")]
        [NativeName("Type.Name", "uint16_t[3][128]")]
        [NativeName("Name", "PredictorPaletteEntries")]
        public fixed ushort PredictorPaletteEntries[384];
    }
}
