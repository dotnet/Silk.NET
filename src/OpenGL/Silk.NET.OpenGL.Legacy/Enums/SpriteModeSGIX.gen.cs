// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SpriteModeSGIX")]
    public enum SpriteModeSGIX : int
    {
        [Obsolete("Deprecated in favour of \"AxialSgix\"")]
        [NativeName("Name", "GL_SPRITE_AXIAL_SGIX")]
        SpriteAxialSgix = 0x814C,
        [Obsolete("Deprecated in favour of \"ObjectAlignedSgix\"")]
        [NativeName("Name", "GL_SPRITE_OBJECT_ALIGNED_SGIX")]
        SpriteObjectAlignedSgix = 0x814D,
        [Obsolete("Deprecated in favour of \"EyeAlignedSgix\"")]
        [NativeName("Name", "GL_SPRITE_EYE_ALIGNED_SGIX")]
        SpriteEyeAlignedSgix = 0x814E,
        [NativeName("Name", "GL_SPRITE_AXIAL_SGIX")]
        AxialSgix = 0x814C,
        [NativeName("Name", "GL_SPRITE_OBJECT_ALIGNED_SGIX")]
        ObjectAlignedSgix = 0x814D,
        [NativeName("Name", "GL_SPRITE_EYE_ALIGNED_SGIX")]
        EyeAlignedSgix = 0x814E,
    }
}
