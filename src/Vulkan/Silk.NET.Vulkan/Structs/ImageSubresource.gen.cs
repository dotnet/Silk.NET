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
    [NativeName("Name", "VkImageSubresource")]
    public unsafe partial struct ImageSubresource
    {
        public ImageSubresource
        (
            ImageAspectFlags? aspectMask = null,
            uint? mipLevel = null,
            uint? arrayLayer = null
        ) : this()
        {
            if (aspectMask is not null)
            {
                AspectMask = aspectMask.Value;
            }

            if (mipLevel is not null)
            {
                MipLevel = mipLevel.Value;
            }

            if (arrayLayer is not null)
            {
                ArrayLayer = arrayLayer.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkImageAspectFlags")]
        [NativeName("Type.Name", "VkImageAspectFlags")]
        [NativeName("Name", "aspectMask")]
        public ImageAspectFlags AspectMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipLevel")]
        public uint MipLevel;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "arrayLayer")]
        public uint ArrayLayer;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
