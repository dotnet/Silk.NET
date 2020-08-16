// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceInlineUniformBlockFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceInlineUniformBlockFeaturesEXT
    {
        public PhysicalDeviceInlineUniformBlockFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceInlineUniformBlockFeaturesExt,
            void* pNext = default,
            Bool32 inlineUniformBlock = default,
            Bool32 descriptorBindingInlineUniformBlockUpdateAfterBind = default
        )
        {
            SType = sType;
            PNext = pNext;
            InlineUniformBlock = inlineUniformBlock;
            DescriptorBindingInlineUniformBlockUpdateAfterBind = descriptorBindingInlineUniformBlockUpdateAfterBind;
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
    }
}
