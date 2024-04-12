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
    [NativeName("Name", "StdVideoAV1GlobalMotion")]
    public unsafe partial struct StdVideoAV1GlobalMotion
    {
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "GmType")]
        public fixed byte GmType[8];
        [NativeName("Type", "int32_t[8][6]")]
        [NativeName("Type.Name", "int32_t[8][6]")]
        [NativeName("Name", "gm_params")]
        public fixed int GmParams[48];
    }
}
