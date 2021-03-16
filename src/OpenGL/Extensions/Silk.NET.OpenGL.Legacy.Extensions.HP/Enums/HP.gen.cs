// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.HP
{
    [NativeName("Name", "GLenum")]
    public enum HP : int
    {
        [NativeName("Name", "GL_IGNORE_BORDER_HP")]
        IgnoreBorderHP = 0x8150,
        [NativeName("Name", "GL_CONSTANT_BORDER_HP")]
        ConstantBorderHP = 0x8151,
        [NativeName("Name", "GL_REPLICATE_BORDER_HP")]
        ReplicateBorderHP = 0x8153,
        [NativeName("Name", "GL_CONVOLUTION_BORDER_COLOR_HP")]
        ConvolutionBorderColorHP = 0x8154,
        [NativeName("Name", "GL_IMAGE_SCALE_X_HP")]
        ImageScaleXHP = 0x8155,
        [NativeName("Name", "GL_IMAGE_SCALE_Y_HP")]
        ImageScaleYHP = 0x8156,
        [NativeName("Name", "GL_IMAGE_TRANSLATE_X_HP")]
        ImageTranslateXHP = 0x8157,
        [NativeName("Name", "GL_IMAGE_TRANSLATE_Y_HP")]
        ImageTranslateYHP = 0x8158,
        [NativeName("Name", "GL_IMAGE_ROTATE_ANGLE_HP")]
        ImageRotateAngleHP = 0x8159,
        [NativeName("Name", "GL_IMAGE_ROTATE_ORIGIN_X_HP")]
        ImageRotateOriginXHP = 0x815A,
        [NativeName("Name", "GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
        ImageRotateOriginYHP = 0x815B,
        [NativeName("Name", "GL_IMAGE_MAG_FILTER_HP")]
        ImageMagFilterHP = 0x815C,
        [NativeName("Name", "GL_IMAGE_MIN_FILTER_HP")]
        ImageMinFilterHP = 0x815D,
        [NativeName("Name", "GL_IMAGE_CUBIC_WEIGHT_HP")]
        ImageCubicWeightHP = 0x815E,
        [NativeName("Name", "GL_CUBIC_HP")]
        CubicHP = 0x815F,
        [NativeName("Name", "GL_AVERAGE_HP")]
        AverageHP = 0x8160,
        [NativeName("Name", "GL_IMAGE_TRANSFORM_2D_HP")]
        ImageTransform2DHP = 0x8161,
        [NativeName("Name", "GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP")]
        PostImageTransformColorTableHP = 0x8162,
        [NativeName("Name", "GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP")]
        ProxyPostImageTransformColorTableHP = 0x8163,
        [NativeName("Name", "GL_OCCLUSION_TEST_HP")]
        OcclusionTestHP = 0x8165,
        [NativeName("Name", "GL_OCCLUSION_TEST_RESULT_HP")]
        OcclusionTestResultHP = 0x8166,
        [NativeName("Name", "GL_TEXTURE_LIGHTING_MODE_HP")]
        TextureLightingModeHP = 0x8167,
        [NativeName("Name", "GL_TEXTURE_POST_SPECULAR_HP")]
        TexturePostSpecularHP = 0x8168,
        [NativeName("Name", "GL_TEXTURE_PRE_SPECULAR_HP")]
        TexturePreSpecularHP = 0x8169,
    }
}
