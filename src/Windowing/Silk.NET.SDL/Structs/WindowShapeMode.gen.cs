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
    [NativeName("Name", "SDL_WindowShapeMode")]
    public unsafe partial struct WindowShapeMode
    {
        public WindowShapeMode
        (
            WindowShapeModeVal? mode = null,
            WindowShapeParams? parameters = null
        ) : this()
        {
            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (parameters is not null)
            {
                Parameters = parameters.Value;
            }
        }


        [NativeName("Type", "WindowShapeMode")]
        [NativeName("Type.Name", "WindowShapeMode")]
        [NativeName("Name", "mode")]
        public WindowShapeModeVal Mode;

        [NativeName("Type", "SDL_WindowShapeParams")]
        [NativeName("Type.Name", "SDL_WindowShapeParams")]
        [NativeName("Name", "parameters")]
        public WindowShapeParams Parameters;
    }
}
