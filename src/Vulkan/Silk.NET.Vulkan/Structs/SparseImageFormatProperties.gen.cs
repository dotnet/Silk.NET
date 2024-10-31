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
    [NativeName("Name", "VkSparseImageFormatProperties")]
    public unsafe partial struct SparseImageFormatProperties
    {
        public SparseImageFormatProperties
        (
            ImageAspectFlags? aspectMask = null,
            Extent3D? imageGranularity = null,
            SparseImageFormatFlags? flags = null
        ) : this()
        {
            if (aspectMask is not null)
            {
                AspectMask = aspectMask.Value;
            }

            if (imageGranularity is not null)
            {
                ImageGranularity = imageGranularity.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
