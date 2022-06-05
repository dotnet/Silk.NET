// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FragmentLightModelParameterSGIX")]
    public enum FragmentLightModelParameterSGIX : int
    {
        [Obsolete("Deprecated in favour of \"LocalViewerSgix\"")]
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
        FragmentLightModelLocalViewerSgix = 0x8408,
        [Obsolete("Deprecated in favour of \"TwoSideSgix\"")]
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
        FragmentLightModelTwoSideSgix = 0x8409,
        [Obsolete("Deprecated in favour of \"AmbientSgix\"")]
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
        FragmentLightModelAmbientSgix = 0x840A,
        [Obsolete("Deprecated in favour of \"NormalInterpolationSgix\"")]
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
        FragmentLightModelNormalInterpolationSgix = 0x840B,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
        LocalViewerSgix = 0x8408,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
        TwoSideSgix = 0x8409,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
        AmbientSgix = 0x840A,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
        NormalInterpolationSgix = 0x840B,
    }
}
