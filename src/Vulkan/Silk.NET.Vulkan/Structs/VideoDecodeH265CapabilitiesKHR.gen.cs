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
    [NativeName("Name", "VkVideoDecodeH265CapabilitiesKHR")]
    public unsafe partial struct VideoDecodeH265CapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoDecodeH265CapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoDecodeH265CapabilitiesKhr,
            void* pNext = null,
            Video.StdVideoH265LevelIdc? maxLevelIdc = null
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

            if (maxLevelIdc is not null)
            {
                MaxLevelIdc = maxLevelIdc.Value;
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
        [NativeName("Type", "StdVideoH265LevelIdc")]
        [NativeName("Type.Name", "StdVideoH265LevelIdc")]
        [NativeName("Name", "maxLevelIdc")]
        public Video.StdVideoH265LevelIdc MaxLevelIdc;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH265CapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
