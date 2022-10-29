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
    [NativeName("Name", "VkVideoEncodeH264RateControlLayerInfoEXT")]
    public unsafe partial struct VideoEncodeH264RateControlLayerInfoEXT : IExtendsChain<VideoEncodeRateControlLayerInfoKHR>
    {
        public VideoEncodeH264RateControlLayerInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264RateControlLayerInfoExt,
            void* pNext = null,
            byte? temporalLayerId = null,
            Bool32? useInitialRcQp = null,
            VideoEncodeH264QpEXT? initialRcQp = null,
            Bool32? useMinQp = null,
            VideoEncodeH264QpEXT? minQp = null,
            Bool32? useMaxQp = null,
            VideoEncodeH264QpEXT? maxQp = null,
            Bool32? useMaxFrameSize = null,
            VideoEncodeH264FrameSizeEXT? maxFrameSize = null
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

            if (temporalLayerId is not null)
            {
                TemporalLayerId = temporalLayerId.Value;
            }

            if (useInitialRcQp is not null)
            {
                UseInitialRcQp = useInitialRcQp.Value;
            }

            if (initialRcQp is not null)
            {
                InitialRcQp = initialRcQp.Value;
            }

            if (useMinQp is not null)
            {
                UseMinQp = useMinQp.Value;
            }

            if (minQp is not null)
            {
                MinQp = minQp.Value;
            }

            if (useMaxQp is not null)
            {
                UseMaxQp = useMaxQp.Value;
            }

            if (maxQp is not null)
            {
                MaxQp = maxQp.Value;
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
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "temporalLayerId")]
        public byte TemporalLayerId;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useInitialRcQp")]
        public Bool32 UseInitialRcQp;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264QpEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264QpEXT")]
        [NativeName("Name", "initialRcQp")]
        public VideoEncodeH264QpEXT InitialRcQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMinQp")]
        public Bool32 UseMinQp;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264QpEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264QpEXT")]
        [NativeName("Name", "minQp")]
        public VideoEncodeH264QpEXT MinQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxQp")]
        public Bool32 UseMaxQp;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264QpEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264QpEXT")]
        [NativeName("Name", "maxQp")]
        public VideoEncodeH264QpEXT MaxQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxFrameSize")]
        public Bool32 UseMaxFrameSize;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264FrameSizeEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264FrameSizeEXT")]
        [NativeName("Name", "maxFrameSize")]
        public VideoEncodeH264FrameSizeEXT MaxFrameSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264RateControlLayerInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
