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

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_UserEvent")]
    public unsafe partial struct UserEvent
    {
        public UserEvent
        (
            uint type = default,
            uint timestamp = default,
            uint windowID = default,
            int code = default,
            void* data1 = default,
            void* data2 = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            WindowID = windowID;
            Code = code;
            Data1 = data1;
            Data2 = data2;
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "timestamp")]
        public uint Timestamp;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "windowID")]
        public uint WindowID;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "code")]
        public int Code;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data1")]
        public void* Data1;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data2")]
        public void* Data2;
    }
}
