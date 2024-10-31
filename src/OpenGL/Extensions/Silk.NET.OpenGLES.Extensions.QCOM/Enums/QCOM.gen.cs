// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [NativeName("Name", "GLenum")]
    public enum QCOM : int
    {
        [NativeName("Name", "GL_ALPHA_TEST_QCOM")]
        AlphaTestQCom = 0xBC0,
        [NativeName("Name", "GL_ALPHA_TEST_FUNC_QCOM")]
        AlphaTestFuncQCom = 0xBC1,
        [NativeName("Name", "GL_ALPHA_TEST_REF_QCOM")]
        AlphaTestRefQCom = 0xBC2,
        [NativeName("Name", "GL_BINNING_CONTROL_HINT_QCOM")]
        BinningControlHintQCom = 0x8FB0,
        [NativeName("Name", "GL_CPU_OPTIMIZED_QCOM")]
        CpuOptimizedQCom = 0x8FB1,
        [NativeName("Name", "GL_GPU_OPTIMIZED_QCOM")]
        GpuOptimizedQCom = 0x8FB2,
        [NativeName("Name", "GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM")]
        RenderDirectToFramebufferQCom = 0x8FB3,
        [NativeName("Name", "GL_TEXTURE_WIDTH_QCOM")]
        TextureWidthQCom = 0x8BD2,
        [NativeName("Name", "GL_TEXTURE_HEIGHT_QCOM")]
        TextureHeightQCom = 0x8BD3,
        [NativeName("Name", "GL_TEXTURE_DEPTH_QCOM")]
        TextureDepthQCom = 0x8BD4,
        [NativeName("Name", "GL_TEXTURE_INTERNAL_FORMAT_QCOM")]
        TextureInternalFormatQCom = 0x8BD5,
        [NativeName("Name", "GL_TEXTURE_FORMAT_QCOM")]
        TextureFormatQCom = 0x8BD6,
        [NativeName("Name", "GL_TEXTURE_TYPE_QCOM")]
        TextureTypeQCom = 0x8BD7,
        [NativeName("Name", "GL_TEXTURE_IMAGE_VALID_QCOM")]
        TextureImageValidQCom = 0x8BD8,
        [NativeName("Name", "GL_TEXTURE_NUM_LEVELS_QCOM")]
        TextureNumLevelsQCom = 0x8BD9,
        [NativeName("Name", "GL_TEXTURE_TARGET_QCOM")]
        TextureTargetQCom = 0x8BDA,
        [NativeName("Name", "GL_TEXTURE_OBJECT_VALID_QCOM")]
        TextureObjectValidQCom = 0x8BDB,
        [NativeName("Name", "GL_STATE_RESTORE")]
        StateRestore = 0x8BDC,
        [NativeName("Name", "GL_FOVEATION_ENABLE_BIT_QCOM")]
        FoveationEnableBitQCom = 0x1,
        [NativeName("Name", "GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM")]
        FoveationScaledBinMethodBitQCom = 0x2,
        [NativeName("Name", "GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM")]
        MotionEstimationSearchBlockXQCom = 0x8C90,
        [NativeName("Name", "GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM")]
        MotionEstimationSearchBlockYQCom = 0x8C91,
        [NativeName("Name", "GL_PERFMON_GLOBAL_MODE_QCOM")]
        PerfmonGlobalModeQCom = 0x8FA0,
        [NativeName("Name", "GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
        FramebufferFetchNoncoherentQCom = 0x96A2,
        [NativeName("Name", "GL_SHADING_RATE_QCOM")]
        ShadingRateQCom = 0x96A4,
        [NativeName("Name", "GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM")]
        ShadingRatePreserveAspectRatioQCom = 0x96A5,
        [NativeName("Name", "GL_SHADING_RATE_1X1_PIXELS_QCOM")]
        ShadingRate1X1PixelsQCom = 0x96A6,
        [NativeName("Name", "GL_SHADING_RATE_1X2_PIXELS_QCOM")]
        ShadingRate1X2PixelsQCom = 0x96A7,
        [NativeName("Name", "GL_SHADING_RATE_2X1_PIXELS_QCOM")]
        ShadingRate2X1PixelsQCom = 0x96A8,
        [NativeName("Name", "GL_SHADING_RATE_2X2_PIXELS_QCOM")]
        ShadingRate2X2PixelsQCom = 0x96A9,
        [NativeName("Name", "GL_SHADING_RATE_4X2_PIXELS_QCOM")]
        ShadingRate4X2PixelsQCom = 0x96AC,
        [NativeName("Name", "GL_SHADING_RATE_4X4_PIXELS_QCOM")]
        ShadingRate4X4PixelsQCom = 0x96AE,
        [NativeName("Name", "GL_TEXTURE_FOVEATED_FEATURE_BITS_QCOM")]
        TextureFoveatedFeatureBitsQCom = 0x8BFB,
        [NativeName("Name", "GL_TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM")]
        TextureFoveatedMinPixelDensityQCom = 0x8BFC,
        [NativeName("Name", "GL_TEXTURE_FOVEATED_FEATURE_QUERY_QCOM")]
        TextureFoveatedFeatureQueryQCom = 0x8BFD,
        [NativeName("Name", "GL_TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM")]
        TextureFoveatedNumFocalPointsQueryQCom = 0x8BFE,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM")]
        FramebufferIncompleteFoveationQCom = 0x8BFF,
        [NativeName("Name", "GL_TEXTURE_FOVEATED_CUTOFF_DENSITY_QCOM")]
        TextureFoveatedCutoffDensityQCom = 0x96A0,
        [NativeName("Name", "GL_FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM")]
        FoveationSubsampledLayoutMethodBitQCom = 0x4,
        [NativeName("Name", "GL_MAX_SHADER_SUBSAMPLED_IMAGE_UNITS_QCOM")]
        MaxShaderSubsampledImageUnitsQCom = 0x8FA1,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS_QCOM")]
        TextureLodBiasQCom = 0x8C96,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT0_QCOM")]
        ColorBufferBit0QCom = 0x1,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT1_QCOM")]
        ColorBufferBit1QCom = 0x2,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT2_QCOM")]
        ColorBufferBit2QCom = 0x4,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT3_QCOM")]
        ColorBufferBit3QCom = 0x8,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT4_QCOM")]
        ColorBufferBit4QCom = 0x10,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT5_QCOM")]
        ColorBufferBit5QCom = 0x20,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT6_QCOM")]
        ColorBufferBit6QCom = 0x40,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT7_QCOM")]
        ColorBufferBit7QCom = 0x80,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT0_QCOM")]
        DepthBufferBit0QCom = 0x100,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT1_QCOM")]
        DepthBufferBit1QCom = 0x200,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT2_QCOM")]
        DepthBufferBit2QCom = 0x400,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT3_QCOM")]
        DepthBufferBit3QCom = 0x800,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT4_QCOM")]
        DepthBufferBit4QCom = 0x1000,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT5_QCOM")]
        DepthBufferBit5QCom = 0x2000,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT6_QCOM")]
        DepthBufferBit6QCom = 0x4000,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT7_QCOM")]
        DepthBufferBit7QCom = 0x8000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT0_QCOM")]
        StencilBufferBit0QCom = 0x10000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT1_QCOM")]
        StencilBufferBit1QCom = 0x20000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT2_QCOM")]
        StencilBufferBit2QCom = 0x40000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT3_QCOM")]
        StencilBufferBit3QCom = 0x80000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT4_QCOM")]
        StencilBufferBit4QCom = 0x100000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT5_QCOM")]
        StencilBufferBit5QCom = 0x200000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT6_QCOM")]
        StencilBufferBit6QCom = 0x400000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT7_QCOM")]
        StencilBufferBit7QCom = 0x800000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT0_QCOM")]
        MultisampleBufferBit0QCom = 0x1000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT1_QCOM")]
        MultisampleBufferBit1QCom = 0x2000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT2_QCOM")]
        MultisampleBufferBit2QCom = 0x4000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT3_QCOM")]
        MultisampleBufferBit3QCom = 0x8000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT4_QCOM")]
        MultisampleBufferBit4QCom = 0x10000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT5_QCOM")]
        MultisampleBufferBit5QCom = 0x20000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT6_QCOM")]
        MultisampleBufferBit6QCom = 0x40000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT7_QCOM")]
        MultisampleBufferBit7QCom = unchecked((int)0x80000000),
        [NativeName("Name", "GL_WRITEONLY_RENDERING_QCOM")]
        WriteonlyRenderingQCom = 0x8823,
        [NativeName("Name", "GL_TEXTURE_Y_DEGAMMA_QCOM")]
        TextureYDegammaQCom = 0x9710,
        [NativeName("Name", "GL_TEXTURE_CBCR_DEGAMMA_QCOM")]
        TextureCbcrDegammaQCom = 0x9711,
    }
}
