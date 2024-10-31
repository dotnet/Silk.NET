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
    [NativeName("Name", "VkCommandBufferInheritanceViewportScissorInfoNV")]
    public unsafe partial struct CommandBufferInheritanceViewportScissorInfoNV : IExtendsChain<CommandBufferInheritanceInfo>
    {
        public CommandBufferInheritanceViewportScissorInfoNV
        (
            StructureType? sType = StructureType.CommandBufferInheritanceViewportScissorInfoNV,
            void* pNext = null,
            Bool32? viewportScissor2D = null,
            uint? viewportDepthCount = null,
            Viewport* pViewportDepths = null
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

            if (viewportScissor2D is not null)
            {
                ViewportScissor2D = viewportScissor2D.Value;
            }

            if (viewportDepthCount is not null)
            {
                ViewportDepthCount = viewportDepthCount.Value;
            }

            if (pViewportDepths is not null)
            {
                PViewportDepths = pViewportDepths;
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
        [NativeName("Name", "viewportScissor2D")]
        public Bool32 ViewportScissor2D;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewportDepthCount")]
        public uint ViewportDepthCount;
/// <summary></summary>
        [NativeName("Type", "VkViewport*")]
        [NativeName("Type.Name", "VkViewport")]
        [NativeName("Name", "pViewportDepths")]
        public Viewport* PViewportDepths;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CommandBufferInheritanceViewportScissorInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
