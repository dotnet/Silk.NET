// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTUREOP")]
    public enum Textureop : int
    {
        [Obsolete("Deprecated in favour of \"Disable\"")]
        [NativeName("Name", "D3DTOP_DISABLE")]
        TopDisable = 0x1,
        [Obsolete("Deprecated in favour of \"Selectarg1\"")]
        [NativeName("Name", "D3DTOP_SELECTARG1")]
        TopSelectarg1 = 0x2,
        [Obsolete("Deprecated in favour of \"Selectarg2\"")]
        [NativeName("Name", "D3DTOP_SELECTARG2")]
        TopSelectarg2 = 0x3,
        [Obsolete("Deprecated in favour of \"Modulate\"")]
        [NativeName("Name", "D3DTOP_MODULATE")]
        TopModulate = 0x4,
        [Obsolete("Deprecated in favour of \"Modulate2X\"")]
        [NativeName("Name", "D3DTOP_MODULATE2X")]
        TopModulate2X = 0x5,
        [Obsolete("Deprecated in favour of \"Modulate4X\"")]
        [NativeName("Name", "D3DTOP_MODULATE4X")]
        TopModulate4X = 0x6,
        [Obsolete("Deprecated in favour of \"Add\"")]
        [NativeName("Name", "D3DTOP_ADD")]
        TopAdd = 0x7,
        [Obsolete("Deprecated in favour of \"Addsigned\"")]
        [NativeName("Name", "D3DTOP_ADDSIGNED")]
        TopAddsigned = 0x8,
        [Obsolete("Deprecated in favour of \"Addsigned2X\"")]
        [NativeName("Name", "D3DTOP_ADDSIGNED2X")]
        TopAddsigned2X = 0x9,
        [Obsolete("Deprecated in favour of \"Subtract\"")]
        [NativeName("Name", "D3DTOP_SUBTRACT")]
        TopSubtract = 0xA,
        [Obsolete("Deprecated in favour of \"Addsmooth\"")]
        [NativeName("Name", "D3DTOP_ADDSMOOTH")]
        TopAddsmooth = 0xB,
        [Obsolete("Deprecated in favour of \"Blenddiffusealpha\"")]
        [NativeName("Name", "D3DTOP_BLENDDIFFUSEALPHA")]
        TopBlenddiffusealpha = 0xC,
        [Obsolete("Deprecated in favour of \"Blendtexturealpha\"")]
        [NativeName("Name", "D3DTOP_BLENDTEXTUREALPHA")]
        TopBlendtexturealpha = 0xD,
        [Obsolete("Deprecated in favour of \"Blendfactoralpha\"")]
        [NativeName("Name", "D3DTOP_BLENDFACTORALPHA")]
        TopBlendfactoralpha = 0xE,
        [Obsolete("Deprecated in favour of \"Blendtexturealphapm\"")]
        [NativeName("Name", "D3DTOP_BLENDTEXTUREALPHAPM")]
        TopBlendtexturealphapm = 0xF,
        [Obsolete("Deprecated in favour of \"Blendcurrentalpha\"")]
        [NativeName("Name", "D3DTOP_BLENDCURRENTALPHA")]
        TopBlendcurrentalpha = 0x10,
        [Obsolete("Deprecated in favour of \"Premodulate\"")]
        [NativeName("Name", "D3DTOP_PREMODULATE")]
        TopPremodulate = 0x11,
        [Obsolete("Deprecated in favour of \"ModulatealphaAddcolor\"")]
        [NativeName("Name", "D3DTOP_MODULATEALPHA_ADDCOLOR")]
        TopModulatealphaAddcolor = 0x12,
        [Obsolete("Deprecated in favour of \"ModulatecolorAddalpha\"")]
        [NativeName("Name", "D3DTOP_MODULATECOLOR_ADDALPHA")]
        TopModulatecolorAddalpha = 0x13,
        [Obsolete("Deprecated in favour of \"ModulateinvalphaAddcolor\"")]
        [NativeName("Name", "D3DTOP_MODULATEINVALPHA_ADDCOLOR")]
        TopModulateinvalphaAddcolor = 0x14,
        [Obsolete("Deprecated in favour of \"ModulateinvcolorAddalpha\"")]
        [NativeName("Name", "D3DTOP_MODULATEINVCOLOR_ADDALPHA")]
        TopModulateinvcolorAddalpha = 0x15,
        [Obsolete("Deprecated in favour of \"Bumpenvmap\"")]
        [NativeName("Name", "D3DTOP_BUMPENVMAP")]
        TopBumpenvmap = 0x16,
        [Obsolete("Deprecated in favour of \"Bumpenvmapluminance\"")]
        [NativeName("Name", "D3DTOP_BUMPENVMAPLUMINANCE")]
        TopBumpenvmapluminance = 0x17,
        [Obsolete("Deprecated in favour of \"Dotproduct3\"")]
        [NativeName("Name", "D3DTOP_DOTPRODUCT3")]
        TopDotproduct3 = 0x18,
        [Obsolete("Deprecated in favour of \"Multiplyadd\"")]
        [NativeName("Name", "D3DTOP_MULTIPLYADD")]
        TopMultiplyadd = 0x19,
        [Obsolete("Deprecated in favour of \"Lerp\"")]
        [NativeName("Name", "D3DTOP_LERP")]
        TopLerp = 0x1A,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DTOP_FORCE_DWORD")]
        TopForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DTOP_DISABLE")]
        Disable = 0x1,
        [NativeName("Name", "D3DTOP_SELECTARG1")]
        Selectarg1 = 0x2,
        [NativeName("Name", "D3DTOP_SELECTARG2")]
        Selectarg2 = 0x3,
        [NativeName("Name", "D3DTOP_MODULATE")]
        Modulate = 0x4,
        [NativeName("Name", "D3DTOP_MODULATE2X")]
        Modulate2X = 0x5,
        [NativeName("Name", "D3DTOP_MODULATE4X")]
        Modulate4X = 0x6,
        [NativeName("Name", "D3DTOP_ADD")]
        Add = 0x7,
        [NativeName("Name", "D3DTOP_ADDSIGNED")]
        Addsigned = 0x8,
        [NativeName("Name", "D3DTOP_ADDSIGNED2X")]
        Addsigned2X = 0x9,
        [NativeName("Name", "D3DTOP_SUBTRACT")]
        Subtract = 0xA,
        [NativeName("Name", "D3DTOP_ADDSMOOTH")]
        Addsmooth = 0xB,
        [NativeName("Name", "D3DTOP_BLENDDIFFUSEALPHA")]
        Blenddiffusealpha = 0xC,
        [NativeName("Name", "D3DTOP_BLENDTEXTUREALPHA")]
        Blendtexturealpha = 0xD,
        [NativeName("Name", "D3DTOP_BLENDFACTORALPHA")]
        Blendfactoralpha = 0xE,
        [NativeName("Name", "D3DTOP_BLENDTEXTUREALPHAPM")]
        Blendtexturealphapm = 0xF,
        [NativeName("Name", "D3DTOP_BLENDCURRENTALPHA")]
        Blendcurrentalpha = 0x10,
        [NativeName("Name", "D3DTOP_PREMODULATE")]
        Premodulate = 0x11,
        [NativeName("Name", "D3DTOP_MODULATEALPHA_ADDCOLOR")]
        ModulatealphaAddcolor = 0x12,
        [NativeName("Name", "D3DTOP_MODULATECOLOR_ADDALPHA")]
        ModulatecolorAddalpha = 0x13,
        [NativeName("Name", "D3DTOP_MODULATEINVALPHA_ADDCOLOR")]
        ModulateinvalphaAddcolor = 0x14,
        [NativeName("Name", "D3DTOP_MODULATEINVCOLOR_ADDALPHA")]
        ModulateinvcolorAddalpha = 0x15,
        [NativeName("Name", "D3DTOP_BUMPENVMAP")]
        Bumpenvmap = 0x16,
        [NativeName("Name", "D3DTOP_BUMPENVMAPLUMINANCE")]
        Bumpenvmapluminance = 0x17,
        [NativeName("Name", "D3DTOP_DOTPRODUCT3")]
        Dotproduct3 = 0x18,
        [NativeName("Name", "D3DTOP_MULTIPLYADD")]
        Multiplyadd = 0x19,
        [NativeName("Name", "D3DTOP_LERP")]
        Lerp = 0x1A,
        [NativeName("Name", "D3DTOP_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
