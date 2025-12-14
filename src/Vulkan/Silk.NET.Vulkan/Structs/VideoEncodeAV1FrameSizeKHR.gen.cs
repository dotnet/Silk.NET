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
    [NativeName("Name", "VkVideoEncodeAV1FrameSizeKHR")]
    public unsafe partial struct VideoEncodeAV1FrameSizeKHR
    {
        public VideoEncodeAV1FrameSizeKHR
        (
            uint? intraFrameSize = null,
            uint? predictiveFrameSize = null,
            uint? bipredictiveFrameSize = null
        ) : this()
        {
            if (intraFrameSize is not null)
            {
                IntraFrameSize = intraFrameSize.Value;
            }

            if (predictiveFrameSize is not null)
            {
                PredictiveFrameSize = predictiveFrameSize.Value;
            }

            if (bipredictiveFrameSize is not null)
            {
                BipredictiveFrameSize = bipredictiveFrameSize.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "intraFrameSize")]
        public uint IntraFrameSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "predictiveFrameSize")]
        public uint PredictiveFrameSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bipredictiveFrameSize")]
        public uint BipredictiveFrameSize;
    }
}
