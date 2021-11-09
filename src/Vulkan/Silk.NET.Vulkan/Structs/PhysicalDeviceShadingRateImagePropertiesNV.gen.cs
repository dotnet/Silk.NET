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
    [NativeName("Name", "VkPhysicalDeviceShadingRateImagePropertiesNV")]
    public unsafe partial struct PhysicalDeviceShadingRateImagePropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceShadingRateImagePropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceShadingRateImagePropertiesNV,
            void* pNext = null,
            Extent2D? shadingRateTexelSize = null,
            uint? shadingRatePaletteSize = null,
            uint? shadingRateMaxCoarseSamples = null
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

            if (shadingRateTexelSize is not null)
            {
                ShadingRateTexelSize = shadingRateTexelSize.Value;
            }

            if (shadingRatePaletteSize is not null)
            {
                ShadingRatePaletteSize = shadingRatePaletteSize.Value;
            }

            if (shadingRateMaxCoarseSamples is not null)
            {
                ShadingRateMaxCoarseSamples = shadingRateMaxCoarseSamples.Value;
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
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "shadingRateTexelSize")]
        public Extent2D ShadingRateTexelSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shadingRatePaletteSize")]
        public uint ShadingRatePaletteSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shadingRateMaxCoarseSamples")]
        public uint ShadingRateMaxCoarseSamples;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShadingRateImagePropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
