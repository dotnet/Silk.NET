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
    [NativeName("Name", "VkVideoEncodeH264ProfileEXT")]
    public unsafe partial struct VideoEncodeH264ProfileEXT : IExtendsChain<VideoProfileKHR>, IExtendsChain<QueryPoolCreateInfo>, IExtendsChain<FormatProperties2>, IExtendsChain<FormatProperties2KHR>, IExtendsChain<ImageCreateInfo>, IExtendsChain<ImageViewCreateInfo>, IExtendsChain<BufferCreateInfo>
    {
        public VideoEncodeH264ProfileEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264ProfileExt,
            void* pNext = null,
            Video.StdVideoH264ProfileIdc? stdProfileIdc = null
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

            if (stdProfileIdc is not null)
            {
                StdProfileIdc = stdProfileIdc.Value;
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
        [NativeName("Type", "StdVideoH264ProfileIdc")]
        [NativeName("Type.Name", "StdVideoH264ProfileIdc")]
        [NativeName("Name", "stdProfileIdc")]
        public Video.StdVideoH264ProfileIdc StdProfileIdc;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264ProfileExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
