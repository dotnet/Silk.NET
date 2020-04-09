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
    public unsafe struct SurfaceFormatKHR
    {
        public SurfaceFormatKHR
        (
            Format format = default,
            ColorSpaceKHR colorSpace = default
        )
        {
           Format = format;
           ColorSpace = colorSpace;
        }

/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public ColorSpaceKHR ColorSpace;
    }
}
