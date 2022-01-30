// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [Flags]
    [NativeName("Name", "aiTextureFlags")]
    public enum TextureFlags : int
    {
        [NativeName("Name", "aiTextureFlags_Invert")]
        TextureFlagsInvert = 0x1,
        [NativeName("Name", "aiTextureFlags_UseAlpha")]
        TextureFlagsUseAlpha = 0x2,
        [NativeName("Name", "aiTextureFlags_IgnoreAlpha")]
        TextureFlagsIgnoreAlpha = 0x4,
    }
}
