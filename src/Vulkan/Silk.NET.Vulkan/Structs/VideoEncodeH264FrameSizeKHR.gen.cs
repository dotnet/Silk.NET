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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoEncodeH264FrameSizeKHR")]
    public unsafe partial struct VideoEncodeH264FrameSizeKHR
    {
        public VideoEncodeH264FrameSizeKHR
        (
            uint? frameIsize = null,
            uint? framePSize = null,
            uint? frameBSize = null
        ) : this()
        {
            if (frameIsize is not null)
            {
                FrameIsize = frameIsize.Value;
            }

            if (framePSize is not null)
            {
                FramePSize = framePSize.Value;
            }

            if (frameBSize is not null)
            {
                FrameBSize = frameBSize.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frameISize")]
        public uint FrameIsize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "framePSize")]
        public uint FramePSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frameBSize")]
        public uint FrameBSize;
    }
}
