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
    [NativeName("Name", "VkVideoDecodeH265SessionParametersAddInfoEXT")]
    public unsafe partial struct VideoDecodeH265SessionParametersAddInfoEXT : IExtendsChain<VideoSessionParametersUpdateInfoKHR>
    {
        public VideoDecodeH265SessionParametersAddInfoEXT
        (
            StructureType? sType = StructureType.VideoDecodeH265SessionParametersAddInfoExt,
            void* pNext = null,
            uint? spsStdCount = null,
            Video.StdVideoH265SequenceParameterSet* pSpsStd = null,
            uint? ppsStdCount = null,
            Video.StdVideoH265PictureParameterSet* pPpsStd = null
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

            if (spsStdCount is not null)
            {
                SpsStdCount = spsStdCount.Value;
            }

            if (pSpsStd is not null)
            {
                PSpsStd = pSpsStd;
            }

            if (ppsStdCount is not null)
            {
                PpsStdCount = ppsStdCount.Value;
            }

            if (pPpsStd is not null)
            {
                PPpsStd = pPpsStd;
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
        [NativeName("Name", "spsStdCount")]
        public uint SpsStdCount;
/// <summary></summary>
        [NativeName("Type", "StdVideoH265SequenceParameterSet*")]
        [NativeName("Type.Name", "StdVideoH265SequenceParameterSet")]
        [NativeName("Name", "pSpsStd")]
        public Video.StdVideoH265SequenceParameterSet* PSpsStd;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "ppsStdCount")]
        public uint PpsStdCount;
/// <summary></summary>
        [NativeName("Type", "StdVideoH265PictureParameterSet*")]
        [NativeName("Type.Name", "StdVideoH265PictureParameterSet")]
        [NativeName("Name", "pPpsStd")]
        public Video.StdVideoH265PictureParameterSet* PPpsStd;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH265SessionParametersAddInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
