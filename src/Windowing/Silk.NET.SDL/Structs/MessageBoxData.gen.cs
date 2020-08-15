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
    [NativeName("Name", "SDL_MessageBoxData")]
    public unsafe partial struct MessageBoxData
    {
        public MessageBoxData
        (
            uint flags = default,
            Window* window = default,
            byte* title = default,
            byte* message = default,
            int numbuttons = default,
            MessageBoxButtonData* buttons = default,
            MessageBoxColorScheme* colorScheme = default
        )
        {
            Flags = flags;
            Window = window;
            Title = title;
            Message = message;
            Numbuttons = numbuttons;
            Buttons = buttons;
            ColorScheme = colorScheme;
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "SDL_Window *")]
        [NativeName("Type.Name", "SDL_Window *")]
        [NativeName("Name", "window")]
        public Window* Window;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "title")]
        public byte* Title;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "message")]
        public byte* Message;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "numbuttons")]
        public int Numbuttons;

        [NativeName("Type", "const SDL_MessageBoxButtonData *")]
        [NativeName("Type.Name", "const SDL_MessageBoxButtonData *")]
        [NativeName("Name", "buttons")]
        public MessageBoxButtonData* Buttons;

        [NativeName("Type", "const SDL_MessageBoxColorScheme *")]
        [NativeName("Type.Name", "const SDL_MessageBoxColorScheme *")]
        [NativeName("Name", "colorScheme")]
        public MessageBoxColorScheme* ColorScheme;
    }
}
