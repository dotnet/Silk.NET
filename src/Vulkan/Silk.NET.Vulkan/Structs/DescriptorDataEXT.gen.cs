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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkDescriptorDataEXT")]
    public unsafe partial struct DescriptorDataEXT
    {
        public DescriptorDataEXT
        (
            Sampler* pSampler = null,
            DescriptorImageInfo* pCombinedImageSampler = null,
            DescriptorImageInfo* pInputAttachmentImage = null,
            DescriptorImageInfo* pSampledImage = null,
            DescriptorImageInfo* pStorageImage = null,
            DescriptorAddressInfoEXT* pUniformTexelBuffer = null,
            DescriptorAddressInfoEXT* pStorageTexelBuffer = null,
            DescriptorAddressInfoEXT* pUniformBuffer = null,
            DescriptorAddressInfoEXT* pStorageBuffer = null,
            ulong? accelerationStructure = null
        ) : this()
        {
            if (pSampler is not null)
            {
                PSampler = pSampler;
            }

            if (pCombinedImageSampler is not null)
            {
                PCombinedImageSampler = pCombinedImageSampler;
            }

            if (pInputAttachmentImage is not null)
            {
                PInputAttachmentImage = pInputAttachmentImage;
            }

            if (pSampledImage is not null)
            {
                PSampledImage = pSampledImage;
            }

            if (pStorageImage is not null)
            {
                PStorageImage = pStorageImage;
            }

            if (pUniformTexelBuffer is not null)
            {
                PUniformTexelBuffer = pUniformTexelBuffer;
            }

            if (pStorageTexelBuffer is not null)
            {
                PStorageTexelBuffer = pStorageTexelBuffer;
            }

            if (pUniformBuffer is not null)
            {
                PUniformBuffer = pUniformBuffer;
            }

            if (pStorageBuffer is not null)
            {
                PStorageBuffer = pStorageBuffer;
            }

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkSampler*")]
        [NativeName("Type.Name", "VkSampler")]
        [NativeName("Name", "pSampler")]
        public Sampler* PSampler;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDescriptorImageInfo*")]
        [NativeName("Type.Name", "VkDescriptorImageInfo")]
        [NativeName("Name", "pCombinedImageSampler")]
        public DescriptorImageInfo* PCombinedImageSampler;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDescriptorImageInfo*")]
        [NativeName("Type.Name", "VkDescriptorImageInfo")]
        [NativeName("Name", "pInputAttachmentImage")]
        public DescriptorImageInfo* PInputAttachmentImage;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDescriptorImageInfo*")]
        [NativeName("Type.Name", "VkDescriptorImageInfo")]
        [NativeName("Name", "pSampledImage")]
        public DescriptorImageInfo* PSampledImage;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDescriptorImageInfo*")]
        [NativeName("Type.Name", "VkDescriptorImageInfo")]
        [NativeName("Name", "pStorageImage")]
        public DescriptorImageInfo* PStorageImage;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDescriptorAddressInfoEXT*")]
        [NativeName("Type.Name", "VkDescriptorAddressInfoEXT")]
        [NativeName("Name", "pUniformTexelBuffer")]
        public DescriptorAddressInfoEXT* PUniformTexelBuffer;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDescriptorAddressInfoEXT*")]
        [NativeName("Type.Name", "VkDescriptorAddressInfoEXT")]
        [NativeName("Name", "pStorageTexelBuffer")]
        public DescriptorAddressInfoEXT* PStorageTexelBuffer;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDescriptorAddressInfoEXT*")]
        [NativeName("Type.Name", "VkDescriptorAddressInfoEXT")]
        [NativeName("Name", "pUniformBuffer")]
        public DescriptorAddressInfoEXT* PUniformBuffer;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDescriptorAddressInfoEXT*")]
        [NativeName("Type.Name", "VkDescriptorAddressInfoEXT")]
        [NativeName("Name", "pStorageBuffer")]
        public DescriptorAddressInfoEXT* PStorageBuffer;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "accelerationStructure")]
        public ulong AccelerationStructure;
    }
}
