// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.ARB
{
    [NativeName("Name", "GLenum")]
    public enum ARB : int
    {
        [NativeName("Name", "WGL_FRONT_COLOR_BUFFER_BIT_ARB")]
        FrontColorBufferBitArb = 0x1,
        [NativeName("Name", "WGL_BACK_COLOR_BUFFER_BIT_ARB")]
        BackColorBufferBitArb = 0x2,
        [NativeName("Name", "WGL_DEPTH_BUFFER_BIT_ARB")]
        DepthBufferBitArb = 0x4,
        [NativeName("Name", "WGL_STENCIL_BUFFER_BIT_ARB")]
        StencilBufferBitArb = 0x8,
        [NativeName("Name", "WGL_CONTEXT_RELEASE_BEHAVIOR_ARB")]
        ContextReleaseBehaviorArb = 0x2097,
        [NativeName("Name", "WGL_CONTEXT_RELEASE_BEHAVIOR_NONE_ARB")]
        ContextReleaseBehaviorNoneArb = 0x0,
        [NativeName("Name", "WGL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_ARB")]
        ContextReleaseBehaviorFlushArb = 0x2098,
        [NativeName("Name", "WGL_CONTEXT_DEBUG_BIT_ARB")]
        ContextDebugBitArb = 0x1,
        [NativeName("Name", "WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB")]
        ContextForwardCompatibleBitArb = 0x2,
        [NativeName("Name", "WGL_CONTEXT_MAJOR_VERSION_ARB")]
        ContextMajorVersionArb = 0x2091,
        [NativeName("Name", "WGL_CONTEXT_MINOR_VERSION_ARB")]
        ContextMinorVersionArb = 0x2092,
        [NativeName("Name", "WGL_CONTEXT_LAYER_PLANE_ARB")]
        ContextLayerPlaneArb = 0x2093,
        [NativeName("Name", "WGL_CONTEXT_FLAGS_ARB")]
        ContextFlagsArb = 0x2094,
        [NativeName("Name", "ERROR_INVALID_VERSION_ARB")]
        ErrorInvalidVersionArb = 0x2095,
        [NativeName("Name", "WGL_CONTEXT_OPENGL_NO_ERROR_ARB")]
        ContextOpenglNoErrorArb = 0x31B3,
        [NativeName("Name", "WGL_CONTEXT_PROFILE_MASK_ARB")]
        ContextProfileMaskArb = 0x9126,
        [NativeName("Name", "WGL_CONTEXT_CORE_PROFILE_BIT_ARB")]
        ContextCoreProfileBitArb = 0x1,
        [NativeName("Name", "WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB")]
        ContextCompatibilityProfileBitArb = 0x2,
        [NativeName("Name", "ERROR_INVALID_PROFILE_ARB")]
        ErrorInvalidProfileArb = 0x2096,
        [NativeName("Name", "WGL_CONTEXT_ROBUST_ACCESS_BIT_ARB")]
        ContextRobustAccessBitArb = 0x4,
        [NativeName("Name", "WGL_LOSE_CONTEXT_ON_RESET_ARB")]
        LoseContextOnResetArb = 0x8252,
        [NativeName("Name", "WGL_CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB")]
        ContextResetNotificationStrategyArb = 0x8256,
        [NativeName("Name", "WGL_NO_RESET_NOTIFICATION_ARB")]
        NoResetNotificationArb = 0x8261,
        [NativeName("Name", "WGL_FRAMEBUFFER_SRGB_CAPABLE_ARB")]
        FramebufferSrgbCapableArb = 0x20A9,
        [NativeName("Name", "ERROR_INVALID_PIXEL_TYPE_ARB")]
        ErrorInvalidPixelTypeArb = 0x2043,
        [NativeName("Name", "ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB")]
        ErrorIncompatibleDeviceContextsArb = 0x2054,
        [NativeName("Name", "WGL_SAMPLE_BUFFERS_ARB")]
        SampleBuffersArb = 0x2041,
        [NativeName("Name", "WGL_SAMPLES_ARB")]
        SamplesArb = 0x2042,
        [NativeName("Name", "WGL_DRAW_TO_PBUFFER_ARB")]
        DrawToPbufferArb = 0x202D,
        [NativeName("Name", "WGL_MAX_PBUFFER_PIXELS_ARB")]
        MaxPbufferPixelsArb = 0x202E,
        [NativeName("Name", "WGL_MAX_PBUFFER_WIDTH_ARB")]
        MaxPbufferWidthArb = 0x202F,
        [NativeName("Name", "WGL_MAX_PBUFFER_HEIGHT_ARB")]
        MaxPbufferHeightArb = 0x2030,
        [NativeName("Name", "WGL_PBUFFER_LARGEST_ARB")]
        PbufferLargestArb = 0x2033,
        [NativeName("Name", "WGL_PBUFFER_WIDTH_ARB")]
        PbufferWidthArb = 0x2034,
        [NativeName("Name", "WGL_PBUFFER_HEIGHT_ARB")]
        PbufferHeightArb = 0x2035,
        [NativeName("Name", "WGL_PBUFFER_LOST_ARB")]
        PbufferLostArb = 0x2036,
        [NativeName("Name", "WGL_NUMBER_PIXEL_FORMATS_ARB")]
        NumberPixelFormatsArb = 0x2000,
        [NativeName("Name", "WGL_DRAW_TO_WINDOW_ARB")]
        DrawToWindowArb = 0x2001,
        [NativeName("Name", "WGL_DRAW_TO_BITMAP_ARB")]
        DrawToBitmapArb = 0x2002,
        [NativeName("Name", "WGL_ACCELERATION_ARB")]
        AccelerationArb = 0x2003,
        [NativeName("Name", "WGL_NEED_PALETTE_ARB")]
        NeedPaletteArb = 0x2004,
        [NativeName("Name", "WGL_NEED_SYSTEM_PALETTE_ARB")]
        NeedSystemPaletteArb = 0x2005,
        [NativeName("Name", "WGL_SWAP_LAYER_BUFFERS_ARB")]
        SwapLayerBuffersArb = 0x2006,
        [NativeName("Name", "WGL_SWAP_METHOD_ARB")]
        SwapMethodArb = 0x2007,
        [NativeName("Name", "WGL_NUMBER_OVERLAYS_ARB")]
        NumberOverlaysArb = 0x2008,
        [NativeName("Name", "WGL_NUMBER_UNDERLAYS_ARB")]
        NumberUnderlaysArb = 0x2009,
        [NativeName("Name", "WGL_TRANSPARENT_ARB")]
        TransparentArb = 0x200A,
        [NativeName("Name", "WGL_TRANSPARENT_RED_VALUE_ARB")]
        TransparentRedValueArb = 0x2037,
        [NativeName("Name", "WGL_TRANSPARENT_GREEN_VALUE_ARB")]
        TransparentGreenValueArb = 0x2038,
        [NativeName("Name", "WGL_TRANSPARENT_BLUE_VALUE_ARB")]
        TransparentBlueValueArb = 0x2039,
        [NativeName("Name", "WGL_TRANSPARENT_ALPHA_VALUE_ARB")]
        TransparentAlphaValueArb = 0x203A,
        [NativeName("Name", "WGL_TRANSPARENT_INDEX_VALUE_ARB")]
        TransparentIndexValueArb = 0x203B,
        [NativeName("Name", "WGL_SHARE_DEPTH_ARB")]
        ShareDepthArb = 0x200C,
        [NativeName("Name", "WGL_SHARE_STENCIL_ARB")]
        ShareStencilArb = 0x200D,
        [NativeName("Name", "WGL_SHARE_ACCUM_ARB")]
        ShareAccumArb = 0x200E,
        [NativeName("Name", "WGL_SUPPORT_GDI_ARB")]
        SupportGdiArb = 0x200F,
        [NativeName("Name", "WGL_SUPPORT_OPENGL_ARB")]
        SupportOpenglArb = 0x2010,
        [NativeName("Name", "WGL_DOUBLE_BUFFER_ARB")]
        DoubleBufferArb = 0x2011,
        [NativeName("Name", "WGL_STEREO_ARB")]
        StereoArb = 0x2012,
        [NativeName("Name", "WGL_PIXEL_TYPE_ARB")]
        PixelTypeArb = 0x2013,
        [NativeName("Name", "WGL_COLOR_BITS_ARB")]
        ColorBitsArb = 0x2014,
        [NativeName("Name", "WGL_RED_BITS_ARB")]
        RedBitsArb = 0x2015,
        [NativeName("Name", "WGL_RED_SHIFT_ARB")]
        RedShiftArb = 0x2016,
        [NativeName("Name", "WGL_GREEN_BITS_ARB")]
        GreenBitsArb = 0x2017,
        [NativeName("Name", "WGL_GREEN_SHIFT_ARB")]
        GreenShiftArb = 0x2018,
        [NativeName("Name", "WGL_BLUE_BITS_ARB")]
        BlueBitsArb = 0x2019,
        [NativeName("Name", "WGL_BLUE_SHIFT_ARB")]
        BlueShiftArb = 0x201A,
        [NativeName("Name", "WGL_ALPHA_BITS_ARB")]
        AlphaBitsArb = 0x201B,
        [NativeName("Name", "WGL_ALPHA_SHIFT_ARB")]
        AlphaShiftArb = 0x201C,
        [NativeName("Name", "WGL_ACCUM_BITS_ARB")]
        AccumBitsArb = 0x201D,
        [NativeName("Name", "WGL_ACCUM_RED_BITS_ARB")]
        AccumRedBitsArb = 0x201E,
        [NativeName("Name", "WGL_ACCUM_GREEN_BITS_ARB")]
        AccumGreenBitsArb = 0x201F,
        [NativeName("Name", "WGL_ACCUM_BLUE_BITS_ARB")]
        AccumBlueBitsArb = 0x2020,
        [NativeName("Name", "WGL_ACCUM_ALPHA_BITS_ARB")]
        AccumAlphaBitsArb = 0x2021,
        [NativeName("Name", "WGL_DEPTH_BITS_ARB")]
        DepthBitsArb = 0x2022,
        [NativeName("Name", "WGL_STENCIL_BITS_ARB")]
        StencilBitsArb = 0x2023,
        [NativeName("Name", "WGL_AUX_BUFFERS_ARB")]
        AuxBuffersArb = 0x2024,
        [NativeName("Name", "WGL_NO_ACCELERATION_ARB")]
        NoAccelerationArb = 0x2025,
        [NativeName("Name", "WGL_GENERIC_ACCELERATION_ARB")]
        GenericAccelerationArb = 0x2026,
        [NativeName("Name", "WGL_FULL_ACCELERATION_ARB")]
        FullAccelerationArb = 0x2027,
        [NativeName("Name", "WGL_SWAP_EXCHANGE_ARB")]
        SwapExchangeArb = 0x2028,
        [NativeName("Name", "WGL_SWAP_COPY_ARB")]
        SwapCopyArb = 0x2029,
        [NativeName("Name", "WGL_SWAP_UNDEFINED_ARB")]
        SwapUndefinedArb = 0x202A,
        [NativeName("Name", "WGL_TYPE_RGBA_ARB")]
        TypeRgbaArb = 0x202B,
        [NativeName("Name", "WGL_TYPE_COLORINDEX_ARB")]
        TypeColorindexArb = 0x202C,
        [NativeName("Name", "WGL_TYPE_RGBA_FLOAT_ARB")]
        TypeRgbaFloatArb = 0x21A0,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RGB_ARB")]
        BindToTextureRgbArb = 0x2070,
        [NativeName("Name", "WGL_BIND_TO_TEXTURE_RGBA_ARB")]
        BindToTextureRgbaArb = 0x2071,
        [NativeName("Name", "WGL_TEXTURE_FORMAT_ARB")]
        TextureFormatArb = 0x2072,
        [NativeName("Name", "WGL_TEXTURE_TARGET_ARB")]
        TextureTargetArb = 0x2073,
        [NativeName("Name", "WGL_MIPMAP_TEXTURE_ARB")]
        MipmapTextureArb = 0x2074,
        [NativeName("Name", "WGL_TEXTURE_RGB_ARB")]
        TextureRgbArb = 0x2075,
        [NativeName("Name", "WGL_TEXTURE_RGBA_ARB")]
        TextureRgbaArb = 0x2076,
        [NativeName("Name", "WGL_NO_TEXTURE_ARB")]
        NoTextureArb = 0x2077,
        [NativeName("Name", "WGL_TEXTURE_CUBE_MAP_ARB")]
        TextureCubeMapArb = 0x2078,
        [NativeName("Name", "WGL_TEXTURE_1D_ARB")]
        Texture1DArb = 0x2079,
        [NativeName("Name", "WGL_TEXTURE_2D_ARB")]
        Texture2DArb = 0x207A,
        [NativeName("Name", "WGL_MIPMAP_LEVEL_ARB")]
        MipmapLevelArb = 0x207B,
        [NativeName("Name", "WGL_CUBE_MAP_FACE_ARB")]
        CubeMapFaceArb = 0x207C,
        [NativeName("Name", "WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
        TextureCubeMapPositiveXArb = 0x207D,
        [NativeName("Name", "WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
        TextureCubeMapNegativeXArb = 0x207E,
        [NativeName("Name", "WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
        TextureCubeMapPositiveYArb = 0x207F,
        [NativeName("Name", "WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
        TextureCubeMapNegativeYArb = 0x2080,
        [NativeName("Name", "WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
        TextureCubeMapPositiveZArb = 0x2081,
        [NativeName("Name", "WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
        TextureCubeMapNegativeZArb = 0x2082,
        [NativeName("Name", "WGL_FRONT_LEFT_ARB")]
        FrontLeftArb = 0x2083,
        [NativeName("Name", "WGL_FRONT_RIGHT_ARB")]
        FrontRightArb = 0x2084,
        [NativeName("Name", "WGL_BACK_LEFT_ARB")]
        BackLeftArb = 0x2085,
        [NativeName("Name", "WGL_BACK_RIGHT_ARB")]
        BackRightArb = 0x2086,
        [NativeName("Name", "WGL_AUX0_ARB")]
        Aux0Arb = 0x2087,
        [NativeName("Name", "WGL_AUX1_ARB")]
        Aux1Arb = 0x2088,
        [NativeName("Name", "WGL_AUX2_ARB")]
        Aux2Arb = 0x2089,
        [NativeName("Name", "WGL_AUX3_ARB")]
        Aux3Arb = 0x208A,
        [NativeName("Name", "WGL_AUX4_ARB")]
        Aux4Arb = 0x208B,
        [NativeName("Name", "WGL_AUX5_ARB")]
        Aux5Arb = 0x208C,
        [NativeName("Name", "WGL_AUX6_ARB")]
        Aux6Arb = 0x208D,
        [NativeName("Name", "WGL_AUX7_ARB")]
        Aux7Arb = 0x208E,
        [NativeName("Name", "WGL_AUX8_ARB")]
        Aux8Arb = 0x208F,
        [NativeName("Name", "WGL_AUX9_ARB")]
        Aux9Arb = 0x2090,
        [NativeName("Name", "WGL_CONTEXT_RESET_ISOLATION_BIT_ARB")]
        ContextResetIsolationBitArb = 0x8,
    }
}
