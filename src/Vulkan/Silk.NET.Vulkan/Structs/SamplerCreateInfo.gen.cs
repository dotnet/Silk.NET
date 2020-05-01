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
    public unsafe struct SamplerCreateInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SamplerCreateFlags Flags;
/// <summary></summary>
        public Filter MagFilter;
/// <summary></summary>
        public Filter MinFilter;
/// <summary></summary>
        public SamplerMipmapMode MipmapMode;
/// <summary></summary>
        public SamplerAddressMode AddressModeU;
/// <summary></summary>
        public SamplerAddressMode AddressModeV;
/// <summary></summary>
        public SamplerAddressMode AddressModeW;
/// <summary></summary>
        public float MipLodBias;
/// <summary></summary>
        public Bool32 AnisotropyEnable;
/// <summary></summary>
        public float MaxAnisotropy;
/// <summary></summary>
        public Bool32 CompareEnable;
/// <summary></summary>
        public CompareOp CompareOp;
/// <summary></summary>
        public float MinLod;
/// <summary></summary>
        public float MaxLod;
/// <summary></summary>
        public BorderColor BorderColor;
/// <summary></summary>
        public Bool32 UnnormalizedCoordinates;
    }
}
