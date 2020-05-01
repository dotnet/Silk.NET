// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceDescriptorIndexingFeaturesEXT
    {
        public PhysicalDeviceDescriptorIndexingFeaturesEXT
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ShaderInputAttachmentArrayDynamicIndexing;
/// <summary></summary>
        public Bool32 ShaderUniformTexelBufferArrayDynamicIndexing;
/// <summary></summary>
        public Bool32 ShaderStorageTexelBufferArrayDynamicIndexing;
/// <summary></summary>
        public Bool32 ShaderUniformBufferArrayNonUniformIndexing;
/// <summary></summary>
        public Bool32 ShaderSampledImageArrayNonUniformIndexing;
/// <summary></summary>
        public Bool32 ShaderStorageBufferArrayNonUniformIndexing;
/// <summary></summary>
        public Bool32 ShaderStorageImageArrayNonUniformIndexing;
/// <summary></summary>
        public Bool32 ShaderInputAttachmentArrayNonUniformIndexing;
/// <summary></summary>
        public Bool32 ShaderUniformTexelBufferArrayNonUniformIndexing;
/// <summary></summary>
        public Bool32 ShaderStorageTexelBufferArrayNonUniformIndexing;
/// <summary></summary>
        public Bool32 DescriptorBindingUniformBufferUpdateAfterBind;
/// <summary></summary>
        public Bool32 DescriptorBindingSampledImageUpdateAfterBind;
/// <summary></summary>
        public Bool32 DescriptorBindingStorageImageUpdateAfterBind;
/// <summary></summary>
        public Bool32 DescriptorBindingStorageBufferUpdateAfterBind;
/// <summary></summary>
        public Bool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;
/// <summary></summary>
        public Bool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;
/// <summary></summary>
        public Bool32 DescriptorBindingUpdateUnusedWhilePending;
/// <summary></summary>
        public Bool32 DescriptorBindingPartiallyBound;
/// <summary></summary>
        public Bool32 DescriptorBindingVariableDescriptorCount;
/// <summary></summary>
        public Bool32 RuntimeDescriptorArray;
    }
}
