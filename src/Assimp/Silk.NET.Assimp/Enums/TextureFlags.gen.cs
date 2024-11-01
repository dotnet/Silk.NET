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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Invert\"")]
        [NativeName("Name", "aiTextureFlags_Invert")]
        TextureFlagsInvert = 0x1,
        [Obsolete("Deprecated in favour of \"UseAlpha\"")]
        [NativeName("Name", "aiTextureFlags_UseAlpha")]
        TextureFlagsUseAlpha = 0x2,
        [Obsolete("Deprecated in favour of \"IgnoreAlpha\"")]
        [NativeName("Name", "aiTextureFlags_IgnoreAlpha")]
        TextureFlagsIgnoreAlpha = 0x4,
        [NativeName("Name", "aiTextureFlags_Invert")]
        Invert = 0x1,
        [NativeName("Name", "aiTextureFlags_UseAlpha")]
        UseAlpha = 0x2,
        [NativeName("Name", "aiTextureFlags_IgnoreAlpha")]
        IgnoreAlpha = 0x4,
    }
}
