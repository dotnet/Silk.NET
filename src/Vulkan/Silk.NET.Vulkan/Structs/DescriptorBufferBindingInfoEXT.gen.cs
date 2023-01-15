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
    [NativeName("Name", "VkDescriptorBufferBindingInfoEXT")]
    public unsafe partial struct DescriptorBufferBindingInfoEXT : IChainStart
    {
        public DescriptorBufferBindingInfoEXT
        (
            StructureType? sType = StructureType.DescriptorBufferBindingInfoExt,
            void* pNext = null,
            ulong? address = null,
            BufferUsageFlags? usage = null
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

            if (address is not null)
            {
                Address = address.Value;
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
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "address")]
        public ulong Address;
/// <summary></summary>
        [NativeName("Type", "VkBufferUsageFlags")]
        [NativeName("Type.Name", "VkBufferUsageFlags")]
        [NativeName("Name", "usage")]
        public BufferUsageFlags Usage;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DescriptorBufferBindingInfoExt;
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
        public static unsafe ref DescriptorBufferBindingInfoEXT Chain(
            out DescriptorBufferBindingInfoEXT capture)
        {
            capture = new DescriptorBufferBindingInfoEXT(StructureType.DescriptorBufferBindingInfoExt);
            return ref capture;
        }
    }
}
