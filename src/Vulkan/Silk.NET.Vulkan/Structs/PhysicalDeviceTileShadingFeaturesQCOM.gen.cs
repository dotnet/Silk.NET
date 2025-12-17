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
    [NativeName("Name", "VkPhysicalDeviceTileShadingFeaturesQCOM")]
    public unsafe partial struct PhysicalDeviceTileShadingFeaturesQCOM : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceTileShadingFeaturesQCOM
        (
            StructureType? sType = StructureType.PhysicalDeviceTileShadingFeaturesQCom,
            void* pNext = null,
            Bool32? tileShading = null,
            Bool32? tileShadingFragmentStage = null,
            Bool32? tileShadingColorAttachments = null,
            Bool32? tileShadingDepthAttachments = null,
            Bool32? tileShadingStencilAttachments = null,
            Bool32? tileShadingInputAttachments = null,
            Bool32? tileShadingSampledAttachments = null,
            Bool32? tileShadingPerTileDraw = null,
            Bool32? tileShadingPerTileDispatch = null,
            Bool32? tileShadingDispatchTile = null,
            Bool32? tileShadingApron = null,
            Bool32? tileShadingAnisotropicApron = null,
            Bool32? tileShadingAtomicOps = null,
            Bool32? tileShadingImageProcessing = null
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

            if (tileShading is not null)
            {
                TileShading = tileShading.Value;
            }

            if (tileShadingFragmentStage is not null)
            {
                TileShadingFragmentStage = tileShadingFragmentStage.Value;
            }

            if (tileShadingColorAttachments is not null)
            {
                TileShadingColorAttachments = tileShadingColorAttachments.Value;
            }

            if (tileShadingDepthAttachments is not null)
            {
                TileShadingDepthAttachments = tileShadingDepthAttachments.Value;
            }

            if (tileShadingStencilAttachments is not null)
            {
                TileShadingStencilAttachments = tileShadingStencilAttachments.Value;
            }

            if (tileShadingInputAttachments is not null)
            {
                TileShadingInputAttachments = tileShadingInputAttachments.Value;
            }

            if (tileShadingSampledAttachments is not null)
            {
                TileShadingSampledAttachments = tileShadingSampledAttachments.Value;
            }

            if (tileShadingPerTileDraw is not null)
            {
                TileShadingPerTileDraw = tileShadingPerTileDraw.Value;
            }

            if (tileShadingPerTileDispatch is not null)
            {
                TileShadingPerTileDispatch = tileShadingPerTileDispatch.Value;
            }

            if (tileShadingDispatchTile is not null)
            {
                TileShadingDispatchTile = tileShadingDispatchTile.Value;
            }

            if (tileShadingApron is not null)
            {
                TileShadingApron = tileShadingApron.Value;
            }

            if (tileShadingAnisotropicApron is not null)
            {
                TileShadingAnisotropicApron = tileShadingAnisotropicApron.Value;
            }

            if (tileShadingAtomicOps is not null)
            {
                TileShadingAtomicOps = tileShadingAtomicOps.Value;
            }

            if (tileShadingImageProcessing is not null)
            {
                TileShadingImageProcessing = tileShadingImageProcessing.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShading")]
        public Bool32 TileShading;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingFragmentStage")]
        public Bool32 TileShadingFragmentStage;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingColorAttachments")]
        public Bool32 TileShadingColorAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingDepthAttachments")]
        public Bool32 TileShadingDepthAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingStencilAttachments")]
        public Bool32 TileShadingStencilAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingInputAttachments")]
        public Bool32 TileShadingInputAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingSampledAttachments")]
        public Bool32 TileShadingSampledAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingPerTileDraw")]
        public Bool32 TileShadingPerTileDraw;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingPerTileDispatch")]
        public Bool32 TileShadingPerTileDispatch;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingDispatchTile")]
        public Bool32 TileShadingDispatchTile;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingApron")]
        public Bool32 TileShadingApron;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingAnisotropicApron")]
        public Bool32 TileShadingAnisotropicApron;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingAtomicOps")]
        public Bool32 TileShadingAtomicOps;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tileShadingImageProcessing")]
        public Bool32 TileShadingImageProcessing;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceTileShadingFeaturesQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
