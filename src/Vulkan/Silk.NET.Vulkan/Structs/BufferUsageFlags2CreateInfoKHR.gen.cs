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
    [NativeName("Name", "VkBufferUsageFlags2CreateInfoKHR")]
    public unsafe partial struct BufferUsageFlags2CreateInfoKHR : IExtendsChain<BufferViewCreateInfo>, IExtendsChain<BufferCreateInfo>, IExtendsChain<PhysicalDeviceExternalBufferInfo>, IExtendsChain<PhysicalDeviceExternalBufferInfoKHR>, IExtendsChain<DescriptorBufferBindingInfoEXT>
    {
        public BufferUsageFlags2CreateInfoKHR
        (
            StructureType? sType = StructureType.BufferUsageFlags2CreateInfoKhr,
            void* pNext = null,
            BufferUsageFlags2KHR? usage = null
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

            if (usage is not null)
            {
                Usage = usage.Value;
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
        [NativeName("Type", "VkBufferUsageFlags2KHR")]
        [NativeName("Type.Name", "VkBufferUsageFlags2KHR")]
        [NativeName("Name", "usage")]
        public BufferUsageFlags2KHR Usage;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BufferUsageFlags2CreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
