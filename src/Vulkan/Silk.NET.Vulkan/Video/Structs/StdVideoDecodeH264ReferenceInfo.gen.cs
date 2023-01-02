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
    [NativeName("Name", "StdVideoDecodeH264ReferenceInfo")]
    public unsafe partial struct StdVideoDecodeH264ReferenceInfo
    {
        public StdVideoDecodeH264ReferenceInfo
        (
            StdVideoDecodeH264ReferenceInfoFlags? flags = null,
            ushort? frameNum = null,
            ushort? reserved = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (frameNum is not null)
            {
                FrameNum = frameNum.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "StdVideoDecodeH264ReferenceInfoFlags")]
        [NativeName("Type.Name", "StdVideoDecodeH264ReferenceInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeH264ReferenceInfoFlags Flags;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "FrameNum")]
        public ushort FrameNum;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "reserved")]
        public ushort Reserved;
        [NativeName("Type", "int32_t[2]")]
        [NativeName("Type.Name", "int32_t[2]")]
        [NativeName("Name", "PicOrderCnt")]
        public fixed int PicOrderCnt[2];
    }
}
