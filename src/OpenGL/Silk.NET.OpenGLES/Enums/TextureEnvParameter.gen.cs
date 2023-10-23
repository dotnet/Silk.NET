// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TextureEnvParameter")]
    public enum TextureEnvParameter : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA_SCALE")]
        AlphaScale = 0xD1C,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_ENV_MODE")]
        TextureEnvMode = 0x2200,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_ENV_COLOR")]
        TextureEnvColor = 0x2201,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS")]
        TextureLodBias = 0x8501,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COMBINE")]
        Combine = 0x8570,
        [NativeName("Name", "GL_COMBINE_ARB")]
        CombineArb = 0x8570,
        [NativeName("Name", "GL_COMBINE_EXT")]
        CombineExt = 0x8570,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COMBINE_RGB")]
        CombineRgb = 0x8571,
        [NativeName("Name", "GL_COMBINE_RGB_ARB")]
        CombineRgbArb = 0x8571,
        [NativeName("Name", "GL_COMBINE_RGB_EXT")]
        CombineRgbExt = 0x8571,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COMBINE_ALPHA")]
        CombineAlpha = 0x8572,
        [NativeName("Name", "GL_COMBINE_ALPHA_ARB")]
        CombineAlphaArb = 0x8572,
        [NativeName("Name", "GL_COMBINE_ALPHA_EXT")]
        CombineAlphaExt = 0x8572,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_RGB_SCALE")]
        RgbScale = 0x8573,
        [NativeName("Name", "GL_RGB_SCALE_ARB")]
        RgbScaleArb = 0x8573,
        [NativeName("Name", "GL_RGB_SCALE_EXT")]
        RgbScaleExt = 0x8573,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ADD_SIGNED")]
        AddSigned = 0x8574,
        [NativeName("Name", "GL_ADD_SIGNED_ARB")]
        AddSignedArb = 0x8574,
        [NativeName("Name", "GL_ADD_SIGNED_EXT")]
        AddSignedExt = 0x8574,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INTERPOLATE")]
        Interpolate = 0x8575,
        [NativeName("Name", "GL_INTERPOLATE_ARB")]
        InterpolateArb = 0x8575,
        [NativeName("Name", "GL_INTERPOLATE_EXT")]
        InterpolateExt = 0x8575,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CONSTANT")]
        Constant = 0x8576,
        [NativeName("Name", "GL_CONSTANT_ARB")]
        ConstantArb = 0x8576,
        [NativeName("Name", "GL_CONSTANT_EXT")]
        ConstantExt = 0x8576,
        [NativeName("Name", "GL_CONSTANT_NV")]
        ConstantNV = 0x8576,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PRIMARY_COLOR")]
        PrimaryColor = 0x8577,
        [NativeName("Name", "GL_PRIMARY_COLOR_ARB")]
        PrimaryColorArb = 0x8577,
        [NativeName("Name", "GL_PRIMARY_COLOR_EXT")]
        PrimaryColorExt = 0x8577,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PREVIOUS")]
        Previous = 0x8578,
        [NativeName("Name", "GL_PREVIOUS_ARB")]
        PreviousArb = 0x8578,
        [NativeName("Name", "GL_PREVIOUS_EXT")]
        PreviousExt = 0x8578,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SOURCE0_RGB")]
        Source0Rgb = 0x8580,
        [NativeName("Name", "GL_SOURCE0_RGB_ARB")]
        Source0RgbArb = 0x8580,
        [NativeName("Name", "GL_SOURCE0_RGB_EXT")]
        Source0RgbExt = 0x8580,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SRC0_RGB")]
        Src0Rgb = 0x8580,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SOURCE1_RGB")]
        Source1Rgb = 0x8581,
        [NativeName("Name", "GL_SOURCE1_RGB_ARB")]
        Source1RgbArb = 0x8581,
        [NativeName("Name", "GL_SOURCE1_RGB_EXT")]
        Source1RgbExt = 0x8581,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SRC1_RGB")]
        Src1Rgb = 0x8581,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SOURCE2_RGB")]
        Source2Rgb = 0x8582,
        [NativeName("Name", "GL_SOURCE2_RGB_ARB")]
        Source2RgbArb = 0x8582,
        [NativeName("Name", "GL_SOURCE2_RGB_EXT")]
        Source2RgbExt = 0x8582,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SRC2_RGB")]
        Src2Rgb = 0x8582,
        [NativeName("Name", "GL_SOURCE3_RGB_NV")]
        Source3RgbNV = 0x8583,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SOURCE0_ALPHA")]
        Source0Alpha = 0x8588,
        [NativeName("Name", "GL_SOURCE0_ALPHA_ARB")]
        Source0AlphaArb = 0x8588,
        [NativeName("Name", "GL_SOURCE0_ALPHA_EXT")]
        Source0AlphaExt = 0x8588,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SRC0_ALPHA")]
        Src0Alpha = 0x8588,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SOURCE1_ALPHA")]
        Source1Alpha = 0x8589,
        [NativeName("Name", "GL_SOURCE1_ALPHA_ARB")]
        Source1AlphaArb = 0x8589,
        [NativeName("Name", "GL_SOURCE1_ALPHA_EXT")]
        Source1AlphaExt = 0x8589,
        [NativeName("Name", "GL_SRC1_ALPHA")]
        Src1Alpha = 0x8589,
        [NativeName("Name", "GL_SRC1_ALPHA_EXT")]
        Src1AlphaExt = 0x8589,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SOURCE2_ALPHA")]
        Source2Alpha = 0x858A,
        [NativeName("Name", "GL_SOURCE2_ALPHA_ARB")]
        Source2AlphaArb = 0x858A,
        [NativeName("Name", "GL_SOURCE2_ALPHA_EXT")]
        Source2AlphaExt = 0x858A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SRC2_ALPHA")]
        Src2Alpha = 0x858A,
        [NativeName("Name", "GL_SOURCE3_ALPHA_NV")]
        Source3AlphaNV = 0x858B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OPERAND0_RGB")]
        Operand0Rgb = 0x8590,
        [NativeName("Name", "GL_OPERAND0_RGB_ARB")]
        Operand0RgbArb = 0x8590,
        [NativeName("Name", "GL_OPERAND0_RGB_EXT")]
        Operand0RgbExt = 0x8590,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OPERAND1_RGB")]
        Operand1Rgb = 0x8591,
        [NativeName("Name", "GL_OPERAND1_RGB_ARB")]
        Operand1RgbArb = 0x8591,
        [NativeName("Name", "GL_OPERAND1_RGB_EXT")]
        Operand1RgbExt = 0x8591,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OPERAND2_RGB")]
        Operand2Rgb = 0x8592,
        [NativeName("Name", "GL_OPERAND2_RGB_ARB")]
        Operand2RgbArb = 0x8592,
        [NativeName("Name", "GL_OPERAND2_RGB_EXT")]
        Operand2RgbExt = 0x8592,
        [NativeName("Name", "GL_OPERAND3_RGB_NV")]
        Operand3RgbNV = 0x8593,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OPERAND0_ALPHA")]
        Operand0Alpha = 0x8598,
        [NativeName("Name", "GL_OPERAND0_ALPHA_ARB")]
        Operand0AlphaArb = 0x8598,
        [NativeName("Name", "GL_OPERAND0_ALPHA_EXT")]
        Operand0AlphaExt = 0x8598,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OPERAND1_ALPHA")]
        Operand1Alpha = 0x8599,
        [NativeName("Name", "GL_OPERAND1_ALPHA_ARB")]
        Operand1AlphaArb = 0x8599,
        [NativeName("Name", "GL_OPERAND1_ALPHA_EXT")]
        Operand1AlphaExt = 0x8599,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OPERAND2_ALPHA")]
        Operand2Alpha = 0x859A,
        [NativeName("Name", "GL_OPERAND2_ALPHA_ARB")]
        Operand2AlphaArb = 0x859A,
        [NativeName("Name", "GL_OPERAND2_ALPHA_EXT")]
        Operand2AlphaExt = 0x859A,
        [NativeName("Name", "GL_OPERAND3_ALPHA_NV")]
        Operand3AlphaNV = 0x859B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COORD_REPLACE")]
        CoordReplace = 0x8862,
    }
}
