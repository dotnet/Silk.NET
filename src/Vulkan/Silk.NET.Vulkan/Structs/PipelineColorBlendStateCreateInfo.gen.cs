// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineColorBlendStateCreateInfo")]
    public unsafe partial struct PipelineColorBlendStateCreateInfo
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
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkPipelineColorBlendStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineColorBlendStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "logicOpEnable")]
        public Bool32 LogicOpEnable;
/// <summary></summary>
        [NativeName("Type", "VkLogicOp")]
        [NativeName("Type.Name", "VkLogicOp")]
        [NativeName("Name", "logicOp")]
        public LogicOp LogicOp;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "attachmentCount")]
        public uint AttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineColorBlendAttachmentState*")]
        [NativeName("Type.Name", "VkPipelineColorBlendAttachmentState")]
        [NativeName("Name", "pAttachments")]
        public PipelineColorBlendAttachmentState* PAttachments;
        /// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "blendConstants")]
        public fixed float BlendConstants[4];
    }
}
