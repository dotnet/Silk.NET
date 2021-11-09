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
    [NativeName("Name", "VkSurfaceCapabilities2KHR")]
    public unsafe partial struct SurfaceCapabilities2KHR : IChainStart
    {
        public SurfaceCapabilities2KHR
        (
            StructureType? sType = StructureType.SurfaceCapabilities2Khr,
            void* pNext = null,
            SurfaceCapabilitiesKHR? surfaceCapabilities = null
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

            if (surfaceCapabilities is not null)
            {
                SurfaceCapabilities = surfaceCapabilities.Value;
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
        [NativeName("Type", "VkSurfaceCapabilitiesKHR")]
        [NativeName("Type.Name", "VkSurfaceCapabilitiesKHR")]
        [NativeName("Name", "surfaceCapabilities")]
        public SurfaceCapabilitiesKHR SurfaceCapabilities;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SurfaceCapabilities2Khr;
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
        public static unsafe ref SurfaceCapabilities2KHR Chain(
            out SurfaceCapabilities2KHR capture)
        {
            capture = new SurfaceCapabilities2KHR(StructureType.SurfaceCapabilities2Khr);
            return ref capture;
        }
    }
}
