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
    [NativeName("Name", "SDL_Surface")]
    public unsafe partial struct Surface
    {
        public Surface
        (
            uint flags = default,
            PixelFormat* format = default,
            int w = default,
            int h = default,
            int pitch = default,
            void* pixels = default,
            void* userdata = default,
            int locked = default,
            void* lockData = default,
            Rect clipRect = default,
            BlitMap* map = default,
            int refcount = default
        )
        {
            Flags = flags;
            Format = format;
            W = w;
            H = h;
            Pitch = pitch;
            Pixels = pixels;
            Userdata = userdata;
            Locked = locked;
            LockData = lockData;
            ClipRect = clipRect;
            Map = map;
            Refcount = refcount;
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "SDL_PixelFormat *")]
        [NativeName("Type.Name", "SDL_PixelFormat *")]
        [NativeName("Name", "format")]
        public PixelFormat* Format;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "w")]
        public int W;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "h")]
        public int H;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "pitch")]
        public int Pitch;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pixels")]
        public void* Pixels;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "userdata")]
        public void* Userdata;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "locked")]
        public int Locked;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "lock_data")]
        public void* LockData;

        [NativeName("Type", "SDL_Rect")]
        [NativeName("Type.Name", "SDL_Rect")]
        [NativeName("Name", "clip_rect")]
        public Rect ClipRect;

        [NativeName("Type", "struct SDL_BlitMap *")]
        [NativeName("Type.Name", "struct SDL_BlitMap *")]
        [NativeName("Name", "map")]
        public BlitMap* Map;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "refcount")]
        public int Refcount;
    }
}
