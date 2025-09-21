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
    [NativeName("Name", "VkVideoDecodeH264InlineSessionParametersInfoKHR")]
    public unsafe partial struct VideoDecodeH264InlineSessionParametersInfoKHR : IExtendsChain<VideoDecodeInfoKHR>
    {
        public VideoDecodeH264InlineSessionParametersInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeH264InlineSessionParametersInfoKhr,
            void* pNext = null,
            Video.StdVideoH264SequenceParameterSet* pStdSps = null,
            Video.StdVideoH264PictureParameterSet* pStdPps = null
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

            if (pStdSps is not null)
            {
                PStdSps = pStdSps;
            }

            if (pStdPps is not null)
            {
                PStdPps = pStdPps;
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
        [NativeName("Type", "StdVideoH264SequenceParameterSet*")]
        [NativeName("Type.Name", "StdVideoH264SequenceParameterSet")]
        [NativeName("Name", "pStdSPS")]
        public Video.StdVideoH264SequenceParameterSet* PStdSps;
/// <summary></summary>
        [NativeName("Type", "StdVideoH264PictureParameterSet*")]
        [NativeName("Type.Name", "StdVideoH264PictureParameterSet")]
        [NativeName("Name", "pStdPPS")]
        public Video.StdVideoH264PictureParameterSet* PStdPps;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH264InlineSessionParametersInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
