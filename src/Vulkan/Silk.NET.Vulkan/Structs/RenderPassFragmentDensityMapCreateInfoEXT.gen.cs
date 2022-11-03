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
    [NativeName("Name", "VkRenderPassFragmentDensityMapCreateInfoEXT")]
    public unsafe partial struct RenderPassFragmentDensityMapCreateInfoEXT : IExtendsChain<RenderPassCreateInfo>, IExtendsChain<RenderPassCreateInfo2>, IExtendsChain<RenderPassCreateInfo2KHR>
    {
        public RenderPassFragmentDensityMapCreateInfoEXT
        (
            StructureType? sType = StructureType.RenderPassFragmentDensityMapCreateInfoExt,
            void* pNext = null,
            AttachmentReference? fragmentDensityMapAttachment = null
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

            if (fragmentDensityMapAttachment is not null)
            {
                FragmentDensityMapAttachment = fragmentDensityMapAttachment.Value;
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
        [NativeName("Type", "VkAttachmentReference")]
        [NativeName("Type.Name", "VkAttachmentReference")]
        [NativeName("Name", "fragmentDensityMapAttachment")]
        public AttachmentReference FragmentDensityMapAttachment;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassFragmentDensityMapCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
