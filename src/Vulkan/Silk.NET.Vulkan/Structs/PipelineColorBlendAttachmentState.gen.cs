// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineColorBlendAttachmentState")]
    public unsafe struct PipelineColorBlendAttachmentState
    {
        public PipelineColorBlendAttachmentState
        (
            Bool32 blendEnable = default,
            BlendFactor srcColorBlendFactor = default,
            BlendFactor dstColorBlendFactor = default,
            BlendOp colorBlendOp = default,
            BlendFactor srcAlphaBlendFactor = default,
            BlendFactor dstAlphaBlendFactor = default,
            BlendOp alphaBlendOp = default,
            ColorComponentFlags colorWriteMask = default
        )
        {
           BlendEnable = blendEnable;
           SrcColorBlendFactor = srcColorBlendFactor;
           DstColorBlendFactor = dstColorBlendFactor;
           ColorBlendOp = colorBlendOp;
           SrcAlphaBlendFactor = srcAlphaBlendFactor;
           DstAlphaBlendFactor = dstAlphaBlendFactor;
           AlphaBlendOp = alphaBlendOp;
           ColorWriteMask = colorWriteMask;
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
