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
    [NativeName("Name", "VkVideoDecodeH265InlineSessionParametersInfoKHR")]
    public unsafe partial struct VideoDecodeH265InlineSessionParametersInfoKHR : IExtendsChain<VideoDecodeInfoKHR>
    {
        public VideoDecodeH265InlineSessionParametersInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeH265InlineSessionParametersInfoKhr,
            void* pNext = null,
            Video.StdVideoH265VideoParameterSet* pStdVps = null,
            Video.StdVideoH265SequenceParameterSet* pStdSps = null,
            Video.StdVideoH265PictureParameterSet* pStdPps = null
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

            if (pStdVps is not null)
            {
                PStdVps = pStdVps;
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
        [NativeName("Type", "StdVideoH265VideoParameterSet*")]
        [NativeName("Type.Name", "StdVideoH265VideoParameterSet")]
        [NativeName("Name", "pStdVPS")]
        public Video.StdVideoH265VideoParameterSet* PStdVps;
/// <summary></summary>
        [NativeName("Type", "StdVideoH265SequenceParameterSet*")]
        [NativeName("Type.Name", "StdVideoH265SequenceParameterSet")]
        [NativeName("Name", "pStdSPS")]
        public Video.StdVideoH265SequenceParameterSet* PStdSps;
/// <summary></summary>
        [NativeName("Type", "StdVideoH265PictureParameterSet*")]
        [NativeName("Type.Name", "StdVideoH265PictureParameterSet")]
        [NativeName("Name", "pStdPPS")]
        public Video.StdVideoH265PictureParameterSet* PStdPps;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH265InlineSessionParametersInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
