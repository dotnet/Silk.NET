// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "__AnonymousEnum_SDL_shape_L80_C9")]
    public enum WindowShapeModeVal : int
    {
        [NativeName("Name", "ShapeModeDefault")]
        ShapeModeDefault = 0x0,
        [NativeName("Name", "ShapeModeBinarizeAlpha")]
        ShapeModeBinarizeAlpha = 0x1,
        [NativeName("Name", "ShapeModeReverseBinarizeAlpha")]
        ShapeModeReverseBinarizeAlpha = 0x2,
        [NativeName("Name", "ShapeModeColorKey")]
        ShapeModeColorKey = 0x3,
    }
}
