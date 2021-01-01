// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTUREOP")]
    public enum Textureop : int
    {
        [NativeName("Name", "D3DTOP_DISABLE")]
        TopDisable = 0x1,
        [NativeName("Name", "D3DTOP_SELECTARG1")]
        TopSelectarg1 = 0x2,
        [NativeName("Name", "D3DTOP_SELECTARG2")]
        TopSelectarg2 = 0x3,
        [NativeName("Name", "D3DTOP_MODULATE")]
        TopModulate = 0x4,
        [NativeName("Name", "D3DTOP_MODULATE2X")]
        TopModulate2X = 0x5,
        [NativeName("Name", "D3DTOP_MODULATE4X")]
        TopModulate4X = 0x6,
        [NativeName("Name", "D3DTOP_ADD")]
        TopAdd = 0x7,
        [NativeName("Name", "D3DTOP_ADDSIGNED")]
        TopAddsigned = 0x8,
        [NativeName("Name", "D3DTOP_ADDSIGNED2X")]
        TopAddsigned2X = 0x9,
        [NativeName("Name", "D3DTOP_SUBTRACT")]
        TopSubtract = 0xA,
        [NativeName("Name", "D3DTOP_ADDSMOOTH")]
        TopAddsmooth = 0xB,
        [NativeName("Name", "D3DTOP_BLENDDIFFUSEALPHA")]
        TopBlenddiffusealpha = 0xC,
        [NativeName("Name", "D3DTOP_BLENDTEXTUREALPHA")]
        TopBlendtexturealpha = 0xD,
        [NativeName("Name", "D3DTOP_BLENDFACTORALPHA")]
        TopBlendfactoralpha = 0xE,
        [NativeName("Name", "D3DTOP_BLENDTEXTUREALPHAPM")]
        TopBlendtexturealphapm = 0xF,
        [NativeName("Name", "D3DTOP_BLENDCURRENTALPHA")]
        TopBlendcurrentalpha = 0x10,
        [NativeName("Name", "D3DTOP_PREMODULATE")]
        TopPremodulate = 0x11,
        [NativeName("Name", "D3DTOP_MODULATEALPHA_ADDCOLOR")]
        TopModulatealphaAddcolor = 0x12,
        [NativeName("Name", "D3DTOP_MODULATECOLOR_ADDALPHA")]
        TopModulatecolorAddalpha = 0x13,
        [NativeName("Name", "D3DTOP_MODULATEINVALPHA_ADDCOLOR")]
        TopModulateinvalphaAddcolor = 0x14,
        [NativeName("Name", "D3DTOP_MODULATEINVCOLOR_ADDALPHA")]
        TopModulateinvcolorAddalpha = 0x15,
        [NativeName("Name", "D3DTOP_BUMPENVMAP")]
        TopBumpenvmap = 0x16,
        [NativeName("Name", "D3DTOP_BUMPENVMAPLUMINANCE")]
        TopBumpenvmapluminance = 0x17,
        [NativeName("Name", "D3DTOP_DOTPRODUCT3")]
        TopDotproduct3 = 0x18,
        [NativeName("Name", "D3DTOP_MULTIPLYADD")]
        TopMultiplyadd = 0x19,
        [NativeName("Name", "D3DTOP_LERP")]
        TopLerp = 0x1A,
        [NativeName("Name", "D3DTOP_FORCE_DWORD")]
        TopForceDword = 0x7FFFFFFF,
    }
}
