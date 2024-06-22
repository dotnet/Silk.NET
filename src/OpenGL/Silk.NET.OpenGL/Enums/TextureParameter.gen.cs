// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TextureParameter")]
    public enum TextureParameter : int
    {
        [Obsolete("Deprecated in favour of \"YDegammaQCom\"")]
        [NativeName("Name", "GL_TEXTURE_Y_DEGAMMA_QCOM")]
        TextureYDegammaQCom = 0x9710,
        [Obsolete("Deprecated in favour of \"CbcrDegammaQCom\"")]
        [NativeName("Name", "GL_TEXTURE_CBCR_DEGAMMA_QCOM")]
        TextureCbcrDegammaQCom = 0x9711,
        [NativeName("Name", "GL_TEXTURE_Y_DEGAMMA_QCOM")]
        YDegammaQCom = 0x9710,
        [NativeName("Name", "GL_TEXTURE_CBCR_DEGAMMA_QCOM")]
        CbcrDegammaQCom = 0x9711,
    }
}
