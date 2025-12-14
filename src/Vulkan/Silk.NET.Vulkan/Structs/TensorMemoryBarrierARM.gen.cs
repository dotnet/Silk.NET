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
    [NativeName("Name", "VkTensorMemoryBarrierARM")]
    public unsafe partial struct TensorMemoryBarrierARM : IExtendsChain<DependencyInfo>, IExtendsChain<DependencyInfoKHR>
    {
        public TensorMemoryBarrierARM
        (
            StructureType? sType = StructureType.TensorMemoryBarrierArm,
            void* pNext = null,
            PipelineStageFlags2? srcStageMask = null,
            AccessFlags2? srcAccessMask = null,
            PipelineStageFlags2? dstStageMask = null,
            AccessFlags2? dstAccessMask = null,
            uint? srcQueueFamilyIndex = null,
            uint? dstQueueFamilyIndex = null,
            TensorARM? tensor = null
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

            if (srcQueueFamilyIndex is not null)
            {
                SrcQueueFamilyIndex = srcQueueFamilyIndex.Value;
            }

            if (dstQueueFamilyIndex is not null)
            {
                DstQueueFamilyIndex = dstQueueFamilyIndex.Value;
            }

            if (tensor is not null)
            {
                Tensor = tensor.Value;
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
        [NativeName("Type", "VkPipelineStageFlags2")]
        [NativeName("Type.Name", "VkPipelineStageFlags2")]
        [NativeName("Name", "srcStageMask")]
        public PipelineStageFlags2 SrcStageMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags2")]
        [NativeName("Type.Name", "VkAccessFlags2")]
        [NativeName("Name", "srcAccessMask")]
        public AccessFlags2 SrcAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkPipelineStageFlags2")]
        [NativeName("Type.Name", "VkPipelineStageFlags2")]
        [NativeName("Name", "dstStageMask")]
        public PipelineStageFlags2 DstStageMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags2")]
        [NativeName("Type.Name", "VkAccessFlags2")]
        [NativeName("Name", "dstAccessMask")]
        public AccessFlags2 DstAccessMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcQueueFamilyIndex")]
        public uint SrcQueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstQueueFamilyIndex")]
        public uint DstQueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "VkTensorARM")]
        [NativeName("Type.Name", "VkTensorARM")]
        [NativeName("Name", "tensor")]
        public TensorARM Tensor;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.TensorMemoryBarrierArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
