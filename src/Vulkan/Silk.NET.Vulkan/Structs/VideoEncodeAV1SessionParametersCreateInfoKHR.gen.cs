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
    [NativeName("Name", "VkVideoEncodeAV1SessionParametersCreateInfoKHR")]
    public unsafe partial struct VideoEncodeAV1SessionParametersCreateInfoKHR : IExtendsChain<VideoSessionParametersCreateInfoKHR>
    {
        public VideoEncodeAV1SessionParametersCreateInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1SessionParametersCreateInfoKhr,
            void* pNext = null,
            Video.StdVideoAV1SequenceHeader* pStdSequenceHeader = null,
            Video.StdVideoEncodeAV1DecoderModelInfo* pStdDecoderModelInfo = null,
            uint? stdOperatingPointCount = null,
            Video.StdVideoEncodeAV1OperatingPointInfo* pStdOperatingPoints = null
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

            if (pStdSequenceHeader is not null)
            {
                PStdSequenceHeader = pStdSequenceHeader;
            }

            if (pStdDecoderModelInfo is not null)
            {
                PStdDecoderModelInfo = pStdDecoderModelInfo;
            }

            if (stdOperatingPointCount is not null)
            {
                StdOperatingPointCount = stdOperatingPointCount.Value;
            }

            if (pStdOperatingPoints is not null)
            {
                PStdOperatingPoints = pStdOperatingPoints;
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
        [NativeName("Type", "StdVideoAV1SequenceHeader*")]
        [NativeName("Type.Name", "StdVideoAV1SequenceHeader")]
        [NativeName("Name", "pStdSequenceHeader")]
        public Video.StdVideoAV1SequenceHeader* PStdSequenceHeader;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeAV1DecoderModelInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeAV1DecoderModelInfo")]
        [NativeName("Name", "pStdDecoderModelInfo")]
        public Video.StdVideoEncodeAV1DecoderModelInfo* PStdDecoderModelInfo;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stdOperatingPointCount")]
        public uint StdOperatingPointCount;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeAV1OperatingPointInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeAV1OperatingPointInfo")]
        [NativeName("Name", "pStdOperatingPoints")]
        public Video.StdVideoEncodeAV1OperatingPointInfo* PStdOperatingPoints;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1SessionParametersCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
