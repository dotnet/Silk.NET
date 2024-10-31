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
    [NativeName("Name", "VkPipelineDiscardRectangleStateCreateInfoEXT")]
    public unsafe partial struct PipelineDiscardRectangleStateCreateInfoEXT : IExtendsChain<GraphicsPipelineCreateInfo>
    {
        public PipelineDiscardRectangleStateCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineDiscardRectangleStateCreateInfoExt,
            void* pNext = null,
            uint? flags = null,
            DiscardRectangleModeEXT? discardRectangleMode = null,
            uint? discardRectangleCount = null,
            Rect2D* pDiscardRectangles = null
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

            if (discardRectangleMode is not null)
            {
                DiscardRectangleMode = discardRectangleMode.Value;
            }

            if (discardRectangleCount is not null)
            {
                DiscardRectangleCount = discardRectangleCount.Value;
            }

            if (pDiscardRectangles is not null)
            {
                PDiscardRectangles = pDiscardRectangles;
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
        [NativeName("Type", "VkPipelineDiscardRectangleStateCreateFlagsEXT")]
        [NativeName("Type.Name", "VkPipelineDiscardRectangleStateCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkDiscardRectangleModeEXT")]
        [NativeName("Type.Name", "VkDiscardRectangleModeEXT")]
        [NativeName("Name", "discardRectangleMode")]
        public DiscardRectangleModeEXT DiscardRectangleMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "discardRectangleCount")]
        public uint DiscardRectangleCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pDiscardRectangles")]
        public Rect2D* PDiscardRectangles;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineDiscardRectangleStateCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
