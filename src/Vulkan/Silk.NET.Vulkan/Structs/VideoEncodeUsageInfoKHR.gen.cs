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
    [NativeName("Name", "VkVideoEncodeUsageInfoKHR")]
    public unsafe partial struct VideoEncodeUsageInfoKHR : IExtendsChain<VideoProfileInfoKHR>, IExtendsChain<QueryPoolCreateInfo>
    {
        public VideoEncodeUsageInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeUsageInfoKhr,
            void* pNext = null,
            VideoEncodeUsageFlagsKHR? videoUsageHints = null,
            VideoEncodeContentFlagsKHR? videoContentHints = null,
            VideoEncodeTuningModeKHR? tuningMode = null
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

            if (videoContentHints is not null)
            {
                VideoContentHints = videoContentHints.Value;
            }

            if (tuningMode is not null)
            {
                TuningMode = tuningMode.Value;
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
        [NativeName("Type", "VkVideoEncodeUsageFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeUsageFlagsKHR")]
        [NativeName("Name", "videoUsageHints")]
        public VideoEncodeUsageFlagsKHR VideoUsageHints;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeContentFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeContentFlagsKHR")]
        [NativeName("Name", "videoContentHints")]
        public VideoEncodeContentFlagsKHR VideoContentHints;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeTuningModeKHR")]
        [NativeName("Type.Name", "VkVideoEncodeTuningModeKHR")]
        [NativeName("Name", "tuningMode")]
        public VideoEncodeTuningModeKHR TuningMode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeUsageInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
