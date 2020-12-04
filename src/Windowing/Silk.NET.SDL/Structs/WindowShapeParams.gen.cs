// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.SDL
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "SDL_WindowShapeParams")]
    public unsafe partial struct WindowShapeParams
    {
        public WindowShapeParams
        (
            byte? binarizationCutoff = null,
            Color? colorKey = null
        ) : this()
        {
            if (binarizationCutoff is not null)
            {
                BinarizationCutoff = binarizationCutoff.Value;
            }

            if (colorKey is not null)
            {
                ColorKey = colorKey.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "binarizationCutoff")]
        public byte BinarizationCutoff;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_Color")]
        [NativeName("Type.Name", "SDL_Color")]
        [NativeName("Name", "colorKey")]
        public Color ColorKey;
    }
}
