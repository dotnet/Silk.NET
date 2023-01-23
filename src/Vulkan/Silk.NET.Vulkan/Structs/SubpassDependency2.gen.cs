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
    [NativeName("Name", "VkSubpassDependency2")]
    [NativeName("Aliases", "VkSubpassDependency2KHR")]
    public unsafe partial struct SubpassDependency2 : IChainStart
    {
        public SubpassDependency2
        (
            StructureType? sType = StructureType.SubpassDependency2,
            void* pNext = null,
            uint? srcSubpass = null,
            uint? dstSubpass = null,
            PipelineStageFlags? srcStageMask = null,
            PipelineStageFlags? dstStageMask = null,
            AccessFlags? srcAccessMask = null,
            AccessFlags? dstAccessMask = null,
            DependencyFlags? dependencyFlags = null,
            int? viewOffset = null
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

            if (srcSubpass is not null)
            {
                SrcSubpass = srcSubpass.Value;
            }

            if (dstSubpass is not null)
            {
                DstSubpass = dstSubpass.Value;
            }

            if (srcStageMask is not null)
            {
                SrcStageMask = srcStageMask.Value;
            }

            if (dstStageMask is not null)
            {
                DstStageMask = dstStageMask.Value;
            }

            if (srcAccessMask is not null)
            {
                SrcAccessMask = srcAccessMask.Value;
            }

            if (dstAccessMask is not null)
            {
                DstAccessMask = dstAccessMask.Value;
            }

            if (dependencyFlags is not null)
            {
                DependencyFlags = dependencyFlags.Value;
            }

            if (viewOffset is not null)
            {
                ViewOffset = viewOffset.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcSubpass")]
        public uint SrcSubpass;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstSubpass")]
        public uint DstSubpass;
/// <summary></summary>
        [NativeName("Type", "VkPipelineStageFlags")]
        [NativeName("Type.Name", "VkPipelineStageFlags")]
        [NativeName("Name", "srcStageMask")]
        public PipelineStageFlags SrcStageMask;
/// <summary></summary>
        [NativeName("Type", "VkPipelineStageFlags")]
        [NativeName("Type.Name", "VkPipelineStageFlags")]
        [NativeName("Name", "dstStageMask")]
        public PipelineStageFlags DstStageMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags")]
        [NativeName("Type.Name", "VkAccessFlags")]
        [NativeName("Name", "srcAccessMask")]
        public AccessFlags SrcAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags")]
        [NativeName("Type.Name", "VkAccessFlags")]
        [NativeName("Name", "dstAccessMask")]
        public AccessFlags DstAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkDependencyFlags")]
        [NativeName("Type.Name", "VkDependencyFlags")]
        [NativeName("Name", "dependencyFlags")]
        public DependencyFlags DependencyFlags;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "viewOffset")]
        public int ViewOffset;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SubpassDependency2;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref SubpassDependency2 Chain(
            out SubpassDependency2 capture)
        {
            capture = new SubpassDependency2(StructureType.SubpassDependency2);
            return ref capture;
        }
    }
}
