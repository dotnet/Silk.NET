// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineColorBlendStateCreateInfo
    {
        public PipelineColorBlendStateCreateInfo
        (
            StructureType sType = StructureType.PipelineColorBlendStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            Bool32 logicOpEnable = default,
            LogicOp logicOp = default,
            uint attachmentCount = default,
            PipelineColorBlendAttachmentState* pAttachments = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           LogicOpEnable = logicOpEnable;
           LogicOp = logicOp;
           AttachmentCount = attachmentCount;
           PAttachments = pAttachments;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public Bool32 LogicOpEnable;
/// <summary></summary>
        public LogicOp LogicOp;
/// <summary></summary>
        public uint AttachmentCount;
/// <summary></summary>
        public PipelineColorBlendAttachmentState* PAttachments;
        /// <summary></summary>
       public fixed float BlendConstants[4];
    }
}
