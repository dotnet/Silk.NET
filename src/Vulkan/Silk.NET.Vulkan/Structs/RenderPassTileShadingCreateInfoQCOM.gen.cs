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
    [NativeName("Name", "VkRenderPassTileShadingCreateInfoQCOM")]
    public unsafe partial struct RenderPassTileShadingCreateInfoQCOM : IExtendsChain<RenderPassCreateInfo>, IExtendsChain<RenderPassCreateInfo2>, IExtendsChain<RenderPassCreateInfo2KHR>, IExtendsChain<RenderingInfo>, IExtendsChain<RenderingInfoKHR>, IExtendsChain<CommandBufferInheritanceInfo>
    {
        public RenderPassTileShadingCreateInfoQCOM
        (
            StructureType? sType = StructureType.RenderPassTileShadingCreateInfoQCom,
            void* pNext = null,
            TileShadingRenderPassFlagsQCOM? flags = null,
            Extent2D? tileApronSize = null
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

            if (tileApronSize is not null)
            {
                TileApronSize = tileApronSize.Value;
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
        [NativeName("Type", "VkTileShadingRenderPassFlagsQCOM")]
        [NativeName("Type.Name", "VkTileShadingRenderPassFlagsQCOM")]
        [NativeName("Name", "flags")]
        public TileShadingRenderPassFlagsQCOM Flags;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "tileApronSize")]
        public Extent2D TileApronSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassTileShadingCreateInfoQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
