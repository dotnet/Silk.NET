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
    [NativeName("Name", "SDL_PixelFormat")]
    public unsafe partial struct PixelFormat
    {
        public PixelFormat
        (
            uint? format = null,
            Palette* palette = null,
            byte? bitsPerPixel = null,
            byte? bytesPerPixel = null,
            uint? rmask = null,
            uint? gmask = null,
            uint? bmask = null,
            uint? amask = null,
            byte? rloss = null,
            byte? gloss = null,
            byte? bloss = null,
            byte? aloss = null,
            byte? rshift = null,
            byte? gshift = null,
            byte? bshift = null,
            byte? ashift = null,
            int? refcount = null,
            PixelFormat* next = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (palette is not null)
            {
                Palette = palette;
            }

            if (bitsPerPixel is not null)
            {
                BitsPerPixel = bitsPerPixel.Value;
            }

            if (bytesPerPixel is not null)
            {
                BytesPerPixel = bytesPerPixel.Value;
            }

            if (rmask is not null)
            {
                Rmask = rmask.Value;
            }

            if (gmask is not null)
            {
                Gmask = gmask.Value;
            }

            if (bmask is not null)
            {
                Bmask = bmask.Value;
            }

            if (amask is not null)
            {
                Amask = amask.Value;
            }

            if (rloss is not null)
            {
                Rloss = rloss.Value;
            }

            if (gloss is not null)
            {
                Gloss = gloss.Value;
            }

            if (bloss is not null)
            {
                Bloss = bloss.Value;
            }

            if (aloss is not null)
            {
                Aloss = aloss.Value;
            }

            if (rshift is not null)
            {
                Rshift = rshift.Value;
            }

            if (gshift is not null)
            {
                Gshift = gshift.Value;
            }

            if (bshift is not null)
            {
                Bshift = bshift.Value;
            }

            if (ashift is not null)
            {
                Ashift = ashift.Value;
            }

            if (refcount is not null)
            {
                Refcount = refcount.Value;
            }

            if (next is not null)
            {
                Next = next;
            }
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "format")]
        public uint Format;

        [NativeName("Type", "SDL_Palette *")]
        [NativeName("Type.Name", "SDL_Palette *")]
        [NativeName("Name", "palette")]
        public Palette* Palette;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "BitsPerPixel")]
        public byte BitsPerPixel;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "BytesPerPixel")]
        public byte BytesPerPixel;
        [NativeName("Type", "Uint8[2]")]
        [NativeName("Type.Name", "Uint8[2]")]
        [NativeName("Name", "padding")]
        public fixed byte Padding[2];

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "Rmask")]
        public uint Rmask;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "Gmask")]
        public uint Gmask;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "Bmask")]
        public uint Bmask;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "Amask")]
        public uint Amask;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "Rloss")]
        public byte Rloss;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "Gloss")]
        public byte Gloss;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "Bloss")]
        public byte Bloss;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "Aloss")]
        public byte Aloss;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "Rshift")]
        public byte Rshift;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "Gshift")]
        public byte Gshift;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "Bshift")]
        public byte Bshift;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "Ashift")]
        public byte Ashift;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "refcount")]
        public int Refcount;

        [NativeName("Type", "struct SDL_PixelFormat *")]
        [NativeName("Type.Name", "struct SDL_PixelFormat *")]
        [NativeName("Name", "next")]
        public PixelFormat* Next;
    }
}
