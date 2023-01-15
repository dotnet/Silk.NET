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
    [NativeName("Name", "VkVideoDecodeH264CapabilitiesKHR")]
    public unsafe partial struct VideoDecodeH264CapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoDecodeH264CapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoDecodeH264CapabilitiesKhr,
            void* pNext = null,
            Video.StdVideoH264LevelIdc? maxLevelIdc = null,
            Offset2D? fieldOffsetGranularity = null
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

            if (fieldOffsetGranularity is not null)
            {
                FieldOffsetGranularity = fieldOffsetGranularity.Value;
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
        [NativeName("Type", "StdVideoH264LevelIdc")]
        [NativeName("Type.Name", "StdVideoH264LevelIdc")]
        [NativeName("Name", "maxLevelIdc")]
        public Video.StdVideoH264LevelIdc MaxLevelIdc;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "fieldOffsetGranularity")]
        public Offset2D FieldOffsetGranularity;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH264CapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
