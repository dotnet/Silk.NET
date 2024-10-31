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
    [NativeName("Name", "VkPhysicalDeviceVulkanSC10Properties")]
    public unsafe partial struct PhysicalDeviceVulkanSC10Properties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceVulkanSC10Properties
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkanSC10Properties,
            void* pNext = null,
            Bool32? deviceNoDynamicHostAllocations = null,
            Bool32? deviceDestroyFreesMemory = null,
            Bool32? commandPoolMultipleCommandBuffersRecording = null,
            Bool32? commandPoolResetCommandBuffer = null,
            Bool32? commandBufferSimultaneousUse = null,
            Bool32? secondaryCommandBufferNullOrImagelessFramebuffer = null,
            Bool32? recycleDescriptorSetMemory = null,
            Bool32? recyclePipelineMemory = null,
            uint? maxRenderPassSubpasses = null,
            uint? maxRenderPassDependencies = null,
            uint? maxSubpassInputAttachments = null,
            uint? maxSubpassPreserveAttachments = null,
            uint? maxFramebufferAttachments = null,
            uint? maxDescriptorSetLayoutBindings = null,
            uint? maxQueryFaultCount = null,
            uint? maxCallbackFaultCount = null,
            uint? maxCommandPoolCommandBuffers = null,
            ulong? maxCommandBufferSize = null
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

            if (deviceNoDynamicHostAllocations is not null)
            {
                DeviceNoDynamicHostAllocations = deviceNoDynamicHostAllocations.Value;
            }

            if (deviceDestroyFreesMemory is not null)
            {
                DeviceDestroyFreesMemory = deviceDestroyFreesMemory.Value;
            }

            if (commandPoolMultipleCommandBuffersRecording is not null)
            {
                CommandPoolMultipleCommandBuffersRecording = commandPoolMultipleCommandBuffersRecording.Value;
            }

            if (commandPoolResetCommandBuffer is not null)
            {
                CommandPoolResetCommandBuffer = commandPoolResetCommandBuffer.Value;
            }

            if (commandBufferSimultaneousUse is not null)
            {
                CommandBufferSimultaneousUse = commandBufferSimultaneousUse.Value;
            }

            if (secondaryCommandBufferNullOrImagelessFramebuffer is not null)
            {
                SecondaryCommandBufferNullOrImagelessFramebuffer = secondaryCommandBufferNullOrImagelessFramebuffer.Value;
            }

            if (recycleDescriptorSetMemory is not null)
            {
                RecycleDescriptorSetMemory = recycleDescriptorSetMemory.Value;
            }

            if (recyclePipelineMemory is not null)
            {
                RecyclePipelineMemory = recyclePipelineMemory.Value;
            }

            if (maxRenderPassSubpasses is not null)
            {
                MaxRenderPassSubpasses = maxRenderPassSubpasses.Value;
            }

            if (maxRenderPassDependencies is not null)
            {
                MaxRenderPassDependencies = maxRenderPassDependencies.Value;
            }

            if (maxSubpassInputAttachments is not null)
            {
                MaxSubpassInputAttachments = maxSubpassInputAttachments.Value;
            }

            if (maxSubpassPreserveAttachments is not null)
            {
                MaxSubpassPreserveAttachments = maxSubpassPreserveAttachments.Value;
            }

            if (maxFramebufferAttachments is not null)
            {
                MaxFramebufferAttachments = maxFramebufferAttachments.Value;
            }

            if (maxDescriptorSetLayoutBindings is not null)
            {
                MaxDescriptorSetLayoutBindings = maxDescriptorSetLayoutBindings.Value;
            }

            if (maxQueryFaultCount is not null)
            {
                MaxQueryFaultCount = maxQueryFaultCount.Value;
            }

            if (maxCallbackFaultCount is not null)
            {
                MaxCallbackFaultCount = maxCallbackFaultCount.Value;
            }

            if (maxCommandPoolCommandBuffers is not null)
            {
                MaxCommandPoolCommandBuffers = maxCommandPoolCommandBuffers.Value;
            }

            if (maxCommandBufferSize is not null)
            {
                MaxCommandBufferSize = maxCommandBufferSize.Value;
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
        [NativeName("Name", "deviceNoDynamicHostAllocations")]
        public Bool32 DeviceNoDynamicHostAllocations;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "deviceDestroyFreesMemory")]
        public Bool32 DeviceDestroyFreesMemory;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "commandPoolMultipleCommandBuffersRecording")]
        public Bool32 CommandPoolMultipleCommandBuffersRecording;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "commandPoolResetCommandBuffer")]
        public Bool32 CommandPoolResetCommandBuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "commandBufferSimultaneousUse")]
        public Bool32 CommandBufferSimultaneousUse;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "secondaryCommandBufferNullOrImagelessFramebuffer")]
        public Bool32 SecondaryCommandBufferNullOrImagelessFramebuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "recycleDescriptorSetMemory")]
        public Bool32 RecycleDescriptorSetMemory;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "recyclePipelineMemory")]
        public Bool32 RecyclePipelineMemory;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxRenderPassSubpasses")]
        public uint MaxRenderPassSubpasses;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxRenderPassDependencies")]
        public uint MaxRenderPassDependencies;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSubpassInputAttachments")]
        public uint MaxSubpassInputAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSubpassPreserveAttachments")]
        public uint MaxSubpassPreserveAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFramebufferAttachments")]
        public uint MaxFramebufferAttachments;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetLayoutBindings")]
        public uint MaxDescriptorSetLayoutBindings;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxQueryFaultCount")]
        public uint MaxQueryFaultCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxCallbackFaultCount")]
        public uint MaxCallbackFaultCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxCommandPoolCommandBuffers")]
        public uint MaxCommandPoolCommandBuffers;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxCommandBufferSize")]
        public ulong MaxCommandBufferSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkanSC10Properties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
