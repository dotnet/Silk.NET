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
    [NativeName("Name", "StdVideoDecodeAV1ReferenceInfo")]
    public unsafe partial struct StdVideoDecodeAV1ReferenceInfo
    {
        public StdVideoDecodeAV1ReferenceInfo
        (
            StdVideoDecodeAV1ReferenceInfoFlags? flags = null,
            byte? frameType = null,
            byte? refFrameSignBias = null,
            byte? orderHint = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (frameType is not null)
            {
                FrameType = frameType.Value;
            }

            if (refFrameSignBias is not null)
            {
                RefFrameSignBias = refFrameSignBias.Value;
            }

            if (orderHint is not null)
            {
                OrderHint = orderHint.Value;
            }
        }


        [NativeName("Type", "StdVideoDecodeAV1ReferenceInfoFlags")]
        [NativeName("Type.Name", "StdVideoDecodeAV1ReferenceInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeAV1ReferenceInfoFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "frame_type")]
        public byte FrameType;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "RefFrameSignBias")]
        public byte RefFrameSignBias;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "OrderHint")]
        public byte OrderHint;
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "SavedOrderHints")]
        public fixed byte SavedOrderHints[8];
    }
}
