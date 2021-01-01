// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
