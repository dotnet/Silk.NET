// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [Flags]
    [NativeName("Name", "aiTextureMapMode")]
    public enum TextureMapMode : int
    {
        [NativeName("Name", "aiTextureMapMode_Wrap")]
        TextureMapModeWrap = 0x0,
        [NativeName("Name", "aiTextureMapMode_Clamp")]
        TextureMapModeClamp = 0x1,
        [NativeName("Name", "aiTextureMapMode_Decal")]
        TextureMapModeDecal = 0x3,
        [NativeName("Name", "aiTextureMapMode_Mirror")]
        TextureMapModeMirror = 0x2,
    }
}
