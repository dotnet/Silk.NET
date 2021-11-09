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
    [NativeName("Name", "VkMemoryBarrier2KHR")]
    public unsafe partial struct MemoryBarrier2KHR : IExtendsChain<SubpassDependency2>, IExtendsChain<SubpassDependency2KHR>
    {
        public MemoryBarrier2KHR
        (
            StructureType? sType = StructureType.MemoryBarrier2Khr,
            void* pNext = null,
            PipelineStageFlags2KHR? srcStageMask = null,
            AccessFlags2KHR? srcAccessMask = null,
            PipelineStageFlags2KHR? dstStageMask = null,
            AccessFlags2KHR? dstAccessMask = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (srcStageMask is not null)
            {
                SrcStageMask = srcStageMask.Value;
            }

            if (srcAccessMask is not null)
            {
                SrcAccessMask = srcAccessMask.Value;
            }

            if (dstStageMask is not null)
            {
                DstStageMask = dstStageMask.Value;
            }

            if (dstAccessMask is not null)
            {
                DstAccessMask = dstAccessMask.Value;
            }
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
        [NativeName("Type", "VkPipelineStageFlags2KHR")]
        [NativeName("Type.Name", "VkPipelineStageFlags2KHR")]
        [NativeName("Name", "srcStageMask")]
        public PipelineStageFlags2KHR SrcStageMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags2KHR")]
        [NativeName("Type.Name", "VkAccessFlags2KHR")]
        [NativeName("Name", "srcAccessMask")]
        public AccessFlags2KHR SrcAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkPipelineStageFlags2KHR")]
        [NativeName("Type.Name", "VkPipelineStageFlags2KHR")]
        [NativeName("Name", "dstStageMask")]
        public PipelineStageFlags2KHR DstStageMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags2KHR")]
        [NativeName("Type.Name", "VkAccessFlags2KHR")]
        [NativeName("Name", "dstAccessMask")]
        public AccessFlags2KHR DstAccessMask;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MemoryBarrier2Khr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
