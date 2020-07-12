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
    public unsafe struct Rect2Df
    {
        public Rect2Df
        (
            Offset2Df offset = default,
            Extent2Df extent = default
        )
        {
           Offset = offset;
           Extent = extent;
        }

/// <summary></summary>
        public Offset2Df Offset;
/// <summary></summary>
        public Extent2Df Extent;
    }
}
