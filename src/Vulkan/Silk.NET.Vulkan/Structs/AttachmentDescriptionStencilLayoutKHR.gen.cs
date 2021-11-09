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
    [NativeName("Name", "VkAttachmentDescriptionStencilLayoutKHR")]
    [NativeName("AliasOf", "VkAttachmentDescriptionStencilLayout")]
    public unsafe partial struct AttachmentDescriptionStencilLayoutKHR : IExtendsChain<AttachmentDescription2>, IExtendsChain<AttachmentDescription2KHR>
    {
        public AttachmentDescriptionStencilLayoutKHR
        (
            StructureType? sType = StructureType.AttachmentDescriptionStencilLayout,
            void* pNext = null,
            ImageLayout? stencilInitialLayout = null,
            ImageLayout? stencilFinalLayout = null
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

            if (stencilInitialLayout is not null)
            {
                StencilInitialLayout = stencilInitialLayout.Value;
            }

            if (stencilFinalLayout is not null)
            {
                StencilFinalLayout = stencilFinalLayout.Value;
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
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "stencilInitialLayout")]
        public ImageLayout StencilInitialLayout;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "stencilFinalLayout")]
        public ImageLayout StencilFinalLayout;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AttachmentDescriptionStencilLayout;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
