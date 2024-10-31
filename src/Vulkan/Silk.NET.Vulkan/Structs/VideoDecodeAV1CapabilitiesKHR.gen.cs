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
    [NativeName("Name", "VkVideoDecodeAV1CapabilitiesKHR")]
    public unsafe partial struct VideoDecodeAV1CapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoDecodeAV1CapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoDecodeAV1CapabilitiesKhr,
            void* pNext = null,
            Video.StdVideoAV1Level? maxLevel = null
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

            if (maxLevel is not null)
            {
                MaxLevel = maxLevel.Value;
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
        [NativeName("Type", "StdVideoAV1Level")]
        [NativeName("Type.Name", "StdVideoAV1Level")]
        [NativeName("Name", "maxLevel")]
        public Video.StdVideoAV1Level MaxLevel;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeAV1CapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
