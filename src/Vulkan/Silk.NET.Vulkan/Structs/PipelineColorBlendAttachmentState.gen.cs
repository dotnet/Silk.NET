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
    [NativeName("Name", "VkPipelineColorBlendAttachmentState")]
    public unsafe partial struct PipelineColorBlendAttachmentState
    {
        public PipelineColorBlendAttachmentState
        (
            Bool32? blendEnable = null,
            BlendFactor? srcColorBlendFactor = null,
            BlendFactor? dstColorBlendFactor = null,
            BlendOp? colorBlendOp = null,
            BlendFactor? srcAlphaBlendFactor = null,
            BlendFactor? dstAlphaBlendFactor = null,
            BlendOp? alphaBlendOp = null,
            ColorComponentFlags? colorWriteMask = null
        ) : this()
        {
            if (blendEnable is not null)
            {
                BlendEnable = blendEnable.Value;
            }

            if (srcColorBlendFactor is not null)
            {
                SrcColorBlendFactor = srcColorBlendFactor.Value;
            }

            if (dstColorBlendFactor is not null)
            {
                DstColorBlendFactor = dstColorBlendFactor.Value;
            }

            if (colorBlendOp is not null)
            {
                ColorBlendOp = colorBlendOp.Value;
            }

            if (srcAlphaBlendFactor is not null)
            {
                SrcAlphaBlendFactor = srcAlphaBlendFactor.Value;
            }

            if (dstAlphaBlendFactor is not null)
            {
                DstAlphaBlendFactor = dstAlphaBlendFactor.Value;
            }

            if (alphaBlendOp is not null)
            {
                AlphaBlendOp = alphaBlendOp.Value;
            }

            if (colorWriteMask is not null)
            {
                ColorWriteMask = colorWriteMask.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "blendEnable")]
        public Bool32 BlendEnable;
/// <summary></summary>
        [NativeName("Type", "VkBlendFactor")]
        [NativeName("Type.Name", "VkBlendFactor")]
        [NativeName("Name", "srcColorBlendFactor")]
        public BlendFactor SrcColorBlendFactor;
/// <summary></summary>
        [NativeName("Type", "VkBlendFactor")]
        [NativeName("Type.Name", "VkBlendFactor")]
        [NativeName("Name", "dstColorBlendFactor")]
        public BlendFactor DstColorBlendFactor;
/// <summary></summary>
        [NativeName("Type", "VkBlendOp")]
        [NativeName("Type.Name", "VkBlendOp")]
        [NativeName("Name", "colorBlendOp")]
        public BlendOp ColorBlendOp;
/// <summary></summary>
        [NativeName("Type", "VkBlendFactor")]
        [NativeName("Type.Name", "VkBlendFactor")]
        [NativeName("Name", "srcAlphaBlendFactor")]
        public BlendFactor SrcAlphaBlendFactor;
/// <summary></summary>
        [NativeName("Type", "VkBlendFactor")]
        [NativeName("Type.Name", "VkBlendFactor")]
        [NativeName("Name", "dstAlphaBlendFactor")]
        public BlendFactor DstAlphaBlendFactor;
/// <summary></summary>
        [NativeName("Type", "VkBlendOp")]
        [NativeName("Type.Name", "VkBlendOp")]
        [NativeName("Name", "alphaBlendOp")]
        public BlendOp AlphaBlendOp;
/// <summary></summary>
        [NativeName("Type", "VkColorComponentFlags")]
        [NativeName("Type.Name", "VkColorComponentFlags")]
        [NativeName("Name", "colorWriteMask")]
        public ColorComponentFlags ColorWriteMask;
    }
}
