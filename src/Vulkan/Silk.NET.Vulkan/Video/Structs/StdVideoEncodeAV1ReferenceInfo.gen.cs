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
    [NativeName("Name", "StdVideoEncodeAV1ReferenceInfo")]
    public unsafe partial struct StdVideoEncodeAV1ReferenceInfo
    {
        public StdVideoEncodeAV1ReferenceInfo
        (
            StdVideoEncodeAV1ReferenceInfoFlags? flags = null,
            uint? refFrameId = null,
            StdVideoAV1FrameType? frameType = null,
            byte? orderHint = null,
            StdVideoEncodeAV1ExtensionHeader* pExtensionHeader = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (refFrameId is not null)
            {
                RefFrameId = refFrameId.Value;
            }

            if (frameType is not null)
            {
                FrameType = frameType.Value;
            }

            if (orderHint is not null)
            {
                OrderHint = orderHint.Value;
            }

            if (pExtensionHeader is not null)
            {
                PExtensionHeader = pExtensionHeader;
            }
        }


        [NativeName("Type", "StdVideoEncodeAV1ReferenceInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeAV1ReferenceInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeAV1ReferenceInfoFlags Flags;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "RefFrameId")]
        public uint RefFrameId;

        [NativeName("Type", "StdVideoAV1FrameType")]
        [NativeName("Type.Name", "StdVideoAV1FrameType")]
        [NativeName("Name", "frame_type")]
        public StdVideoAV1FrameType FrameType;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "OrderHint")]
        public byte OrderHint;
        [NativeName("Type", "uint8_t[3]")]
        [NativeName("Type.Name", "uint8_t[3]")]
        [NativeName("Name", "reserved1")]
        public fixed byte Reserved1[3];

        [NativeName("Type", "const StdVideoEncodeAV1ExtensionHeader *")]
        [NativeName("Type.Name", "const StdVideoEncodeAV1ExtensionHeader *")]
        [NativeName("Name", "pExtensionHeader")]
        public StdVideoEncodeAV1ExtensionHeader* PExtensionHeader;
    }
}
