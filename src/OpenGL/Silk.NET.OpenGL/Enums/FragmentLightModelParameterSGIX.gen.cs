// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FragmentLightModelParameterSGIX")]
    public enum FragmentLightModelParameterSGIX : int
    {
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
        FragmentLightModelLocalViewerSgix = 0x8408,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
        FragmentLightModelTwoSideSgix = 0x8409,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
        FragmentLightModelAmbientSgix = 0x840A,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
        FragmentLightModelNormalInterpolationSgix = 0x840B,
    }
}
