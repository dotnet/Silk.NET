// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct SparseImageFormatProperties
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
        public ImageAspectFlags AspectMask;
/// <summary></summary>
        public Extent3D ImageGranularity;
/// <summary></summary>
        public SparseImageFormatFlags Flags;
    }
}
