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
    [NativeName("Name", "SDL_RendererInfo")]
    public unsafe partial struct RendererInfo
    {
        public RendererInfo
        (
            byte* name = null,
            uint? flags = null,
            uint? numTextureFormats = null,
            int? maxTextureWidth = null,
            int? maxTextureHeight = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (numTextureFormats is not null)
            {
                NumTextureFormats = numTextureFormats.Value;
            }

            if (maxTextureWidth is not null)
            {
                MaxTextureWidth = maxTextureWidth.Value;
            }

            if (maxTextureHeight is not null)
            {
                MaxTextureHeight = maxTextureHeight.Value;
            }
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
        [NativeName("Type", "Uint32[16]")]
        [NativeName("Type.Name", "Uint32[16]")]
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
