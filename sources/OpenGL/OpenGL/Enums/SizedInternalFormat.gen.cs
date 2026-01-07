// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SizedInternalFormat")]
public enum SizedInternalFormat : uint
{
    [NativeName("GL_R3_G3_B2")]
    R3G3B2 = 10768,

    [NativeName("GL_RGB4")]
    Rgb4 = 32847,

    [NativeName("GL_RGB5")]
    Rgb5 = 32848,

    [NativeName("GL_RGB8")]
    Rgb8 = 32849,

    [NativeName("GL_RGB10")]
    Rgb10 = 32850,

    [NativeName("GL_RGB12")]
    Rgb12 = 32851,

    [NativeName("GL_RGB16")]
    Rgb16 = 32852,

    [NativeName("GL_RGBA2")]
    Rgba2 = 32853,

    [NativeName("GL_RGBA4")]
    Rgba4 = 32854,

    [NativeName("GL_RGB5_A1")]
    Rgb5A1 = 32855,

    [NativeName("GL_RGBA8")]
    Rgba8 = 32856,

    [NativeName("GL_RGB10_A2")]
    Rgb10A2 = 32857,

    [NativeName("GL_RGBA12")]
    Rgba12 = 32858,

    [NativeName("GL_RGBA16")]
    Rgba16 = 32859,

    [NativeName("GL_ALPHA4")]
    Alpha4 = 32827,

    [NativeName("GL_ALPHA8")]
    Alpha8 = 32828,

    [NativeName("GL_ALPHA12")]
    Alpha12 = 32829,

    [NativeName("GL_ALPHA16")]
    Alpha16 = 32830,

    [NativeName("GL_LUMINANCE4")]
    Luminance4 = 32831,

    [NativeName("GL_LUMINANCE8")]
    Luminance8 = 32832,

    [NativeName("GL_LUMINANCE12")]
    Luminance12 = 32833,

    [NativeName("GL_LUMINANCE16")]
    Luminance16 = 32834,

    [NativeName("GL_LUMINANCE4_ALPHA4")]
    Luminance4Alpha4 = 32835,

    [NativeName("GL_LUMINANCE6_ALPHA2")]
    Luminance6Alpha2 = 32836,

    [NativeName("GL_LUMINANCE8_ALPHA8")]
    Luminance8Alpha8 = 32837,

    [NativeName("GL_LUMINANCE12_ALPHA4")]
    Luminance12Alpha4 = 32838,

    [NativeName("GL_LUMINANCE12_ALPHA12")]
    Luminance12Alpha12 = 32839,

    [NativeName("GL_LUMINANCE16_ALPHA16")]
    Luminance16Alpha16 = 32840,

    [NativeName("GL_INTENSITY4")]
    Intensity4 = 32842,

    [NativeName("GL_INTENSITY8")]
    Intensity8 = 32843,

    [NativeName("GL_INTENSITY12")]
    Intensity12 = 32844,

    [NativeName("GL_INTENSITY16")]
    Intensity16 = 32845,

    [NativeName("GL_DEPTH_COMPONENT16")]
    DepthComponent16 = 33189,

    [NativeName("GL_DEPTH_COMPONENT24")]
    DepthComponent24 = 33190,

    [NativeName("GL_DEPTH_COMPONENT32")]
    DepthComponent32 = 33191,

    [NativeName("GL_SRGB8")]
    Srgb8 = 35905,

    [NativeName("GL_SRGB8_ALPHA8")]
    Srgb8Alpha8 = 35907,

    [NativeName("GL_RGBA32F")]
    RGBA32F = 34836,

    [NativeName("GL_RGB32F")]
    RGB32F = 34837,

    [NativeName("GL_RGBA16F")]
    RGBA16F = 34842,

    [NativeName("GL_RGB16F")]
    RGB16F = 34843,

    [NativeName("GL_R11F_G11F_B10F")]
    R11FG11FB10F = 35898,

    [NativeName("GL_RGB9_E5")]
    Rgb9E5 = 35901,

    [NativeName("GL_RGBA32UI")]
    Rgba32Ui = 36208,

    [NativeName("GL_RGB32UI")]
    Rgb32Ui = 36209,

    [NativeName("GL_RGBA16UI")]
    Rgba16Ui = 36214,

    [NativeName("GL_RGB16UI")]
    Rgb16Ui = 36215,

    [NativeName("GL_RGBA8UI")]
    Rgba8Ui = 36220,

    [NativeName("GL_RGB8UI")]
    Rgb8Ui = 36221,

    [NativeName("GL_RGBA32I")]
    Rgba32I = 36226,

    [NativeName("GL_RGB32I")]
    Rgb32I = 36227,

    [NativeName("GL_RGBA16I")]
    Rgba16I = 36232,

    [NativeName("GL_RGB16I")]
    Rgb16I = 36233,

    [NativeName("GL_RGBA8I")]
    Rgba8I = 36238,

    [NativeName("GL_RGB8I")]
    Rgb8I = 36239,

    [NativeName("GL_DEPTH_COMPONENT32F")]
    DepthComponent32F = 36012,

    [NativeName("GL_DEPTH32F_STENCIL8")]
    Depth32FStencil8 = 36013,

    [NativeName("GL_DEPTH24_STENCIL8")]
    Depth24Stencil8 = 35056,

    [NativeName("GL_STENCIL_INDEX1")]
    StencilIndex1 = 36166,

    [NativeName("GL_STENCIL_INDEX4")]
    StencilIndex4 = 36167,

    [NativeName("GL_STENCIL_INDEX8")]
    StencilIndex8 = 36168,

    [NativeName("GL_STENCIL_INDEX16")]
    StencilIndex16 = 36169,

    [NativeName("GL_COMPRESSED_RED_RGTC1")]
    CompressedRedRgtc1 = 36283,

    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1")]
    CompressedSignedRedRgtc1 = 36284,

    [NativeName("GL_COMPRESSED_RG_RGTC2")]
    CompressedRgRgtc2 = 36285,

    [NativeName("GL_COMPRESSED_SIGNED_RG_RGTC2")]
    CompressedSignedRgRgtc2 = 36286,

    [NativeName("GL_R8")]
    R8 = 33321,

    [NativeName("GL_R16")]
    R16 = 33322,

    [NativeName("GL_RG8")]
    RG8 = 33323,

    [NativeName("GL_RG16")]
    Rg16 = 33324,

    [NativeName("GL_R16F")]
    R16F = 33325,

    [NativeName("GL_R32F")]
    R32F = 33326,

    [NativeName("GL_RG16F")]
    RG16F = 33327,

    [NativeName("GL_RG32F")]
    RG32F = 33328,

    [NativeName("GL_R8I")]
    R8I = 33329,

    [NativeName("GL_R8UI")]
    R8Ui = 33330,

    [NativeName("GL_R16I")]
    R16I = 33331,

    [NativeName("GL_R16UI")]
    R16Ui = 33332,

    [NativeName("GL_R32I")]
    R32I = 33333,

    [NativeName("GL_R32UI")]
    R32Ui = 33334,

    [NativeName("GL_RG8I")]
    Rg8I = 33335,

    [NativeName("GL_RG8UI")]
    Rg8Ui = 33336,

    [NativeName("GL_RG16I")]
    Rg16I = 33337,

    [NativeName("GL_RG16UI")]
    Rg16Ui = 33338,

    [NativeName("GL_RG32I")]
    Rg32I = 33339,

    [NativeName("GL_RG32UI")]
    Rg32Ui = 33340,

    [NativeName("GL_R8_SNORM")]
    R8Snorm = 36756,

    [NativeName("GL_RG8_SNORM")]
    Rg8Snorm = 36757,

    [NativeName("GL_RGB8_SNORM")]
    Rgb8Snorm = 36758,

    [NativeName("GL_RGBA8_SNORM")]
    Rgba8Snorm = 36759,

    [NativeName("GL_R16_SNORM")]
    R16Snorm = 36760,

    [NativeName("GL_RG16_SNORM")]
    Rg16Snorm = 36761,

    [NativeName("GL_RGB16_SNORM")]
    Rgb16Snorm = 36762,

    [NativeName("GL_RGBA16_SNORM")]
    Rgba16Snorm = 36763,

    [NativeName("GL_RGB10_A2UI")]
    Rgb10A2Ui = 36975,

    [NativeName("GL_RGB565")]
    Rgb565 = 36194,

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM")]
    CompressedRgbaBptcUnorm = 36492,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM")]
    CompressedSrgbAlphaBptcUnorm = 36493,

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT")]
    CompressedRgbBptcSignedFloat = 36494,

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT")]
    CompressedRgbBptcUnsignedFloat = 36495,

    [NativeName("GL_COMPRESSED_RGB8_ETC2")]
    CompressedRgb8Etc2 = 37492,

    [NativeName("GL_COMPRESSED_SRGB8_ETC2")]
    CompressedSrgb8Etc2 = 37493,

    [NativeName("GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
    CompressedRgb8PunchthroughAlpha1Etc2 = 37494,

    [NativeName("GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
    CompressedSrgb8PunchthroughAlpha1Etc2 = 37495,

    [NativeName("GL_COMPRESSED_RGBA8_ETC2_EAC")]
    CompressedRgba8Etc2Eac = 37496,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC")]
    CompressedSrgb8Alpha8Etc2Eac = 37497,

    [NativeName("GL_COMPRESSED_R11_EAC")]
    CompressedR11Eac = 37488,

    [NativeName("GL_COMPRESSED_SIGNED_R11_EAC")]
    CompressedSignedR11Eac = 37489,

    [NativeName("GL_COMPRESSED_RG11_EAC")]
    CompressedRg11Eac = 37490,

    [NativeName("GL_COMPRESSED_SIGNED_RG11_EAC")]
    CompressedSignedRg11Eac = 37491,

    [NativeName("GL_DEPTH_COMPONENT16_ARB")]
    DepthComponent16ARB = 33189,

    [NativeName("GL_DEPTH_COMPONENT24_ARB")]
    DepthComponent24ARB = 33190,

    [NativeName("GL_DEPTH_COMPONENT32_ARB")]
    DepthComponent32ARB = 33191,

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
    CompressedRgbaBptcUnormARB = 36492,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
    CompressedSrgbAlphaBptcUnormARB = 36493,

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
    CompressedRgbBptcSignedFloatARB = 36494,

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
    CompressedRgbBptcUnsignedFloatARB = 36495,

    [NativeName("GL_RGBA32F_ARB")]
    Rgba32FARB = 34836,

    [NativeName("GL_RGB32F_ARB")]
    Rgb32FARB = 34837,

    [NativeName("GL_RGBA16F_ARB")]
    Rgba16FARB = 34842,

    [NativeName("GL_RGB16F_ARB")]
    Rgb16FARB = 34843,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4_KHR")]
    CompressedRGBAASTC4X4KHR = 37808,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4_KHR")]
    CompressedRGBAASTC5X4KHR = 37809,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5_KHR")]
    CompressedRGBAASTC5X5KHR = 37810,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5_KHR")]
    CompressedRGBAASTC6X5KHR = 37811,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6_KHR")]
    CompressedRGBAASTC6X6KHR = 37812,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x5_KHR")]
    CompressedRGBAASTC8X5KHR = 37813,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x6_KHR")]
    CompressedRGBAASTC8X6KHR = 37814,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x8_KHR")]
    CompressedRGBAASTC8X8KHR = 37815,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x5_KHR")]
    CompressedRGBAASTC10X5KHR = 37816,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x6_KHR")]
    CompressedRGBAASTC10X6KHR = 37817,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x8_KHR")]
    CompressedRGBAASTC10X8KHR = 37818,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x10_KHR")]
    CompressedRGBAASTC10X10KHR = 37819,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x10_KHR")]
    CompressedRGBAASTC12X10KHR = 37820,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x12_KHR")]
    CompressedRGBAASTC12X12KHR = 37821,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
    CompressedSRGB8Alpha8Astc4X4KHR = 37840,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
    CompressedSRGB8Alpha8Astc5X4KHR = 37841,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
    CompressedSRGB8Alpha8Astc5X5KHR = 37842,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
    CompressedSRGB8Alpha8Astc6X5KHR = 37843,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
    CompressedSRGB8Alpha8Astc6X6KHR = 37844,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
    CompressedSRGB8Alpha8Astc8X5KHR = 37845,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
    CompressedSRGB8Alpha8Astc8X6KHR = 37846,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
    CompressedSRGB8Alpha8Astc8X8KHR = 37847,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
    CompressedSRGB8Alpha8Astc10X5KHR = 37848,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
    CompressedSRGB8Alpha8Astc10X6KHR = 37849,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
    CompressedSRGB8Alpha8Astc10X8KHR = 37850,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
    CompressedSRGB8Alpha8Astc10X10KHR = 37851,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
    CompressedSRGB8Alpha8Astc12X10KHR = 37852,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
    CompressedSRGB8Alpha8Astc12X12KHR = 37853,

    [NativeName("GL_STENCIL_INDEX1_EXT")]
    StencilIndex1EXT = 36166,

    [NativeName("GL_STENCIL_INDEX4_EXT")]
    StencilIndex4EXT = 36167,

    [NativeName("GL_STENCIL_INDEX8_EXT")]
    StencilIndex8EXT = 36168,

    [NativeName("GL_STENCIL_INDEX16_EXT")]
    StencilIndex16EXT = 36169,

    [NativeName("GL_DEPTH24_STENCIL8_EXT")]
    Depth24Stencil8EXT = 35056,

    [NativeName("GL_R11F_G11F_B10F_EXT")]
    R11FG11FB10FEXT = 35898,

    [NativeName("GL_ALPHA4_EXT")]
    Alpha4EXT = 32827,

    [NativeName("GL_ALPHA8_EXT")]
    Alpha8EXT = 32828,

    [NativeName("GL_ALPHA12_EXT")]
    Alpha12EXT = 32829,

    [NativeName("GL_ALPHA16_EXT")]
    Alpha16EXT = 32830,

    [NativeName("GL_LUMINANCE4_EXT")]
    Luminance4EXT = 32831,

    [NativeName("GL_LUMINANCE8_EXT")]
    Luminance8EXT = 32832,

    [NativeName("GL_LUMINANCE12_EXT")]
    Luminance12EXT = 32833,

    [NativeName("GL_LUMINANCE16_EXT")]
    Luminance16EXT = 32834,

    [NativeName("GL_LUMINANCE4_ALPHA4_EXT")]
    Luminance4Alpha4EXT = 32835,

    [NativeName("GL_LUMINANCE6_ALPHA2_EXT")]
    Luminance6Alpha2EXT = 32836,

    [NativeName("GL_LUMINANCE8_ALPHA8_EXT")]
    Luminance8Alpha8EXT = 32837,

    [NativeName("GL_LUMINANCE12_ALPHA4_EXT")]
    Luminance12Alpha4EXT = 32838,

    [NativeName("GL_LUMINANCE12_ALPHA12_EXT")]
    Luminance12Alpha12EXT = 32839,

    [NativeName("GL_LUMINANCE16_ALPHA16_EXT")]
    Luminance16Alpha16EXT = 32840,

    [NativeName("GL_INTENSITY4_EXT")]
    Intensity4EXT = 32842,

    [NativeName("GL_INTENSITY8_EXT")]
    Intensity8EXT = 32843,

    [NativeName("GL_INTENSITY12_EXT")]
    Intensity12EXT = 32844,

    [NativeName("GL_INTENSITY16_EXT")]
    Intensity16EXT = 32845,

    [NativeName("GL_RGB2_EXT")]
    Rgb2EXT = 32846,

    [NativeName("GL_RGB4_EXT")]
    Rgb4EXT = 32847,

    [NativeName("GL_RGB5_EXT")]
    Rgb5EXT = 32848,

    [NativeName("GL_RGB8_EXT")]
    Rgb8EXT = 32849,

    [NativeName("GL_RGB10_EXT")]
    Rgb10EXT = 32850,

    [NativeName("GL_RGB12_EXT")]
    Rgb12EXT = 32851,

    [NativeName("GL_RGB16_EXT")]
    Rgb16EXT = 32852,

    [NativeName("GL_RGBA2_EXT")]
    Rgba2EXT = 32853,

    [NativeName("GL_RGBA4_EXT")]
    Rgba4EXT = 32854,

    [NativeName("GL_RGB5_A1_EXT")]
    Rgb5A1EXT = 32855,

    [NativeName("GL_RGBA8_EXT")]
    Rgba8EXT = 32856,

    [NativeName("GL_RGB10_A2_EXT")]
    Rgb10A2EXT = 32857,

    [NativeName("GL_RGBA12_EXT")]
    Rgba12EXT = 32858,

    [NativeName("GL_RGBA16_EXT")]
    Rgba16EXT = 32859,

    [NativeName("GL_COMPRESSED_RED_RGTC1_EXT")]
    CompressedRedRgtc1EXT = 36283,

    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
    CompressedSignedRedRgtc1EXT = 36284,

    [NativeName("GL_COMPRESSED_RED_GREEN_RGTC2_EXT")]
    CompressedRedGreenRgtc2EXT = 36285,

    [NativeName("GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
    CompressedSignedRedGreenRgtc2EXT = 36286,

    [NativeName("GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
    CompressedRgbS3TcDxt1EXT = 33776,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
    CompressedRgbaS3TcDxt1EXT = 33777,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
    CompressedRgbaS3TcDxt3EXT = 33778,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
    CompressedRgbaS3TcDxt5EXT = 33779,

    [NativeName("GL_RGBA32UI_EXT")]
    Rgba32UiEXT = 36208,

    [NativeName("GL_RGB32UI_EXT")]
    Rgb32UiEXT = 36209,

    [NativeName("GL_ALPHA32UI_EXT")]
    Alpha32UiEXT = 36210,

    [NativeName("GL_INTENSITY32UI_EXT")]
    Intensity32UiEXT = 36211,

    [NativeName("GL_LUMINANCE32UI_EXT")]
    Luminance32UiEXT = 36212,

    [NativeName("GL_LUMINANCE_ALPHA32UI_EXT")]
    LuminanceAlpha32UiEXT = 36213,

    [NativeName("GL_RGBA16UI_EXT")]
    Rgba16UiEXT = 36214,

    [NativeName("GL_RGB16UI_EXT")]
    Rgb16UiEXT = 36215,

    [NativeName("GL_ALPHA16UI_EXT")]
    Alpha16UiEXT = 36216,

    [NativeName("GL_INTENSITY16UI_EXT")]
    Intensity16UiEXT = 36217,

    [NativeName("GL_LUMINANCE16UI_EXT")]
    Luminance16UiEXT = 36218,

    [NativeName("GL_LUMINANCE_ALPHA16UI_EXT")]
    LuminanceAlpha16UiEXT = 36219,

    [NativeName("GL_RGBA8UI_EXT")]
    Rgba8UiEXT = 36220,

    [NativeName("GL_RGB8UI_EXT")]
    Rgb8UiEXT = 36221,

    [NativeName("GL_ALPHA8UI_EXT")]
    Alpha8UiEXT = 36222,

    [NativeName("GL_INTENSITY8UI_EXT")]
    Intensity8UiEXT = 36223,

    [NativeName("GL_LUMINANCE8UI_EXT")]
    Luminance8UiEXT = 36224,

    [NativeName("GL_LUMINANCE_ALPHA8UI_EXT")]
    LuminanceAlpha8UiEXT = 36225,

    [NativeName("GL_RGBA32I_EXT")]
    Rgba32IEXT = 36226,

    [NativeName("GL_RGB32I_EXT")]
    Rgb32IEXT = 36227,

    [NativeName("GL_ALPHA32I_EXT")]
    Alpha32IEXT = 36228,

    [NativeName("GL_INTENSITY32I_EXT")]
    Intensity32IEXT = 36229,

    [NativeName("GL_LUMINANCE32I_EXT")]
    Luminance32IEXT = 36230,

    [NativeName("GL_LUMINANCE_ALPHA32I_EXT")]
    LuminanceAlpha32IEXT = 36231,

    [NativeName("GL_RGBA16I_EXT")]
    Rgba16IEXT = 36232,

    [NativeName("GL_RGB16I_EXT")]
    Rgb16IEXT = 36233,

    [NativeName("GL_ALPHA16I_EXT")]
    Alpha16IEXT = 36234,

    [NativeName("GL_INTENSITY16I_EXT")]
    Intensity16IEXT = 36235,

    [NativeName("GL_LUMINANCE16I_EXT")]
    Luminance16IEXT = 36236,

    [NativeName("GL_LUMINANCE_ALPHA16I_EXT")]
    LuminanceAlpha16IEXT = 36237,

    [NativeName("GL_RGBA8I_EXT")]
    Rgba8IEXT = 36238,

    [NativeName("GL_RGB8I_EXT")]
    Rgb8IEXT = 36239,

    [NativeName("GL_ALPHA8I_EXT")]
    Alpha8IEXT = 36240,

    [NativeName("GL_INTENSITY8I_EXT")]
    Intensity8IEXT = 36241,

    [NativeName("GL_LUMINANCE8I_EXT")]
    Luminance8IEXT = 36242,

    [NativeName("GL_LUMINANCE_ALPHA8I_EXT")]
    LuminanceAlpha8IEXT = 36243,

    [NativeName("GL_SRGB8_EXT")]
    Srgb8EXT = 35905,

    [NativeName("GL_SRGB8_ALPHA8_EXT")]
    Srgb8Alpha8EXT = 35907,

    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
    CompressedSrgbS3TcDxt1EXT = 35916,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
    CompressedSrgbAlphaS3TcDxt1EXT = 35917,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
    CompressedSrgbAlphaS3TcDxt3EXT = 35918,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
    CompressedSrgbAlphaS3TcDxt5EXT = 35919,

    [NativeName("GL_RGB9_E5_EXT")]
    Rgb9E5EXT = 35901,

    [NativeName("GL_RGBA32F_EXT")]
    Rgba32FEXT = 34836,

    [NativeName("GL_RGB32F_EXT")]
    Rgb32FEXT = 34837,

    [NativeName("GL_RGBA16F_EXT")]
    Rgba16FEXT = 34842,

    [NativeName("GL_RGB16F_EXT")]
    Rgb16FEXT = 34843,

    [NativeName("GL_R8_EXT")]
    R8EXT = 33321,

    [NativeName("GL_RG8_EXT")]
    RG8EXT = 33323,

    [NativeName("GL_R32F_EXT")]
    R32FEXT = 33326,

    [NativeName("GL_RG32F_EXT")]
    Rg32FEXT = 33328,

    [NativeName("GL_R16F_EXT")]
    R16FEXT = 33325,

    [NativeName("GL_RG16F_EXT")]
    Rg16FEXT = 33327,

    [NativeName("GL_DEPTH_COMPONENT32F_NV")]
    DepthComponent32FNV = 36267,

    [NativeName("GL_DEPTH32F_STENCIL8_NV")]
    Depth32FStencil8NV = 36268,

    [NativeName("GL_DEPTH_COMPONENT16_SGIX")]
    DepthComponent16SGIX = 33189,

    [NativeName("GL_DEPTH_COMPONENT24_SGIX")]
    DepthComponent24SGIX = 33190,

    [NativeName("GL_DEPTH_COMPONENT32_SGIX")]
    DepthComponent32SGIX = 33191,

    [NativeName("GL_ETC1_RGB8_OES")]
    Etc1Rgb8OES = 36196,

    [NativeName("GL_DEPTH_COMPONENT24_OES")]
    DepthComponent24OES = 33190,

    [NativeName("GL_DEPTH_COMPONENT32_OES")]
    DepthComponent32OES = 33191,

    [NativeName("GL_DEPTH24_STENCIL8_OES")]
    Depth24Stencil8OES = 35056,

    [NativeName("GL_ALPHA8_OES")]
    Alpha8OES = 32828,

    [NativeName("GL_DEPTH_COMPONENT16_OES")]
    DepthComponent16OES = 33189,

    [NativeName("GL_LUMINANCE4_ALPHA4_OES")]
    Luminance4Alpha4OES = 32835,

    [NativeName("GL_LUMINANCE8_ALPHA8_OES")]
    Luminance8Alpha8OES = 32837,

    [NativeName("GL_LUMINANCE8_OES")]
    Luminance8OES = 32832,

    [NativeName("GL_RGBA4_OES")]
    Rgba4OES = 32854,

    [NativeName("GL_RGB5_A1_OES")]
    Rgb5A1OES = 32855,

    [NativeName("GL_RGB565_OES")]
    Rgb565OES = 36194,

    [NativeName("GL_RGB8_OES")]
    Rgb8OES = 32849,

    [NativeName("GL_RGBA8_OES")]
    Rgba8OES = 32856,

    [NativeName("GL_STENCIL_INDEX1_OES")]
    StencilIndex1OES = 36166,

    [NativeName("GL_STENCIL_INDEX4_OES")]
    StencilIndex4OES = 36167,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_3x3x3_OES")]
    CompressedRGBAASTC3X3X3OES = 37824,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x3x3_OES")]
    CompressedRGBAASTC4X3X3OES = 37825,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x3_OES")]
    CompressedRGBAASTC4X4X3OES = 37826,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x4_OES")]
    CompressedRGBAASTC4X4X4OES = 37827,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4x4_OES")]
    CompressedRGBAASTC5X4X4OES = 37828,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x4_OES")]
    CompressedRGBAASTC5X5X4OES = 37829,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x5_OES")]
    CompressedRGBAASTC5X5X5OES = 37830,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5x5_OES")]
    CompressedRGBAASTC6X5X5OES = 37831,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x5_OES")]
    CompressedRGBAASTC6X6X5OES = 37832,

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x6_OES")]
    CompressedRGBAASTC6X6X6OES = 37833,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES")]
    CompressedSRGB8Alpha8Astc3X3X3OES = 37856,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES")]
    CompressedSRGB8Alpha8Astc4X3X3OES = 37857,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES")]
    CompressedSRGB8Alpha8Astc4X4X3OES = 37858,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES")]
    CompressedSRGB8Alpha8Astc4X4X4OES = 37859,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES")]
    CompressedSRGB8Alpha8Astc5X4X4OES = 37860,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES")]
    CompressedSRGB8Alpha8Astc5X5X4OES = 37861,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES")]
    CompressedSRGB8Alpha8Astc5X5X5OES = 37862,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES")]
    CompressedSRGB8Alpha8Astc6X5X5OES = 37863,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES")]
    CompressedSRGB8Alpha8Astc6X6X5OES = 37864,

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES")]
    CompressedSRGB8Alpha8Astc6X6X6OES = 37865,

    [NativeName("GL_STENCIL_INDEX8_OES")]
    StencilIndex8OES = 36168,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE")]
    CompressedRgbaS3TcDxt3ANGLE = 33778,

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE")]
    CompressedRgbaS3TcDxt5ANGLE = 33779,

    [NativeName("GL_R11F_G11F_B10F_APPLE")]
    R11FG11FB10FAPPLE = 35898,

    [NativeName("GL_RGB9_E5_APPLE")]
    Rgb9E5APPLE = 35901,

    [NativeName("GL_R16_SNORM_EXT")]
    R16SnormEXT = 36760,

    [NativeName("GL_RG16_SNORM_EXT")]
    Rg16SnormEXT = 36761,

    [NativeName("GL_RGBA16_SNORM_EXT")]
    Rgba16SnormEXT = 36763,

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_EXT")]
    CompressedRgbaBptcUnormEXT = 36492,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT")]
    CompressedSrgbAlphaBptcUnormEXT = 36493,

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT")]
    CompressedRgbBptcSignedFloatEXT = 36494,

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT")]
    CompressedRgbBptcUnsignedFloatEXT = 36495,

    [NativeName("GL_R16_EXT")]
    R16EXT = 33322,

    [NativeName("GL_RG16_EXT")]
    Rg16EXT = 33324,

    [NativeName("GL_RGB16_SNORM_EXT")]
    Rgb16SnormEXT = 36762,

    [NativeName("GL_SRGB8_NV")]
    Srgb8NV = 35905,

    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_NV")]
    CompressedSrgbS3TcDxt1NV = 35916,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV")]
    CompressedSrgbAlphaS3TcDxt1NV = 35917,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV")]
    CompressedSrgbAlphaS3TcDxt3NV = 35918,

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV")]
    CompressedSrgbAlphaS3TcDxt5NV = 35919,
}
