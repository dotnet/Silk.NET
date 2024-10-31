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
    [NativeName("Name", "VkPhysicalDeviceMaintenance7PropertiesKHR")]
    public unsafe partial struct PhysicalDeviceMaintenance7PropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceMaintenance7PropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceMaintenance7PropertiesKhr,
            void* pNext = null,
            Bool32? robustFragmentShadingRateAttachmentAccess = null,
            Bool32? separateDepthStencilAttachmentAccess = null,
            uint? maxDescriptorSetTotalUniformBuffersDynamic = null,
            uint? maxDescriptorSetTotalStorageBuffersDynamic = null,
            uint? maxDescriptorSetTotalBuffersDynamic = null,
            uint? maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic = null,
            uint? maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic = null,
            uint? maxDescriptorSetUpdateAfterBindTotalBuffersDynamic = null
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

            if (robustFragmentShadingRateAttachmentAccess is not null)
            {
                RobustFragmentShadingRateAttachmentAccess = robustFragmentShadingRateAttachmentAccess.Value;
            }

            if (separateDepthStencilAttachmentAccess is not null)
            {
                SeparateDepthStencilAttachmentAccess = separateDepthStencilAttachmentAccess.Value;
            }

            if (maxDescriptorSetTotalUniformBuffersDynamic is not null)
            {
                MaxDescriptorSetTotalUniformBuffersDynamic = maxDescriptorSetTotalUniformBuffersDynamic.Value;
            }

            if (maxDescriptorSetTotalStorageBuffersDynamic is not null)
            {
                MaxDescriptorSetTotalStorageBuffersDynamic = maxDescriptorSetTotalStorageBuffersDynamic.Value;
            }

            if (maxDescriptorSetTotalBuffersDynamic is not null)
            {
                MaxDescriptorSetTotalBuffersDynamic = maxDescriptorSetTotalBuffersDynamic.Value;
            }

            if (maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic is not null)
            {
                MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic = maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic.Value;
            }

            if (maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic is not null)
            {
                MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic = maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic.Value;
            }

            if (maxDescriptorSetUpdateAfterBindTotalBuffersDynamic is not null)
            {
                MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic = maxDescriptorSetUpdateAfterBindTotalBuffersDynamic.Value;
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
        [NativeName("Name", "robustFragmentShadingRateAttachmentAccess")]
        public Bool32 RobustFragmentShadingRateAttachmentAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "separateDepthStencilAttachmentAccess")]
        public Bool32 SeparateDepthStencilAttachmentAccess;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetTotalUniformBuffersDynamic")]
        public uint MaxDescriptorSetTotalUniformBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetTotalStorageBuffersDynamic")]
        public uint MaxDescriptorSetTotalStorageBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetTotalBuffersDynamic")]
        public uint MaxDescriptorSetTotalBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic")]
        public uint MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic")]
        public uint MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindTotalBuffersDynamic")]
        public uint MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMaintenance7PropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
