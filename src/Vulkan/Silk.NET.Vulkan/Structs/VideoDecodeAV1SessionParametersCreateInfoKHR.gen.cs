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
    [NativeName("Name", "VkVideoDecodeAV1SessionParametersCreateInfoKHR")]
    public unsafe partial struct VideoDecodeAV1SessionParametersCreateInfoKHR : IExtendsChain<VideoSessionParametersCreateInfoKHR>
    {
        public VideoDecodeAV1SessionParametersCreateInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeAV1SessionParametersCreateInfoKhr,
            void* pNext = null,
            Video.StdVideoAV1SequenceHeader* pStdSequenceHeader = null
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeAV1SessionParametersCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
