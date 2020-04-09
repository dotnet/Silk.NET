// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Legacy.Extensions.HP
{
    public enum HP
    {
        IgnoreBorderHP = 0x8150,
        ConstantBorderHP = 0x8151,
        ReplicateBorderHP = 0x8153,
        ConvolutionBorderColorHP = 0x8154,
        ImageScaleXHP = 0x8155,
        ImageScaleYHP = 0x8156,
        ImageTranslateXHP = 0x8157,
        ImageTranslateYHP = 0x8158,
        ImageRotateAngleHP = 0x8159,
        ImageRotateOriginXHP = 0x815A,
        ImageRotateOriginYHP = 0x815B,
        ImageMagFilterHP = 0x815C,
        ImageMinFilterHP = 0x815D,
        ImageCubicWeightHP = 0x815E,
        CubicHP = 0x815F,
        AverageHP = 0x8160,
        ImageTransform2DHP = 0x8161,
        PostImageTransformColorTableHP = 0x8162,
        ProxyPostImageTransformColorTableHP = 0x8163,
        OcclusionTestHP = 0x8165,
        OcclusionTestResultHP = 0x8166,
        TextureLightingModeHP = 0x8167,
        TexturePostSpecularHP = 0x8168,
        TexturePreSpecularHP = 0x8169,
    }
}
