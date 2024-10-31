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
    [NativeName("Name", "VkImageFormatProperties")]
    public unsafe partial struct ImageFormatProperties
    {
        public ImageFormatProperties
        (
            Extent3D? maxExtent = null,
            uint? maxMipLevels = null,
            uint? maxArrayLayers = null,
            SampleCountFlags? sampleCounts = null,
            ulong? maxResourceSize = null
        ) : this()
        {
            if (maxExtent is not null)
            {
                MaxExtent = maxExtent.Value;
            }

            if (maxMipLevels is not null)
            {
                MaxMipLevels = maxMipLevels.Value;
            }

            if (maxArrayLayers is not null)
            {
                MaxArrayLayers = maxArrayLayers.Value;
            }

            if (sampleCounts is not null)
            {
                SampleCounts = sampleCounts.Value;
            }

            if (maxResourceSize is not null)
            {
                MaxResourceSize = maxResourceSize.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "maxExtent")]
        public Extent3D MaxExtent;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMipLevels")]
        public uint MaxMipLevels;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxArrayLayers")]
        public uint MaxArrayLayers;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "sampleCounts")]
        public SampleCountFlags SampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxResourceSize")]
        public ulong MaxResourceSize;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
