// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SizedInternalFormat")]
    public enum SizedInternalFormat : int
    {
        [NativeName("Name", "GL_R3_G3_B2")]
        R3G3B2 = 0x2A10,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA4")]
        Alpha4 = 0x803B,
        [NativeName("Name", "GL_ALPHA4_EXT")]
        Alpha4Ext = 0x803B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA8")]
        Alpha8 = 0x803C,
        [NativeName("Name", "GL_ALPHA8_EXT")]
        Alpha8Ext = 0x803C,
        [NativeName("Name", "GL_ALPHA8_OES")]
        Alpha8Oes = 0x803C,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA12")]
        Alpha12 = 0x803D,
        [NativeName("Name", "GL_ALPHA12_EXT")]
        Alpha12Ext = 0x803D,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALPHA16")]
        Alpha16 = 0x803E,
        [NativeName("Name", "GL_ALPHA16_EXT")]
        Alpha16Ext = 0x803E,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE4")]
        Luminance4 = 0x803F,
        [NativeName("Name", "GL_LUMINANCE4_EXT")]
        Luminance4Ext = 0x803F,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE8")]
        Luminance8 = 0x8040,
        [NativeName("Name", "GL_LUMINANCE8_EXT")]
        Luminance8Ext = 0x8040,
        [NativeName("Name", "GL_LUMINANCE8_OES")]
        Luminance8Oes = 0x8040,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE12")]
        Luminance12 = 0x8041,
        [NativeName("Name", "GL_LUMINANCE12_EXT")]
        Luminance12Ext = 0x8041,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE16")]
        Luminance16 = 0x8042,
        [NativeName("Name", "GL_LUMINANCE16_EXT")]
        Luminance16Ext = 0x8042,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE4_ALPHA4")]
        Luminance4Alpha4 = 0x8043,
        [NativeName("Name", "GL_LUMINANCE4_ALPHA4_EXT")]
        Luminance4Alpha4Ext = 0x8043,
        [NativeName("Name", "GL_LUMINANCE4_ALPHA4_OES")]
        Luminance4Alpha4Oes = 0x8043,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE6_ALPHA2")]
        Luminance6Alpha2 = 0x8044,
        [NativeName("Name", "GL_LUMINANCE6_ALPHA2_EXT")]
        Luminance6Alpha2Ext = 0x8044,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE8_ALPHA8")]
        Luminance8Alpha8 = 0x8045,
        [NativeName("Name", "GL_LUMINANCE8_ALPHA8_EXT")]
        Luminance8Alpha8Ext = 0x8045,
        [NativeName("Name", "GL_LUMINANCE8_ALPHA8_OES")]
        Luminance8Alpha8Oes = 0x8045,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE12_ALPHA4")]
        Luminance12Alpha4 = 0x8046,
        [NativeName("Name", "GL_LUMINANCE12_ALPHA4_EXT")]
        Luminance12Alpha4Ext = 0x8046,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE12_ALPHA12")]
        Luminance12Alpha12 = 0x8047,
        [NativeName("Name", "GL_LUMINANCE12_ALPHA12_EXT")]
        Luminance12Alpha12Ext = 0x8047,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE16_ALPHA16")]
        Luminance16Alpha16 = 0x8048,
        [NativeName("Name", "GL_LUMINANCE16_ALPHA16_EXT")]
        Luminance16Alpha16Ext = 0x8048,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INTENSITY4")]
        Intensity4 = 0x804A,
        [NativeName("Name", "GL_INTENSITY4_EXT")]
        Intensity4Ext = 0x804A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INTENSITY8")]
        Intensity8 = 0x804B,
        [NativeName("Name", "GL_INTENSITY8_EXT")]
        Intensity8Ext = 0x804B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INTENSITY12")]
        Intensity12 = 0x804C,
        [NativeName("Name", "GL_INTENSITY12_EXT")]
        Intensity12Ext = 0x804C,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INTENSITY16")]
        Intensity16 = 0x804D,
        [NativeName("Name", "GL_INTENSITY16_EXT")]
        Intensity16Ext = 0x804D,
        [NativeName("Name", "GL_RGB2_EXT")]
        Rgb2Ext = 0x804E,
        [NativeName("Name", "GL_RGB4")]
        Rgb4 = 0x804F,
        [NativeName("Name", "GL_RGB4_EXT")]
        Rgb4Ext = 0x804F,
        [NativeName("Name", "GL_RGB5")]
        Rgb5 = 0x8050,
        [NativeName("Name", "GL_RGB5_EXT")]
        Rgb5Ext = 0x8050,
        [NativeName("Name", "GL_RGB8")]
        Rgb8 = 0x8051,
        [NativeName("Name", "GL_RGB8_EXT")]
        Rgb8Ext = 0x8051,
        [NativeName("Name", "GL_RGB8_OES")]
        Rgb8Oes = 0x8051,
        [NativeName("Name", "GL_RGB10")]
        Rgb10 = 0x8052,
        [NativeName("Name", "GL_RGB10_EXT")]
        Rgb10Ext = 0x8052,
        [NativeName("Name", "GL_RGB12")]
        Rgb12 = 0x8053,
        [NativeName("Name", "GL_RGB12_EXT")]
        Rgb12Ext = 0x8053,
        [NativeName("Name", "GL_RGB16")]
        Rgb16 = 0x8054,
        [NativeName("Name", "GL_RGB16_EXT")]
        Rgb16Ext = 0x8054,
        [NativeName("Name", "GL_RGBA2")]
        Rgba2 = 0x8055,
        [NativeName("Name", "GL_RGBA2_EXT")]
        Rgba2Ext = 0x8055,
        [NativeName("Name", "GL_RGBA4")]
        Rgba4 = 0x8056,
        [NativeName("Name", "GL_RGBA4_EXT")]
        Rgba4Ext = 0x8056,
        [NativeName("Name", "GL_RGBA4_OES")]
        Rgba4Oes = 0x8056,
        [NativeName("Name", "GL_RGB5_A1")]
        Rgb5A1 = 0x8057,
        [NativeName("Name", "GL_RGB5_A1_EXT")]
        Rgb5A1Ext = 0x8057,
        [NativeName("Name", "GL_RGB5_A1_OES")]
        Rgb5A1Oes = 0x8057,
        [NativeName("Name", "GL_RGBA8")]
        Rgba8 = 0x8058,
        [NativeName("Name", "GL_RGBA8_EXT")]
        Rgba8Ext = 0x8058,
        [NativeName("Name", "GL_RGBA8_OES")]
        Rgba8Oes = 0x8058,
        [NativeName("Name", "GL_RGB10_A2")]
        Rgb10A2 = 0x8059,
        [NativeName("Name", "GL_RGB10_A2_EXT")]
        Rgb10A2Ext = 0x8059,
        [NativeName("Name", "GL_RGBA12")]
        Rgba12 = 0x805A,
        [NativeName("Name", "GL_RGBA12_EXT")]
        Rgba12Ext = 0x805A,
        [NativeName("Name", "GL_RGBA16")]
        Rgba16 = 0x805B,
        [NativeName("Name", "GL_RGBA16_EXT")]
        Rgba16Ext = 0x805B,
        [NativeName("Name", "GL_DEPTH_COMPONENT16")]
        DepthComponent16 = 0x81A5,
        [NativeName("Name", "GL_DEPTH_COMPONENT16_ARB")]
        DepthComponent16Arb = 0x81A5,
        [NativeName("Name", "GL_DEPTH_COMPONENT16_OES")]
        DepthComponent16Oes = 0x81A5,
        [NativeName("Name", "GL_DEPTH_COMPONENT16_SGIX")]
        DepthComponent16Sgix = 0x81A5,
        [NativeName("Name", "GL_DEPTH_COMPONENT24")]
        DepthComponent24 = 0x81A6,
        [NativeName("Name", "GL_DEPTH_COMPONENT24_ARB")]
        DepthComponent24Arb = 0x81A6,
        [NativeName("Name", "GL_DEPTH_COMPONENT24_OES")]
        DepthComponent24Oes = 0x81A6,
        [NativeName("Name", "GL_DEPTH_COMPONENT24_SGIX")]
        DepthComponent24Sgix = 0x81A6,
        [NativeName("Name", "GL_DEPTH_COMPONENT32")]
        DepthComponent32 = 0x81A7,
        [NativeName("Name", "GL_DEPTH_COMPONENT32_ARB")]
        DepthComponent32Arb = 0x81A7,
        [NativeName("Name", "GL_DEPTH_COMPONENT32_OES")]
        DepthComponent32Oes = 0x81A7,
        [NativeName("Name", "GL_DEPTH_COMPONENT32_SGIX")]
        DepthComponent32Sgix = 0x81A7,
        [NativeName("Name", "GL_R8")]
        R8 = 0x8229,
        [NativeName("Name", "GL_R8_EXT")]
        R8Ext = 0x8229,
        [NativeName("Name", "GL_R16")]
        R16 = 0x822A,
        [NativeName("Name", "GL_R16_EXT")]
        R16Ext = 0x822A,
        [NativeName("Name", "GL_RG8")]
        RG8 = 0x822B,
        [NativeName("Name", "GL_RG8_EXT")]
        RG8Ext = 0x822B,
        [NativeName("Name", "GL_RG16")]
        RG16 = 0x822C,
        [NativeName("Name", "GL_RG16_EXT")]
        RG16Ext = 0x822C,
        [NativeName("Name", "GL_R16F")]
        R16f = 0x822D,
        [NativeName("Name", "GL_R16F_EXT")]
        R16fExt = 0x822D,
        [NativeName("Name", "GL_R32F")]
        R32f = 0x822E,
        [NativeName("Name", "GL_R32F_EXT")]
        R32fExt = 0x822E,
        [NativeName("Name", "GL_RG16F")]
        RG16f = 0x822F,
        [NativeName("Name", "GL_RG16F_EXT")]
        RG16fExt = 0x822F,
        [NativeName("Name", "GL_RG32F")]
        RG32f = 0x8230,
        [NativeName("Name", "GL_RG32F_EXT")]
        RG32fExt = 0x8230,
        [NativeName("Name", "GL_R8I")]
        R8i = 0x8231,
        [NativeName("Name", "GL_R8UI")]
        R8ui = 0x8232,
        [NativeName("Name", "GL_R16I")]
        R16i = 0x8233,
        [NativeName("Name", "GL_R16UI")]
        R16ui = 0x8234,
        [NativeName("Name", "GL_R32I")]
        R32i = 0x8235,
        [NativeName("Name", "GL_R32UI")]
        R32ui = 0x8236,
        [NativeName("Name", "GL_RG8I")]
        RG8i = 0x8237,
        [NativeName("Name", "GL_RG8UI")]
        RG8ui = 0x8238,
        [NativeName("Name", "GL_RG16I")]
        RG16i = 0x8239,
        [NativeName("Name", "GL_RG16UI")]
        RG16ui = 0x823A,
        [NativeName("Name", "GL_RG32I")]
        RG32i = 0x823B,
        [NativeName("Name", "GL_RG32UI")]
        RG32ui = 0x823C,
        [NativeName("Name", "GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
        CompressedRgbS3TCDxt1Ext = 0x83F0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
        CompressedRgbaS3TCDxt1Ext = 0x83F1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE")]
        CompressedRgbaS3TCDxt3Angle = 0x83F2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
        CompressedRgbaS3TCDxt3Ext = 0x83F2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE")]
        CompressedRgbaS3TCDxt5Angle = 0x83F3,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
        CompressedRgbaS3TCDxt5Ext = 0x83F3,
        [NativeName("Name", "GL_RGBA32F")]
        Rgba32f = 0x8814,
        [NativeName("Name", "GL_RGBA32F_ARB")]
        Rgba32fArb = 0x8814,
        [NativeName("Name", "GL_RGBA32F_EXT")]
        Rgba32fExt = 0x8814,
        [NativeName("Name", "GL_RGB32F")]
        Rgb32f = 0x8815,
        [NativeName("Name", "GL_RGB32F_ARB")]
        Rgb32fArb = 0x8815,
        [NativeName("Name", "GL_RGB32F_EXT")]
        Rgb32fExt = 0x8815,
        [NativeName("Name", "GL_RGBA16F")]
        Rgba16f = 0x881A,
        [NativeName("Name", "GL_RGBA16F_ARB")]
        Rgba16fArb = 0x881A,
        [NativeName("Name", "GL_RGBA16F_EXT")]
        Rgba16fExt = 0x881A,
        [NativeName("Name", "GL_RGB16F")]
        Rgb16f = 0x881B,
        [NativeName("Name", "GL_RGB16F_ARB")]
        Rgb16fArb = 0x881B,
        [NativeName("Name", "GL_RGB16F_EXT")]
        Rgb16fExt = 0x881B,
        [NativeName("Name", "GL_DEPTH24_STENCIL8")]
        Depth24Stencil8 = 0x88F0,
        [NativeName("Name", "GL_DEPTH24_STENCIL8_EXT")]
        Depth24Stencil8Ext = 0x88F0,
        [NativeName("Name", "GL_DEPTH24_STENCIL8_OES")]
        Depth24Stencil8Oes = 0x88F0,
        [NativeName("Name", "GL_R11F_G11F_B10F")]
        R11fG11fB10f = 0x8C3A,
        [NativeName("Name", "GL_R11F_G11F_B10F_APPLE")]
        R11fG11fB10fApple = 0x8C3A,
        [NativeName("Name", "GL_R11F_G11F_B10F_EXT")]
        R11fG11fB10fExt = 0x8C3A,
        [NativeName("Name", "GL_RGB9_E5")]
        Rgb9E5 = 0x8C3D,
        [NativeName("Name", "GL_RGB9_E5_APPLE")]
        Rgb9E5Apple = 0x8C3D,
        [NativeName("Name", "GL_RGB9_E5_EXT")]
        Rgb9E5Ext = 0x8C3D,
        [NativeName("Name", "GL_SRGB8")]
        Srgb8 = 0x8C41,
        [NativeName("Name", "GL_SRGB8_EXT")]
        Srgb8Ext = 0x8C41,
        [NativeName("Name", "GL_SRGB8_NV")]
        Srgb8NV = 0x8C41,
        [NativeName("Name", "GL_SRGB8_ALPHA8")]
        Srgb8Alpha8 = 0x8C43,
        [NativeName("Name", "GL_SRGB8_ALPHA8_EXT")]
        Srgb8Alpha8Ext = 0x8C43,
        [NativeName("Name", "GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
        CompressedSrgbS3TCDxt1Ext = 0x8C4C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_S3TC_DXT1_NV")]
        CompressedSrgbS3TCDxt1NV = 0x8C4C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
        CompressedSrgbAlphaS3TCDxt1Ext = 0x8C4D,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV")]
        CompressedSrgbAlphaS3TCDxt1NV = 0x8C4D,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
        CompressedSrgbAlphaS3TCDxt3Ext = 0x8C4E,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV")]
        CompressedSrgbAlphaS3TCDxt3NV = 0x8C4E,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
        CompressedSrgbAlphaS3TCDxt5Ext = 0x8C4F,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV")]
        CompressedSrgbAlphaS3TCDxt5NV = 0x8C4F,
        [NativeName("Name", "GL_DEPTH_COMPONENT32F")]
        DepthComponent32f = 0x8CAC,
        [NativeName("Name", "GL_DEPTH32F_STENCIL8")]
        Depth32fStencil8 = 0x8CAD,
        [NativeName("Name", "GL_STENCIL_INDEX1")]
        StencilIndex1 = 0x8D46,
        [NativeName("Name", "GL_STENCIL_INDEX1_EXT")]
        StencilIndex1Ext = 0x8D46,
        [NativeName("Name", "GL_STENCIL_INDEX1_OES")]
        StencilIndex1Oes = 0x8D46,
        [NativeName("Name", "GL_STENCIL_INDEX4")]
        StencilIndex4 = 0x8D47,
        [NativeName("Name", "GL_STENCIL_INDEX4_EXT")]
        StencilIndex4Ext = 0x8D47,
        [NativeName("Name", "GL_STENCIL_INDEX4_OES")]
        StencilIndex4Oes = 0x8D47,
        [NativeName("Name", "GL_STENCIL_INDEX8")]
        StencilIndex8 = 0x8D48,
        [NativeName("Name", "GL_STENCIL_INDEX8_EXT")]
        StencilIndex8Ext = 0x8D48,
        [NativeName("Name", "GL_STENCIL_INDEX8_OES")]
        StencilIndex8Oes = 0x8D48,
        [NativeName("Name", "GL_STENCIL_INDEX16")]
        StencilIndex16 = 0x8D49,
        [NativeName("Name", "GL_STENCIL_INDEX16_EXT")]
        StencilIndex16Ext = 0x8D49,
        [NativeName("Name", "GL_RGB565_OES")]
        Rgb565Oes = 0x8D62,
        [NativeName("Name", "GL_RGB565")]
        Rgb565 = 0x8D62,
        [NativeName("Name", "GL_ETC1_RGB8_OES")]
        Etc1Rgb8Oes = 0x8D64,
        [NativeName("Name", "GL_RGBA32UI")]
        Rgba32ui = 0x8D70,
        [NativeName("Name", "GL_RGBA32UI_EXT")]
        Rgba32uiExt = 0x8D70,
        [NativeName("Name", "GL_RGB32UI")]
        Rgb32ui = 0x8D71,
        [NativeName("Name", "GL_RGB32UI_EXT")]
        Rgb32uiExt = 0x8D71,
        [NativeName("Name", "GL_ALPHA32UI_EXT")]
        Alpha32uiExt = 0x8D72,
        [NativeName("Name", "GL_INTENSITY32UI_EXT")]
        Intensity32uiExt = 0x8D73,
        [NativeName("Name", "GL_LUMINANCE32UI_EXT")]
        Luminance32uiExt = 0x8D74,
        [NativeName("Name", "GL_LUMINANCE_ALPHA32UI_EXT")]
        LuminanceAlpha32uiExt = 0x8D75,
        [NativeName("Name", "GL_RGBA16UI")]
        Rgba16ui = 0x8D76,
        [NativeName("Name", "GL_RGBA16UI_EXT")]
        Rgba16uiExt = 0x8D76,
        [NativeName("Name", "GL_RGB16UI")]
        Rgb16ui = 0x8D77,
        [NativeName("Name", "GL_RGB16UI_EXT")]
        Rgb16uiExt = 0x8D77,
        [NativeName("Name", "GL_ALPHA16UI_EXT")]
        Alpha16uiExt = 0x8D78,
        [NativeName("Name", "GL_INTENSITY16UI_EXT")]
        Intensity16uiExt = 0x8D79,
        [NativeName("Name", "GL_LUMINANCE16UI_EXT")]
        Luminance16uiExt = 0x8D7A,
        [NativeName("Name", "GL_LUMINANCE_ALPHA16UI_EXT")]
        LuminanceAlpha16uiExt = 0x8D7B,
        [NativeName("Name", "GL_RGBA8UI")]
        Rgba8ui = 0x8D7C,
        [NativeName("Name", "GL_RGBA8UI_EXT")]
        Rgba8uiExt = 0x8D7C,
        [NativeName("Name", "GL_RGB8UI")]
        Rgb8ui = 0x8D7D,
        [NativeName("Name", "GL_RGB8UI_EXT")]
        Rgb8uiExt = 0x8D7D,
        [NativeName("Name", "GL_ALPHA8UI_EXT")]
        Alpha8uiExt = 0x8D7E,
        [NativeName("Name", "GL_INTENSITY8UI_EXT")]
        Intensity8uiExt = 0x8D7F,
        [NativeName("Name", "GL_LUMINANCE8UI_EXT")]
        Luminance8uiExt = 0x8D80,
        [NativeName("Name", "GL_LUMINANCE_ALPHA8UI_EXT")]
        LuminanceAlpha8uiExt = 0x8D81,
        [NativeName("Name", "GL_RGBA32I")]
        Rgba32i = 0x8D82,
        [NativeName("Name", "GL_RGBA32I_EXT")]
        Rgba32iExt = 0x8D82,
        [NativeName("Name", "GL_RGB32I")]
        Rgb32i = 0x8D83,
        [NativeName("Name", "GL_RGB32I_EXT")]
        Rgb32iExt = 0x8D83,
        [NativeName("Name", "GL_ALPHA32I_EXT")]
        Alpha32iExt = 0x8D84,
        [NativeName("Name", "GL_INTENSITY32I_EXT")]
        Intensity32iExt = 0x8D85,
        [NativeName("Name", "GL_LUMINANCE32I_EXT")]
        Luminance32iExt = 0x8D86,
        [NativeName("Name", "GL_LUMINANCE_ALPHA32I_EXT")]
        LuminanceAlpha32iExt = 0x8D87,
        [NativeName("Name", "GL_RGBA16I")]
        Rgba16i = 0x8D88,
        [NativeName("Name", "GL_RGBA16I_EXT")]
        Rgba16iExt = 0x8D88,
        [NativeName("Name", "GL_RGB16I")]
        Rgb16i = 0x8D89,
        [NativeName("Name", "GL_RGB16I_EXT")]
        Rgb16iExt = 0x8D89,
        [NativeName("Name", "GL_ALPHA16I_EXT")]
        Alpha16iExt = 0x8D8A,
        [NativeName("Name", "GL_INTENSITY16I_EXT")]
        Intensity16iExt = 0x8D8B,
        [NativeName("Name", "GL_LUMINANCE16I_EXT")]
        Luminance16iExt = 0x8D8C,
        [NativeName("Name", "GL_LUMINANCE_ALPHA16I_EXT")]
        LuminanceAlpha16iExt = 0x8D8D,
        [NativeName("Name", "GL_RGBA8I")]
        Rgba8i = 0x8D8E,
        [NativeName("Name", "GL_RGBA8I_EXT")]
        Rgba8iExt = 0x8D8E,
        [NativeName("Name", "GL_RGB8I")]
        Rgb8i = 0x8D8F,
        [NativeName("Name", "GL_RGB8I_EXT")]
        Rgb8iExt = 0x8D8F,
        [NativeName("Name", "GL_ALPHA8I_EXT")]
        Alpha8iExt = 0x8D90,
        [NativeName("Name", "GL_INTENSITY8I_EXT")]
        Intensity8iExt = 0x8D91,
        [NativeName("Name", "GL_LUMINANCE8I_EXT")]
        Luminance8iExt = 0x8D92,
        [NativeName("Name", "GL_LUMINANCE_ALPHA8I_EXT")]
        LuminanceAlpha8iExt = 0x8D93,
        [NativeName("Name", "GL_DEPTH_COMPONENT32F_NV")]
        DepthComponent32fNV = 0x8DAB,
        [NativeName("Name", "GL_DEPTH32F_STENCIL8_NV")]
        Depth32fStencil8NV = 0x8DAC,
        [NativeName("Name", "GL_COMPRESSED_RED_RGTC1")]
        CompressedRedRgtc1 = 0x8DBB,
        [NativeName("Name", "GL_COMPRESSED_RED_RGTC1_EXT")]
        CompressedRedRgtc1Ext = 0x8DBB,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RED_RGTC1")]
        CompressedSignedRedRgtc1 = 0x8DBC,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
        CompressedSignedRedRgtc1Ext = 0x8DBC,
        [NativeName("Name", "GL_COMPRESSED_RED_GREEN_RGTC2_EXT")]
        CompressedRedGreenRgtc2Ext = 0x8DBD,
        [NativeName("Name", "GL_COMPRESSED_RG_RGTC2")]
        CompressedRGRgtc2 = 0x8DBD,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
        CompressedSignedRedGreenRgtc2Ext = 0x8DBE,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RG_RGTC2")]
        CompressedSignedRGRgtc2 = 0x8DBE,
        [NativeName("Name", "GL_COMPRESSED_RGBA_BPTC_UNORM")]
        CompressedRgbaBptcUnorm = 0x8E8C,
        [NativeName("Name", "GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
        CompressedRgbaBptcUnormArb = 0x8E8C,
        [NativeName("Name", "GL_COMPRESSED_RGBA_BPTC_UNORM_EXT")]
        CompressedRgbaBptcUnormExt = 0x8E8C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM")]
        CompressedSrgbAlphaBptcUnorm = 0x8E8D,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
        CompressedSrgbAlphaBptcUnormArb = 0x8E8D,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT")]
        CompressedSrgbAlphaBptcUnormExt = 0x8E8D,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT")]
        CompressedRgbBptcSignedFloat = 0x8E8E,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
        CompressedRgbBptcSignedFloatArb = 0x8E8E,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT")]
        CompressedRgbBptcSignedFloatExt = 0x8E8E,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT")]
        CompressedRgbBptcUnsignedFloat = 0x8E8F,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
        CompressedRgbBptcUnsignedFloatArb = 0x8E8F,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT")]
        CompressedRgbBptcUnsignedFloatExt = 0x8E8F,
        [NativeName("Name", "GL_R8_SNORM")]
        R8SNorm = 0x8F94,
        [NativeName("Name", "GL_RG8_SNORM")]
        RG8SNorm = 0x8F95,
        [NativeName("Name", "GL_RGB8_SNORM")]
        Rgb8SNorm = 0x8F96,
        [NativeName("Name", "GL_RGBA8_SNORM")]
        Rgba8SNorm = 0x8F97,
        [NativeName("Name", "GL_R16_SNORM")]
        R16SNorm = 0x8F98,
        [NativeName("Name", "GL_R16_SNORM_EXT")]
        R16SNormExt = 0x8F98,
        [NativeName("Name", "GL_RG16_SNORM")]
        RG16SNorm = 0x8F99,
        [NativeName("Name", "GL_RG16_SNORM_EXT")]
        RG16SNormExt = 0x8F99,
        [NativeName("Name", "GL_RGB16_SNORM")]
        Rgb16SNorm = 0x8F9A,
        [NativeName("Name", "GL_RGB16_SNORM_EXT")]
        Rgb16SNormExt = 0x8F9A,
        [NativeName("Name", "GL_RGBA16_SNORM")]
        Rgba16SNorm = 0x8F9B,
        [NativeName("Name", "GL_RGBA16_SNORM_EXT")]
        Rgba16SNormExt = 0x8F9B,
        [NativeName("Name", "GL_RGB10_A2UI")]
        Rgb10A2ui = 0x906F,
        [NativeName("Name", "GL_COMPRESSED_R11_EAC")]
        CompressedR11Eac = 0x9270,
        [NativeName("Name", "GL_COMPRESSED_R11_EAC_OES")]
        CompressedR11EacOes = 0x9270,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_R11_EAC")]
        CompressedSignedR11Eac = 0x9271,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_R11_EAC_OES")]
        CompressedSignedR11EacOes = 0x9271,
        [NativeName("Name", "GL_COMPRESSED_RG11_EAC")]
        CompressedRG11Eac = 0x9272,
        [NativeName("Name", "GL_COMPRESSED_RG11_EAC_OES")]
        CompressedRG11EacOes = 0x9272,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RG11_EAC")]
        CompressedSignedRG11Eac = 0x9273,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RG11_EAC_OES")]
        CompressedSignedRG11EacOes = 0x9273,
        [NativeName("Name", "GL_COMPRESSED_RGB8_ETC2")]
        CompressedRgb8Etc2 = 0x9274,
        [NativeName("Name", "GL_COMPRESSED_RGB8_ETC2_OES")]
        CompressedRgb8Etc2Oes = 0x9274,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ETC2")]
        CompressedSrgb8Etc2 = 0x9275,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ETC2_OES")]
        CompressedSrgb8Etc2Oes = 0x9275,
        [NativeName("Name", "GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
        [NativeName("Name", "GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2_OES")]
        CompressedRgb8PunchthroughAlpha1Etc2Oes = 0x9276,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2_OES")]
        CompressedSrgb8PunchthroughAlpha1Etc2Oes = 0x9277,
        [NativeName("Name", "GL_COMPRESSED_RGBA8_ETC2_EAC")]
        CompressedRgba8Etc2Eac = 0x9278,
        [NativeName("Name", "GL_COMPRESSED_RGBA8_ETC2_EAC_OES")]
        CompressedRgba8Etc2EacOes = 0x9278,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC")]
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC_OES")]
        CompressedSrgb8Alpha8Etc2EacOes = 0x9279,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x4")]
        CompressedRgbaAstc4x4 = 0x93B0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x4_KHR")]
        CompressedRgbaAstc4x4Khr = 0x93B0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x4")]
        CompressedRgbaAstc5x4 = 0x93B1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x4_KHR")]
        CompressedRgbaAstc5x4Khr = 0x93B1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x5")]
        CompressedRgbaAstc5x5 = 0x93B2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x5_KHR")]
        CompressedRgbaAstc5x5Khr = 0x93B2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x5")]
        CompressedRgbaAstc6x5 = 0x93B3,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x5_KHR")]
        CompressedRgbaAstc6x5Khr = 0x93B3,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x6")]
        CompressedRgbaAstc6x6 = 0x93B4,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x6_KHR")]
        CompressedRgbaAstc6x6Khr = 0x93B4,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x5")]
        CompressedRgbaAstc8x5 = 0x93B5,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x5_KHR")]
        CompressedRgbaAstc8x5Khr = 0x93B5,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x6")]
        CompressedRgbaAstc8x6 = 0x93B6,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x6_KHR")]
        CompressedRgbaAstc8x6Khr = 0x93B6,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x8")]
        CompressedRgbaAstc8x8 = 0x93B7,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_8x8_KHR")]
        CompressedRgbaAstc8x8Khr = 0x93B7,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x5")]
        CompressedRgbaAstc10x5 = 0x93B8,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x5_KHR")]
        CompressedRgbaAstc10x5Khr = 0x93B8,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x6")]
        CompressedRgbaAstc10x6 = 0x93B9,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x6_KHR")]
        CompressedRgbaAstc10x6Khr = 0x93B9,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x8")]
        CompressedRgbaAstc10x8 = 0x93BA,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x8_KHR")]
        CompressedRgbaAstc10x8Khr = 0x93BA,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x10")]
        CompressedRgbaAstc10x10 = 0x93BB,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_10x10_KHR")]
        CompressedRgbaAstc10x10Khr = 0x93BB,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_12x10")]
        CompressedRgbaAstc12x10 = 0x93BC,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_12x10_KHR")]
        CompressedRgbaAstc12x10Khr = 0x93BC,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_12x12")]
        CompressedRgbaAstc12x12 = 0x93BD,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_12x12_KHR")]
        CompressedRgbaAstc12x12Khr = 0x93BD,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_3x3x3_OES")]
        CompressedRgbaAstc3x3x3Oes = 0x93C0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x3x3_OES")]
        CompressedRgbaAstc4x3x3Oes = 0x93C1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x4x3_OES")]
        CompressedRgbaAstc4x4x3Oes = 0x93C2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_4x4x4_OES")]
        CompressedRgbaAstc4x4x4Oes = 0x93C3,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x4x4_OES")]
        CompressedRgbaAstc5x4x4Oes = 0x93C4,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x5x4_OES")]
        CompressedRgbaAstc5x5x4Oes = 0x93C5,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_5x5x5_OES")]
        CompressedRgbaAstc5x5x5Oes = 0x93C6,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x5x5_OES")]
        CompressedRgbaAstc6x5x5Oes = 0x93C7,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x6x5_OES")]
        CompressedRgbaAstc6x6x5Oes = 0x93C8,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ASTC_6x6x6_OES")]
        CompressedRgbaAstc6x6x6Oes = 0x93C9,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4")]
        CompressedSrgb8Alpha8Astc4x4 = 0x93D0,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
        CompressedSrgb8Alpha8Astc4x4Khr = 0x93D0,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4")]
        CompressedSrgb8Alpha8Astc5x4 = 0x93D1,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
        CompressedSrgb8Alpha8Astc5x4Khr = 0x93D1,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5")]
        CompressedSrgb8Alpha8Astc5x5 = 0x93D2,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
        CompressedSrgb8Alpha8Astc5x5Khr = 0x93D2,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5")]
        CompressedSrgb8Alpha8Astc6x5 = 0x93D3,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
        CompressedSrgb8Alpha8Astc6x5Khr = 0x93D3,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6")]
        CompressedSrgb8Alpha8Astc6x6 = 0x93D4,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
        CompressedSrgb8Alpha8Astc6x6Khr = 0x93D4,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5")]
        CompressedSrgb8Alpha8Astc8x5 = 0x93D5,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
        CompressedSrgb8Alpha8Astc8x5Khr = 0x93D5,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6")]
        CompressedSrgb8Alpha8Astc8x6 = 0x93D6,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
        CompressedSrgb8Alpha8Astc8x6Khr = 0x93D6,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8")]
        CompressedSrgb8Alpha8Astc8x8 = 0x93D7,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
        CompressedSrgb8Alpha8Astc8x8Khr = 0x93D7,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5")]
        CompressedSrgb8Alpha8Astc10x5 = 0x93D8,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
        CompressedSrgb8Alpha8Astc10x5Khr = 0x93D8,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6")]
        CompressedSrgb8Alpha8Astc10x6 = 0x93D9,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
        CompressedSrgb8Alpha8Astc10x6Khr = 0x93D9,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8")]
        CompressedSrgb8Alpha8Astc10x8 = 0x93DA,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
        CompressedSrgb8Alpha8Astc10x8Khr = 0x93DA,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10")]
        CompressedSrgb8Alpha8Astc10x10 = 0x93DB,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
        CompressedSrgb8Alpha8Astc10x10Khr = 0x93DB,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10")]
        CompressedSrgb8Alpha8Astc12x10 = 0x93DC,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
        CompressedSrgb8Alpha8Astc12x10Khr = 0x93DC,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12")]
        CompressedSrgb8Alpha8Astc12x12 = 0x93DD,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
        CompressedSrgb8Alpha8Astc12x12Khr = 0x93DD,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES")]
        CompressedSrgb8Alpha8Astc3x3x3Oes = 0x93E0,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES")]
        CompressedSrgb8Alpha8Astc4x3x3Oes = 0x93E1,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES")]
        CompressedSrgb8Alpha8Astc4x4x3Oes = 0x93E2,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES")]
        CompressedSrgb8Alpha8Astc4x4x4Oes = 0x93E3,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES")]
        CompressedSrgb8Alpha8Astc5x4x4Oes = 0x93E4,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES")]
        CompressedSrgb8Alpha8Astc5x5x4Oes = 0x93E5,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES")]
        CompressedSrgb8Alpha8Astc5x5x5Oes = 0x93E6,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES")]
        CompressedSrgb8Alpha8Astc6x5x5Oes = 0x93E7,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES")]
        CompressedSrgb8Alpha8Astc6x6x5Oes = 0x93E8,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES")]
        CompressedSrgb8Alpha8Astc6x6x6Oes = 0x93E9,
    }
}
