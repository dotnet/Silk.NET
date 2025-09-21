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
    [NativeName("Name", "VkDisplaySurfaceCreateInfoKHR")]
    public unsafe partial struct DisplaySurfaceCreateInfoKHR : IChainStart
    {
        public DisplaySurfaceCreateInfoKHR
        (
            StructureType? sType = StructureType.DisplaySurfaceCreateInfoKhr,
            void* pNext = null,
            uint? flags = null,
            DisplayModeKHR? displayMode = null,
            uint? planeIndex = null,
            uint? planeStackIndex = null,
            SurfaceTransformFlagsKHR? transform = null,
            float? globalAlpha = null,
            DisplayPlaneAlphaFlagsKHR? alphaMode = null,
            Extent2D? imageExtent = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (displayMode is not null)
            {
                DisplayMode = displayMode.Value;
            }

            if (planeIndex is not null)
            {
                PlaneIndex = planeIndex.Value;
            }

            if (planeStackIndex is not null)
            {
                PlaneStackIndex = planeStackIndex.Value;
            }

            if (transform is not null)
            {
                Transform = transform.Value;
            }

            if (globalAlpha is not null)
            {
                GlobalAlpha = globalAlpha.Value;
            }

            if (alphaMode is not null)
            {
                AlphaMode = alphaMode.Value;
            }

            if (imageExtent is not null)
            {
                ImageExtent = imageExtent.Value;
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
        [NativeName("Type", "VkDisplaySurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkDisplaySurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkDisplayModeKHR")]
        [NativeName("Type.Name", "VkDisplayModeKHR")]
        [NativeName("Name", "displayMode")]
        public DisplayModeKHR DisplayMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "planeIndex")]
        public uint PlaneIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "planeStackIndex")]
        public uint PlaneStackIndex;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Name", "transform")]
        public SurfaceTransformFlagsKHR Transform;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "globalAlpha")]
        public float GlobalAlpha;
/// <summary></summary>
        [NativeName("Type", "VkDisplayPlaneAlphaFlagBitsKHR")]
        [NativeName("Type.Name", "VkDisplayPlaneAlphaFlagBitsKHR")]
        [NativeName("Name", "alphaMode")]
        public DisplayPlaneAlphaFlagsKHR AlphaMode;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "imageExtent")]
        public Extent2D ImageExtent;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DisplaySurfaceCreateInfoKhr;
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
        public static unsafe ref DisplaySurfaceCreateInfoKHR Chain(
            out DisplaySurfaceCreateInfoKHR capture)
        {
            capture = new DisplaySurfaceCreateInfoKHR(StructureType.DisplaySurfaceCreateInfoKhr);
            return ref capture;
        }
    }
}
