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
    [NativeName("Name", "VkVideoEncodeH264RateControlInfoEXT")]
    public unsafe partial struct VideoEncodeH264RateControlInfoEXT : IExtendsChain<VideoEncodeRateControlInfoKHR>
    {
        public VideoEncodeH264RateControlInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264RateControlInfoExt,
            void* pNext = null,
            uint? gopFrameCount = null,
            uint? idrPeriod = null,
            uint? consecutiveBFrameCount = null,
            VideoEncodeH264RateControlStructureFlagsEXT? rateControlStructure = null
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
        [NativeName("Type", "VkVideoEncodeH264RateControlStructureFlagBitsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264RateControlStructureFlagBitsEXT")]
        [NativeName("Name", "rateControlStructure")]
        public VideoEncodeH264RateControlStructureFlagsEXT RateControlStructure;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264RateControlInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
