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
    [NativeName("Name", "VkVideoEncodeH265RateControlInfoEXT")]
    public unsafe partial struct VideoEncodeH265RateControlInfoEXT : IExtendsChain<VideoCodingControlInfoKHR>
    {
        public VideoEncodeH265RateControlInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265RateControlInfoExt,
            void* pNext = null,
            uint? gopFrameCount = null,
            uint? idrPeriod = null,
            uint? consecutiveBFrameCount = null,
            VideoEncodeH265RateControlStructureEXT? rateControlStructure = null,
            uint? subLayerCount = null
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

            if (gopFrameCount is not null)
            {
                GopFrameCount = gopFrameCount.Value;
            }

            if (idrPeriod is not null)
            {
                IdrPeriod = idrPeriod.Value;
            }

            if (consecutiveBFrameCount is not null)
            {
                ConsecutiveBFrameCount = consecutiveBFrameCount.Value;
            }

            if (rateControlStructure is not null)
            {
                RateControlStructure = rateControlStructure.Value;
            }

            if (subLayerCount is not null)
            {
                SubLayerCount = subLayerCount.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gopFrameCount")]
        public uint GopFrameCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "idrPeriod")]
        public uint IdrPeriod;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "consecutiveBFrameCount")]
        public uint ConsecutiveBFrameCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265RateControlStructureEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265RateControlStructureEXT")]
        [NativeName("Name", "rateControlStructure")]
        public VideoEncodeH265RateControlStructureEXT RateControlStructure;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subLayerCount")]
        public uint SubLayerCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265RateControlInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
