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
    [NativeName("Name", "VkCustomResolveCreateInfoEXT")]
    public unsafe partial struct CustomResolveCreateInfoEXT : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<CommandBufferInheritanceInfo>, IExtendsChain<ShaderCreateInfoEXT>
    {
        public CustomResolveCreateInfoEXT
        (
            StructureType? sType = StructureType.CustomResolveCreateInfoExt,
            void* pNext = null,
            Bool32? customResolve = null,
            uint? colorAttachmentCount = null,
            Format* pColorAttachmentFormats = null,
            Format? depthAttachmentFormat = null,
            Format? stencilAttachmentFormat = null
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

            if (customResolve is not null)
            {
                CustomResolve = customResolve.Value;
            }

            if (colorAttachmentCount is not null)
            {
                ColorAttachmentCount = colorAttachmentCount.Value;
            }

            if (pColorAttachmentFormats is not null)
            {
                PColorAttachmentFormats = pColorAttachmentFormats;
            }

            if (depthAttachmentFormat is not null)
            {
                DepthAttachmentFormat = depthAttachmentFormat.Value;
            }

            if (stencilAttachmentFormat is not null)
            {
                StencilAttachmentFormat = stencilAttachmentFormat.Value;
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
        [NativeName("Name", "customResolve")]
        public Bool32 CustomResolve;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorAttachmentCount")]
        public uint ColorAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkFormat*")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "pColorAttachmentFormats")]
        public Format* PColorAttachmentFormats;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "depthAttachmentFormat")]
        public Format DepthAttachmentFormat;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "stencilAttachmentFormat")]
        public Format StencilAttachmentFormat;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CustomResolveCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
