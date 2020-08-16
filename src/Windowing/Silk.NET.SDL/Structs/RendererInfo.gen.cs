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
    [NativeName("Name", "SDL_RendererInfo")]
    public unsafe partial struct RendererInfo
    {
        public RendererInfo
        (
            byte* name = default,
            uint flags = default,
            uint numTextureFormats = default,
            int maxTextureWidth = default,
            int maxTextureHeight = default
        )
        {
            Name = name;
            Flags = flags;
            NumTextureFormats = numTextureFormats;
            MaxTextureWidth = maxTextureWidth;
            MaxTextureHeight = maxTextureHeight;
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "num_texture_formats")]
        public uint NumTextureFormats;
        [NativeName("Type", "Uint32 [16]")]
        [NativeName("Type.Name", "Uint32 [16]")]
        [NativeName("Name", "texture_formats")]
        public fixed uint TextureFormats[16];

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "max_texture_width")]
        public int MaxTextureWidth;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "max_texture_height")]
        public int MaxTextureHeight;
    }
}
