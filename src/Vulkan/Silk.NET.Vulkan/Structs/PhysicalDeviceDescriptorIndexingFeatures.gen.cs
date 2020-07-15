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
    [NativeName("Name", "VkPhysicalDeviceDescriptorIndexingFeatures")]
    public unsafe partial struct PhysicalDeviceDescriptorIndexingFeatures
    {
        public PhysicalDeviceDescriptorIndexingFeatures
        (
            StructureType sType = StructureType.PhysicalDeviceDescriptorIndexingFeatures,
            void* pNext = default,
            Bool32 shaderInputAttachmentArrayDynamicIndexing = default,
            Bool32 shaderUniformTexelBufferArrayDynamicIndexing = default,
            Bool32 shaderStorageTexelBufferArrayDynamicIndexing = default,
            Bool32 shaderUniformBufferArrayNonUniformIndexing = default,
            Bool32 shaderSampledImageArrayNonUniformIndexing = default,
            Bool32 shaderStorageBufferArrayNonUniformIndexing = default,
            Bool32 shaderStorageImageArrayNonUniformIndexing = default,
            Bool32 shaderInputAttachmentArrayNonUniformIndexing = default,
            Bool32 shaderUniformTexelBufferArrayNonUniformIndexing = default,
            Bool32 shaderStorageTexelBufferArrayNonUniformIndexing = default,
            Bool32 descriptorBindingUniformBufferUpdateAfterBind = default,
            Bool32 descriptorBindingSampledImageUpdateAfterBind = default,
            Bool32 descriptorBindingStorageImageUpdateAfterBind = default,
            Bool32 descriptorBindingStorageBufferUpdateAfterBind = default,
            Bool32 descriptorBindingUniformTexelBufferUpdateAfterBind = default,
            Bool32 descriptorBindingStorageTexelBufferUpdateAfterBind = default,
            Bool32 descriptorBindingUpdateUnusedWhilePending = default,
            Bool32 descriptorBindingPartiallyBound = default,
            Bool32 descriptorBindingVariableDescriptorCount = default,
            Bool32 runtimeDescriptorArray = default
        )
        {
            SType = sType;
            PNext = pNext;
            ShaderInputAttachmentArrayDynamicIndexing = shaderInputAttachmentArrayDynamicIndexing;
            ShaderUniformTexelBufferArrayDynamicIndexing = shaderUniformTexelBufferArrayDynamicIndexing;
            ShaderStorageTexelBufferArrayDynamicIndexing = shaderStorageTexelBufferArrayDynamicIndexing;
            ShaderUniformBufferArrayNonUniformIndexing = shaderUniformBufferArrayNonUniformIndexing;
            ShaderSampledImageArrayNonUniformIndexing = shaderSampledImageArrayNonUniformIndexing;
            ShaderStorageBufferArrayNonUniformIndexing = shaderStorageBufferArrayNonUniformIndexing;
            ShaderStorageImageArrayNonUniformIndexing = shaderStorageImageArrayNonUniformIndexing;
            ShaderInputAttachmentArrayNonUniformIndexing = shaderInputAttachmentArrayNonUniformIndexing;
            ShaderUniformTexelBufferArrayNonUniformIndexing = shaderUniformTexelBufferArrayNonUniformIndexing;
            ShaderStorageTexelBufferArrayNonUniformIndexing = shaderStorageTexelBufferArrayNonUniformIndexing;
            DescriptorBindingUniformBufferUpdateAfterBind = descriptorBindingUniformBufferUpdateAfterBind;
            DescriptorBindingSampledImageUpdateAfterBind = descriptorBindingSampledImageUpdateAfterBind;
            DescriptorBindingStorageImageUpdateAfterBind = descriptorBindingStorageImageUpdateAfterBind;
            DescriptorBindingStorageBufferUpdateAfterBind = descriptorBindingStorageBufferUpdateAfterBind;
            DescriptorBindingUniformTexelBufferUpdateAfterBind = descriptorBindingUniformTexelBufferUpdateAfterBind;
            DescriptorBindingStorageTexelBufferUpdateAfterBind = descriptorBindingStorageTexelBufferUpdateAfterBind;
            DescriptorBindingUpdateUnusedWhilePending = descriptorBindingUpdateUnusedWhilePending;
            DescriptorBindingPartiallyBound = descriptorBindingPartiallyBound;
            DescriptorBindingVariableDescriptorCount = descriptorBindingVariableDescriptorCount;
            RuntimeDescriptorArray = runtimeDescriptorArray;
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
        [NativeName("Name", "shaderInputAttachmentArrayDynamicIndexing")]
        public Bool32 ShaderInputAttachmentArrayDynamicIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderUniformTexelBufferArrayDynamicIndexing")]
        public Bool32 ShaderUniformTexelBufferArrayDynamicIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageTexelBufferArrayDynamicIndexing")]
        public Bool32 ShaderStorageTexelBufferArrayDynamicIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderUniformBufferArrayNonUniformIndexing")]
        public Bool32 ShaderUniformBufferArrayNonUniformIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSampledImageArrayNonUniformIndexing")]
        public Bool32 ShaderSampledImageArrayNonUniformIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageBufferArrayNonUniformIndexing")]
        public Bool32 ShaderStorageBufferArrayNonUniformIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageImageArrayNonUniformIndexing")]
        public Bool32 ShaderStorageImageArrayNonUniformIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderInputAttachmentArrayNonUniformIndexing")]
        public Bool32 ShaderInputAttachmentArrayNonUniformIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderUniformTexelBufferArrayNonUniformIndexing")]
        public Bool32 ShaderUniformTexelBufferArrayNonUniformIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageTexelBufferArrayNonUniformIndexing")]
        public Bool32 ShaderStorageTexelBufferArrayNonUniformIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingUniformBufferUpdateAfterBind")]
        public Bool32 DescriptorBindingUniformBufferUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingSampledImageUpdateAfterBind")]
        public Bool32 DescriptorBindingSampledImageUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingStorageImageUpdateAfterBind")]
        public Bool32 DescriptorBindingStorageImageUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingStorageBufferUpdateAfterBind")]
        public Bool32 DescriptorBindingStorageBufferUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingUniformTexelBufferUpdateAfterBind")]
        public Bool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingStorageTexelBufferUpdateAfterBind")]
        public Bool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingUpdateUnusedWhilePending")]
        public Bool32 DescriptorBindingUpdateUnusedWhilePending;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingPartiallyBound")]
        public Bool32 DescriptorBindingPartiallyBound;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingVariableDescriptorCount")]
        public Bool32 DescriptorBindingVariableDescriptorCount;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "runtimeDescriptorArray")]
        public Bool32 RuntimeDescriptorArray;
    }
}
