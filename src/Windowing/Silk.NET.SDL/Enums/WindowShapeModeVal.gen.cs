// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "__AnonymousEnum_SDL_shape_L85_C9")]
    public enum WindowShapeModeVal : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "ShapeModeDefault")]
        ShapeModeDefault = 0x0,
        [Obsolete("Deprecated in favour of \"BinarizeAlpha\"")]
        [NativeName("Name", "ShapeModeBinarizeAlpha")]
        ShapeModeBinarizeAlpha = 0x1,
        [Obsolete("Deprecated in favour of \"ReverseBinarizeAlpha\"")]
        [NativeName("Name", "ShapeModeReverseBinarizeAlpha")]
        ShapeModeReverseBinarizeAlpha = 0x2,
        [Obsolete("Deprecated in favour of \"ColorKey\"")]
        [NativeName("Name", "ShapeModeColorKey")]
        ShapeModeColorKey = 0x3,
        [NativeName("Name", "ShapeModeDefault")]
        Default = 0x0,
        [NativeName("Name", "ShapeModeBinarizeAlpha")]
        BinarizeAlpha = 0x1,
        [NativeName("Name", "ShapeModeReverseBinarizeAlpha")]
        ReverseBinarizeAlpha = 0x2,
        [NativeName("Name", "ShapeModeColorKey")]
        ColorKey = 0x3,
    }
}
