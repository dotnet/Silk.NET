// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSparseImageFormatProperties")]
    public unsafe partial struct SparseImageFormatProperties
    {
        public SparseImageFormatProperties
        (
            ImageAspectFlags aspectMask = default,
            Extent3D imageGranularity = default,
            SparseImageFormatFlags flags = default
        )
        {
            AspectMask = aspectMask;
            ImageGranularity = imageGranularity;
            Flags = flags;
        }

/// <summary></summary>
        [NativeName("Type", "VkImageAspectFlags")]
        [NativeName("Type.Name", "VkImageAspectFlags")]
        [NativeName("Name", "aspectMask")]
        public ImageAspectFlags AspectMask;
/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "imageGranularity")]
        public Extent3D ImageGranularity;
/// <summary></summary>
        [NativeName("Type", "VkSparseImageFormatFlags")]
        [NativeName("Type.Name", "VkSparseImageFormatFlags")]
        [NativeName("Name", "flags")]
        public SparseImageFormatFlags Flags;
    }
}
