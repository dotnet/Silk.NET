// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public abstract unsafe partial class Vk : NativeAPI
    {
        public const uint AttachmentUnused = (~0U);
        public const uint False = 0;
        public const float LodClampNone = 1000.0f;
        public const uint LuidSize = 8;
        public const uint LuidSizeKhr = 8;
        public const uint MaxDescriptionSize = 256;
        public const uint MaxDeviceGroupSize = 32;
        public const uint MaxDeviceGroupSizeKhr = 32;
        public const uint MaxDriverInfoSize = 256;
        public const uint MaxDriverInfoSizeKhr = 256;
        public const uint MaxDriverNameSize = 256;
        public const uint MaxDriverNameSizeKhr = 256;
        public const uint MaxExtensionNameSize = 256;
        public const uint MaxMemoryHeaps = 16;
        public const uint MaxMemoryTypes = 32;
        public const uint MaxPhysicalDeviceNameSize = 256;
        public const uint QueueFamilyExternal = (~0U-1);
        public const uint QueueFamilyExternalKhr = (~0U-1);
        public const uint QueueFamilyForeignExt = (~0U-2);
        public const uint QueueFamilyIgnored = (~0U);
        public const uint RemainingArrayLayers = (~0U);
        public const uint RemainingMipLevels = (~0U);
        public const uint ShaderUnusedKhr = (~0U);
        public const uint ShaderUnusedNV = (~0U);
        public const uint SubpassExternal = (~0U);
        public const uint True = 1;
        public const uint UuidSize = 16;
        public const ulong WholeSize = (~0ul);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        public abstract unsafe void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        public abstract void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassBeginInfo pSubpassBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirectCount")]
        public abstract void CmdDrawIndexedIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectCount")]
        public abstract void CmdDrawIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2")]
        public abstract unsafe void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2")]
        public abstract void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        public abstract unsafe void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        public abstract void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassBeginInfo pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public abstract unsafe Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public abstract Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress")]
        public abstract unsafe ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress")]
        public abstract ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        public abstract unsafe ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        public abstract ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        public abstract unsafe ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        public abstract ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceMemoryOpaqueCaptureAddressInfo pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue")]
        public abstract unsafe Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue")]
        public abstract Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetQueryPool")]
        public abstract void ResetQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore")]
        public abstract unsafe Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreSignalInfo* pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore")]
        public abstract Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreSignalInfo pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores")]
        public abstract unsafe Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreWaitInfo* pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores")]
        public abstract Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreWaitInfo pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2")]
        public abstract unsafe Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindBufferMemoryInfo* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2")]
        public abstract Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindBufferMemoryInfo pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2")]
        public abstract unsafe Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindImageMemoryInfo* pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2")]
        public abstract Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindImageMemoryInfo pBindInfos);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchBase")]
        public abstract void CmdDispatchBase([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint baseGroupX, [Count(Count = 0)] uint baseGroupY, [Count(Count = 0)] uint baseGroupZ, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDeviceMask")]
        public abstract void CmdSetDeviceMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint deviceMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public abstract unsafe Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public abstract Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public abstract unsafe Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public abstract Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        public abstract unsafe void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        public abstract void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion")]
        public abstract unsafe void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion")]
        public abstract void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion")]
        public abstract unsafe Result EnumerateInstanceVersion([Count(Count = 0)] uint* pApiVersion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion")]
        public abstract Result EnumerateInstanceVersion([Count(Count = 0)] ref uint pApiVersion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public abstract unsafe Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public abstract Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceGroupCount, [Count(Computed = "pPhysicalDeviceGroupCount")] ref PhysicalDeviceGroupProperties pPhysicalDeviceGroupProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        public abstract unsafe void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        public abstract void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public abstract unsafe void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public abstract void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayoutSupport pSupport);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        public abstract unsafe void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] PeerMemoryFeatureFlags* pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        public abstract void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out PeerMemoryFeatureFlags pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        public abstract unsafe void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceQueueInfo2* pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        public abstract void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceQueueInfo2 pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        public abstract unsafe void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        public abstract void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public abstract unsafe void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public abstract void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public abstract unsafe void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public abstract void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public abstract unsafe void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public abstract void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalFenceInfo pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalFenceProperties pExternalFenceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public abstract unsafe void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public abstract void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalSemaphoreProperties pExternalSemaphoreProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        public abstract unsafe void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures2* pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        public abstract void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures2 pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        public abstract unsafe void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties2* pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        public abstract void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties2 pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public abstract unsafe Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public abstract Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceImageFormatInfo2 pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties2 pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        public abstract unsafe void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties2* pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        public abstract void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties2 pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2")]
        public abstract unsafe void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties2* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2")]
        public abstract void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties2 pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public abstract unsafe void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public abstract void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties2 pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public abstract unsafe void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public abstract void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkTrimCommandPool")]
        public abstract void TrimCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        public abstract unsafe void UpdateDescriptorSetWithTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        public abstract void UpdateDescriptorSetWithTemplate<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        public abstract unsafe Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] CommandBuffer* pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        public abstract Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandBufferAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] out CommandBuffer pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        public abstract unsafe Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] DescriptorSet* pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        public abstract Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] out DescriptorSet pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public abstract unsafe Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceMemory* pMemory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public abstract Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref MemoryAllocateInfo pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceMemory pMemory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer")]
        public abstract unsafe Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferBeginInfo* pBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer")]
        public abstract Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandBufferBeginInfo pBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory")]
        public abstract Result BindBufferMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory")]
        public abstract Result BindImageMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginQuery")]
        public abstract void CmdBeginQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass")]
        public abstract unsafe void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass")]
        public abstract void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        public abstract unsafe void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Computed = "dynamicOffsetCount"), Flow(FlowDirection.In)] uint* pDynamicOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        public abstract void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] ref DescriptorSet pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Computed = "dynamicOffsetCount"), Flow(FlowDirection.In)] ref uint pDynamicOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindIndexBuffer")]
        public abstract void CmdBindIndexBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] IndexType indexType);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindPipeline")]
        public abstract void CmdBindPipeline([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        public abstract unsafe void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        public abstract void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage")]
        public abstract unsafe void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageBlit* pRegions, [Count(Count = 0)] Filter filter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage")]
        public abstract void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageBlit pRegions, [Count(Count = 0)] Filter filter);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        public abstract unsafe void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Computed = "attachmentCount"), Flow(FlowDirection.In)] ClearAttachment* pAttachments, [Count(Count = 0)] uint rectCount, [Count(Computed = "rectCount"), Flow(FlowDirection.In)] ClearRect* pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        public abstract void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Computed = "attachmentCount"), Flow(FlowDirection.In)] ref ClearAttachment pAttachments, [Count(Count = 0)] uint rectCount, [Count(Computed = "rectCount"), Flow(FlowDirection.In)] ref ClearRect pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        public abstract unsafe void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearColorValue* pColor, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        public abstract void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref ClearColorValue pColor, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ref ImageSubresourceRange pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        public abstract unsafe void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearDepthStencilValue* pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        public abstract void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref ClearDepthStencilValue pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Computed = "rangeCount"), Flow(FlowDirection.In)] ref ImageSubresourceRange pRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer")]
        public abstract unsafe void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferCopy* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer")]
        public abstract void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferCopy pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage")]
        public abstract unsafe void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferImageCopy* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage")]
        public abstract void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferImageCopy pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage")]
        public abstract unsafe void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageCopy* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage")]
        public abstract void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageCopy pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer")]
        public abstract unsafe void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] BufferImageCopy* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer")]
        public abstract void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref BufferImageCopy pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyQueryPoolResults")]
        public abstract void CmdCopyQueryPoolResults([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatch")]
        public abstract void CmdDispatch([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchIndirect")]
        public abstract void CmdDispatchIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDraw")]
        public abstract void CmdDraw([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstVertex, [Count(Count = 0)] uint firstInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexed")]
        public abstract void CmdDrawIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint indexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstIndex, [Count(Count = 0)] int vertexOffset, [Count(Count = 0)] uint firstInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirect")]
        public abstract void CmdDrawIndexedIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirect")]
        public abstract void CmdDrawIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndQuery")]
        public abstract void CmdEndQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass")]
        public abstract void CmdEndRenderPass([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands")]
        public abstract unsafe void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] CommandBuffer* pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands")]
        public abstract void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] ref CommandBuffer pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdFillBuffer")]
        public abstract void CmdFillBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint data);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass")]
        public abstract void CmdNextSubpass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public abstract unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public abstract void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] ref MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ref BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ref ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants")]
        public abstract unsafe void CmdPushConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Computed = "size")] void* pValues);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants")]
        public abstract void CmdPushConstants<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Computed = "size")] ref T0 pValues) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResetEvent")]
        public abstract void CmdResetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResetQueryPool")]
        public abstract void CmdResetQueryPool([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage")]
        public abstract unsafe void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ImageResolve* pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage")]
        public abstract void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Computed = "regionCount"), Flow(FlowDirection.In)] ref ImageResolve pRegions);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetBlendConstants")]
        public abstract void CmdSetBlendConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float blendConstants);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBias")]
        public abstract void CmdSetDepthBias([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float depthBiasConstantFactor, [Count(Count = 0)] float depthBiasClamp, [Count(Count = 0)] float depthBiasSlopeFactor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBounds")]
        public abstract void CmdSetDepthBounds([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float minDepthBounds, [Count(Count = 0)] float maxDepthBounds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetEvent")]
        public abstract void CmdSetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineWidth")]
        public abstract void CmdSetLineWidth([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float lineWidth);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor")]
        public abstract unsafe void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] Rect2D* pScissors);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor")]
        public abstract void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] ref Rect2D pScissors);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilCompareMask")]
        public abstract void CmdSetStencilCompareMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint compareMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilReference")]
        public abstract void CmdSetStencilReference([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint reference);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilWriteMask")]
        public abstract void CmdSetStencilWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint writeMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport")]
        public abstract unsafe void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] Viewport* pViewports);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport")]
        public abstract void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ref Viewport pViewports);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer")]
        public abstract unsafe void CmdUpdateBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Computed = "dataSize")] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer")]
        public abstract void CmdUpdateBuffer<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Computed = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public abstract unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Computed = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public abstract void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Computed = "eventCount"), Flow(FlowDirection.In)] ref Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Computed = "memoryBarrierCount"), Flow(FlowDirection.In)] ref MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Computed = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ref BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Computed = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ref ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteTimestamp")]
        public abstract void CmdWriteTimestamp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags pipelineStage, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public abstract unsafe Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Buffer* pBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public abstract Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Buffer pBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public abstract unsafe Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferView* pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public abstract Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferView pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public abstract unsafe Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CommandPool* pCommandPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public abstract Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref CommandPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CommandPool pCommandPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public abstract unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public abstract Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref ComputePipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public abstract unsafe Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorPool* pDescriptorPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public abstract Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorPool pDescriptorPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public abstract unsafe Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayout* pSetLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public abstract Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayout pSetLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public abstract unsafe Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Device* pDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public abstract Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Device pDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public abstract unsafe Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Event* pEvent);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public abstract Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref EventCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Event pEvent);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public abstract unsafe Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Fence* pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public abstract Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FenceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Fence pFence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public abstract unsafe Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Framebuffer* pFramebuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public abstract Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FramebufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Framebuffer pFramebuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public abstract unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public abstract Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Computed = "createInfoCount"), Flow(FlowDirection.In)] ref GraphicsPipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public abstract unsafe Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Image* pImage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public abstract Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Image pImage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public abstract unsafe Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ImageView* pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public abstract Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageView pView);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public abstract unsafe Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Instance* pInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public abstract Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] ref InstanceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Instance pInstance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public abstract unsafe Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineCache* pPipelineCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public abstract Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineCacheCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineCache pPipelineCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public abstract unsafe Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineLayout* pPipelineLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public abstract Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineLayout pPipelineLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public abstract unsafe Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] QueryPool* pQueryPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public abstract Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref QueryPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out QueryPool pQueryPool);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public abstract unsafe Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public abstract Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref RenderPassCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public abstract unsafe Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Sampler* pSampler);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public abstract Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SamplerCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Sampler pSampler);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public abstract unsafe Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Semaphore* pSemaphore);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public abstract Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Semaphore pSemaphore);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public abstract unsafe Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ShaderModule* pShaderModule);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public abstract Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ShaderModule pShaderModule);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer")]
        public abstract unsafe void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer")]
        public abstract void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView")]
        public abstract unsafe void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView")]
        public abstract void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool")]
        public abstract unsafe void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool")]
        public abstract void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool")]
        public abstract unsafe void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool")]
        public abstract void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout")]
        public abstract unsafe void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout")]
        public abstract void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice")]
        public abstract unsafe void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice")]
        public abstract void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent")]
        public abstract unsafe void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent")]
        public abstract void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence")]
        public abstract unsafe void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence")]
        public abstract void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer")]
        public abstract unsafe void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer")]
        public abstract void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage")]
        public abstract unsafe void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage")]
        public abstract void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView")]
        public abstract unsafe void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView")]
        public abstract void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance")]
        public abstract unsafe void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance")]
        public abstract void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline")]
        public abstract unsafe void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline")]
        public abstract void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache")]
        public abstract unsafe void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache")]
        public abstract void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout")]
        public abstract unsafe void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout")]
        public abstract void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool")]
        public abstract unsafe void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool")]
        public abstract void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass")]
        public abstract unsafe void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass")]
        public abstract void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler")]
        public abstract unsafe void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler")]
        public abstract void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore")]
        public abstract unsafe void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore")]
        public abstract void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule")]
        public abstract unsafe void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule")]
        public abstract void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDeviceWaitIdle")]
        public abstract Result DeviceWaitIdle([Count(Count = 0)] Device device);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEndCommandBuffer")]
        public abstract Result EndCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public abstract unsafe Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public abstract Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public abstract unsafe Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public abstract Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref LayerProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public abstract unsafe Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public abstract Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public abstract unsafe Result EnumerateInstanceLayerProperties([Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public abstract Result EnumerateInstanceLayerProperties([Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref LayerProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        public abstract unsafe Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceCount, [Count(Computed = "pPhysicalDeviceCount")] PhysicalDevice* pPhysicalDevices);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        public abstract Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceCount, [Count(Computed = "pPhysicalDeviceCount")] ref PhysicalDevice pPhysicalDevices);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges")]
        public abstract unsafe Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] MappedMemoryRange* pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges")]
        public abstract Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] ref MappedMemoryRange pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers")]
        public abstract unsafe void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] CommandBuffer* pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers")]
        public abstract void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Computed = "commandBufferCount"), Flow(FlowDirection.In)] ref CommandBuffer pCommandBuffers);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets")]
        public abstract unsafe Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets")]
        public abstract Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Computed = "descriptorSetCount"), Flow(FlowDirection.In)] ref DescriptorSet pDescriptorSets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory")]
        public abstract unsafe void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory")]
        public abstract void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements")]
        public abstract unsafe void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements")]
        public abstract void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment")]
        public abstract unsafe void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pCommittedMemoryInBytes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment")]
        public abstract void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pCommittedMemoryInBytes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public abstract unsafe FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] byte* pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public abstract FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue")]
        public abstract unsafe void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue")]
        public abstract void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetEventStatus")]
        public abstract Result GetEventStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceStatus")]
        public abstract Result GetFenceStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements")]
        public abstract unsafe void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements* pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements")]
        public abstract void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements pMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public abstract unsafe void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements* pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public abstract void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements pSparseMemoryRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        public abstract unsafe void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource* pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] SubresourceLayout* pLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        public abstract void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageSubresource pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] out SubresourceLayout pLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public abstract unsafe FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public abstract FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures")]
        public abstract unsafe void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures* pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures")]
        public abstract void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        public abstract unsafe void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties* pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        public abstract void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        public abstract unsafe Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties* pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        public abstract Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        public abstract unsafe void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties* pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        public abstract void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties")]
        public abstract unsafe void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties")]
        public abstract void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public abstract unsafe void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties* pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public abstract void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public abstract unsafe void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public abstract void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        public abstract unsafe Result GetPipelineCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] UIntPtr* pDataSize, [Count(Computed = "pDataSize")] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        public abstract Result GetPipelineCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] ref UIntPtr pDataSize, [Count(Computed = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults")]
        public abstract unsafe Result GetQueryPoolResults([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults")]
        public abstract Result GetQueryPoolResults<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] UIntPtr dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity")]
        public abstract unsafe void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.Out)] Extent2D* pGranularity);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity")]
        public abstract void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.Out)] out Extent2D pGranularity);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges")]
        public abstract unsafe Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] MappedMemoryRange* pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges")]
        public abstract Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Computed = "memoryRangeCount"), Flow(FlowDirection.In)] ref MappedMemoryRange pMemoryRanges);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMapMemory")]
        public abstract unsafe Result MapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] void** ppData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMapMemory")]
        public abstract unsafe Result MapMemory<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] ref T0* ppData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches")]
        public abstract unsafe Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] PipelineCache* pSrcCaches);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches")]
        public abstract Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ref PipelineCache pSrcCaches);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse")]
        public abstract unsafe Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] BindSparseInfo* pBindInfo, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse")]
        public abstract Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Computed = "bindInfoCount"), Flow(FlowDirection.In)] ref BindSparseInfo pBindInfo, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit")]
        public abstract unsafe Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Computed = "submitCount"), Flow(FlowDirection.In)] SubmitInfo* pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit")]
        public abstract Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Computed = "submitCount"), Flow(FlowDirection.In)] ref SubmitInfo pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueWaitIdle")]
        public abstract Result QueueWaitIdle([Count(Count = 0)] Queue queue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetCommandBuffer")]
        public abstract Result ResetCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CommandBufferResetFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetCommandPool")]
        public abstract Result ResetCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] CommandPoolResetFlags flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetDescriptorPool")]
        public abstract Result ResetDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetEvent")]
        public abstract Result ResetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetFences")]
        public abstract unsafe Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] Fence* pFences);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkResetFences")]
        public abstract Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] ref Fence pFences);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetEvent")]
        public abstract Result SetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUnmapMemory")]
        public abstract void UnmapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        public abstract unsafe void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Computed = "descriptorCopyCount"), Flow(FlowDirection.In)] CopyDescriptorSet* pDescriptorCopies);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        public abstract void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] ref WriteDescriptorSet pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Computed = "descriptorCopyCount"), Flow(FlowDirection.In)] ref CopyDescriptorSet pDescriptorCopies);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences")]
        public abstract unsafe Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] Fence* pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences")]
        public abstract Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Computed = "fenceCount"), Flow(FlowDirection.In)] ref Fence pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public abstract unsafe Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public abstract Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public abstract unsafe Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public abstract Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public abstract FuncPtr GetDeviceProcAddr([Count(Count = 0)] Device device, [Flow(FlowDirection.In)] string pName);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public abstract FuncPtr GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string pName);

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceFeatures2 GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures2 ret = default;
            GetPhysicalDeviceFeatures2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceMemoryProperties2 GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties2 ret = default;
            GetPhysicalDeviceMemoryProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceProperties2 GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties2 ret = default;
            GetPhysicalDeviceProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceFeatures GetPhysicalDeviceFeature([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures ret = default;
            GetPhysicalDeviceFeatures(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceMemoryProperties GetPhysicalDeviceMemoryProperty([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties ret = default;
            GetPhysicalDeviceMemoryProperties(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe PhysicalDeviceProperties GetPhysicalDeviceProperty([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties ret = default;
            GetPhysicalDeviceProperties(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetQueryPoolResults([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] void* pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags)
        {
            // IntPtrOverloader
            return GetQueryPoolResults(device, queryPool, firstQuery, queryCount, new UIntPtr(dataSize), pData, stride, flags);
        }

        /// <summary>To be added.</summary>
        public unsafe Result GetQueryPoolResults<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] uint dataSize, [Count(Computed = "dataSize")] ref T0 pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetQueryPoolResults(device, queryPool, firstQuery, queryCount, new UIntPtr(dataSize), ref pData, stride, flags);
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new VulkanLibraryNameContainer();

        public Vk(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

