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
    [NativeName("Name", "SDL_Vertex")]
    public unsafe partial struct Vertex
    {
        public Vertex
        (
            FPoint? position = null,
            Color? color = null,
            FPoint? texCoord = null
        ) : this()
        {
            if (position is not null)
            {
                Position = position.Value;
            }

            if (color is not null)
            {
                Color = color.Value;
            }

            if (texCoord is not null)
            {
                TexCoord = texCoord.Value;
            }
        }


        [NativeName("Type", "SDL_FPoint")]
        [NativeName("Type.Name", "SDL_FPoint")]
        [NativeName("Name", "position")]
        public FPoint Position;

        [NativeName("Type", "SDL_Color")]
        [NativeName("Type.Name", "SDL_Color")]
        [NativeName("Name", "color")]
        public Color Color;

        [NativeName("Type", "SDL_FPoint")]
        [NativeName("Type.Name", "SDL_FPoint")]
        [NativeName("Name", "tex_coord")]
        public FPoint TexCoord;
    }
}
