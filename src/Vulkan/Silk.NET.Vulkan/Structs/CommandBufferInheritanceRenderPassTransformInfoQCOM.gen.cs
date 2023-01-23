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
    [NativeName("Name", "VkCommandBufferInheritanceRenderPassTransformInfoQCOM")]
    public unsafe partial struct CommandBufferInheritanceRenderPassTransformInfoQCOM : IExtendsChain<CommandBufferInheritanceInfo>
    {
        public CommandBufferInheritanceRenderPassTransformInfoQCOM
        (
            StructureType? sType = StructureType.CommandBufferInheritanceRenderPassTransformInfoQCom,
            void* pNext = null,
            SurfaceTransformFlagsKHR? transform = null,
            Rect2D? renderArea = null
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

            if (transform is not null)
            {
                Transform = transform.Value;
            }

            if (renderArea is not null)
            {
                RenderArea = renderArea.Value;
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
        [NativeName("Type", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Name", "transform")]
        public SurfaceTransformFlagsKHR Transform;
/// <summary></summary>
        [NativeName("Type", "VkRect2D")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "renderArea")]
        public Rect2D RenderArea;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CommandBufferInheritanceRenderPassTransformInfoQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
