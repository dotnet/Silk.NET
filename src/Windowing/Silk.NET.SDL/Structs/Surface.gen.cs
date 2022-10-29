// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "SDL_Surface")]
    public unsafe partial struct Surface
    {
        public Surface
        (
            uint? flags = null,
            PixelFormat* format = null,
            int? w = null,
            int? h = null,
            int? pitch = null,
            void* pixels = null,
            void* userdata = null,
            int? locked = null,
            void* listBlitmap = null,
            Silk.NET.Maths.Rectangle<int>? clipRect = null,
            BlitMap* map = null,
            int? refcount = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (format is not null)
            {
                Format = format;
            }

            if (w is not null)
            {
                W = w.Value;
            }

            if (h is not null)
            {
                H = h.Value;
            }

            if (pitch is not null)
            {
                Pitch = pitch.Value;
            }

            if (pixels is not null)
            {
                Pixels = pixels;
            }

            if (userdata is not null)
            {
                Userdata = userdata;
            }

            if (locked is not null)
            {
                Locked = locked.Value;
            }

            if (listBlitmap is not null)
            {
                ListBlitmap = listBlitmap;
            }

            if (clipRect is not null)
            {
                ClipRect = clipRect.Value;
            }

            if (map is not null)
            {
                Map = map;
            }

            if (refcount is not null)
            {
                Refcount = refcount.Value;
            }
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
        [NativeName("Name", "list_blitmap")]
        public void* ListBlitmap;

        [NativeName("Type", "SDL_Rect")]
        [NativeName("Type.Name", "SDL_Rect")]
        [NativeName("Name", "clip_rect")]
        public Silk.NET.Maths.Rectangle<int> ClipRect;

        [NativeName("Type", "SDL_BlitMap *")]
        [NativeName("Type.Name", "SDL_BlitMap *")]
        [NativeName("Name", "map")]
        public BlitMap* Map;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "refcount")]
        public int Refcount;
    }
}
