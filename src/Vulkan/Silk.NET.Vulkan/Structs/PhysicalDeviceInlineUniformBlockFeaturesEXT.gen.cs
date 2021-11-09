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
    [NativeName("Name", "VkPhysicalDeviceInlineUniformBlockFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceInlineUniformBlockFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceInlineUniformBlockFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceInlineUniformBlockFeaturesExt,
            void* pNext = null,
            Bool32? inlineUniformBlock = null,
            Bool32? descriptorBindingInlineUniformBlockUpdateAfterBind = null
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

            if (inlineUniformBlock is not null)
            {
                InlineUniformBlock = inlineUniformBlock.Value;
            }

            if (descriptorBindingInlineUniformBlockUpdateAfterBind is not null)
            {
                DescriptorBindingInlineUniformBlockUpdateAfterBind = descriptorBindingInlineUniformBlockUpdateAfterBind.Value;
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
        [NativeName("Name", "inlineUniformBlock")]
        public Bool32 InlineUniformBlock;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingInlineUniformBlockUpdateAfterBind")]
        public Bool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceInlineUniformBlockFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
