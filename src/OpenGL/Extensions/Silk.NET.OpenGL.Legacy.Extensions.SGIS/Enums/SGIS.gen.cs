// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [NativeName("Name", "GLenum")]
    public enum SGIS
    {
        [NativeName("Name", "GL_DETAIL_TEXTURE_2D_SGIS")]
        DetailTexture2DSgis = 0x8095,
        [NativeName("Name", "GL_DETAIL_TEXTURE_2D_BINDING_SGIS")]
        DetailTexture2DBindingSgis = 0x8096,
        [NativeName("Name", "GL_LINEAR_DETAIL_SGIS")]
        LinearDetailSgis = 0x8097,
        [NativeName("Name", "GL_LINEAR_DETAIL_ALPHA_SGIS")]
        LinearDetailAlphaSgis = 0x8098,
        [NativeName("Name", "GL_LINEAR_DETAIL_COLOR_SGIS")]
        LinearDetailColorSgis = 0x8099,
        [NativeName("Name", "GL_DETAIL_TEXTURE_LEVEL_SGIS")]
        DetailTextureLevelSgis = 0x809A,
        [NativeName("Name", "GL_DETAIL_TEXTURE_MODE_SGIS")]
        DetailTextureModeSgis = 0x809B,
        [NativeName("Name", "GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS")]
        DetailTextureFuncPointsSgis = 0x809C,
        [NativeName("Name", "GL_FOG_FUNC_SGIS")]
        FogFuncSgis = 0x812A,
        [NativeName("Name", "GL_FOG_FUNC_POINTS_SGIS")]
        FogFuncPointsSgis = 0x812B,
        [NativeName("Name", "GL_MAX_FOG_FUNC_POINTS_SGIS")]
        MaxFogFuncPointsSgis = 0x812C,
        [NativeName("Name", "GL_GENERATE_MIPMAP_SGIS")]
        GenerateMipmapSgis = 0x8191,
        [NativeName("Name", "GL_GENERATE_MIPMAP_HINT_SGIS")]
        GenerateMipmapHintSgis = 0x8192,
        [NativeName("Name", "GL_MULTISAMPLE_SGIS")]
        MultisampleSgis = 0x809D,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
        SampleAlphaToMaskSgis = 0x809E,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_ONE_SGIS")]
        SampleAlphaToOneSgis = 0x809F,
        [NativeName("Name", "GL_SAMPLE_MASK_SGIS")]
        SampleMaskSgis = 0x80A0,
        [NativeName("Name", "GL_1PASS_SGIS")]
        Gl1PassSgis = 0x80A1,
        [NativeName("Name", "GL_2PASS_0_SGIS")]
        Gl2Pass0Sgis = 0x80A2,
        [NativeName("Name", "GL_2PASS_1_SGIS")]
        Gl2Pass1Sgis = 0x80A3,
        [NativeName("Name", "GL_4PASS_0_SGIS")]
        Gl4Pass0Sgis = 0x80A4,
        [NativeName("Name", "GL_4PASS_1_SGIS")]
        Gl4Pass1Sgis = 0x80A5,
        [NativeName("Name", "GL_4PASS_2_SGIS")]
        Gl4Pass2Sgis = 0x80A6,
        [NativeName("Name", "GL_4PASS_3_SGIS")]
        Gl4Pass3Sgis = 0x80A7,
        [NativeName("Name", "GL_SAMPLE_BUFFERS_SGIS")]
        SampleBuffersSgis = 0x80A8,
        [NativeName("Name", "GL_SAMPLES_SGIS")]
        SamplesSgis = 0x80A9,
        [NativeName("Name", "GL_SAMPLE_MASK_VALUE_SGIS")]
        SampleMaskValueSgis = 0x80AA,
        [NativeName("Name", "GL_SAMPLE_MASK_INVERT_SGIS")]
        SampleMaskInvertSgis = 0x80AB,
        [NativeName("Name", "GL_SAMPLE_PATTERN_SGIS")]
        SamplePatternSgis = 0x80AC,
        [NativeName("Name", "GL_PIXEL_TEXTURE_SGIS")]
        PixelTextureSgis = 0x8353,
        [NativeName("Name", "GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS")]
        PixelFragmentRgbSourceSgis = 0x8354,
        [NativeName("Name", "GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS")]
        PixelFragmentAlphaSourceSgis = 0x8355,
        [NativeName("Name", "GL_PIXEL_GROUP_COLOR_SGIS")]
        PixelGroupColorSgis = 0x8356,
        [NativeName("Name", "GL_EYE_DISTANCE_TO_POINT_SGIS")]
        EyeDistanceToPointSgis = 0x81F0,
        [NativeName("Name", "GL_OBJECT_DISTANCE_TO_POINT_SGIS")]
        ObjectDistanceToPointSgis = 0x81F1,
        [NativeName("Name", "GL_EYE_DISTANCE_TO_LINE_SGIS")]
        EyeDistanceToLineSgis = 0x81F2,
        [NativeName("Name", "GL_OBJECT_DISTANCE_TO_LINE_SGIS")]
        ObjectDistanceToLineSgis = 0x81F3,
        [NativeName("Name", "GL_EYE_POINT_SGIS")]
        EyePointSgis = 0x81F4,
        [NativeName("Name", "GL_OBJECT_POINT_SGIS")]
        ObjectPointSgis = 0x81F5,
        [NativeName("Name", "GL_EYE_LINE_SGIS")]
        EyeLineSgis = 0x81F6,
        [NativeName("Name", "GL_OBJECT_LINE_SGIS")]
        ObjectLineSgis = 0x81F7,
        [NativeName("Name", "GL_POINT_SIZE_MIN_SGIS")]
        PointSizeMinSgis = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MAX_SGIS")]
        PointSizeMaxSgis = 0x8127,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
        PointFadeThresholdSizeSgis = 0x8128,
        [NativeName("Name", "GL_DISTANCE_ATTENUATION_SGIS")]
        DistanceAttenuationSgis = 0x8129,
        [NativeName("Name", "GL_LINEAR_SHARPEN_SGIS")]
        LinearSharpenSgis = 0x80AD,
        [NativeName("Name", "GL_LINEAR_SHARPEN_ALPHA_SGIS")]
        LinearSharpenAlphaSgis = 0x80AE,
        [NativeName("Name", "GL_LINEAR_SHARPEN_COLOR_SGIS")]
        LinearSharpenColorSgis = 0x80AF,
        [NativeName("Name", "GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS")]
        SharpenTextureFuncPointsSgis = 0x80B0,
        [NativeName("Name", "GL_PACK_SKIP_VOLUMES_SGIS")]
        PackSkipVolumesSgis = 0x8130,
        [NativeName("Name", "GL_PACK_IMAGE_DEPTH_SGIS")]
        PackImageDepthSgis = 0x8131,
        [NativeName("Name", "GL_UNPACK_SKIP_VOLUMES_SGIS")]
        UnpackSkipVolumesSgis = 0x8132,
        [NativeName("Name", "GL_UNPACK_IMAGE_DEPTH_SGIS")]
        UnpackImageDepthSgis = 0x8133,
        [NativeName("Name", "GL_TEXTURE_4D_SGIS")]
        Texture4DSgis = 0x8134,
        [NativeName("Name", "GL_PROXY_TEXTURE_4D_SGIS")]
        ProxyTexture4DSgis = 0x8135,
        [NativeName("Name", "GL_TEXTURE_4DSIZE_SGIS")]
        Texture4DsizeSgis = 0x8136,
        [NativeName("Name", "GL_TEXTURE_WRAP_Q_SGIS")]
        TextureWrapQSgis = 0x8137,
        [NativeName("Name", "GL_MAX_4D_TEXTURE_SIZE_SGIS")]
        Max4DTextureSizeSgis = 0x8138,
        [NativeName("Name", "GL_TEXTURE_4D_BINDING_SGIS")]
        Texture4DBindingSgis = 0x814F,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_SGIS")]
        ClampToBorderSgis = 0x812D,
        [NativeName("Name", "GL_TEXTURE_COLOR_WRITEMASK_SGIS")]
        TextureColorWritemaskSgis = 0x81EF,
        [NativeName("Name", "GL_CLAMP_TO_EDGE_SGIS")]
        ClampToEdgeSgis = 0x812F,
        [NativeName("Name", "GL_FILTER4_SGIS")]
        Filter4Sgis = 0x8146,
        [NativeName("Name", "GL_TEXTURE_FILTER4_SIZE_SGIS")]
        TextureFilter4SizeSgis = 0x8147,
        [NativeName("Name", "GL_TEXTURE_MIN_LOD_SGIS")]
        TextureMinLodSgis = 0x813A,
        [NativeName("Name", "GL_TEXTURE_MAX_LOD_SGIS")]
        TextureMaxLodSgis = 0x813B,
        [NativeName("Name", "GL_TEXTURE_BASE_LEVEL_SGIS")]
        TextureBaseLevelSgis = 0x813C,
        [NativeName("Name", "GL_TEXTURE_MAX_LEVEL_SGIS")]
        TextureMaxLevelSgis = 0x813D,
        [NativeName("Name", "GL_DUAL_ALPHA4_SGIS")]
        DualAlpha4Sgis = 0x8110,
        [NativeName("Name", "GL_DUAL_ALPHA8_SGIS")]
        DualAlpha8Sgis = 0x8111,
        [NativeName("Name", "GL_DUAL_ALPHA12_SGIS")]
        DualAlpha12Sgis = 0x8112,
        [NativeName("Name", "GL_DUAL_ALPHA16_SGIS")]
        DualAlpha16Sgis = 0x8113,
        [NativeName("Name", "GL_DUAL_LUMINANCE4_SGIS")]
        DualLuminance4Sgis = 0x8114,
        [NativeName("Name", "GL_DUAL_LUMINANCE8_SGIS")]
        DualLuminance8Sgis = 0x8115,
        [NativeName("Name", "GL_DUAL_LUMINANCE12_SGIS")]
        DualLuminance12Sgis = 0x8116,
        [NativeName("Name", "GL_DUAL_LUMINANCE16_SGIS")]
        DualLuminance16Sgis = 0x8117,
        [NativeName("Name", "GL_DUAL_INTENSITY4_SGIS")]
        DualIntensity4Sgis = 0x8118,
        [NativeName("Name", "GL_DUAL_INTENSITY8_SGIS")]
        DualIntensity8Sgis = 0x8119,
        [NativeName("Name", "GL_DUAL_INTENSITY12_SGIS")]
        DualIntensity12Sgis = 0x811A,
        [NativeName("Name", "GL_DUAL_INTENSITY16_SGIS")]
        DualIntensity16Sgis = 0x811B,
        [NativeName("Name", "GL_DUAL_LUMINANCE_ALPHA4_SGIS")]
        DualLuminanceAlpha4Sgis = 0x811C,
        [NativeName("Name", "GL_DUAL_LUMINANCE_ALPHA8_SGIS")]
        DualLuminanceAlpha8Sgis = 0x811D,
        [NativeName("Name", "GL_QUAD_ALPHA4_SGIS")]
        QuadAlpha4Sgis = 0x811E,
        [NativeName("Name", "GL_QUAD_ALPHA8_SGIS")]
        QuadAlpha8Sgis = 0x811F,
        [NativeName("Name", "GL_QUAD_LUMINANCE4_SGIS")]
        QuadLuminance4Sgis = 0x8120,
        [NativeName("Name", "GL_QUAD_LUMINANCE8_SGIS")]
        QuadLuminance8Sgis = 0x8121,
        [NativeName("Name", "GL_QUAD_INTENSITY4_SGIS")]
        QuadIntensity4Sgis = 0x8122,
        [NativeName("Name", "GL_QUAD_INTENSITY8_SGIS")]
        QuadIntensity8Sgis = 0x8123,
        [NativeName("Name", "GL_DUAL_TEXTURE_SELECT_SGIS")]
        DualTextureSelectSgis = 0x8124,
        [NativeName("Name", "GL_QUAD_TEXTURE_SELECT_SGIS")]
        QuadTextureSelectSgis = 0x8125,
    }
}
