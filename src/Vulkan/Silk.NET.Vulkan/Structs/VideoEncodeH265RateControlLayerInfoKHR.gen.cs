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
    [NativeName("Name", "VkVideoEncodeH265RateControlLayerInfoKHR")]
    public unsafe partial struct VideoEncodeH265RateControlLayerInfoKHR : IExtendsChain<VideoEncodeRateControlLayerInfoKHR>
    {
        public VideoEncodeH265RateControlLayerInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH265RateControlLayerInfoKhr,
            void* pNext = null,
            Bool32? useMinQp = null,
            VideoEncodeH265QpKHR? minQp = null,
            Bool32? useMaxQp = null,
            VideoEncodeH265QpKHR? maxQp = null,
            Bool32? useMaxFrameSize = null,
            VideoEncodeH265FrameSizeKHR? maxFrameSize = null
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMinQp")]
        public Bool32 UseMinQp;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265QpKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265QpKHR")]
        [NativeName("Name", "minQp")]
        public VideoEncodeH265QpKHR MinQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxQp")]
        public Bool32 UseMaxQp;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265QpKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265QpKHR")]
        [NativeName("Name", "maxQp")]
        public VideoEncodeH265QpKHR MaxQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "useMaxFrameSize")]
        public Bool32 UseMaxFrameSize;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265FrameSizeKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265FrameSizeKHR")]
        [NativeName("Name", "maxFrameSize")]
        public VideoEncodeH265FrameSizeKHR MaxFrameSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265RateControlLayerInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
