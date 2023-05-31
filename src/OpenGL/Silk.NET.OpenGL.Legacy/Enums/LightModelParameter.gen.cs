// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "LightModelParameter")]
    public enum LightModelParameter : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_LOCAL_VIEWER")]
        LightModelLocalViewer = 0xB51,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_TWO_SIDE")]
        LightModelTwoSide = 0xB52,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_AMBIENT")]
        LightModelAmbient = 0xB53,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL")]
        LightModelColorControl = 0x81F8,
        [Obsolete("Deprecated in favour of \"ColorControlExt\"")]
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
        LightModelColorControlExt = 0x81F8,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_LOCAL_VIEWER")]
        LocalViewer = 0xB51,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_TWO_SIDE")]
        TwoSide = 0xB52,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_AMBIENT")]
        Ambient = 0xB53,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL")]
        ColorControl = 0x81F8,
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
        ColorControlExt = 0x81F8,
    }
}
