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
    [NativeName("Name", "VkSubresourceLayout2KHR")]
    [NativeName("Aliases", "VkSubresourceLayout2EXT")]
    public unsafe partial struct SubresourceLayout2KHR : IChainStart
    {
        public SubresourceLayout2KHR
        (
            StructureType? sType = StructureType.SubresourceLayout2Khr,
            void* pNext = null,
            SubresourceLayout? subresourceLayout = null
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

            if (subresourceLayout is not null)
            {
                SubresourceLayout = subresourceLayout.Value;
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
        [NativeName("Type", "VkSubresourceLayout")]
        [NativeName("Type.Name", "VkSubresourceLayout")]
        [NativeName("Name", "subresourceLayout")]
        public SubresourceLayout SubresourceLayout;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SubresourceLayout2Khr;
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
        public static unsafe ref SubresourceLayout2KHR Chain(
            out SubresourceLayout2KHR capture)
        {
            capture = new SubresourceLayout2KHR(StructureType.SubresourceLayout2Khr);
            return ref capture;
        }
    }
}
