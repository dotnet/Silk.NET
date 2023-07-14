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
    [NativeName("Name", "VkVideoEncodeRateControlInfoKHR")]
    public unsafe partial struct VideoEncodeRateControlInfoKHR : IExtendsChain<VideoCodingControlInfoKHR>, IExtendsChain<VideoBeginCodingInfoKHR>
    {
        public VideoEncodeRateControlInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeRateControlInfoKhr,
            void* pNext = null,
            uint? flags = null,
            VideoEncodeRateControlModeFlagsKHR? rateControlMode = null,
            uint? layerCount = null,
            VideoEncodeRateControlLayerInfoKHR* pLayers = null,
            uint? virtualBufferSizeInMs = null,
            uint? initialVirtualBufferSizeInMs = null
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

            if (rateControlMode is not null)
            {
                RateControlMode = rateControlMode.Value;
            }

            if (layerCount is not null)
            {
                LayerCount = layerCount.Value;
            }

            if (pLayers is not null)
            {
                PLayers = pLayers;
            }

            if (virtualBufferSizeInMs is not null)
            {
                VirtualBufferSizeInMs = virtualBufferSizeInMs.Value;
            }

            if (initialVirtualBufferSizeInMs is not null)
            {
                InitialVirtualBufferSizeInMs = initialVirtualBufferSizeInMs.Value;
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
        [NativeName("Type", "VkVideoEncodeRateControlFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeRateControlFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRateControlModeFlagBitsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeRateControlModeFlagBitsKHR")]
        [NativeName("Name", "rateControlMode")]
        public VideoEncodeRateControlModeFlagsKHR RateControlMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layerCount")]
        public uint LayerCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRateControlLayerInfoKHR*")]
        [NativeName("Type.Name", "VkVideoEncodeRateControlLayerInfoKHR")]
        [NativeName("Name", "pLayers")]
        public VideoEncodeRateControlLayerInfoKHR* PLayers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "virtualBufferSizeInMs")]
        public uint VirtualBufferSizeInMs;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "initialVirtualBufferSizeInMs")]
        public uint InitialVirtualBufferSizeInMs;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeRateControlInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
