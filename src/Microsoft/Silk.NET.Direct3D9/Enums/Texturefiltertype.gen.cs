// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTUREFILTERTYPE")]
    public enum Texturefiltertype : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3DTEXF_NONE")]
        TexfNone = 0x0,
        [Obsolete("Deprecated in favour of \"Point\"")]
        [NativeName("Name", "D3DTEXF_POINT")]
        TexfPoint = 0x1,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "D3DTEXF_LINEAR")]
        TexfLinear = 0x2,
        [Obsolete("Deprecated in favour of \"Anisotropic\"")]
        [NativeName("Name", "D3DTEXF_ANISOTROPIC")]
        TexfAnisotropic = 0x3,
        [Obsolete("Deprecated in favour of \"Pyramidalquad\"")]
        [NativeName("Name", "D3DTEXF_PYRAMIDALQUAD")]
        TexfPyramidalquad = 0x6,
        [Obsolete("Deprecated in favour of \"Gaussianquad\"")]
        [NativeName("Name", "D3DTEXF_GAUSSIANQUAD")]
        TexfGaussianquad = 0x7,
        [Obsolete("Deprecated in favour of \"Convolutionmono\"")]
        [NativeName("Name", "D3DTEXF_CONVOLUTIONMONO")]
        TexfConvolutionmono = 0x8,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DTEXF_FORCE_DWORD")]
        TexfForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DTEXF_NONE")]
        None = 0x0,
        [NativeName("Name", "D3DTEXF_POINT")]
        Point = 0x1,
        [NativeName("Name", "D3DTEXF_LINEAR")]
        Linear = 0x2,
        [NativeName("Name", "D3DTEXF_ANISOTROPIC")]
        Anisotropic = 0x3,
        [NativeName("Name", "D3DTEXF_PYRAMIDALQUAD")]
        Pyramidalquad = 0x6,
        [NativeName("Name", "D3DTEXF_GAUSSIANQUAD")]
        Gaussianquad = 0x7,
        [NativeName("Name", "D3DTEXF_CONVOLUTIONMONO")]
        Convolutionmono = 0x8,
        [NativeName("Name", "D3DTEXF_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
