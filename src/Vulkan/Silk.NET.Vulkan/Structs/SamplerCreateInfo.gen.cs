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
    [NativeName("Name", "VkSamplerCreateInfo")]
    public unsafe partial struct SamplerCreateInfo
    {
        public SamplerCreateInfo
        (
            StructureType sType = StructureType.SamplerCreateInfo,
            void* pNext = default,
            SamplerCreateFlags flags = default,
            Filter magFilter = default,
            Filter minFilter = default,
            SamplerMipmapMode mipmapMode = default,
            SamplerAddressMode addressModeU = default,
            SamplerAddressMode addressModeV = default,
            SamplerAddressMode addressModeW = default,
            float mipLodBias = default,
            Bool32 anisotropyEnable = default,
            float maxAnisotropy = default,
            Bool32 compareEnable = default,
            CompareOp compareOp = default,
            float minLod = default,
            float maxLod = default,
            BorderColor borderColor = default,
            Bool32 unnormalizedCoordinates = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            MagFilter = magFilter;
            MinFilter = minFilter;
            MipmapMode = mipmapMode;
            AddressModeU = addressModeU;
            AddressModeV = addressModeV;
            AddressModeW = addressModeW;
            MipLodBias = mipLodBias;
            AnisotropyEnable = anisotropyEnable;
            MaxAnisotropy = maxAnisotropy;
            CompareEnable = compareEnable;
            CompareOp = compareOp;
            MinLod = minLod;
            MaxLod = maxLod;
            BorderColor = borderColor;
            UnnormalizedCoordinates = unnormalizedCoordinates;
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
        [NativeName("Type", "VkSamplerCreateFlags")]
        [NativeName("Type.Name", "VkSamplerCreateFlags")]
        [NativeName("Name", "flags")]
        public SamplerCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkFilter")]
        [NativeName("Type.Name", "VkFilter")]
        [NativeName("Name", "magFilter")]
        public Filter MagFilter;
/// <summary></summary>
        [NativeName("Type", "VkFilter")]
        [NativeName("Type.Name", "VkFilter")]
        [NativeName("Name", "minFilter")]
        public Filter MinFilter;
/// <summary></summary>
        [NativeName("Type", "VkSamplerMipmapMode")]
        [NativeName("Type.Name", "VkSamplerMipmapMode")]
        [NativeName("Name", "mipmapMode")]
        public SamplerMipmapMode MipmapMode;
/// <summary></summary>
        [NativeName("Type", "VkSamplerAddressMode")]
        [NativeName("Type.Name", "VkSamplerAddressMode")]
        [NativeName("Name", "addressModeU")]
        public SamplerAddressMode AddressModeU;
/// <summary></summary>
        [NativeName("Type", "VkSamplerAddressMode")]
        [NativeName("Type.Name", "VkSamplerAddressMode")]
        [NativeName("Name", "addressModeV")]
        public SamplerAddressMode AddressModeV;
/// <summary></summary>
        [NativeName("Type", "VkSamplerAddressMode")]
        [NativeName("Type.Name", "VkSamplerAddressMode")]
        [NativeName("Name", "addressModeW")]
        public SamplerAddressMode AddressModeW;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mipLodBias")]
        public float MipLodBias;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "anisotropyEnable")]
        public Bool32 AnisotropyEnable;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxAnisotropy")]
        public float MaxAnisotropy;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "compareEnable")]
        public Bool32 CompareEnable;
/// <summary></summary>
        [NativeName("Type", "VkCompareOp")]
        [NativeName("Type.Name", "VkCompareOp")]
        [NativeName("Name", "compareOp")]
        public CompareOp CompareOp;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minLod")]
        public float MinLod;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxLod")]
        public float MaxLod;
/// <summary></summary>
        [NativeName("Type", "VkBorderColor")]
        [NativeName("Type.Name", "VkBorderColor")]
        [NativeName("Name", "borderColor")]
        public BorderColor BorderColor;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "unnormalizedCoordinates")]
        public Bool32 UnnormalizedCoordinates;
    }
}
