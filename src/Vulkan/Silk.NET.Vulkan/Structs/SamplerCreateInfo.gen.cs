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
    [NativeName("Name", "VkSamplerCreateInfo")]
    public unsafe partial struct SamplerCreateInfo : IChainStart
    {
        public SamplerCreateInfo
        (
            StructureType? sType = StructureType.SamplerCreateInfo,
            void* pNext = null,
            SamplerCreateFlags? flags = null,
            Filter? magFilter = null,
            Filter? minFilter = null,
            SamplerMipmapMode? mipmapMode = null,
            SamplerAddressMode? addressModeU = null,
            SamplerAddressMode? addressModeV = null,
            SamplerAddressMode? addressModeW = null,
            float? mipLodBias = null,
            Bool32? anisotropyEnable = null,
            float? maxAnisotropy = null,
            Bool32? compareEnable = null,
            CompareOp? compareOp = null,
            float? minLod = null,
            float? maxLod = null,
            BorderColor? borderColor = null,
            Bool32? unnormalizedCoordinates = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (magFilter is not null)
            {
                MagFilter = magFilter.Value;
            }

            if (minFilter is not null)
            {
                MinFilter = minFilter.Value;
            }

            if (mipmapMode is not null)
            {
                MipmapMode = mipmapMode.Value;
            }

            if (addressModeU is not null)
            {
                AddressModeU = addressModeU.Value;
            }

            if (addressModeV is not null)
            {
                AddressModeV = addressModeV.Value;
            }

            if (addressModeW is not null)
            {
                AddressModeW = addressModeW.Value;
            }

            if (mipLodBias is not null)
            {
                MipLodBias = mipLodBias.Value;
            }

            if (anisotropyEnable is not null)
            {
                AnisotropyEnable = anisotropyEnable.Value;
            }

            if (maxAnisotropy is not null)
            {
                MaxAnisotropy = maxAnisotropy.Value;
            }

            if (compareEnable is not null)
            {
                CompareEnable = compareEnable.Value;
            }

            if (compareOp is not null)
            {
                CompareOp = compareOp.Value;
            }

            if (minLod is not null)
            {
                MinLod = minLod.Value;
            }

            if (maxLod is not null)
            {
                MaxLod = maxLod.Value;
            }

            if (borderColor is not null)
            {
                BorderColor = borderColor.Value;
            }

            if (unnormalizedCoordinates is not null)
            {
                UnnormalizedCoordinates = unnormalizedCoordinates.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SamplerCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref SamplerCreateInfo Chain(
            out SamplerCreateInfo capture)
        {
            capture = new SamplerCreateInfo(StructureType.SamplerCreateInfo);
            return ref capture;
        }
    }
}
