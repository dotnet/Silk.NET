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
    [NativeName("Name", "SDL_PixelFormat")]
    public unsafe partial struct PixelFormat
    {
        public PixelFormat
        (
            uint format = default,
            Palette* palette = default,
            byte bitsPerPixel = default,
            byte bytesPerPixel = default,
            uint rmask = default,
            uint gmask = default,
            uint bmask = default,
            uint amask = default,
            byte rloss = default,
            byte gloss = default,
            byte bloss = default,
            byte aloss = default,
            byte rshift = default,
            byte gshift = default,
            byte bshift = default,
            byte ashift = default,
            int refcount = default,
            PixelFormat* next = default
        )
        {
            Format = format;
            Palette = palette;
            BitsPerPixel = bitsPerPixel;
            BytesPerPixel = bytesPerPixel;
            Rmask = rmask;
            Gmask = gmask;
            Bmask = bmask;
            Amask = amask;
            Rloss = rloss;
            Gloss = gloss;
            Bloss = bloss;
            Aloss = aloss;
            Rshift = rshift;
            Gshift = gshift;
            Bshift = bshift;
            Ashift = ashift;
            Refcount = refcount;
            Next = next;
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
        [NativeName("Type", "Uint8 [2]")]
        [NativeName("Type.Name", "Uint8 [2]")]
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
