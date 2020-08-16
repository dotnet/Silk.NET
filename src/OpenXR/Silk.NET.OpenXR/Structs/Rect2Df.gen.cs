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
    [NativeName("Name", "XrRect2Df")]
    public unsafe partial struct Rect2Df
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
        [NativeName("Type", "XrOffset2Df")]
        [NativeName("Type.Name", "XrOffset2Df")]
        [NativeName("Name", "offset")]
        public Offset2Df Offset;
/// <summary></summary>
        [NativeName("Type", "XrExtent2Df")]
        [NativeName("Type.Name", "XrExtent2Df")]
        [NativeName("Name", "extent")]
        public Extent2Df Extent;
    }
}
