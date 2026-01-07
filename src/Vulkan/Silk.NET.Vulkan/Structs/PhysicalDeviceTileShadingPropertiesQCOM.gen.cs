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
    [NativeName("Name", "VkPhysicalDeviceTileShadingPropertiesQCOM")]
    public unsafe partial struct PhysicalDeviceTileShadingPropertiesQCOM : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceTileShadingPropertiesQCOM
        (
            StructureType? sType = StructureType.PhysicalDeviceTileShadingPropertiesQCom,
            void* pNext = null,
            uint? maxApronSize = null,
            Bool32? preferNonCoherent = null,
            Extent2D? tileGranularity = null,
            Extent2D? maxTileShadingRate = null
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

            if (maxApronSize is not null)
            {
                MaxApronSize = maxApronSize.Value;
            }

            if (preferNonCoherent is not null)
            {
                PreferNonCoherent = preferNonCoherent.Value;
            }

            if (tileGranularity is not null)
            {
                TileGranularity = tileGranularity.Value;
            }

            if (maxTileShadingRate is not null)
            {
                MaxTileShadingRate = maxTileShadingRate.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxApronSize")]
        public uint MaxApronSize;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "preferNonCoherent")]
        public Bool32 PreferNonCoherent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "tileGranularity")]
        public Extent2D TileGranularity;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxTileShadingRate")]
        public Extent2D MaxTileShadingRate;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceTileShadingPropertiesQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
