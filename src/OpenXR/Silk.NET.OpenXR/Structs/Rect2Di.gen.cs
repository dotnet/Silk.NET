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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrRect2Di")]
    public unsafe partial struct Rect2Di
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
        [NativeName("Type", "XrOffset2Di")]
        [NativeName("Type.Name", "XrOffset2Di")]
        [NativeName("Name", "offset")]
        public Offset2Di Offset;
/// <summary></summary>
        [NativeName("Type", "XrExtent2Di")]
        [NativeName("Type.Name", "XrExtent2Di")]
        [NativeName("Name", "extent")]
        public Extent2Di Extent;
    }
}
