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
    public unsafe struct Extent2Di
    {
        public Extent2Di
        (
            int width = default,
            int height = default
        )
        {
           Width = width;
           Height = height;
        }

/// <summary></summary>
        public int Width;
/// <summary></summary>
        public int Height;
    }
}
