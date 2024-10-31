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
    [NativeName("Name", "VkPhysicalDeviceSurfaceInfo2KHR")]
    public unsafe partial struct PhysicalDeviceSurfaceInfo2KHR : IChainStart
    {
        public PhysicalDeviceSurfaceInfo2KHR
        (
            StructureType? sType = StructureType.PhysicalDeviceSurfaceInfo2Khr,
            void* pNext = null,
            SurfaceKHR? surface = null
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

            if (surface is not null)
            {
                Surface = surface.Value;
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
        [NativeName("Type", "VkSurfaceKHR")]
        [NativeName("Type.Name", "VkSurfaceKHR")]
        [NativeName("Name", "surface")]
        public SurfaceKHR Surface;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceSurfaceInfo2Khr;
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
        public static unsafe ref PhysicalDeviceSurfaceInfo2KHR Chain(
            out PhysicalDeviceSurfaceInfo2KHR capture)
        {
            capture = new PhysicalDeviceSurfaceInfo2KHR(StructureType.PhysicalDeviceSurfaceInfo2Khr);
            return ref capture;
        }
    }
}
