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
    [NativeName("Name", "SDL_MessageBoxButtonData")]
    public unsafe partial struct MessageBoxButtonData
    {
        public MessageBoxButtonData
        (
            uint? flags = null,
            int? buttonid = null,
            byte* text = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (buttonid is not null)
            {
                Buttonid = buttonid.Value;
            }

            if (text is not null)
            {
                Text = text;
            }
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "buttonid")]
        public int Buttonid;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "text")]
        public byte* Text;
    }
}
