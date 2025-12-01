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
    [NativeName("GL_ETC1_RGB8_OES")]
    Etc1Rgb8OES = unchecked((uint)0x8D64),

    [NativeName("GL_DEPTH_COMPONENT24_OES")]
    DepthComponent24OES = unchecked((uint)0x81A6),

    [NativeName("GL_DEPTH_COMPONENT32_OES")]
    DepthComponent32OES = unchecked((uint)0x81A7),

    [NativeName("GL_RGBA4_OES")]
    Rgba4OES = unchecked((uint)0x8056),

    [NativeName("GL_RGB5_A1_OES")]
    Rgb5A1OES = unchecked((uint)0x8057),

    [NativeName("GL_RGB565_OES")]
    Rgb565OES = unchecked((uint)0x8D62),

    [NativeName("GL_DEPTH_COMPONENT16_OES")]
    DepthComponent16OES = unchecked((uint)0x81A5),

    [NativeName("GL_DEPTH24_STENCIL8_OES")]
    Depth24Stencil8OES = unchecked((uint)0x88F0),

    [NativeName("GL_ALPHA8_OES")]
    Alpha8OES = unchecked((uint)0x803C),

    [NativeName("GL_LUMINANCE4_ALPHA4_OES")]
    Luminance4Alpha4OES = unchecked((uint)0x8043),

    [NativeName("GL_LUMINANCE8_ALPHA8_OES")]
    Luminance8Alpha8OES = unchecked((uint)0x8045),

    [NativeName("GL_LUMINANCE8_OES")]
    Luminance8OES = unchecked((uint)0x8040),

    [NativeName("GL_RGB8_OES")]
    Rgb8OES = unchecked((uint)0x8051),

    [NativeName("GL_RGBA8_OES")]
    Rgba8OES = unchecked((uint)0x8058),

    [NativeName("GL_RGB10_EXT")]
    Rgb10EXT = unchecked((uint)0x8052),

    [NativeName("GL_RGB10_A2_EXT")]
    Rgb10A2EXT = unchecked((uint)0x8059),

    [NativeName("GL_STENCIL_INDEX1_OES")]
    StencilIndex1OES = unchecked((uint)0x8D46),

    [NativeName("GL_STENCIL_INDEX4_OES")]
    StencilIndex4OES = unchecked((uint)0x8D47),

    [NativeName("GL_STENCIL_INDEX8_OES")]
    StencilIndex8OES = unchecked((uint)0x8D48),

    [NativeName("GL_SRGB8_ALPHA8_EXT")]
    Srgb8Alpha8EXT = unchecked((uint)0x8C43),

    [NativeName("GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
    CompressedRgbS3TcDxt1EXT = unchecked((uint)0x83F0),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
    CompressedRgbaS3TcDxt1EXT = unchecked((uint)0x83F1),

    [NativeName("GL_ALPHA8_EXT")]
    Alpha8EXT = unchecked((uint)0x803C),

    [NativeName("GL_LUMINANCE8_EXT")]
    Luminance8EXT = unchecked((uint)0x8040),

    [NativeName("GL_LUMINANCE8_ALPHA8_EXT")]
    Luminance8Alpha8EXT = unchecked((uint)0x8045),

    [NativeName("GL_RGBA32F_EXT")]
    Rgba32FEXT = unchecked((uint)0x8814),

    [NativeName("GL_RGB32F_EXT")]
    Rgb32FEXT = unchecked((uint)0x8815),

    [NativeName("GL_RGBA16F_EXT")]
    Rgba16FEXT = unchecked((uint)0x881A),

    [NativeName("GL_RGB16F_EXT")]
    Rgb16FEXT = unchecked((uint)0x881B),

    [NativeName("GL_R8_EXT")]
    R8EXT = unchecked((uint)0x8229),

    [NativeName("GL_RG8_EXT")]
    Rg8EXT = unchecked((uint)0x822B),

    [NativeName("GL_R32F_EXT")]
    R32FEXT = unchecked((uint)0x822E),

    [NativeName("GL_RG32F_EXT")]
    Rg32FEXT = unchecked((uint)0x8230),

    [NativeName("GL_R16F_EXT")]
    R16FEXT = unchecked((uint)0x822D),

    [NativeName("GL_RG16F_EXT")]
    Rg16FEXT = unchecked((uint)0x822F),

    [NativeName("GL_R3_G3_B2")]
    R3G3B2 = unchecked((uint)0x2A10),

    [NativeName("GL_RGB4")]
    Rgb4 = unchecked((uint)0x804F),

    [NativeName("GL_RGB5")]
    Rgb5 = unchecked((uint)0x8050),

    [NativeName("GL_RGB8")]
    Rgb8 = unchecked((uint)0x8051),

    [NativeName("GL_RGB10")]
    Rgb10 = unchecked((uint)0x8052),

    [NativeName("GL_RGB12")]
    Rgb12 = unchecked((uint)0x8053),

    [NativeName("GL_RGB16")]
    Rgb16 = unchecked((uint)0x8054),

    [NativeName("GL_RGBA2")]
    Rgba2 = unchecked((uint)0x8055),

    [NativeName("GL_RGBA4")]
    Rgba4 = unchecked((uint)0x8056),

    [NativeName("GL_RGB5_A1")]
    Rgb5A1 = unchecked((uint)0x8057),

    [NativeName("GL_RGBA8")]
    Rgba8 = unchecked((uint)0x8058),

    [NativeName("GL_RGB10_A2")]
    Rgb10A2 = unchecked((uint)0x8059),

    [NativeName("GL_RGBA12")]
    Rgba12 = unchecked((uint)0x805A),

    [NativeName("GL_RGBA16")]
    Rgba16 = unchecked((uint)0x805B),

    [NativeName("GL_ALPHA4")]
    Alpha4 = unchecked((uint)0x803B),

    [NativeName("GL_ALPHA8")]
    Alpha8 = unchecked((uint)0x803C),

    [NativeName("GL_ALPHA12")]
    Alpha12 = unchecked((uint)0x803D),

    [NativeName("GL_ALPHA16")]
    Alpha16 = unchecked((uint)0x803E),

    [NativeName("GL_LUMINANCE4")]
    Luminance4 = unchecked((uint)0x803F),

    [NativeName("GL_LUMINANCE8")]
    Luminance8 = unchecked((uint)0x8040),

    [NativeName("GL_LUMINANCE12")]
    Luminance12 = unchecked((uint)0x8041),

    [NativeName("GL_LUMINANCE16")]
    Luminance16 = unchecked((uint)0x8042),

    [NativeName("GL_LUMINANCE4_ALPHA4")]
    Luminance4Alpha4 = unchecked((uint)0x8043),

    [NativeName("GL_LUMINANCE6_ALPHA2")]
    Luminance6Alpha2 = unchecked((uint)0x8044),

    [NativeName("GL_LUMINANCE8_ALPHA8")]
    Luminance8Alpha8 = unchecked((uint)0x8045),

    [NativeName("GL_LUMINANCE12_ALPHA4")]
    Luminance12Alpha4 = unchecked((uint)0x8046),

    [NativeName("GL_LUMINANCE12_ALPHA12")]
    Luminance12Alpha12 = unchecked((uint)0x8047),

    [NativeName("GL_LUMINANCE16_ALPHA16")]
    Luminance16Alpha16 = unchecked((uint)0x8048),

    [NativeName("GL_INTENSITY4")]
    Intensity4 = unchecked((uint)0x804A),

    [NativeName("GL_INTENSITY8")]
    Intensity8 = unchecked((uint)0x804B),

    [NativeName("GL_INTENSITY12")]
    Intensity12 = unchecked((uint)0x804C),

    [NativeName("GL_INTENSITY16")]
    Intensity16 = unchecked((uint)0x804D),

    [NativeName("GL_DEPTH_COMPONENT16")]
    DepthComponent16 = unchecked((uint)0x81A5),

    [NativeName("GL_DEPTH_COMPONENT24")]
    DepthComponent24 = unchecked((uint)0x81A6),

    [NativeName("GL_DEPTH_COMPONENT32")]
    DepthComponent32 = unchecked((uint)0x81A7),

    [NativeName("GL_SRGB8")]
    Srgb8 = unchecked((uint)0x8C41),

    [NativeName("GL_SRGB8_ALPHA8")]
    Srgb8Alpha8 = unchecked((uint)0x8C43),

    [NativeName("GL_RGBA32F")]
    Rgba32F = unchecked((uint)0x8814),

    [NativeName("GL_RGB32F")]
    Rgb32F = unchecked((uint)0x8815),

    [NativeName("GL_RGBA16F")]
    Rgba16F = unchecked((uint)0x881A),

    [NativeName("GL_RGB16F")]
    Rgb16F = unchecked((uint)0x881B),

    [NativeName("GL_R11F_G11F_B10F")]
    R11FG11FB10F = unchecked((uint)0x8C3A),

    [NativeName("GL_RGB9_E5")]
    Rgb9E5 = unchecked((uint)0x8C3D),

    [NativeName("GL_RGBA32UI")]
    Rgba32Ui = unchecked((uint)0x8D70),

    [NativeName("GL_RGB32UI")]
    Rgb32Ui = unchecked((uint)0x8D71),

    [NativeName("GL_RGBA16UI")]
    Rgba16Ui = unchecked((uint)0x8D76),

    [NativeName("GL_RGB16UI")]
    Rgb16Ui = unchecked((uint)0x8D77),

    [NativeName("GL_RGBA8UI")]
    Rgba8Ui = unchecked((uint)0x8D7C),

    [NativeName("GL_RGB8UI")]
    Rgb8Ui = unchecked((uint)0x8D7D),

    [NativeName("GL_RGBA32I")]
    Rgba32I = unchecked((uint)0x8D82),

    [NativeName("GL_RGB32I")]
    Rgb32I = unchecked((uint)0x8D83),

    [NativeName("GL_RGBA16I")]
    Rgba16I = unchecked((uint)0x8D88),

    [NativeName("GL_RGB16I")]
    Rgb16I = unchecked((uint)0x8D89),

    [NativeName("GL_RGBA8I")]
    Rgba8I = unchecked((uint)0x8D8E),

    [NativeName("GL_RGB8I")]
    Rgb8I = unchecked((uint)0x8D8F),

    [NativeName("GL_DEPTH_COMPONENT32F")]
    DepthComponent32F = unchecked((uint)0x8CAC),

    [NativeName("GL_DEPTH32F_STENCIL8")]
    Depth32FStencil8 = unchecked((uint)0x8CAD),

    [NativeName("GL_DEPTH24_STENCIL8")]
    Depth24Stencil8 = unchecked((uint)0x88F0),

    [NativeName("GL_STENCIL_INDEX1")]
    StencilIndex1 = unchecked((uint)0x8D46),

    [NativeName("GL_STENCIL_INDEX4")]
    StencilIndex4 = unchecked((uint)0x8D47),

    [NativeName("GL_STENCIL_INDEX8")]
    StencilIndex8 = unchecked((uint)0x8D48),

    [NativeName("GL_STENCIL_INDEX16")]
    StencilIndex16 = unchecked((uint)0x8D49),

    [NativeName("GL_COMPRESSED_RED_RGTC1")]
    CompressedRedRgtc1 = unchecked((uint)0x8DBB),

    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1")]
    CompressedSignedRedRgtc1 = unchecked((uint)0x8DBC),

    [NativeName("GL_COMPRESSED_RG_RGTC2")]
    CompressedRgRgtc2 = unchecked((uint)0x8DBD),

    [NativeName("GL_COMPRESSED_SIGNED_RG_RGTC2")]
    CompressedSignedRgRgtc2 = unchecked((uint)0x8DBE),

    [NativeName("GL_R8")]
    R8 = unchecked((uint)0x8229),

    [NativeName("GL_R16")]
    R16 = unchecked((uint)0x822A),

    [NativeName("GL_RG8")]
    Rg8 = unchecked((uint)0x822B),

    [NativeName("GL_RG16")]
    Rg16 = unchecked((uint)0x822C),

    [NativeName("GL_R16F")]
    R16F = unchecked((uint)0x822D),

    [NativeName("GL_R32F")]
    R32F = unchecked((uint)0x822E),

    [NativeName("GL_RG16F")]
    Rg16F = unchecked((uint)0x822F),

    [NativeName("GL_RG32F")]
    Rg32F = unchecked((uint)0x8230),

    [NativeName("GL_R8I")]
    R8I = unchecked((uint)0x8231),

    [NativeName("GL_R8UI")]
    R8Ui = unchecked((uint)0x8232),

    [NativeName("GL_R16I")]
    R16I = unchecked((uint)0x8233),

    [NativeName("GL_R16UI")]
    R16Ui = unchecked((uint)0x8234),

    [NativeName("GL_R32I")]
    R32I = unchecked((uint)0x8235),

    [NativeName("GL_R32UI")]
    R32Ui = unchecked((uint)0x8236),

    [NativeName("GL_RG8I")]
    Rg8I = unchecked((uint)0x8237),

    [NativeName("GL_RG8UI")]
    Rg8Ui = unchecked((uint)0x8238),

    [NativeName("GL_RG16I")]
    Rg16I = unchecked((uint)0x8239),

    [NativeName("GL_RG16UI")]
    Rg16Ui = unchecked((uint)0x823A),

    [NativeName("GL_RG32I")]
    Rg32I = unchecked((uint)0x823B),

    [NativeName("GL_RG32UI")]
    Rg32Ui = unchecked((uint)0x823C),

    [NativeName("GL_R8_SNORM")]
    R8Snorm = unchecked((uint)0x8F94),

    [NativeName("GL_RG8_SNORM")]
    Rg8Snorm = unchecked((uint)0x8F95),

    [NativeName("GL_RGB8_SNORM")]
    Rgb8Snorm = unchecked((uint)0x8F96),

    [NativeName("GL_RGBA8_SNORM")]
    Rgba8Snorm = unchecked((uint)0x8F97),

    [NativeName("GL_R16_SNORM")]
    R16Snorm = unchecked((uint)0x8F98),

    [NativeName("GL_RG16_SNORM")]
    Rg16Snorm = unchecked((uint)0x8F99),

    [NativeName("GL_RGB16_SNORM")]
    Rgb16Snorm = unchecked((uint)0x8F9A),

    [NativeName("GL_RGBA16_SNORM")]
    Rgba16Snorm = unchecked((uint)0x8F9B),

    [NativeName("GL_RGB10_A2UI")]
    Rgb10A2Ui = unchecked((uint)0x906F),

    [NativeName("GL_RGB565")]
    Rgb565 = unchecked((uint)0x8D62),

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM")]
    CompressedRgbaBptcUnorm = unchecked((uint)0x8E8C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM")]
    CompressedSrgbAlphaBptcUnorm = unchecked((uint)0x8E8D),

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT")]
    CompressedRgbBptcSignedFloat = unchecked((uint)0x8E8E),

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT")]
    CompressedRgbBptcUnsignedFloat = unchecked((uint)0x8E8F),

    [NativeName("GL_COMPRESSED_RGB8_ETC2")]
    CompressedRgb8Etc2 = unchecked((uint)0x9274),

    [NativeName("GL_COMPRESSED_SRGB8_ETC2")]
    CompressedSrgb8Etc2 = unchecked((uint)0x9275),

    [NativeName("GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
    CompressedRgb8PunchthroughAlpha1Etc2 = unchecked((uint)0x9276),

    [NativeName("GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
    CompressedSrgb8PunchthroughAlpha1Etc2 = unchecked((uint)0x9277),

    [NativeName("GL_COMPRESSED_RGBA8_ETC2_EAC")]
    CompressedRgba8Etc2Eac = unchecked((uint)0x9278),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC")]
    CompressedSrgb8Alpha8Etc2Eac = unchecked((uint)0x9279),

    [NativeName("GL_COMPRESSED_R11_EAC")]
    CompressedR11Eac = unchecked((uint)0x9270),

    [NativeName("GL_COMPRESSED_SIGNED_R11_EAC")]
    CompressedSignedR11Eac = unchecked((uint)0x9271),

    [NativeName("GL_COMPRESSED_RG11_EAC")]
    CompressedRg11Eac = unchecked((uint)0x9272),

    [NativeName("GL_COMPRESSED_SIGNED_RG11_EAC")]
    CompressedSignedRg11Eac = unchecked((uint)0x9273),

    [NativeName("GL_DEPTH_COMPONENT16_ARB")]
    DepthComponent16ARB = unchecked((uint)0x81A5),

    [NativeName("GL_DEPTH_COMPONENT24_ARB")]
    DepthComponent24ARB = unchecked((uint)0x81A6),

    [NativeName("GL_DEPTH_COMPONENT32_ARB")]
    DepthComponent32ARB = unchecked((uint)0x81A7),

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
    CompressedRgbaBptcUnormARB = unchecked((uint)0x8E8C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
    CompressedSrgbAlphaBptcUnormARB = unchecked((uint)0x8E8D),

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
    CompressedRgbBptcSignedFloatARB = unchecked((uint)0x8E8E),

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
    CompressedRgbBptcUnsignedFloatARB = unchecked((uint)0x8E8F),

    [NativeName("GL_RGBA32F_ARB")]
    Rgba32FARB = unchecked((uint)0x8814),

    [NativeName("GL_RGB32F_ARB")]
    Rgb32FARB = unchecked((uint)0x8815),

    [NativeName("GL_RGBA16F_ARB")]
    Rgba16FARB = unchecked((uint)0x881A),

    [NativeName("GL_RGB16F_ARB")]
    Rgb16FARB = unchecked((uint)0x881B),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4_KHR")]
    CompressedRgbaAstc4X4KHR = unchecked((uint)0x93B0),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4_KHR")]
    CompressedRgbaAstc5X4KHR = unchecked((uint)0x93B1),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5_KHR")]
    CompressedRgbaAstc5X5KHR = unchecked((uint)0x93B2),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5_KHR")]
    CompressedRgbaAstc6X5KHR = unchecked((uint)0x93B3),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6_KHR")]
    CompressedRgbaAstc6X6KHR = unchecked((uint)0x93B4),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x5_KHR")]
    CompressedRgbaAstc8X5KHR = unchecked((uint)0x93B5),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x6_KHR")]
    CompressedRgbaAstc8X6KHR = unchecked((uint)0x93B6),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_8x8_KHR")]
    CompressedRgbaAstc8X8KHR = unchecked((uint)0x93B7),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x5_KHR")]
    CompressedRgbaAstc10X5KHR = unchecked((uint)0x93B8),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x6_KHR")]
    CompressedRgbaAstc10X6KHR = unchecked((uint)0x93B9),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x8_KHR")]
    CompressedRgbaAstc10X8KHR = unchecked((uint)0x93BA),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_10x10_KHR")]
    CompressedRgbaAstc10X10KHR = unchecked((uint)0x93BB),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x10_KHR")]
    CompressedRgbaAstc12X10KHR = unchecked((uint)0x93BC),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_12x12_KHR")]
    CompressedRgbaAstc12X12KHR = unchecked((uint)0x93BD),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
    CompressedSrgb8Alpha8Astc4X4KHR = unchecked((uint)0x93D0),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
    CompressedSrgb8Alpha8Astc5X4KHR = unchecked((uint)0x93D1),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
    CompressedSrgb8Alpha8Astc5X5KHR = unchecked((uint)0x93D2),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
    CompressedSrgb8Alpha8Astc6X5KHR = unchecked((uint)0x93D3),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
    CompressedSrgb8Alpha8Astc6X6KHR = unchecked((uint)0x93D4),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
    CompressedSrgb8Alpha8Astc8X5KHR = unchecked((uint)0x93D5),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
    CompressedSrgb8Alpha8Astc8X6KHR = unchecked((uint)0x93D6),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
    CompressedSrgb8Alpha8Astc8X8KHR = unchecked((uint)0x93D7),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
    CompressedSrgb8Alpha8Astc10X5KHR = unchecked((uint)0x93D8),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
    CompressedSrgb8Alpha8Astc10X6KHR = unchecked((uint)0x93D9),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
    CompressedSrgb8Alpha8Astc10X8KHR = unchecked((uint)0x93DA),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
    CompressedSrgb8Alpha8Astc10X10KHR = unchecked((uint)0x93DB),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
    CompressedSrgb8Alpha8Astc12X10KHR = unchecked((uint)0x93DC),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
    CompressedSrgb8Alpha8Astc12X12KHR = unchecked((uint)0x93DD),

    [NativeName("GL_STENCIL_INDEX1_EXT")]
    StencilIndex1EXT = unchecked((uint)0x8D46),

    [NativeName("GL_STENCIL_INDEX4_EXT")]
    StencilIndex4EXT = unchecked((uint)0x8D47),

    [NativeName("GL_STENCIL_INDEX8_EXT")]
    StencilIndex8EXT = unchecked((uint)0x8D48),

    [NativeName("GL_STENCIL_INDEX16_EXT")]
    StencilIndex16EXT = unchecked((uint)0x8D49),

    [NativeName("GL_DEPTH24_STENCIL8_EXT")]
    Depth24Stencil8EXT = unchecked((uint)0x88F0),

    [NativeName("GL_R11F_G11F_B10F_EXT")]
    R11FG11FB10FEXT = unchecked((uint)0x8C3A),

    [NativeName("GL_ALPHA4_EXT")]
    Alpha4EXT = unchecked((uint)0x803B),

    [NativeName("GL_ALPHA12_EXT")]
    Alpha12EXT = unchecked((uint)0x803D),

    [NativeName("GL_ALPHA16_EXT")]
    Alpha16EXT = unchecked((uint)0x803E),

    [NativeName("GL_LUMINANCE4_EXT")]
    Luminance4EXT = unchecked((uint)0x803F),

    [NativeName("GL_LUMINANCE12_EXT")]
    Luminance12EXT = unchecked((uint)0x8041),

    [NativeName("GL_LUMINANCE16_EXT")]
    Luminance16EXT = unchecked((uint)0x8042),

    [NativeName("GL_LUMINANCE4_ALPHA4_EXT")]
    Luminance4Alpha4EXT = unchecked((uint)0x8043),

    [NativeName("GL_LUMINANCE6_ALPHA2_EXT")]
    Luminance6Alpha2EXT = unchecked((uint)0x8044),

    [NativeName("GL_LUMINANCE12_ALPHA4_EXT")]
    Luminance12Alpha4EXT = unchecked((uint)0x8046),

    [NativeName("GL_LUMINANCE12_ALPHA12_EXT")]
    Luminance12Alpha12EXT = unchecked((uint)0x8047),

    [NativeName("GL_LUMINANCE16_ALPHA16_EXT")]
    Luminance16Alpha16EXT = unchecked((uint)0x8048),

    [NativeName("GL_INTENSITY4_EXT")]
    Intensity4EXT = unchecked((uint)0x804A),

    [NativeName("GL_INTENSITY8_EXT")]
    Intensity8EXT = unchecked((uint)0x804B),

    [NativeName("GL_INTENSITY12_EXT")]
    Intensity12EXT = unchecked((uint)0x804C),

    [NativeName("GL_INTENSITY16_EXT")]
    Intensity16EXT = unchecked((uint)0x804D),

    [NativeName("GL_RGB2_EXT")]
    Rgb2EXT = unchecked((uint)0x804E),

    [NativeName("GL_RGB4_EXT")]
    Rgb4EXT = unchecked((uint)0x804F),

    [NativeName("GL_RGB5_EXT")]
    Rgb5EXT = unchecked((uint)0x8050),

    [NativeName("GL_RGB8_EXT")]
    Rgb8EXT = unchecked((uint)0x8051),

    [NativeName("GL_RGB12_EXT")]
    Rgb12EXT = unchecked((uint)0x8053),

    [NativeName("GL_RGB16_EXT")]
    Rgb16EXT = unchecked((uint)0x8054),

    [NativeName("GL_RGBA2_EXT")]
    Rgba2EXT = unchecked((uint)0x8055),

    [NativeName("GL_RGBA4_EXT")]
    Rgba4EXT = unchecked((uint)0x8056),

    [NativeName("GL_RGB5_A1_EXT")]
    Rgb5A1EXT = unchecked((uint)0x8057),

    [NativeName("GL_RGBA8_EXT")]
    Rgba8EXT = unchecked((uint)0x8058),

    [NativeName("GL_RGBA12_EXT")]
    Rgba12EXT = unchecked((uint)0x805A),

    [NativeName("GL_RGBA16_EXT")]
    Rgba16EXT = unchecked((uint)0x805B),

    [NativeName("GL_COMPRESSED_RED_RGTC1_EXT")]
    CompressedRedRgtc1EXT = unchecked((uint)0x8DBB),

    [NativeName("GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
    CompressedSignedRedRgtc1EXT = unchecked((uint)0x8DBC),

    [NativeName("GL_COMPRESSED_RED_GREEN_RGTC2_EXT")]
    CompressedRedGreenRgtc2EXT = unchecked((uint)0x8DBD),

    [NativeName("GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
    CompressedSignedRedGreenRgtc2EXT = unchecked((uint)0x8DBE),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
    CompressedRgbaS3TcDxt3EXT = unchecked((uint)0x83F2),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
    CompressedRgbaS3TcDxt5EXT = unchecked((uint)0x83F3),

    [NativeName("GL_RGBA32UI_EXT")]
    Rgba32UiEXT = unchecked((uint)0x8D70),

    [NativeName("GL_RGB32UI_EXT")]
    Rgb32UiEXT = unchecked((uint)0x8D71),

    [NativeName("GL_ALPHA32UI_EXT")]
    Alpha32UiEXT = unchecked((uint)0x8D72),

    [NativeName("GL_INTENSITY32UI_EXT")]
    Intensity32UiEXT = unchecked((uint)0x8D73),

    [NativeName("GL_LUMINANCE32UI_EXT")]
    Luminance32UiEXT = unchecked((uint)0x8D74),

    [NativeName("GL_LUMINANCE_ALPHA32UI_EXT")]
    LuminanceAlpha32UiEXT = unchecked((uint)0x8D75),

    [NativeName("GL_RGBA16UI_EXT")]
    Rgba16UiEXT = unchecked((uint)0x8D76),

    [NativeName("GL_RGB16UI_EXT")]
    Rgb16UiEXT = unchecked((uint)0x8D77),

    [NativeName("GL_ALPHA16UI_EXT")]
    Alpha16UiEXT = unchecked((uint)0x8D78),

    [NativeName("GL_INTENSITY16UI_EXT")]
    Intensity16UiEXT = unchecked((uint)0x8D79),

    [NativeName("GL_LUMINANCE16UI_EXT")]
    Luminance16UiEXT = unchecked((uint)0x8D7A),

    [NativeName("GL_LUMINANCE_ALPHA16UI_EXT")]
    LuminanceAlpha16UiEXT = unchecked((uint)0x8D7B),

    [NativeName("GL_RGBA8UI_EXT")]
    Rgba8UiEXT = unchecked((uint)0x8D7C),

    [NativeName("GL_RGB8UI_EXT")]
    Rgb8UiEXT = unchecked((uint)0x8D7D),

    [NativeName("GL_ALPHA8UI_EXT")]
    Alpha8UiEXT = unchecked((uint)0x8D7E),

    [NativeName("GL_INTENSITY8UI_EXT")]
    Intensity8UiEXT = unchecked((uint)0x8D7F),

    [NativeName("GL_LUMINANCE8UI_EXT")]
    Luminance8UiEXT = unchecked((uint)0x8D80),

    [NativeName("GL_LUMINANCE_ALPHA8UI_EXT")]
    LuminanceAlpha8UiEXT = unchecked((uint)0x8D81),

    [NativeName("GL_RGBA32I_EXT")]
    Rgba32IEXT = unchecked((uint)0x8D82),

    [NativeName("GL_RGB32I_EXT")]
    Rgb32IEXT = unchecked((uint)0x8D83),

    [NativeName("GL_ALPHA32I_EXT")]
    Alpha32IEXT = unchecked((uint)0x8D84),

    [NativeName("GL_INTENSITY32I_EXT")]
    Intensity32IEXT = unchecked((uint)0x8D85),

    [NativeName("GL_LUMINANCE32I_EXT")]
    Luminance32IEXT = unchecked((uint)0x8D86),

    [NativeName("GL_LUMINANCE_ALPHA32I_EXT")]
    LuminanceAlpha32IEXT = unchecked((uint)0x8D87),

    [NativeName("GL_RGBA16I_EXT")]
    Rgba16IEXT = unchecked((uint)0x8D88),

    [NativeName("GL_RGB16I_EXT")]
    Rgb16IEXT = unchecked((uint)0x8D89),

    [NativeName("GL_ALPHA16I_EXT")]
    Alpha16IEXT = unchecked((uint)0x8D8A),

    [NativeName("GL_INTENSITY16I_EXT")]
    Intensity16IEXT = unchecked((uint)0x8D8B),

    [NativeName("GL_LUMINANCE16I_EXT")]
    Luminance16IEXT = unchecked((uint)0x8D8C),

    [NativeName("GL_LUMINANCE_ALPHA16I_EXT")]
    LuminanceAlpha16IEXT = unchecked((uint)0x8D8D),

    [NativeName("GL_RGBA8I_EXT")]
    Rgba8IEXT = unchecked((uint)0x8D8E),

    [NativeName("GL_RGB8I_EXT")]
    Rgb8IEXT = unchecked((uint)0x8D8F),

    [NativeName("GL_ALPHA8I_EXT")]
    Alpha8IEXT = unchecked((uint)0x8D90),

    [NativeName("GL_INTENSITY8I_EXT")]
    Intensity8IEXT = unchecked((uint)0x8D91),

    [NativeName("GL_LUMINANCE8I_EXT")]
    Luminance8IEXT = unchecked((uint)0x8D92),

    [NativeName("GL_LUMINANCE_ALPHA8I_EXT")]
    LuminanceAlpha8IEXT = unchecked((uint)0x8D93),

    [NativeName("GL_SRGB8_EXT")]
    Srgb8EXT = unchecked((uint)0x8C41),

    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
    CompressedSrgbS3TcDxt1EXT = unchecked((uint)0x8C4C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
    CompressedSrgbAlphaS3TcDxt1EXT = unchecked((uint)0x8C4D),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
    CompressedSrgbAlphaS3TcDxt3EXT = unchecked((uint)0x8C4E),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
    CompressedSrgbAlphaS3TcDxt5EXT = unchecked((uint)0x8C4F),

    [NativeName("GL_RGB9_E5_EXT")]
    Rgb9E5EXT = unchecked((uint)0x8C3D),

    [NativeName("GL_DEPTH_COMPONENT32F_NV")]
    DepthComponent32FNV = unchecked((uint)0x8DAB),

    [NativeName("GL_DEPTH32F_STENCIL8_NV")]
    Depth32FStencil8NV = unchecked((uint)0x8DAC),

    [NativeName("GL_DEPTH_COMPONENT16_SGIX")]
    DepthComponent16SGIX = unchecked((uint)0x81A5),

    [NativeName("GL_DEPTH_COMPONENT24_SGIX")]
    DepthComponent24SGIX = unchecked((uint)0x81A6),

    [NativeName("GL_DEPTH_COMPONENT32_SGIX")]
    DepthComponent32SGIX = unchecked((uint)0x81A7),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_3x3x3_OES")]
    CompressedRgbaAstc3X3X3OES = unchecked((uint)0x93C0),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x3x3_OES")]
    CompressedRgbaAstc4X3X3OES = unchecked((uint)0x93C1),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x3_OES")]
    CompressedRgbaAstc4X4X3OES = unchecked((uint)0x93C2),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_4x4x4_OES")]
    CompressedRgbaAstc4X4X4OES = unchecked((uint)0x93C3),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x4x4_OES")]
    CompressedRgbaAstc5X4X4OES = unchecked((uint)0x93C4),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x4_OES")]
    CompressedRgbaAstc5X5X4OES = unchecked((uint)0x93C5),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_5x5x5_OES")]
    CompressedRgbaAstc5X5X5OES = unchecked((uint)0x93C6),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x5x5_OES")]
    CompressedRgbaAstc6X5X5OES = unchecked((uint)0x93C7),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x5_OES")]
    CompressedRgbaAstc6X6X5OES = unchecked((uint)0x93C8),

    [NativeName("GL_COMPRESSED_RGBA_ASTC_6x6x6_OES")]
    CompressedRgbaAstc6X6X6OES = unchecked((uint)0x93C9),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES")]
    CompressedSrgb8Alpha8Astc3X3X3OES = unchecked((uint)0x93E0),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES")]
    CompressedSrgb8Alpha8Astc4X3X3OES = unchecked((uint)0x93E1),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES")]
    CompressedSrgb8Alpha8Astc4X4X3OES = unchecked((uint)0x93E2),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES")]
    CompressedSrgb8Alpha8Astc4X4X4OES = unchecked((uint)0x93E3),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES")]
    CompressedSrgb8Alpha8Astc5X4X4OES = unchecked((uint)0x93E4),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES")]
    CompressedSrgb8Alpha8Astc5X5X4OES = unchecked((uint)0x93E5),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES")]
    CompressedSrgb8Alpha8Astc5X5X5OES = unchecked((uint)0x93E6),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES")]
    CompressedSrgb8Alpha8Astc6X5X5OES = unchecked((uint)0x93E7),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES")]
    CompressedSrgb8Alpha8Astc6X6X5OES = unchecked((uint)0x93E8),

    [NativeName("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES")]
    CompressedSrgb8Alpha8Astc6X6X6OES = unchecked((uint)0x93E9),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE")]
    CompressedRgbaS3TcDxt3ANGLE = unchecked((uint)0x83F2),

    [NativeName("GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE")]
    CompressedRgbaS3TcDxt5ANGLE = unchecked((uint)0x83F3),

    [NativeName("GL_R11F_G11F_B10F_APPLE")]
    R11FG11FB10FAPPLE = unchecked((uint)0x8C3A),

    [NativeName("GL_RGB9_E5_APPLE")]
    Rgb9E5APPLE = unchecked((uint)0x8C3D),

    [NativeName("GL_R16_SNORM_EXT")]
    R16SnormEXT = unchecked((uint)0x8F98),

    [NativeName("GL_RG16_SNORM_EXT")]
    Rg16SnormEXT = unchecked((uint)0x8F99),

    [NativeName("GL_RGBA16_SNORM_EXT")]
    Rgba16SnormEXT = unchecked((uint)0x8F9B),

    [NativeName("GL_COMPRESSED_RGBA_BPTC_UNORM_EXT")]
    CompressedRgbaBptcUnormEXT = unchecked((uint)0x8E8C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT")]
    CompressedSrgbAlphaBptcUnormEXT = unchecked((uint)0x8E8D),

    [NativeName("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT")]
    CompressedRgbBptcSignedFloatEXT = unchecked((uint)0x8E8E),

    [NativeName("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT")]
    CompressedRgbBptcUnsignedFloatEXT = unchecked((uint)0x8E8F),

    [NativeName("GL_R16_EXT")]
    R16EXT = unchecked((uint)0x822A),

    [NativeName("GL_RG16_EXT")]
    Rg16EXT = unchecked((uint)0x822C),

    [NativeName("GL_RGB16_SNORM_EXT")]
    Rgb16SnormEXT = unchecked((uint)0x8F9A),

    [NativeName("GL_SRGB8_NV")]
    Srgb8NV = unchecked((uint)0x8C41),

    [NativeName("GL_COMPRESSED_SRGB_S3TC_DXT1_NV")]
    CompressedSrgbS3TcDxt1NV = unchecked((uint)0x8C4C),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV")]
    CompressedSrgbAlphaS3TcDxt1NV = unchecked((uint)0x8C4D),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV")]
    CompressedSrgbAlphaS3TcDxt3NV = unchecked((uint)0x8C4E),

    [NativeName("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV")]
    CompressedSrgbAlphaS3TcDxt5NV = unchecked((uint)0x8C4F),
}
