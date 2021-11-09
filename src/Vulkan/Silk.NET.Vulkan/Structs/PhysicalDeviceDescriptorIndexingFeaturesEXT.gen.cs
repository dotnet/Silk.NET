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
    [NativeName("Name", "VkPhysicalDeviceDescriptorIndexingFeaturesEXT")]
    [NativeName("AliasOf", "VkPhysicalDeviceDescriptorIndexingFeatures")]
    public unsafe partial struct PhysicalDeviceDescriptorIndexingFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceDescriptorIndexingFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceDescriptorIndexingFeatures,
            void* pNext = null,
            Bool32? shaderInputAttachmentArrayDynamicIndexing = null,
            Bool32? shaderUniformTexelBufferArrayDynamicIndexing = null,
            Bool32? shaderStorageTexelBufferArrayDynamicIndexing = null,
            Bool32? shaderUniformBufferArrayNonUniformIndexing = null,
            Bool32? shaderSampledImageArrayNonUniformIndexing = null,
            Bool32? shaderStorageBufferArrayNonUniformIndexing = null,
            Bool32? shaderStorageImageArrayNonUniformIndexing = null,
            Bool32? shaderInputAttachmentArrayNonUniformIndexing = null,
            Bool32? shaderUniformTexelBufferArrayNonUniformIndexing = null,
            Bool32? shaderStorageTexelBufferArrayNonUniformIndexing = null,
            Bool32? descriptorBindingUniformBufferUpdateAfterBind = null,
            Bool32? descriptorBindingSampledImageUpdateAfterBind = null,
            Bool32? descriptorBindingStorageImageUpdateAfterBind = null,
            Bool32? descriptorBindingStorageBufferUpdateAfterBind = null,
            Bool32? descriptorBindingUniformTexelBufferUpdateAfterBind = null,
            Bool32? descriptorBindingStorageTexelBufferUpdateAfterBind = null,
            Bool32? descriptorBindingUpdateUnusedWhilePending = null,
            Bool32? descriptorBindingPartiallyBound = null,
            Bool32? descriptorBindingVariableDescriptorCount = null,
            Bool32? runtimeDescriptorArray = null
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

            if (shaderInputAttachmentArrayDynamicIndexing is not null)
            {
                ShaderInputAttachmentArrayDynamicIndexing = shaderInputAttachmentArrayDynamicIndexing.Value;
            }

            if (shaderUniformTexelBufferArrayDynamicIndexing is not null)
            {
                ShaderUniformTexelBufferArrayDynamicIndexing = shaderUniformTexelBufferArrayDynamicIndexing.Value;
            }

            if (shaderStorageTexelBufferArrayDynamicIndexing is not null)
            {
                ShaderStorageTexelBufferArrayDynamicIndexing = shaderStorageTexelBufferArrayDynamicIndexing.Value;
            }

            if (shaderUniformBufferArrayNonUniformIndexing is not null)
            {
                ShaderUniformBufferArrayNonUniformIndexing = shaderUniformBufferArrayNonUniformIndexing.Value;
            }

            if (shaderSampledImageArrayNonUniformIndexing is not null)
            {
                ShaderSampledImageArrayNonUniformIndexing = shaderSampledImageArrayNonUniformIndexing.Value;
            }

            if (shaderStorageBufferArrayNonUniformIndexing is not null)
            {
                ShaderStorageBufferArrayNonUniformIndexing = shaderStorageBufferArrayNonUniformIndexing.Value;
            }

            if (shaderStorageImageArrayNonUniformIndexing is not null)
            {
                ShaderStorageImageArrayNonUniformIndexing = shaderStorageImageArrayNonUniformIndexing.Value;
            }

            if (shaderInputAttachmentArrayNonUniformIndexing is not null)
            {
                ShaderInputAttachmentArrayNonUniformIndexing = shaderInputAttachmentArrayNonUniformIndexing.Value;
            }

            if (shaderUniformTexelBufferArrayNonUniformIndexing is not null)
            {
                ShaderUniformTexelBufferArrayNonUniformIndexing = shaderUniformTexelBufferArrayNonUniformIndexing.Value;
            }

            if (shaderStorageTexelBufferArrayNonUniformIndexing is not null)
            {
                ShaderStorageTexelBufferArrayNonUniformIndexing = shaderStorageTexelBufferArrayNonUniformIndexing.Value;
            }

            if (descriptorBindingUniformBufferUpdateAfterBind is not null)
            {
                DescriptorBindingUniformBufferUpdateAfterBind = descriptorBindingUniformBufferUpdateAfterBind.Value;
            }

            if (descriptorBindingSampledImageUpdateAfterBind is not null)
            {
                DescriptorBindingSampledImageUpdateAfterBind = descriptorBindingSampledImageUpdateAfterBind.Value;
            }

            if (descriptorBindingStorageImageUpdateAfterBind is not null)
            {
                DescriptorBindingStorageImageUpdateAfterBind = descriptorBindingStorageImageUpdateAfterBind.Value;
            }

            if (descriptorBindingStorageBufferUpdateAfterBind is not null)
            {
                DescriptorBindingStorageBufferUpdateAfterBind = descriptorBindingStorageBufferUpdateAfterBind.Value;
            }

            if (descriptorBindingUniformTexelBufferUpdateAfterBind is not null)
            {
                DescriptorBindingUniformTexelBufferUpdateAfterBind = descriptorBindingUniformTexelBufferUpdateAfterBind.Value;
            }

            if (descriptorBindingStorageTexelBufferUpdateAfterBind is not null)
            {
                DescriptorBindingStorageTexelBufferUpdateAfterBind = descriptorBindingStorageTexelBufferUpdateAfterBind.Value;
            }

            if (descriptorBindingUpdateUnusedWhilePending is not null)
            {
                DescriptorBindingUpdateUnusedWhilePending = descriptorBindingUpdateUnusedWhilePending.Value;
            }

            if (descriptorBindingPartiallyBound is not null)
            {
                DescriptorBindingPartiallyBound = descriptorBindingPartiallyBound.Value;
            }

            if (descriptorBindingVariableDescriptorCount is not null)
            {
                DescriptorBindingVariableDescriptorCount = descriptorBindingVariableDescriptorCount.Value;
            }

            if (runtimeDescriptorArray is not null)
            {
                RuntimeDescriptorArray = runtimeDescriptorArray.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDescriptorIndexingFeatures;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
