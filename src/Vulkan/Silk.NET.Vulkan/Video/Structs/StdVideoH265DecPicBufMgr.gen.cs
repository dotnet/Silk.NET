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
    [NativeName("Name", "StdVideoH265DecPicBufMgr")]
    public unsafe partial struct StdVideoH265DecPicBufMgr
    {
        [NativeName("Type", "uint32_t[7]")]
        [NativeName("Type.Name", "uint32_t[7]")]
        [NativeName("Name", "max_latency_increase_plus1")]
        public fixed uint MaxLatencyIncreasePlus1[7];
        [NativeName("Type", "uint8_t[7]")]
        [NativeName("Type.Name", "uint8_t[7]")]
        [NativeName("Name", "max_dec_pic_buffering_minus1")]
        public fixed byte MaxDecPicBufferingMinus1[7];
        [NativeName("Type", "uint8_t[7]")]
        [NativeName("Type.Name", "uint8_t[7]")]
        [NativeName("Name", "max_num_reorder_pics")]
        public fixed byte MaxNumReorderPics[7];
    }
}
