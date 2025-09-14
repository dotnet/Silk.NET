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
    [NativeName("Name", "VkMemoryBarrierAccessFlags3KHR")]
    public unsafe partial struct MemoryBarrierAccessFlags3KHR : IExtendsChain<SubpassDependency2>, IExtendsChain<SubpassDependency2KHR>, IExtendsChain<BufferMemoryBarrier2>, IExtendsChain<BufferMemoryBarrier2KHR>, IExtendsChain<ImageMemoryBarrier2>, IExtendsChain<ImageMemoryBarrier2KHR>
    {
        public MemoryBarrierAccessFlags3KHR
        (
            StructureType? sType = StructureType.MemoryBarrierAccessFlags3Khr,
            void* pNext = null,
            AccessFlags3KHR? srcAccessMask3 = null,
            AccessFlags3KHR? dstAccessMask3 = null
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

            if (srcAccessMask3 is not null)
            {
                SrcAccessMask3 = srcAccessMask3.Value;
            }

            if (dstAccessMask3 is not null)
            {
                DstAccessMask3 = dstAccessMask3.Value;
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
        [NativeName("Type", "VkAccessFlags3KHR")]
        [NativeName("Type.Name", "VkAccessFlags3KHR")]
        [NativeName("Name", "srcAccessMask3")]
        public AccessFlags3KHR SrcAccessMask3;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags3KHR")]
        [NativeName("Type.Name", "VkAccessFlags3KHR")]
        [NativeName("Name", "dstAccessMask3")]
        public AccessFlags3KHR DstAccessMask3;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MemoryBarrierAccessFlags3Khr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
