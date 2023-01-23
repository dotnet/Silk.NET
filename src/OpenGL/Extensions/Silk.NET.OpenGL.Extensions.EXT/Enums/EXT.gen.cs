// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [NativeName("Name", "GLenum")]
    public enum EXT : int
    {
        [NativeName("Name", "GL_PROGRAM_PIPELINE_OBJECT_EXT")]
        ProgramPipelineObjectExt = 0x8A4F,
        [NativeName("Name", "GL_PROGRAM_OBJECT_EXT")]
        ProgramObjectExt = 0x8B40,
        [NativeName("Name", "GL_SHADER_OBJECT_EXT")]
        ShaderObjectExt = 0x8B48,
        [NativeName("Name", "GL_BUFFER_OBJECT_EXT")]
        BufferObjectExt = 0x9151,
        [NativeName("Name", "GL_QUERY_OBJECT_EXT")]
        QueryObjectExt = 0x9153,
        [NativeName("Name", "GL_VERTEX_ARRAY_OBJECT_EXT")]
        VertexArrayObjectExt = 0x9154,
        [NativeName("Name", "GL_SAMPLER")]
        Sampler = 0x82E6,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK")]
        TransformFeedback = 0x8E22,
        [NativeName("Name", "GL_PROGRAM_MATRIX_EXT")]
        ProgramMatrixExt = 0x8E2D,
        [NativeName("Name", "GL_TRANSPOSE_PROGRAM_MATRIX_EXT")]
        TransposeProgramMatrixExt = 0x8E2E,
        [NativeName("Name", "GL_PROGRAM_MATRIX_STACK_DEPTH_EXT")]
        ProgramMatrixStackDepthExt = 0x8E2F,
        [NativeName("Name", "GL_POLYGON_OFFSET_CLAMP_EXT")]
        PolygonOffsetClampExt = 0x8E1B,
        [NativeName("Name", "GL_RASTER_MULTISAMPLE_EXT")]
        RasterMultisampleExt = 0x9327,
        [NativeName("Name", "GL_RASTER_SAMPLES_EXT")]
        RasterSamplesExt = 0x9328,
        [NativeName("Name", "GL_MAX_RASTER_SAMPLES_EXT")]
        MaxRasterSamplesExt = 0x9329,
        [NativeName("Name", "GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT")]
        RasterFixedSampleLocationsExt = 0x932A,
        [NativeName("Name", "GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT")]
        MultisampleRasterizationAllowedExt = 0x932B,
        [NativeName("Name", "GL_EFFECTIVE_RASTER_SAMPLES_EXT")]
        EffectiveRasterSamplesExt = 0x932C,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT")]
        FragmentShaderDiscardsSamplesExt = 0x8A52,
        [NativeName("Name", "GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
        CompressedRgbS3TCDxt1Ext = 0x83F0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
        CompressedRgbaS3TCDxt1Ext = 0x83F1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
        CompressedRgbaS3TCDxt3Ext = 0x83F2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
        CompressedRgbaS3TCDxt5Ext = 0x83F3,
        [NativeName("Name", "GL_TEXTURE_REDUCTION_MODE_EXT")]
        TextureReductionModeExt = 0x9366,
        [NativeName("Name", "GL_WEIGHTED_AVERAGE_EXT")]
        WeightedAverageExt = 0x9367,
        [NativeName("Name", "GL_TEXTURE_SRGB_DECODE_EXT")]
        TextureSrgbDecodeExt = 0x8A48,
        [NativeName("Name", "GL_DECODE_EXT")]
        DecodeExt = 0x8A49,
        [NativeName("Name", "GL_SKIP_DECODE_EXT")]
        SkipDecodeExt = 0x8A4A,
        [NativeName("Name", "GL_SR8_EXT")]
        SR8Ext = 0x8FBD,
        [NativeName("Name", "GL_SRG8_EXT")]
        Srg8Ext = 0x8FBE,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_FORMAT_EXT")]
        TextureImmutableFormatExt = 0x912F,
        [NativeName("Name", "GL_ALPHA8_EXT")]
        Alpha8Ext = 0x803C,
        [NativeName("Name", "GL_LUMINANCE8_EXT")]
        Luminance8Ext = 0x8040,
        [NativeName("Name", "GL_LUMINANCE8_ALPHA8_EXT")]
        Luminance8Alpha8Ext = 0x8045,
        [NativeName("Name", "GL_RGBA32F_EXT")]
        Rgba32fExt = 0x8814,
        [NativeName("Name", "GL_RGB32F_EXT")]
        Rgb32fExt = 0x8815,
        [NativeName("Name", "GL_ALPHA32F_EXT")]
        Alpha32fExt = 0x8816,
        [NativeName("Name", "GL_LUMINANCE32F_EXT")]
        Luminance32fExt = 0x8818,
        [NativeName("Name", "GL_LUMINANCE_ALPHA32F_EXT")]
        LuminanceAlpha32fExt = 0x8819,
        [NativeName("Name", "GL_RGBA16F_EXT")]
        Rgba16fExt = 0x881A,
        [NativeName("Name", "GL_RGB16F_EXT")]
        Rgb16fExt = 0x881B,
        [NativeName("Name", "GL_ALPHA16F_EXT")]
        Alpha16fExt = 0x881C,
        [NativeName("Name", "GL_LUMINANCE16F_EXT")]
        Luminance16fExt = 0x881E,
        [NativeName("Name", "GL_LUMINANCE_ALPHA16F_EXT")]
        LuminanceAlpha16fExt = 0x881F,
        [NativeName("Name", "GL_RGB10_A2_EXT")]
        Rgb10A2Ext = 0x8059,
        [NativeName("Name", "GL_RGB10_EXT")]
        Rgb10Ext = 0x8052,
        [NativeName("Name", "GL_BGRA8_EXT")]
        Bgra8Ext = 0x93A1,
        [NativeName("Name", "GL_R8_EXT")]
        R8Ext = 0x8229,
        [NativeName("Name", "GL_RG8_EXT")]
        RG8Ext = 0x822B,
        [NativeName("Name", "GL_R32F_EXT")]
        R32fExt = 0x822E,
        [NativeName("Name", "GL_RG32F_EXT")]
        RG32fExt = 0x8230,
        [NativeName("Name", "GL_R16F_EXT")]
        R16fExt = 0x822D,
        [NativeName("Name", "GL_RG16F_EXT")]
        RG16fExt = 0x822F,
        [NativeName("Name", "GL_INCLUSIVE_EXT")]
        InclusiveExt = 0x8F10,
        [NativeName("Name", "GL_EXCLUSIVE_EXT")]
        ExclusiveExt = 0x8F11,
        [NativeName("Name", "GL_WINDOW_RECTANGLE_EXT")]
        WindowRectangleExt = 0x8F12,
        [NativeName("Name", "GL_WINDOW_RECTANGLE_MODE_EXT")]
        WindowRectangleModeExt = 0x8F13,
        [NativeName("Name", "GL_MAX_WINDOW_RECTANGLES_EXT")]
        MaxWindowRectanglesExt = 0x8F14,
        [NativeName("Name", "GL_NUM_WINDOW_RECTANGLES_EXT")]
        NumWindowRectanglesExt = 0x8F15,
    }
}
