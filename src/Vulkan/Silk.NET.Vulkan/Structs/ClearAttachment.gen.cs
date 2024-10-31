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
    [NativeName("Name", "VkClearAttachment")]
    public unsafe partial struct ClearAttachment
    {
        public ClearAttachment
        (
            ImageAspectFlags? aspectMask = null,
            uint? colorAttachment = null,
            ClearValue? clearValue = null
        ) : this()
        {
            if (aspectMask is not null)
            {
                AspectMask = aspectMask.Value;
            }

            if (colorAttachment is not null)
            {
                ColorAttachment = colorAttachment.Value;
            }

            if (clearValue is not null)
            {
                ClearValue = clearValue.Value;
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
        [NativeName("Name", "colorAttachment")]
        public uint ColorAttachment;
/// <summary></summary>
        [NativeName("Type", "VkClearValue")]
        [NativeName("Type.Name", "VkClearValue")]
        [NativeName("Name", "clearValue")]
        public ClearValue ClearValue;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
