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
    [NativeName("Name", "VkPhysicalDeviceVulkan12Features")]
    public unsafe partial struct PhysicalDeviceVulkan12Features : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceVulkan12Features
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkan12Features,
            void* pNext = null,
            Bool32? samplerMirrorClampToEdge = null,
            Bool32? drawIndirectCount = null,
            Bool32? storageBuffer8BitAccess = null,
            Bool32? uniformAndStorageBuffer8BitAccess = null,
            Bool32? storagePushConstant8 = null,
            Bool32? shaderBufferInt64Atomics = null,
            Bool32? shaderSharedInt64Atomics = null,
            Bool32? shaderFloat16 = null,
            Bool32? shaderInt8 = null,
            Bool32? descriptorIndexing = null,
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
            Bool32? runtimeDescriptorArray = null,
            Bool32? samplerFilterMinmax = null,
            Bool32? scalarBlockLayout = null,
            Bool32? imagelessFramebuffer = null,
            Bool32? uniformBufferStandardLayout = null,
            Bool32? shaderSubgroupExtendedTypes = null,
            Bool32? separateDepthStencilLayouts = null,
            Bool32? hostQueryReset = null,
            Bool32? timelineSemaphore = null,
            Bool32? bufferDeviceAddress = null,
            Bool32? bufferDeviceAddressCaptureReplay = null,
            Bool32? bufferDeviceAddressMultiDevice = null,
            Bool32? vulkanMemoryModel = null,
            Bool32? vulkanMemoryModelDeviceScope = null,
            Bool32? vulkanMemoryModelAvailabilityVisibilityChains = null,
            Bool32? shaderOutputViewportIndex = null,
            Bool32? shaderOutputLayer = null,
            Bool32? subgroupBroadcastDynamicId = null
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

            if (samplerMirrorClampToEdge is not null)
            {
                SamplerMirrorClampToEdge = samplerMirrorClampToEdge.Value;
            }

            if (drawIndirectCount is not null)
            {
                DrawIndirectCount = drawIndirectCount.Value;
            }

            if (storageBuffer8BitAccess is not null)
            {
                StorageBuffer8BitAccess = storageBuffer8BitAccess.Value;
            }

            if (uniformAndStorageBuffer8BitAccess is not null)
            {
                UniformAndStorageBuffer8BitAccess = uniformAndStorageBuffer8BitAccess.Value;
            }

            if (storagePushConstant8 is not null)
            {
                StoragePushConstant8 = storagePushConstant8.Value;
            }

            if (shaderBufferInt64Atomics is not null)
            {
                ShaderBufferInt64Atomics = shaderBufferInt64Atomics.Value;
            }

            if (shaderSharedInt64Atomics is not null)
            {
                ShaderSharedInt64Atomics = shaderSharedInt64Atomics.Value;
            }

            if (shaderFloat16 is not null)
            {
                ShaderFloat16 = shaderFloat16.Value;
            }

            if (shaderInt8 is not null)
            {
                ShaderInt8 = shaderInt8.Value;
            }

            if (descriptorIndexing is not null)
            {
                DescriptorIndexing = descriptorIndexing.Value;
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

            if (samplerFilterMinmax is not null)
            {
                SamplerFilterMinmax = samplerFilterMinmax.Value;
            }

            if (scalarBlockLayout is not null)
            {
                ScalarBlockLayout = scalarBlockLayout.Value;
            }

            if (imagelessFramebuffer is not null)
            {
                ImagelessFramebuffer = imagelessFramebuffer.Value;
            }

            if (uniformBufferStandardLayout is not null)
            {
                UniformBufferStandardLayout = uniformBufferStandardLayout.Value;
            }

            if (shaderSubgroupExtendedTypes is not null)
            {
                ShaderSubgroupExtendedTypes = shaderSubgroupExtendedTypes.Value;
            }

            if (separateDepthStencilLayouts is not null)
            {
                SeparateDepthStencilLayouts = separateDepthStencilLayouts.Value;
            }

            if (hostQueryReset is not null)
            {
                HostQueryReset = hostQueryReset.Value;
            }

            if (timelineSemaphore is not null)
            {
                TimelineSemaphore = timelineSemaphore.Value;
            }

            if (bufferDeviceAddress is not null)
            {
                BufferDeviceAddress = bufferDeviceAddress.Value;
            }

            if (bufferDeviceAddressCaptureReplay is not null)
            {
                BufferDeviceAddressCaptureReplay = bufferDeviceAddressCaptureReplay.Value;
            }

            if (bufferDeviceAddressMultiDevice is not null)
            {
                BufferDeviceAddressMultiDevice = bufferDeviceAddressMultiDevice.Value;
            }

            if (vulkanMemoryModel is not null)
            {
                VulkanMemoryModel = vulkanMemoryModel.Value;
            }

            if (vulkanMemoryModelDeviceScope is not null)
            {
                VulkanMemoryModelDeviceScope = vulkanMemoryModelDeviceScope.Value;
            }

            if (vulkanMemoryModelAvailabilityVisibilityChains is not null)
            {
                VulkanMemoryModelAvailabilityVisibilityChains = vulkanMemoryModelAvailabilityVisibilityChains.Value;
            }

            if (shaderOutputViewportIndex is not null)
            {
                ShaderOutputViewportIndex = shaderOutputViewportIndex.Value;
            }

            if (shaderOutputLayer is not null)
            {
                ShaderOutputLayer = shaderOutputLayer.Value;
            }

            if (subgroupBroadcastDynamicId is not null)
            {
                SubgroupBroadcastDynamicId = subgroupBroadcastDynamicId.Value;
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
        [NativeName("Name", "samplerMirrorClampToEdge")]
        public Bool32 SamplerMirrorClampToEdge;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "drawIndirectCount")]
        public Bool32 DrawIndirectCount;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "storageBuffer8BitAccess")]
        public Bool32 StorageBuffer8BitAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "uniformAndStorageBuffer8BitAccess")]
        public Bool32 UniformAndStorageBuffer8BitAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "storagePushConstant8")]
        public Bool32 StoragePushConstant8;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBufferInt64Atomics")]
        public Bool32 ShaderBufferInt64Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedInt64Atomics")]
        public Bool32 ShaderSharedInt64Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderFloat16")]
        public Bool32 ShaderFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderInt8")]
        public Bool32 ShaderInt8;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorIndexing")]
        public Bool32 DescriptorIndexing;
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
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "samplerFilterMinmax")]
        public Bool32 SamplerFilterMinmax;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "scalarBlockLayout")]
        public Bool32 ScalarBlockLayout;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "imagelessFramebuffer")]
        public Bool32 ImagelessFramebuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "uniformBufferStandardLayout")]
        public Bool32 UniformBufferStandardLayout;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSubgroupExtendedTypes")]
        public Bool32 ShaderSubgroupExtendedTypes;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "separateDepthStencilLayouts")]
        public Bool32 SeparateDepthStencilLayouts;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "hostQueryReset")]
        public Bool32 HostQueryReset;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "timelineSemaphore")]
        public Bool32 TimelineSemaphore;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddress")]
        public Bool32 BufferDeviceAddress;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddressCaptureReplay")]
        public Bool32 BufferDeviceAddressCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddressMultiDevice")]
        public Bool32 BufferDeviceAddressMultiDevice;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vulkanMemoryModel")]
        public Bool32 VulkanMemoryModel;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vulkanMemoryModelDeviceScope")]
        public Bool32 VulkanMemoryModelDeviceScope;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vulkanMemoryModelAvailabilityVisibilityChains")]
        public Bool32 VulkanMemoryModelAvailabilityVisibilityChains;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderOutputViewportIndex")]
        public Bool32 ShaderOutputViewportIndex;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderOutputLayer")]
        public Bool32 ShaderOutputLayer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "subgroupBroadcastDynamicId")]
        public Bool32 SubgroupBroadcastDynamicId;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkan12Features;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
