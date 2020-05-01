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
    public unsafe struct PhysicalDeviceVulkan12Features
    {
        public PhysicalDeviceVulkan12Features
        (
            StructureType sType = StructureType.PhysicalDeviceVulkan12Features,
            void* pNext = default,
            Bool32 samplerMirrorClampToEdge = default,
            Bool32 drawIndirectCount = default,
            Bool32 storageBuffer8BitAccess = default,
            Bool32 uniformAndStorageBuffer8BitAccess = default,
            Bool32 storagePushConstant8 = default,
            Bool32 shaderBufferInt64Atomics = default,
            Bool32 shaderSharedInt64Atomics = default,
            Bool32 shaderFloat16 = default,
            Bool32 shaderInt8 = default,
            Bool32 descriptorIndexing = default,
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
            Bool32 runtimeDescriptorArray = default,
            Bool32 samplerFilterMinmax = default,
            Bool32 scalarBlockLayout = default,
            Bool32 imagelessFramebuffer = default,
            Bool32 uniformBufferStandardLayout = default,
            Bool32 shaderSubgroupExtendedTypes = default,
            Bool32 separateDepthStencilLayouts = default,
            Bool32 hostQueryReset = default,
            Bool32 timelineSemaphore = default,
            Bool32 bufferDeviceAddress = default,
            Bool32 bufferDeviceAddressCaptureReplay = default,
            Bool32 bufferDeviceAddressMultiDevice = default,
            Bool32 vulkanMemoryModel = default,
            Bool32 vulkanMemoryModelDeviceScope = default,
            Bool32 vulkanMemoryModelAvailabilityVisibilityChains = default,
            Bool32 shaderOutputViewportIndex = default,
            Bool32 shaderOutputLayer = default,
            Bool32 subgroupBroadcastDynamicId = default
        )
        {
           SType = sType;
           PNext = pNext;
           SamplerMirrorClampToEdge = samplerMirrorClampToEdge;
           DrawIndirectCount = drawIndirectCount;
           StorageBuffer8BitAccess = storageBuffer8BitAccess;
           UniformAndStorageBuffer8BitAccess = uniformAndStorageBuffer8BitAccess;
           StoragePushConstant8 = storagePushConstant8;
           ShaderBufferInt64Atomics = shaderBufferInt64Atomics;
           ShaderSharedInt64Atomics = shaderSharedInt64Atomics;
           ShaderFloat16 = shaderFloat16;
           ShaderInt8 = shaderInt8;
           DescriptorIndexing = descriptorIndexing;
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
           SamplerFilterMinmax = samplerFilterMinmax;
           ScalarBlockLayout = scalarBlockLayout;
           ImagelessFramebuffer = imagelessFramebuffer;
           UniformBufferStandardLayout = uniformBufferStandardLayout;
           ShaderSubgroupExtendedTypes = shaderSubgroupExtendedTypes;
           SeparateDepthStencilLayouts = separateDepthStencilLayouts;
           HostQueryReset = hostQueryReset;
           TimelineSemaphore = timelineSemaphore;
           BufferDeviceAddress = bufferDeviceAddress;
           BufferDeviceAddressCaptureReplay = bufferDeviceAddressCaptureReplay;
           BufferDeviceAddressMultiDevice = bufferDeviceAddressMultiDevice;
           VulkanMemoryModel = vulkanMemoryModel;
           VulkanMemoryModelDeviceScope = vulkanMemoryModelDeviceScope;
           VulkanMemoryModelAvailabilityVisibilityChains = vulkanMemoryModelAvailabilityVisibilityChains;
           ShaderOutputViewportIndex = shaderOutputViewportIndex;
           ShaderOutputLayer = shaderOutputLayer;
           SubgroupBroadcastDynamicId = subgroupBroadcastDynamicId;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 SamplerMirrorClampToEdge;
/// <summary></summary>
        public Bool32 DrawIndirectCount;
/// <summary></summary>
        public Bool32 StorageBuffer8BitAccess;
/// <summary></summary>
        public Bool32 UniformAndStorageBuffer8BitAccess;
/// <summary></summary>
        public Bool32 StoragePushConstant8;
/// <summary></summary>
        public Bool32 ShaderBufferInt64Atomics;
/// <summary></summary>
        public Bool32 ShaderSharedInt64Atomics;
/// <summary></summary>
        public Bool32 ShaderFloat16;
/// <summary></summary>
        public Bool32 ShaderInt8;
/// <summary></summary>
        public Bool32 DescriptorIndexing;
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
/// <summary></summary>
        public Bool32 SamplerFilterMinmax;
/// <summary></summary>
        public Bool32 ScalarBlockLayout;
/// <summary></summary>
        public Bool32 ImagelessFramebuffer;
/// <summary></summary>
        public Bool32 UniformBufferStandardLayout;
/// <summary></summary>
        public Bool32 ShaderSubgroupExtendedTypes;
/// <summary></summary>
        public Bool32 SeparateDepthStencilLayouts;
/// <summary></summary>
        public Bool32 HostQueryReset;
/// <summary></summary>
        public Bool32 TimelineSemaphore;
/// <summary></summary>
        public Bool32 BufferDeviceAddress;
/// <summary></summary>
        public Bool32 BufferDeviceAddressCaptureReplay;
/// <summary></summary>
        public Bool32 BufferDeviceAddressMultiDevice;
/// <summary></summary>
        public Bool32 VulkanMemoryModel;
/// <summary></summary>
        public Bool32 VulkanMemoryModelDeviceScope;
/// <summary></summary>
        public Bool32 VulkanMemoryModelAvailabilityVisibilityChains;
/// <summary></summary>
        public Bool32 ShaderOutputViewportIndex;
/// <summary></summary>
        public Bool32 ShaderOutputLayer;
/// <summary></summary>
        public Bool32 SubgroupBroadcastDynamicId;
    }
}
