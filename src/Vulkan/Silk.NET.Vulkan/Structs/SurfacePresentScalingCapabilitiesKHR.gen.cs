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
    [NativeName("Name", "VkSurfacePresentScalingCapabilitiesKHR")]
    [NativeName("Aliases", "VkSurfacePresentScalingCapabilitiesEXT")]
    public unsafe partial struct SurfacePresentScalingCapabilitiesKHR : IExtendsChain<SurfaceCapabilities2KHR>
    {
        public SurfacePresentScalingCapabilitiesKHR
        (
            StructureType? sType = StructureType.SurfacePresentScalingCapabilitiesKhr,
            void* pNext = null,
            PresentScalingFlagsKHR? supportedPresentScaling = null,
            PresentGravityFlagsKHR? supportedPresentGravityX = null,
            PresentGravityFlagsKHR? supportedPresentGravityY = null,
            Extent2D? minScaledImageExtent = null,
            Extent2D? maxScaledImageExtent = null
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

            if (supportedPresentScaling is not null)
            {
                SupportedPresentScaling = supportedPresentScaling.Value;
            }

            if (supportedPresentGravityX is not null)
            {
                SupportedPresentGravityX = supportedPresentGravityX.Value;
            }

            if (supportedPresentGravityY is not null)
            {
                SupportedPresentGravityY = supportedPresentGravityY.Value;
            }

            if (minScaledImageExtent is not null)
            {
                MinScaledImageExtent = minScaledImageExtent.Value;
            }

            if (maxScaledImageExtent is not null)
            {
                MaxScaledImageExtent = maxScaledImageExtent.Value;
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
        [NativeName("Type", "VkPresentScalingFlagsKHR")]
        [NativeName("Type.Name", "VkPresentScalingFlagsKHR")]
        [NativeName("Name", "supportedPresentScaling")]
        public PresentScalingFlagsKHR SupportedPresentScaling;
/// <summary></summary>
        [NativeName("Type", "VkPresentGravityFlagsKHR")]
        [NativeName("Type.Name", "VkPresentGravityFlagsKHR")]
        [NativeName("Name", "supportedPresentGravityX")]
        public PresentGravityFlagsKHR SupportedPresentGravityX;
/// <summary></summary>
        [NativeName("Type", "VkPresentGravityFlagsKHR")]
        [NativeName("Type.Name", "VkPresentGravityFlagsKHR")]
        [NativeName("Name", "supportedPresentGravityY")]
        public PresentGravityFlagsKHR SupportedPresentGravityY;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minScaledImageExtent")]
        public Extent2D MinScaledImageExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxScaledImageExtent")]
        public Extent2D MaxScaledImageExtent;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SurfacePresentScalingCapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
