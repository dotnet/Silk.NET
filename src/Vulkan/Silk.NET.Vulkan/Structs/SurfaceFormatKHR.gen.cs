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
    [NativeName("Name", "VkSurfaceFormatKHR")]
    public unsafe partial struct SurfaceFormatKHR
    {
        public SurfaceFormatKHR
        (
            Format? format = null,
            ColorSpaceKHR? colorSpace = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "VkColorSpaceKHR")]
        [NativeName("Type.Name", "VkColorSpaceKHR")]
        [NativeName("Name", "colorSpace")]
        public ColorSpaceKHR ColorSpace;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
