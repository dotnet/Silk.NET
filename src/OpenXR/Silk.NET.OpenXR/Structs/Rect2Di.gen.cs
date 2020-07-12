// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct Rect2Di
    {
        public Rect2Di
        (
            Offset2Di offset = default,
            Extent2Di extent = default
        )
        {
           Offset = offset;
           Extent = extent;
        }

/// <summary></summary>
        public Offset2Di Offset;
/// <summary></summary>
        public Extent2Di Extent;
    }
}
