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
    [NativeName("Name", "VkSurfacePresentScalingCapabilitiesEXT")]
    public unsafe partial struct SurfacePresentScalingCapabilitiesEXT : IExtendsChain<SurfaceCapabilities2KHR>
    {
        public SurfacePresentScalingCapabilitiesEXT
        (
            StructureType? sType = StructureType.SurfacePresentScalingCapabilitiesExt,
            void* pNext = null,
            PresentScalingFlagsEXT? supportedPresentScaling = null,
            PresentGravityFlagsEXT? supportedPresentGravityX = null,
            PresentGravityFlagsEXT? supportedPresentGravityY = null,
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
        [NativeName("Type", "VkPresentScalingFlagsEXT")]
        [NativeName("Type.Name", "VkPresentScalingFlagsEXT")]
        [NativeName("Name", "supportedPresentScaling")]
        public PresentScalingFlagsEXT SupportedPresentScaling;
/// <summary></summary>
        [NativeName("Type", "VkPresentGravityFlagsEXT")]
        [NativeName("Type.Name", "VkPresentGravityFlagsEXT")]
        [NativeName("Name", "supportedPresentGravityX")]
        public PresentGravityFlagsEXT SupportedPresentGravityX;
/// <summary></summary>
        [NativeName("Type", "VkPresentGravityFlagsEXT")]
        [NativeName("Type.Name", "VkPresentGravityFlagsEXT")]
        [NativeName("Name", "supportedPresentGravityY")]
        public PresentGravityFlagsEXT SupportedPresentGravityY;
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
            return SType = StructureType.SurfacePresentScalingCapabilitiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
