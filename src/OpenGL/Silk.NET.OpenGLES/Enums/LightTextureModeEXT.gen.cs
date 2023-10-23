// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "LightTextureModeEXT")]
    public enum LightTextureModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"MaterialExt\"")]
        [NativeName("Name", "GL_FRAGMENT_MATERIAL_EXT")]
        FragmentMaterialExt = 0x8349,
        [Obsolete("Deprecated in favour of \"NormalExt\"")]
        [NativeName("Name", "GL_FRAGMENT_NORMAL_EXT")]
        FragmentNormalExt = 0x834A,
        [Obsolete("Deprecated in favour of \"ColorExt\"")]
        [NativeName("Name", "GL_FRAGMENT_COLOR_EXT")]
        FragmentColorExt = 0x834C,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FRAGMENT_DEPTH")]
        FragmentDepth = 0x8452,
        [Obsolete("Deprecated in favour of \"DepthExt\"")]
        [NativeName("Name", "GL_FRAGMENT_DEPTH_EXT")]
        FragmentDepthExt = 0x8452,
        [NativeName("Name", "GL_FRAGMENT_MATERIAL_EXT")]
        MaterialExt = 0x8349,
        [NativeName("Name", "GL_FRAGMENT_NORMAL_EXT")]
        NormalExt = 0x834A,
        [NativeName("Name", "GL_FRAGMENT_COLOR_EXT")]
        ColorExt = 0x834C,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FRAGMENT_DEPTH")]
        Depth = 0x8452,
        [NativeName("Name", "GL_FRAGMENT_DEPTH_EXT")]
        DepthExt = 0x8452,
    }
}
