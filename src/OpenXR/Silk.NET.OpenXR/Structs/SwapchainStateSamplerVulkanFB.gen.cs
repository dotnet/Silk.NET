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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSwapchainStateSamplerVulkanFB")]
    public unsafe partial struct SwapchainStateSamplerVulkanFB
    {
        public SwapchainStateSamplerVulkanFB
        (
            StructureType? type = StructureType.TypeSwapchainStateSamplerVulkanFB,
            void* next = null,
            uint? minFilter = null,
            uint? magFilter = null,
            uint? mipmapMode = null,
            uint? wrapModeS = null,
            uint? wrapModeT = null,
            uint? swizzleRed = null,
            uint? swizzleGreen = null,
            uint? swizzleBlue = null,
            uint? swizzleAlpha = null,
            float? maxAnisotropy = null,
            Color4f? borderColor = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (minFilter is not null)
            {
                MinFilter = minFilter.Value;
            }

            if (magFilter is not null)
            {
                MagFilter = magFilter.Value;
            }

            if (mipmapMode is not null)
            {
                MipmapMode = mipmapMode.Value;
            }

            if (wrapModeS is not null)
            {
                WrapModeS = wrapModeS.Value;
            }

            if (wrapModeT is not null)
            {
                WrapModeT = wrapModeT.Value;
            }

            if (swizzleRed is not null)
            {
                SwizzleRed = swizzleRed.Value;
            }

            if (swizzleGreen is not null)
            {
                SwizzleGreen = swizzleGreen.Value;
            }

            if (swizzleBlue is not null)
            {
                SwizzleBlue = swizzleBlue.Value;
            }

            if (swizzleAlpha is not null)
            {
                SwizzleAlpha = swizzleAlpha.Value;
            }

            if (maxAnisotropy is not null)
            {
                MaxAnisotropy = maxAnisotropy.Value;
            }

            if (borderColor is not null)
            {
                BorderColor = borderColor.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "VkFilter")]
        [NativeName("Type.Name", "VkFilter")]
        [NativeName("Name", "minFilter")]
        public uint MinFilter;
/// <summary></summary>
        [NativeName("Type", "VkFilter")]
        [NativeName("Type.Name", "VkFilter")]
        [NativeName("Name", "magFilter")]
        public uint MagFilter;
/// <summary></summary>
        [NativeName("Type", "VkSamplerMipmapMode")]
        [NativeName("Type.Name", "VkSamplerMipmapMode")]
        [NativeName("Name", "mipmapMode")]
        public uint MipmapMode;
/// <summary></summary>
        [NativeName("Type", "VkSamplerAddressMode")]
        [NativeName("Type.Name", "VkSamplerAddressMode")]
        [NativeName("Name", "wrapModeS")]
        public uint WrapModeS;
/// <summary></summary>
        [NativeName("Type", "VkSamplerAddressMode")]
        [NativeName("Type.Name", "VkSamplerAddressMode")]
        [NativeName("Name", "wrapModeT")]
        public uint WrapModeT;
/// <summary></summary>
        [NativeName("Type", "VkComponentSwizzle")]
        [NativeName("Type.Name", "VkComponentSwizzle")]
        [NativeName("Name", "swizzleRed")]
        public uint SwizzleRed;
/// <summary></summary>
        [NativeName("Type", "VkComponentSwizzle")]
        [NativeName("Type.Name", "VkComponentSwizzle")]
        [NativeName("Name", "swizzleGreen")]
        public uint SwizzleGreen;
/// <summary></summary>
        [NativeName("Type", "VkComponentSwizzle")]
        [NativeName("Type.Name", "VkComponentSwizzle")]
        [NativeName("Name", "swizzleBlue")]
        public uint SwizzleBlue;
/// <summary></summary>
        [NativeName("Type", "VkComponentSwizzle")]
        [NativeName("Type.Name", "VkComponentSwizzle")]
        [NativeName("Name", "swizzleAlpha")]
        public uint SwizzleAlpha;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxAnisotropy")]
        public float MaxAnisotropy;
/// <summary></summary>
        [NativeName("Type", "XrColor4f")]
        [NativeName("Type.Name", "XrColor4f")]
        [NativeName("Name", "borderColor")]
        public Color4f BorderColor;
    }
}
