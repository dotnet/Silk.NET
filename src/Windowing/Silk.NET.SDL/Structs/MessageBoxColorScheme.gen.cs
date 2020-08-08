// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_MessageBoxColorScheme")]
    public unsafe partial struct MessageBoxColorScheme
    {
        
        [NativeName("Type", "SDL_MessageBoxColor [5]")]
        [NativeName("Type.Name", "SDL_MessageBoxColor [5]")]
        [NativeName("Name", "colors")]
        public MessageBoxColor Colors_0;
        
        [NativeName("Type", "SDL_MessageBoxColor [5]")]
        [NativeName("Type.Name", "SDL_MessageBoxColor [5]")]
        [NativeName("Name", "colors")]
        public MessageBoxColor Colors_1;
        
        [NativeName("Type", "SDL_MessageBoxColor [5]")]
        [NativeName("Type.Name", "SDL_MessageBoxColor [5]")]
        [NativeName("Name", "colors")]
        public MessageBoxColor Colors_2;
        
        [NativeName("Type", "SDL_MessageBoxColor [5]")]
        [NativeName("Type.Name", "SDL_MessageBoxColor [5]")]
        [NativeName("Name", "colors")]
        public MessageBoxColor Colors_3;
        
        [NativeName("Type", "SDL_MessageBoxColor [5]")]
        [NativeName("Type.Name", "SDL_MessageBoxColor [5]")]
        [NativeName("Name", "colors")]
        public MessageBoxColor Colors_4;
    }
}
