// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.WGL3DL
{
    [NativeName("Name", "GLenum")]
    public enum WGL3DL : int
    {
        [Obsolete("Deprecated in favour of \"EmitterEnable3DL\"")]
        [NativeName("Name", "WGL_STEREO_EMITTER_ENABLE_3DL")]
        StereoEmitterEnable3DL = 0x2055,
        [Obsolete("Deprecated in favour of \"EmitterDisable3DL\"")]
        [NativeName("Name", "WGL_STEREO_EMITTER_DISABLE_3DL")]
        StereoEmitterDisable3DL = 0x2056,
        [Obsolete("Deprecated in favour of \"PolarityNormal3DL\"")]
        [NativeName("Name", "WGL_STEREO_POLARITY_NORMAL_3DL")]
        StereoPolarityNormal3DL = 0x2057,
        [Obsolete("Deprecated in favour of \"PolarityInvert3DL\"")]
        [NativeName("Name", "WGL_STEREO_POLARITY_INVERT_3DL")]
        StereoPolarityInvert3DL = 0x2058,
        [NativeName("Name", "WGL_STEREO_EMITTER_ENABLE_3DL")]
        EmitterEnable3DL = 0x2055,
        [NativeName("Name", "WGL_STEREO_EMITTER_DISABLE_3DL")]
        EmitterDisable3DL = 0x2056,
        [NativeName("Name", "WGL_STEREO_POLARITY_NORMAL_3DL")]
        PolarityNormal3DL = 0x2057,
        [NativeName("Name", "WGL_STEREO_POLARITY_INVERT_3DL")]
        PolarityInvert3DL = 0x2058,
    }
}
