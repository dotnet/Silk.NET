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
    [NativeName("Name", "VkVideoEncodeCapabilitiesKHR")]
    public unsafe partial struct VideoEncodeCapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeCapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeCapabilitiesKhr,
            void* pNext = null,
            VideoEncodeCapabilityFlagsKHR? flags = null,
            VideoEncodeRateControlModeFlagsKHR? rateControlModes = null,
            uint? maxRateControlLayers = null,
            uint? maxQualityLevels = null,
            Extent2D? inputImageDataFillAlignment = null,
            VideoEncodeFeedbackFlagsKHR? supportedEncodeFeedbackFlags = null
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

            if (rateControlModes is not null)
            {
                RateControlModes = rateControlModes.Value;
            }

            if (maxRateControlLayers is not null)
            {
                MaxRateControlLayers = maxRateControlLayers.Value;
            }

            if (maxQualityLevels is not null)
            {
                MaxQualityLevels = maxQualityLevels.Value;
            }

            if (inputImageDataFillAlignment is not null)
            {
                InputImageDataFillAlignment = inputImageDataFillAlignment.Value;
            }

            if (supportedEncodeFeedbackFlags is not null)
            {
                SupportedEncodeFeedbackFlags = supportedEncodeFeedbackFlags.Value;
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
        [NativeName("Type", "VkVideoEncodeCapabilityFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeCapabilityFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoEncodeCapabilityFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRateControlModeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeRateControlModeFlagsKHR")]
        [NativeName("Name", "rateControlModes")]
        public VideoEncodeRateControlModeFlagsKHR RateControlModes;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxRateControlLayers")]
        public uint MaxRateControlLayers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxQualityLevels")]
        public uint MaxQualityLevels;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "inputImageDataFillAlignment")]
        public Extent2D InputImageDataFillAlignment;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeFeedbackFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeFeedbackFlagsKHR")]
        [NativeName("Name", "supportedEncodeFeedbackFlags")]
        public VideoEncodeFeedbackFlagsKHR SupportedEncodeFeedbackFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeCapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
