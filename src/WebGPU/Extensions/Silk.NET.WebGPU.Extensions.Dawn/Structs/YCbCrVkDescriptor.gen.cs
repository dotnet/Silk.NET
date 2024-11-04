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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUYCbCrVkDescriptor")]
    public unsafe partial struct YCbCrVkDescriptor
    {
        public YCbCrVkDescriptor
        (
            ChainedStruct? chain = null,
            uint? vkFormat = null,
            uint? vkYCbCrModel = null,
            uint? vkYCbCrRange = null,
            uint? vkComponentSwizzleRed = null,
            uint? vkComponentSwizzleGreen = null,
            uint? vkComponentSwizzleBlue = null,
            uint? vkComponentSwizzleAlpha = null,
            uint? vkXChromaOffset = null,
            uint? vkYChromaOffset = null,
            FilterMode? vkChromaFilter = null,
            Silk.NET.Core.Bool32? forceExplicitReconstruction = null,
            ulong? externalFormat = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (vkFormat is not null)
            {
                VkFormat = vkFormat.Value;
            }

            if (vkYCbCrModel is not null)
            {
                VkYCbCrModel = vkYCbCrModel.Value;
            }

            if (vkYCbCrRange is not null)
            {
                VkYCbCrRange = vkYCbCrRange.Value;
            }

            if (vkComponentSwizzleRed is not null)
            {
                VkComponentSwizzleRed = vkComponentSwizzleRed.Value;
            }

            if (vkComponentSwizzleGreen is not null)
            {
                VkComponentSwizzleGreen = vkComponentSwizzleGreen.Value;
            }

            if (vkComponentSwizzleBlue is not null)
            {
                VkComponentSwizzleBlue = vkComponentSwizzleBlue.Value;
            }

            if (vkComponentSwizzleAlpha is not null)
            {
                VkComponentSwizzleAlpha = vkComponentSwizzleAlpha.Value;
            }

            if (vkXChromaOffset is not null)
            {
                VkXChromaOffset = vkXChromaOffset.Value;
            }

            if (vkYChromaOffset is not null)
            {
                VkYChromaOffset = vkYChromaOffset.Value;
            }

            if (vkChromaFilter is not null)
            {
                VkChromaFilter = vkChromaFilter.Value;
            }

            if (forceExplicitReconstruction is not null)
            {
                ForceExplicitReconstruction = forceExplicitReconstruction.Value;
            }

            if (externalFormat is not null)
            {
                ExternalFormat = externalFormat.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkFormat")]
        public uint VkFormat;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkYCbCrModel")]
        public uint VkYCbCrModel;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkYCbCrRange")]
        public uint VkYCbCrRange;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkComponentSwizzleRed")]
        public uint VkComponentSwizzleRed;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkComponentSwizzleGreen")]
        public uint VkComponentSwizzleGreen;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkComponentSwizzleBlue")]
        public uint VkComponentSwizzleBlue;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkComponentSwizzleAlpha")]
        public uint VkComponentSwizzleAlpha;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkXChromaOffset")]
        public uint VkXChromaOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vkYChromaOffset")]
        public uint VkYChromaOffset;

        [NativeName("Type", "WGPUFilterMode")]
        [NativeName("Type.Name", "WGPUFilterMode")]
        [NativeName("Name", "vkChromaFilter")]
        public FilterMode VkChromaFilter;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "forceExplicitReconstruction")]
        public Silk.NET.Core.Bool32 ForceExplicitReconstruction;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "externalFormat")]
        public ulong ExternalFormat;
    }
}
