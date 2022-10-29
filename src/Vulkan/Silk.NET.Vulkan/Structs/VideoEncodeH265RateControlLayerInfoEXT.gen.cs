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
    [NativeName("Name", "VkVideoEncodeH265RateControlLayerInfoEXT")]
    public unsafe partial struct VideoEncodeH265RateControlLayerInfoEXT : IExtendsChain<VideoEncodeRateControlLayerInfoKHR>
    {
        public VideoEncodeH265RateControlLayerInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265RateControlLayerInfoExt,
            void* pNext = null,
            byte? temporalId = null,
            Bool32? useInitialRcQp = null,
            VideoEncodeH265QpEXT? initialRcQp = null,
            Bool32? useMinQp = null,
            VideoEncodeH265QpEXT? minQp = null,
            Bool32? useMaxQp = null,
            VideoEncodeH265QpEXT? maxQp = null,
            Bool32? useMaxFrameSize = null,
            VideoEncodeH265FrameSizeEXT? maxFrameSize = null
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

            if (temporalId is not null)
            {
                TemporalId = temporalId.Value;
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
        [NativeName("Name", "temporalId")]
        public byte TemporalId;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useInitialRcQp")]
        public Bool32 UseInitialRcQp;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265QpEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265QpEXT")]
        [NativeName("Name", "initialRcQp")]
        public VideoEncodeH265QpEXT InitialRcQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMinQp")]
        public Bool32 UseMinQp;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265QpEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265QpEXT")]
        [NativeName("Name", "minQp")]
        public VideoEncodeH265QpEXT MinQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxQp")]
        public Bool32 UseMaxQp;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265QpEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265QpEXT")]
        [NativeName("Name", "maxQp")]
        public VideoEncodeH265QpEXT MaxQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxFrameSize")]
        public Bool32 UseMaxFrameSize;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265FrameSizeEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265FrameSizeEXT")]
        [NativeName("Name", "maxFrameSize")]
        public VideoEncodeH265FrameSizeEXT MaxFrameSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265RateControlLayerInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
