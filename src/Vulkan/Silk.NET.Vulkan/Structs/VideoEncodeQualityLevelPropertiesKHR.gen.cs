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
    [NativeName("Name", "VkVideoEncodeQualityLevelPropertiesKHR")]
    public unsafe partial struct VideoEncodeQualityLevelPropertiesKHR : IChainStart
    {
        public VideoEncodeQualityLevelPropertiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeQualityLevelPropertiesKhr,
            void* pNext = null,
            VideoEncodeRateControlModeFlagsKHR? preferredRateControlMode = null,
            uint? preferredRateControlLayerCount = null
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

            if (preferredRateControlMode is not null)
            {
                PreferredRateControlMode = preferredRateControlMode.Value;
            }

            if (preferredRateControlLayerCount is not null)
            {
                PreferredRateControlLayerCount = preferredRateControlLayerCount.Value;
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
        [NativeName("Type", "VkVideoEncodeRateControlModeFlagBitsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeRateControlModeFlagBitsKHR")]
        [NativeName("Name", "preferredRateControlMode")]
        public VideoEncodeRateControlModeFlagsKHR PreferredRateControlMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredRateControlLayerCount")]
        public uint PreferredRateControlLayerCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeQualityLevelPropertiesKhr;
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
        public static unsafe ref VideoEncodeQualityLevelPropertiesKHR Chain(
            out VideoEncodeQualityLevelPropertiesKHR capture)
        {
            capture = new VideoEncodeQualityLevelPropertiesKHR(StructureType.VideoEncodeQualityLevelPropertiesKhr);
            return ref capture;
        }
    }
}
