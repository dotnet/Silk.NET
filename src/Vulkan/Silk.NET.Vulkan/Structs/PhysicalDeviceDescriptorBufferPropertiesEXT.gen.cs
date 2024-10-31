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
    [NativeName("Name", "VkPhysicalDeviceDescriptorBufferPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceDescriptorBufferPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceDescriptorBufferPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceDescriptorBufferPropertiesExt,
            void* pNext = null,
            Bool32? combinedImageSamplerDescriptorSingleArray = null,
            Bool32? bufferlessPushDescriptors = null,
            Bool32? allowSamplerImageViewPostSubmitCreation = null,
            ulong? descriptorBufferOffsetAlignment = null,
            uint? maxDescriptorBufferBindings = null,
            uint? maxResourceDescriptorBufferBindings = null,
            uint? maxSamplerDescriptorBufferBindings = null,
            uint? maxEmbeddedImmutableSamplerBindings = null,
            uint? maxEmbeddedImmutableSamplers = null,
            nuint? bufferCaptureReplayDescriptorDataSize = null,
            nuint? imageCaptureReplayDescriptorDataSize = null,
            nuint? imageViewCaptureReplayDescriptorDataSize = null,
            nuint? samplerCaptureReplayDescriptorDataSize = null,
            nuint? accelerationStructureCaptureReplayDescriptorDataSize = null,
            nuint? samplerDescriptorSize = null,
            nuint? combinedImageSamplerDescriptorSize = null,
            nuint? sampledImageDescriptorSize = null,
            nuint? storageImageDescriptorSize = null,
            nuint? uniformTexelBufferDescriptorSize = null,
            nuint? robustUniformTexelBufferDescriptorSize = null,
            nuint? storageTexelBufferDescriptorSize = null,
            nuint? robustStorageTexelBufferDescriptorSize = null,
            nuint? uniformBufferDescriptorSize = null,
            nuint? robustUniformBufferDescriptorSize = null,
            nuint? storageBufferDescriptorSize = null,
            nuint? robustStorageBufferDescriptorSize = null,
            nuint? inputAttachmentDescriptorSize = null,
            nuint? accelerationStructureDescriptorSize = null,
            ulong? maxSamplerDescriptorBufferRange = null,
            ulong? maxResourceDescriptorBufferRange = null,
            ulong? samplerDescriptorBufferAddressSpaceSize = null,
            ulong? resourceDescriptorBufferAddressSpaceSize = null,
            ulong? descriptorBufferAddressSpaceSize = null
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

            if (combinedImageSamplerDescriptorSingleArray is not null)
            {
                CombinedImageSamplerDescriptorSingleArray = combinedImageSamplerDescriptorSingleArray.Value;
            }

            if (bufferlessPushDescriptors is not null)
            {
                BufferlessPushDescriptors = bufferlessPushDescriptors.Value;
            }

            if (allowSamplerImageViewPostSubmitCreation is not null)
            {
                AllowSamplerImageViewPostSubmitCreation = allowSamplerImageViewPostSubmitCreation.Value;
            }

            if (descriptorBufferOffsetAlignment is not null)
            {
                DescriptorBufferOffsetAlignment = descriptorBufferOffsetAlignment.Value;
            }

            if (maxDescriptorBufferBindings is not null)
            {
                MaxDescriptorBufferBindings = maxDescriptorBufferBindings.Value;
            }

            if (maxResourceDescriptorBufferBindings is not null)
            {
                MaxResourceDescriptorBufferBindings = maxResourceDescriptorBufferBindings.Value;
            }

            if (maxSamplerDescriptorBufferBindings is not null)
            {
                MaxSamplerDescriptorBufferBindings = maxSamplerDescriptorBufferBindings.Value;
            }

            if (maxEmbeddedImmutableSamplerBindings is not null)
            {
                MaxEmbeddedImmutableSamplerBindings = maxEmbeddedImmutableSamplerBindings.Value;
            }

            if (maxEmbeddedImmutableSamplers is not null)
            {
                MaxEmbeddedImmutableSamplers = maxEmbeddedImmutableSamplers.Value;
            }

            if (bufferCaptureReplayDescriptorDataSize is not null)
            {
                BufferCaptureReplayDescriptorDataSize = bufferCaptureReplayDescriptorDataSize.Value;
            }

            if (imageCaptureReplayDescriptorDataSize is not null)
            {
                ImageCaptureReplayDescriptorDataSize = imageCaptureReplayDescriptorDataSize.Value;
            }

            if (imageViewCaptureReplayDescriptorDataSize is not null)
            {
                ImageViewCaptureReplayDescriptorDataSize = imageViewCaptureReplayDescriptorDataSize.Value;
            }

            if (samplerCaptureReplayDescriptorDataSize is not null)
            {
                SamplerCaptureReplayDescriptorDataSize = samplerCaptureReplayDescriptorDataSize.Value;
            }

            if (accelerationStructureCaptureReplayDescriptorDataSize is not null)
            {
                AccelerationStructureCaptureReplayDescriptorDataSize = accelerationStructureCaptureReplayDescriptorDataSize.Value;
            }

            if (samplerDescriptorSize is not null)
            {
                SamplerDescriptorSize = samplerDescriptorSize.Value;
            }

            if (combinedImageSamplerDescriptorSize is not null)
            {
                CombinedImageSamplerDescriptorSize = combinedImageSamplerDescriptorSize.Value;
            }

            if (sampledImageDescriptorSize is not null)
            {
                SampledImageDescriptorSize = sampledImageDescriptorSize.Value;
            }

            if (storageImageDescriptorSize is not null)
            {
                StorageImageDescriptorSize = storageImageDescriptorSize.Value;
            }

            if (uniformTexelBufferDescriptorSize is not null)
            {
                UniformTexelBufferDescriptorSize = uniformTexelBufferDescriptorSize.Value;
            }

            if (robustUniformTexelBufferDescriptorSize is not null)
            {
                RobustUniformTexelBufferDescriptorSize = robustUniformTexelBufferDescriptorSize.Value;
            }

            if (storageTexelBufferDescriptorSize is not null)
            {
                StorageTexelBufferDescriptorSize = storageTexelBufferDescriptorSize.Value;
            }

            if (robustStorageTexelBufferDescriptorSize is not null)
            {
                RobustStorageTexelBufferDescriptorSize = robustStorageTexelBufferDescriptorSize.Value;
            }

            if (uniformBufferDescriptorSize is not null)
            {
                UniformBufferDescriptorSize = uniformBufferDescriptorSize.Value;
            }

            if (robustUniformBufferDescriptorSize is not null)
            {
                RobustUniformBufferDescriptorSize = robustUniformBufferDescriptorSize.Value;
            }

            if (storageBufferDescriptorSize is not null)
            {
                StorageBufferDescriptorSize = storageBufferDescriptorSize.Value;
            }

            if (robustStorageBufferDescriptorSize is not null)
            {
                RobustStorageBufferDescriptorSize = robustStorageBufferDescriptorSize.Value;
            }

            if (inputAttachmentDescriptorSize is not null)
            {
                InputAttachmentDescriptorSize = inputAttachmentDescriptorSize.Value;
            }

            if (accelerationStructureDescriptorSize is not null)
            {
                AccelerationStructureDescriptorSize = accelerationStructureDescriptorSize.Value;
            }

            if (maxSamplerDescriptorBufferRange is not null)
            {
                MaxSamplerDescriptorBufferRange = maxSamplerDescriptorBufferRange.Value;
            }

            if (maxResourceDescriptorBufferRange is not null)
            {
                MaxResourceDescriptorBufferRange = maxResourceDescriptorBufferRange.Value;
            }

            if (samplerDescriptorBufferAddressSpaceSize is not null)
            {
                SamplerDescriptorBufferAddressSpaceSize = samplerDescriptorBufferAddressSpaceSize.Value;
            }

            if (resourceDescriptorBufferAddressSpaceSize is not null)
            {
                ResourceDescriptorBufferAddressSpaceSize = resourceDescriptorBufferAddressSpaceSize.Value;
            }

            if (descriptorBufferAddressSpaceSize is not null)
            {
                DescriptorBufferAddressSpaceSize = descriptorBufferAddressSpaceSize.Value;
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
        [NativeName("Name", "combinedImageSamplerDescriptorSingleArray")]
        public Bool32 CombinedImageSamplerDescriptorSingleArray;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferlessPushDescriptors")]
        public Bool32 BufferlessPushDescriptors;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "allowSamplerImageViewPostSubmitCreation")]
        public Bool32 AllowSamplerImageViewPostSubmitCreation;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "descriptorBufferOffsetAlignment")]
        public ulong DescriptorBufferOffsetAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorBufferBindings")]
        public uint MaxDescriptorBufferBindings;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxResourceDescriptorBufferBindings")]
        public uint MaxResourceDescriptorBufferBindings;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSamplerDescriptorBufferBindings")]
        public uint MaxSamplerDescriptorBufferBindings;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxEmbeddedImmutableSamplerBindings")]
        public uint MaxEmbeddedImmutableSamplerBindings;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxEmbeddedImmutableSamplers")]
        public uint MaxEmbeddedImmutableSamplers;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "bufferCaptureReplayDescriptorDataSize")]
        public nuint BufferCaptureReplayDescriptorDataSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "imageCaptureReplayDescriptorDataSize")]
        public nuint ImageCaptureReplayDescriptorDataSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "imageViewCaptureReplayDescriptorDataSize")]
        public nuint ImageViewCaptureReplayDescriptorDataSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "samplerCaptureReplayDescriptorDataSize")]
        public nuint SamplerCaptureReplayDescriptorDataSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "accelerationStructureCaptureReplayDescriptorDataSize")]
        public nuint AccelerationStructureCaptureReplayDescriptorDataSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "samplerDescriptorSize")]
        public nuint SamplerDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "combinedImageSamplerDescriptorSize")]
        public nuint CombinedImageSamplerDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "sampledImageDescriptorSize")]
        public nuint SampledImageDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "storageImageDescriptorSize")]
        public nuint StorageImageDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "uniformTexelBufferDescriptorSize")]
        public nuint UniformTexelBufferDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "robustUniformTexelBufferDescriptorSize")]
        public nuint RobustUniformTexelBufferDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "storageTexelBufferDescriptorSize")]
        public nuint StorageTexelBufferDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "robustStorageTexelBufferDescriptorSize")]
        public nuint RobustStorageTexelBufferDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "uniformBufferDescriptorSize")]
        public nuint UniformBufferDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "robustUniformBufferDescriptorSize")]
        public nuint RobustUniformBufferDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "storageBufferDescriptorSize")]
        public nuint StorageBufferDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "robustStorageBufferDescriptorSize")]
        public nuint RobustStorageBufferDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "inputAttachmentDescriptorSize")]
        public nuint InputAttachmentDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "accelerationStructureDescriptorSize")]
        public nuint AccelerationStructureDescriptorSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxSamplerDescriptorBufferRange")]
        public ulong MaxSamplerDescriptorBufferRange;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxResourceDescriptorBufferRange")]
        public ulong MaxResourceDescriptorBufferRange;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "samplerDescriptorBufferAddressSpaceSize")]
        public ulong SamplerDescriptorBufferAddressSpaceSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "resourceDescriptorBufferAddressSpaceSize")]
        public ulong ResourceDescriptorBufferAddressSpaceSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "descriptorBufferAddressSpaceSize")]
        public ulong DescriptorBufferAddressSpaceSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDescriptorBufferPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
