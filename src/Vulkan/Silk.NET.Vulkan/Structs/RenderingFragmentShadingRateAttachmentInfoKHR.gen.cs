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
    [NativeName("Name", "VkRenderingFragmentShadingRateAttachmentInfoKHR")]
    public unsafe partial struct RenderingFragmentShadingRateAttachmentInfoKHR : IExtendsChain<RenderingInfoKHR>
    {
        public RenderingFragmentShadingRateAttachmentInfoKHR
        (
            StructureType? sType = StructureType.RenderingFragmentShadingRateAttachmentInfoKhr,
            void* pNext = null,
            ImageView? imageView = null,
            ImageLayout? imageLayout = null,
            Extent2D? shadingRateAttachmentTexelSize = null
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

            if (imageView is not null)
            {
                ImageView = imageView.Value;
            }

            if (imageLayout is not null)
            {
                ImageLayout = imageLayout.Value;
            }

            if (shadingRateAttachmentTexelSize is not null)
            {
                ShadingRateAttachmentTexelSize = shadingRateAttachmentTexelSize.Value;
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
        [NativeName("Type", "VkImageView")]
        [NativeName("Type.Name", "VkImageView")]
        [NativeName("Name", "imageView")]
        public ImageView ImageView;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "imageLayout")]
        public ImageLayout ImageLayout;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "shadingRateAttachmentTexelSize")]
        public Extent2D ShadingRateAttachmentTexelSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderingFragmentShadingRateAttachmentInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
