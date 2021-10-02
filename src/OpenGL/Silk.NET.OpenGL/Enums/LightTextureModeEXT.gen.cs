// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "LightTextureModeEXT")]
    public enum LightTextureModeEXT : int
    {
        [NativeName("Name", "GL_FRAGMENT_MATERIAL_EXT")]
        FragmentMaterialExt = 0x8349,
        [NativeName("Name", "GL_FRAGMENT_NORMAL_EXT")]
        FragmentNormalExt = 0x834A,
        [NativeName("Name", "GL_FRAGMENT_COLOR_EXT")]
        FragmentColorExt = 0x834C,
        [NativeName("Name", "GL_FRAGMENT_DEPTH_EXT")]
        FragmentDepthExt = 0x8452,
    }
}
