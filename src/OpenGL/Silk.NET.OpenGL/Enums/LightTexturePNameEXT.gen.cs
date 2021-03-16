// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "LightTexturePNameEXT")]
    public enum LightTexturePNameEXT : int
    {
        [NativeName("Name", "GL_ATTENUATION_EXT")]
        AttenuationExt = 0x834D,
        [NativeName("Name", "GL_SHADOW_ATTENUATION_EXT")]
        ShadowAttenuationExt = 0x834E,
    }
}
