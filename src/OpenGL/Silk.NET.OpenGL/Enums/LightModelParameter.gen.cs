// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "LightModelParameter")]
    public enum LightModelParameter : int
    {
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
        LightModelColorControlExt = 0x81F8,
    }
}
