// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [NativeName("Name", "GLenum")]
    public enum SGIX : int
    {
        [NativeName("Name", "GL_ASYNC_MARKER_SGIX")]
        AsyncMarkerSgix = 0x8329,
        [NativeName("Name", "GL_ASYNC_HISTOGRAM_SGIX")]
        AsyncHistogramSgix = 0x832C,
        [NativeName("Name", "GL_MAX_ASYNC_HISTOGRAM_SGIX")]
        MaxAsyncHistogramSgix = 0x832D,
        [NativeName("Name", "GL_ASYNC_TEX_IMAGE_SGIX")]
        AsyncTexImageSgix = 0x835C,
        [NativeName("Name", "GL_ASYNC_DRAW_PIXELS_SGIX")]
        AsyncDrawPixelsSgix = 0x835D,
        [NativeName("Name", "GL_ASYNC_READ_PIXELS_SGIX")]
        AsyncReadPixelsSgix = 0x835E,
        [NativeName("Name", "GL_MAX_ASYNC_TEX_IMAGE_SGIX")]
        MaxAsyncTexImageSgix = 0x835F,
        [NativeName("Name", "GL_MAX_ASYNC_DRAW_PIXELS_SGIX")]
        MaxAsyncDrawPixelsSgix = 0x8360,
        [NativeName("Name", "GL_MAX_ASYNC_READ_PIXELS_SGIX")]
        MaxAsyncReadPixelsSgix = 0x8361,
        [NativeName("Name", "GL_ALPHA_MIN_SGIX")]
        AlphaMinSgix = 0x8320,
        [NativeName("Name", "GL_ALPHA_MAX_SGIX")]
        AlphaMaxSgix = 0x8321,
        [NativeName("Name", "GL_CALLIGRAPHIC_FRAGMENT_SGIX")]
        CalligraphicFragmentSgix = 0x8183,
        [NativeName("Name", "GL_LINEAR_CLIPMAP_LINEAR_SGIX")]
        LinearClipmapLinearSgix = 0x8170,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_CENTER_SGIX")]
        TextureClipmapCenterSgix = 0x8171,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_FRAME_SGIX")]
        TextureClipmapFrameSgix = 0x8172,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_OFFSET_SGIX")]
        TextureClipmapOffsetSgix = 0x8173,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
        TextureClipmapVirtualDepthSgix = 0x8174,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX")]
        TextureClipmapLodOffsetSgix = 0x8175,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_DEPTH_SGIX")]
        TextureClipmapDepthSgix = 0x8176,
        [NativeName("Name", "GL_MAX_CLIPMAP_DEPTH_SGIX")]
        MaxClipmapDepthSgix = 0x8177,
        [NativeName("Name", "GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
        MaxClipmapVirtualDepthSgix = 0x8178,
        [NativeName("Name", "GL_NEAREST_CLIPMAP_NEAREST_SGIX")]
        NearestClipmapNearestSgix = 0x844D,
        [NativeName("Name", "GL_NEAREST_CLIPMAP_LINEAR_SGIX")]
        NearestClipmapLinearSgix = 0x844E,
        [NativeName("Name", "GL_LINEAR_CLIPMAP_NEAREST_SGIX")]
        LinearClipmapNearestSgix = 0x844F,
        [NativeName("Name", "GL_CONVOLUTION_HINT_SGIX")]
        ConvolutionHintSgix = 0x8316,
        [NativeName("Name", "GL_DEPTH_COMPONENT16_SGIX")]
        DepthComponent16Sgix = 0x81A5,
        [NativeName("Name", "GL_DEPTH_COMPONENT24_SGIX")]
        DepthComponent24Sgix = 0x81A6,
        [NativeName("Name", "GL_DEPTH_COMPONENT32_SGIX")]
        DepthComponent32Sgix = 0x81A7,
        [NativeName("Name", "GL_FOG_OFFSET_SGIX")]
        FogOffsetSgix = 0x8198,
        [NativeName("Name", "GL_FOG_OFFSET_VALUE_SGIX")]
        FogOffsetValueSgix = 0x8199,
        [NativeName("Name", "GL_FRAGMENT_LIGHTING_SGIX")]
        FragmentLightingSgix = 0x8400,
        [NativeName("Name", "GL_FRAGMENT_COLOR_MATERIAL_SGIX")]
        FragmentColorMaterialSgix = 0x8401,
        [NativeName("Name", "GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX")]
        FragmentColorMaterialFaceSgix = 0x8402,
        [NativeName("Name", "GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX")]
        FragmentColorMaterialParameterSgix = 0x8403,
        [NativeName("Name", "GL_MAX_FRAGMENT_LIGHTS_SGIX")]
        MaxFragmentLightsSgix = 0x8404,
        [NativeName("Name", "GL_MAX_ACTIVE_LIGHTS_SGIX")]
        MaxActiveLightsSgix = 0x8405,
        [NativeName("Name", "GL_CURRENT_RASTER_NORMAL_SGIX")]
        CurrentRasterNormalSgix = 0x8406,
        [NativeName("Name", "GL_LIGHT_ENV_MODE_SGIX")]
        LightEnvModeSgix = 0x8407,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX")]
        FragmentLightModelLocalViewerSgix = 0x8408,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX")]
        FragmentLightModelTwoSideSgix = 0x8409,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX")]
        FragmentLightModelAmbientSgix = 0x840A,
        [NativeName("Name", "GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX")]
        FragmentLightModelNormalInterpolationSgix = 0x840B,
        [NativeName("Name", "GL_FRAGMENT_LIGHT0_SGIX")]
        FragmentLight0Sgix = 0x840C,
        [NativeName("Name", "GL_FRAGMENT_LIGHT1_SGIX")]
        FragmentLight1Sgix = 0x840D,
        [NativeName("Name", "GL_FRAGMENT_LIGHT2_SGIX")]
        FragmentLight2Sgix = 0x840E,
        [NativeName("Name", "GL_FRAGMENT_LIGHT3_SGIX")]
        FragmentLight3Sgix = 0x840F,
        [NativeName("Name", "GL_FRAGMENT_LIGHT4_SGIX")]
        FragmentLight4Sgix = 0x8410,
        [NativeName("Name", "GL_FRAGMENT_LIGHT5_SGIX")]
        FragmentLight5Sgix = 0x8411,
        [NativeName("Name", "GL_FRAGMENT_LIGHT6_SGIX")]
        FragmentLight6Sgix = 0x8412,
        [NativeName("Name", "GL_FRAGMENT_LIGHT7_SGIX")]
        FragmentLight7Sgix = 0x8413,
        [NativeName("Name", "GL_FRAMEZOOM_SGIX")]
        FramezoomSgix = 0x818B,
        [NativeName("Name", "GL_FRAMEZOOM_FACTOR_SGIX")]
        FramezoomFactorSgix = 0x818C,
        [NativeName("Name", "GL_MAX_FRAMEZOOM_FACTOR_SGIX")]
        MaxFramezoomFactorSgix = 0x818D,
        [NativeName("Name", "GL_INSTRUMENT_BUFFER_POINTER_SGIX")]
        InstrumentBufferPointerSgix = 0x8180,
        [NativeName("Name", "GL_INSTRUMENT_MEASUREMENTS_SGIX")]
        InstrumentMeasurementsSgix = 0x8181,
        [NativeName("Name", "GL_INTERLACE_SGIX")]
        InterlaceSgix = 0x8094,
        [NativeName("Name", "GL_IR_INSTRUMENT1_SGIX")]
        IRInstrument1Sgix = 0x817F,
        [NativeName("Name", "GL_LIST_PRIORITY_SGIX")]
        ListPrioritySgix = 0x8182,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_SGIX")]
        PixelTexGenSgix = 0x8139,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_MODE_SGIX")]
        PixelTexGenModeSgix = 0x832B,
        [NativeName("Name", "GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX")]
        PixelTileBestAlignmentSgix = 0x813E,
        [NativeName("Name", "GL_PIXEL_TILE_CACHE_INCREMENT_SGIX")]
        PixelTileCacheIncrementSgix = 0x813F,
        [NativeName("Name", "GL_PIXEL_TILE_WIDTH_SGIX")]
        PixelTileWidthSgix = 0x8140,
        [NativeName("Name", "GL_PIXEL_TILE_HEIGHT_SGIX")]
        PixelTileHeightSgix = 0x8141,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_WIDTH_SGIX")]
        PixelTileGridWidthSgix = 0x8142,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_HEIGHT_SGIX")]
        PixelTileGridHeightSgix = 0x8143,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_DEPTH_SGIX")]
        PixelTileGridDepthSgix = 0x8144,
        [NativeName("Name", "GL_PIXEL_TILE_CACHE_SIZE_SGIX")]
        PixelTileCacheSizeSgix = 0x8145,
        [NativeName("Name", "GL_TEXTURE_DEFORMATION_BIT_SGIX")]
        TextureDeformationBitSgix = 0x1,
        [NativeName("Name", "GL_GEOMETRY_DEFORMATION_BIT_SGIX")]
        GeometryDeformationBitSgix = 0x2,
        [NativeName("Name", "GL_GEOMETRY_DEFORMATION_SGIX")]
        GeometryDeformationSgix = 0x8194,
        [NativeName("Name", "GL_TEXTURE_DEFORMATION_SGIX")]
        TextureDeformationSgix = 0x8195,
        [NativeName("Name", "GL_DEFORMATIONS_MASK_SGIX")]
        DeformationsMaskSgix = 0x8196,
        [NativeName("Name", "GL_MAX_DEFORMATION_ORDER_SGIX")]
        MaxDeformationOrderSgix = 0x8197,
        [NativeName("Name", "GL_REFERENCE_PLANE_SGIX")]
        ReferencePlaneSgix = 0x817D,
        [NativeName("Name", "GL_REFERENCE_PLANE_EQUATION_SGIX")]
        ReferencePlaneEquationSgix = 0x817E,
        [NativeName("Name", "GL_PACK_RESAMPLE_SGIX")]
        PackResampleSgix = 0x842E,
        [NativeName("Name", "GL_UNPACK_RESAMPLE_SGIX")]
        UnpackResampleSgix = 0x842F,
        [NativeName("Name", "GL_RESAMPLE_REPLICATE_SGIX")]
        ResampleReplicateSgix = 0x8433,
        [NativeName("Name", "GL_RESAMPLE_ZERO_FILL_SGIX")]
        ResampleZeroFillSgix = 0x8434,
        [NativeName("Name", "GL_RESAMPLE_DECIMATE_SGIX")]
        ResampleDecimateSgix = 0x8430,
        [NativeName("Name", "GL_SCALEBIAS_HINT_SGIX")]
        ScalebiasHintSgix = 0x8322,
        [NativeName("Name", "GL_TEXTURE_COMPARE_SGIX")]
        TextureCompareSgix = 0x819A,
        [NativeName("Name", "GL_TEXTURE_COMPARE_OPERATOR_SGIX")]
        TextureCompareOperatorSgix = 0x819B,
        [NativeName("Name", "GL_TEXTURE_LEQUAL_R_SGIX")]
        TextureLequalRSgix = 0x819C,
        [NativeName("Name", "GL_TEXTURE_GEQUAL_R_SGIX")]
        TextureGequalRSgix = 0x819D,
        [NativeName("Name", "GL_SHADOW_AMBIENT_SGIX")]
        ShadowAmbientSgix = 0x80BF,
        [NativeName("Name", "GL_SPRITE_SGIX")]
        SpriteSgix = 0x8148,
        [NativeName("Name", "GL_SPRITE_MODE_SGIX")]
        SpriteModeSgix = 0x8149,
        [NativeName("Name", "GL_SPRITE_AXIS_SGIX")]
        SpriteAxisSgix = 0x814A,
        [NativeName("Name", "GL_SPRITE_TRANSLATION_SGIX")]
        SpriteTranslationSgix = 0x814B,
        [NativeName("Name", "GL_SPRITE_AXIAL_SGIX")]
        SpriteAxialSgix = 0x814C,
        [NativeName("Name", "GL_SPRITE_OBJECT_ALIGNED_SGIX")]
        SpriteObjectAlignedSgix = 0x814D,
        [NativeName("Name", "GL_SPRITE_EYE_ALIGNED_SGIX")]
        SpriteEyeAlignedSgix = 0x814E,
        [NativeName("Name", "GL_PACK_SUBSAMPLE_RATE_SGIX")]
        PackSubsampleRateSgix = 0x85A0,
        [NativeName("Name", "GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
        UnpackSubsampleRateSgix = 0x85A1,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4444_SGIX")]
        PixelSubsample4444Sgix = 0x85A2,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_2424_SGIX")]
        PixelSubsample2424Sgix = 0x85A3,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4242_SGIX")]
        PixelSubsample4242Sgix = 0x85A4,
        [NativeName("Name", "GL_TEXTURE_ENV_BIAS_SGIX")]
        TextureEnvBiasSgix = 0x80BE,
        [NativeName("Name", "GL_TEXTURE_MAX_CLAMP_S_SGIX")]
        TextureMaxClampSSgix = 0x8369,
        [NativeName("Name", "GL_TEXTURE_MAX_CLAMP_T_SGIX")]
        TextureMaxClampTSgix = 0x836A,
        [NativeName("Name", "GL_TEXTURE_MAX_CLAMP_R_SGIX")]
        TextureMaxClampRSgix = 0x836B,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS_S_SGIX")]
        TextureLodBiasSSgix = 0x818E,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS_T_SGIX")]
        TextureLodBiasTSgix = 0x818F,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS_R_SGIX")]
        TextureLodBiasRSgix = 0x8190,
        [NativeName("Name", "GL_TEXTURE_MULTI_BUFFER_HINT_SGIX")]
        TextureMultiBufferHintSgix = 0x812E,
        [NativeName("Name", "GL_POST_TEXTURE_FILTER_BIAS_SGIX")]
        PostTextureFilterBiasSgix = 0x8179,
        [NativeName("Name", "GL_POST_TEXTURE_FILTER_SCALE_SGIX")]
        PostTextureFilterScaleSgix = 0x817A,
        [NativeName("Name", "GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX")]
        PostTextureFilterBiasRangeSgix = 0x817B,
        [NativeName("Name", "GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX")]
        PostTextureFilterScaleRangeSgix = 0x817C,
        [NativeName("Name", "GL_VERTEX_PRECLIP_SGIX")]
        VertexPreclipSgix = 0x83EE,
        [NativeName("Name", "GL_VERTEX_PRECLIP_HINT_SGIX")]
        VertexPreclipHintSgix = 0x83EF,
        [NativeName("Name", "GL_YCRCB_422_SGIX")]
        Ycrcb422Sgix = 0x81BB,
        [NativeName("Name", "GL_YCRCB_444_SGIX")]
        Ycrcb444Sgix = 0x81BC,
        [NativeName("Name", "GL_YCRCB_SGIX")]
        YcrcbSgix = 0x8318,
        [NativeName("Name", "GL_YCRCBA_SGIX")]
        YcrcbaSgix = 0x8319,
    }
}
