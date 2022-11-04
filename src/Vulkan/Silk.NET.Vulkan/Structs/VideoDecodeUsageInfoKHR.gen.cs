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
    [NativeName("Name", "VkVideoDecodeUsageInfoKHR")]
    public unsafe partial struct VideoDecodeUsageInfoKHR : IExtendsChain<VideoProfileInfoKHR>, IExtendsChain<QueryPoolCreateInfo>
    {
        public VideoDecodeUsageInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeUsageInfoKhr,
            void* pNext = null,
            VideoDecodeUsageFlagsKHR? videoUsageHints = null
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

            if (videoUsageHints is not null)
            {
                VideoUsageHints = videoUsageHints.Value;
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
        [NativeName("Type", "VkVideoDecodeUsageFlagsKHR")]
        [NativeName("Type.Name", "VkVideoDecodeUsageFlagsKHR")]
        [NativeName("Name", "videoUsageHints")]
        public VideoDecodeUsageFlagsKHR VideoUsageHints;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeUsageInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
