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
    [NativeName("Name", "VkVideoEncodeH264SessionParametersAddInfoKHR")]
    public unsafe partial struct VideoEncodeH264SessionParametersAddInfoKHR : IExtendsChain<VideoSessionParametersUpdateInfoKHR>
    {
        public VideoEncodeH264SessionParametersAddInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264SessionParametersAddInfoKhr,
            void* pNext = null,
            uint? stdSpscount = null,
            Video.StdVideoH264SequenceParameterSet* pStdSpss = null,
            uint? stdPpscount = null,
            Video.StdVideoH264PictureParameterSet* pStdPpss = null
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

            if (stdSpscount is not null)
            {
                StdSpscount = stdSpscount.Value;
            }

            if (pStdSpss is not null)
            {
                PStdSpss = pStdSpss;
            }

            if (stdPpscount is not null)
            {
                StdPpscount = stdPpscount.Value;
            }

            if (pStdPpss is not null)
            {
                PStdPpss = pStdPpss;
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
        [NativeName("Name", "stdSPSCount")]
        public uint StdSpscount;
/// <summary></summary>
        [NativeName("Type", "StdVideoH264SequenceParameterSet*")]
        [NativeName("Type.Name", "StdVideoH264SequenceParameterSet")]
        [NativeName("Name", "pStdSPSs")]
        public Video.StdVideoH264SequenceParameterSet* PStdSpss;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stdPPSCount")]
        public uint StdPpscount;
/// <summary></summary>
        [NativeName("Type", "StdVideoH264PictureParameterSet*")]
        [NativeName("Type.Name", "StdVideoH264PictureParameterSet")]
        [NativeName("Name", "pStdPPSs")]
        public Video.StdVideoH264PictureParameterSet* PStdPpss;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264SessionParametersAddInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
