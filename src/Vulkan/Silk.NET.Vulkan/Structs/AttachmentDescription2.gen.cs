// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAttachmentDescription2")]
    public unsafe partial struct AttachmentDescription2
    {
        public AttachmentDescription2
        (
            StructureType sType = StructureType.AttachmentDescription2,
            void* pNext = default,
            AttachmentDescriptionFlags flags = default,
            Format format = default,
            SampleCountFlags samples = default,
            AttachmentLoadOp loadOp = default,
            AttachmentStoreOp storeOp = default,
            AttachmentLoadOp stencilLoadOp = default,
            AttachmentStoreOp stencilStoreOp = default,
            ImageLayout initialLayout = default,
            ImageLayout finalLayout = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            Format = format;
            Samples = samples;
            LoadOp = loadOp;
            StoreOp = storeOp;
            StencilLoadOp = stencilLoadOp;
            StencilStoreOp = stencilStoreOp;
            InitialLayout = initialLayout;
            FinalLayout = finalLayout;
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
        [NativeName("Type", "VkAttachmentDescriptionFlags")]
        [NativeName("Type.Name", "VkAttachmentDescriptionFlags")]
        [NativeName("Name", "flags")]
        public AttachmentDescriptionFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "samples")]
        public SampleCountFlags Samples;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentLoadOp")]
        [NativeName("Type.Name", "VkAttachmentLoadOp")]
        [NativeName("Name", "loadOp")]
        public AttachmentLoadOp LoadOp;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentStoreOp")]
        [NativeName("Type.Name", "VkAttachmentStoreOp")]
        [NativeName("Name", "storeOp")]
        public AttachmentStoreOp StoreOp;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentLoadOp")]
        [NativeName("Type.Name", "VkAttachmentLoadOp")]
        [NativeName("Name", "stencilLoadOp")]
        public AttachmentLoadOp StencilLoadOp;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentStoreOp")]
        [NativeName("Type.Name", "VkAttachmentStoreOp")]
        [NativeName("Name", "stencilStoreOp")]
        public AttachmentStoreOp StencilStoreOp;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "initialLayout")]
        public ImageLayout InitialLayout;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "finalLayout")]
        public ImageLayout FinalLayout;
    }
}
