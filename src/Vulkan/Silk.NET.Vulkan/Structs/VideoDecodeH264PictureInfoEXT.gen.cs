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
    [NativeName("Name", "VkVideoDecodeH264PictureInfoEXT")]
    public unsafe partial struct VideoDecodeH264PictureInfoEXT : IChainStart, IExtendsChain<VideoDecodeInfoKHR>
    {
        public VideoDecodeH264PictureInfoEXT
        (
            StructureType? sType = StructureType.VideoDecodeH264PictureInfoExt,
            void* pNext = null,
            Video.StdVideoDecodeH264PictureInfo* pStdPictureInfo = null,
            uint? slicesCount = null,
            uint* pSlicesDataOffsets = null
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

            if (pStdPictureInfo is not null)
            {
                PStdPictureInfo = pStdPictureInfo;
            }

            if (slicesCount is not null)
            {
                SlicesCount = slicesCount.Value;
            }

            if (pSlicesDataOffsets is not null)
            {
                PSlicesDataOffsets = pSlicesDataOffsets;
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
        [NativeName("Type", "StdVideoDecodeH264PictureInfo*")]
        [NativeName("Type.Name", "StdVideoDecodeH264PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public Video.StdVideoDecodeH264PictureInfo* PStdPictureInfo;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "slicesCount")]
        public uint SlicesCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pSlicesDataOffsets")]
        public uint* PSlicesDataOffsets;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH264PictureInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref VideoDecodeH264PictureInfoEXT Chain(
            out VideoDecodeH264PictureInfoEXT capture)
        {
            capture = new VideoDecodeH264PictureInfoEXT(StructureType.VideoDecodeH264PictureInfoExt);
            return ref capture;
        }
    }
}
