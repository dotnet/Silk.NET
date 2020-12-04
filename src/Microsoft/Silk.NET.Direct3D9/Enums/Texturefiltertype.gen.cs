// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTUREFILTERTYPE")]
    public enum Texturefiltertype
    {
        [NativeName("Name", "D3DTEXF_NONE")]
        TexfNone = 0x0,
        [NativeName("Name", "D3DTEXF_POINT")]
        TexfPoint = 0x1,
        [NativeName("Name", "D3DTEXF_LINEAR")]
        TexfLinear = 0x2,
        [NativeName("Name", "D3DTEXF_ANISOTROPIC")]
        TexfAnisotropic = 0x3,
        [NativeName("Name", "D3DTEXF_PYRAMIDALQUAD")]
        TexfPyramidalquad = 0x6,
        [NativeName("Name", "D3DTEXF_GAUSSIANQUAD")]
        TexfGaussianquad = 0x7,
        [NativeName("Name", "D3DTEXF_CONVOLUTIONMONO")]
        TexfConvolutionmono = 0x8,
        [NativeName("Name", "D3DTEXF_FORCE_DWORD")]
        TexfForceDword = 0x7FFFFFFF,
    }
}
