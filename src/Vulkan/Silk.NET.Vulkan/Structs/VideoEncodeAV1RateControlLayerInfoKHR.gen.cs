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
    [NativeName("Name", "VkVideoEncodeAV1RateControlLayerInfoKHR")]
    public unsafe partial struct VideoEncodeAV1RateControlLayerInfoKHR : IExtendsChain<VideoEncodeRateControlLayerInfoKHR>
    {
        public VideoEncodeAV1RateControlLayerInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1RateControlLayerInfoKhr,
            void* pNext = null,
            Bool32? useMinQIndex = null,
            VideoEncodeAV1QIndexKHR? minQIndex = null,
            Bool32? useMaxQIndex = null,
            VideoEncodeAV1QIndexKHR? maxQIndex = null,
            Bool32? useMaxFrameSize = null,
            VideoEncodeAV1FrameSizeKHR? maxFrameSize = null
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

            if (useMinQIndex is not null)
            {
                UseMinQIndex = useMinQIndex.Value;
            }

            if (minQIndex is not null)
            {
                MinQIndex = minQIndex.Value;
            }

            if (useMaxQIndex is not null)
            {
                UseMaxQIndex = useMaxQIndex.Value;
            }

            if (maxQIndex is not null)
            {
                MaxQIndex = maxQIndex.Value;
            }

            if (useMaxFrameSize is not null)
            {
                UseMaxFrameSize = useMaxFrameSize.Value;
            }

            if (maxFrameSize is not null)
            {
                MaxFrameSize = maxFrameSize.Value;
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
        [NativeName("Name", "useMinQIndex")]
        public Bool32 UseMinQIndex;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeAV1QIndexKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1QIndexKHR")]
        [NativeName("Name", "minQIndex")]
        public VideoEncodeAV1QIndexKHR MinQIndex;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxQIndex")]
        public Bool32 UseMaxQIndex;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeAV1QIndexKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1QIndexKHR")]
        [NativeName("Name", "maxQIndex")]
        public VideoEncodeAV1QIndexKHR MaxQIndex;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxFrameSize")]
        public Bool32 UseMaxFrameSize;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeAV1FrameSizeKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1FrameSizeKHR")]
        [NativeName("Name", "maxFrameSize")]
        public VideoEncodeAV1FrameSizeKHR MaxFrameSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1RateControlLayerInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
