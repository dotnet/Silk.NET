// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public Bool32 BlendEnable;
/// <summary></summary>
        public BlendFactor SrcColorBlendFactor;
/// <summary></summary>
        public BlendFactor DstColorBlendFactor;
/// <summary></summary>
        public BlendOp ColorBlendOp;
/// <summary></summary>
        public BlendFactor SrcAlphaBlendFactor;
/// <summary></summary>
        public BlendFactor DstAlphaBlendFactor;
/// <summary></summary>
        public BlendOp AlphaBlendOp;
/// <summary></summary>
        public ColorComponentFlags ColorWriteMask;
    }
}
