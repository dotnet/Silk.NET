// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.EXT
{
    [NativeName("Name", "GLenum")]
    public enum EXT : int
    {
        [NativeName("Name", "WGL_COLORSPACE_EXT")]
        ColorspaceExt = 0x309D,
        [NativeName("Name", "WGL_COLORSPACE_SRGB_EXT")]
        ColorspaceSrgbExt = 0x3089,
        [NativeName("Name", "WGL_COLORSPACE_LINEAR_EXT")]
        ColorspaceLinearExt = 0x308A,
        [NativeName("Name", "WGL_CONTEXT_ES2_PROFILE_BIT_EXT")]
        ContextES2ProfileBitExt = 0x4,
        [NativeName("Name", "WGL_CONTEXT_ES_PROFILE_BIT_EXT")]
        ContextESProfileBitExt = 0x4,
        [NativeName("Name", "WGL_DEPTH_FLOAT_EXT")]
        DepthFloatExt = 0x2040,
        [NativeName("Name", "WGL_FRAMEBUFFER_SRGB_CAPABLE_EXT")]
        FramebufferSrgbCapableExt = 0x20A9,
        [NativeName("Name", "ERROR_INVALID_PIXEL_TYPE_EXT")]
        ErrorInvalidPixelTypeExt = 0x2043,
        [NativeName("Name", "WGL_SAMPLE_BUFFERS_EXT")]
        SampleBuffersExt = 0x2041,
        [NativeName("Name", "WGL_SAMPLES_EXT")]
        SamplesExt = 0x2042,
        [NativeName("Name", "WGL_DRAW_TO_PBUFFER_EXT")]
        DrawToPbufferExt = 0x202D,
        [NativeName("Name", "WGL_MAX_PBUFFER_PIXELS_EXT")]
        MaxPbufferPixelsExt = 0x202E,
        [NativeName("Name", "WGL_MAX_PBUFFER_WIDTH_EXT")]
        MaxPbufferWidthExt = 0x202F,
        [NativeName("Name", "WGL_MAX_PBUFFER_HEIGHT_EXT")]
        MaxPbufferHeightExt = 0x2030,
        [NativeName("Name", "WGL_OPTIMAL_PBUFFER_WIDTH_EXT")]
        OptimalPbufferWidthExt = 0x2031,
        [NativeName("Name", "WGL_OPTIMAL_PBUFFER_HEIGHT_EXT")]
        OptimalPbufferHeightExt = 0x2032,
        [NativeName("Name", "WGL_PBUFFER_LARGEST_EXT")]
        PbufferLargestExt = 0x2033,
        [NativeName("Name", "WGL_PBUFFER_WIDTH_EXT")]
        PbufferWidthExt = 0x2034,
        [NativeName("Name", "WGL_PBUFFER_HEIGHT_EXT")]
        PbufferHeightExt = 0x2035,
        [NativeName("Name", "WGL_NUMBER_PIXEL_FORMATS_EXT")]
        NumberPixelFormatsExt = 0x2000,
        [NativeName("Name", "WGL_DRAW_TO_WINDOW_EXT")]
        DrawToWindowExt = 0x2001,
        [NativeName("Name", "WGL_DRAW_TO_BITMAP_EXT")]
        DrawToBitmapExt = 0x2002,
        [NativeName("Name", "WGL_ACCELERATION_EXT")]
        AccelerationExt = 0x2003,
        [NativeName("Name", "WGL_NEED_PALETTE_EXT")]
        NeedPaletteExt = 0x2004,
        [NativeName("Name", "WGL_NEED_SYSTEM_PALETTE_EXT")]
        NeedSystemPaletteExt = 0x2005,
        [NativeName("Name", "WGL_SWAP_LAYER_BUFFERS_EXT")]
        SwapLayerBuffersExt = 0x2006,
        [NativeName("Name", "WGL_SWAP_METHOD_EXT")]
        SwapMethodExt = 0x2007,
        [NativeName("Name", "WGL_NUMBER_OVERLAYS_EXT")]
        NumberOverlaysExt = 0x2008,
        [NativeName("Name", "WGL_NUMBER_UNDERLAYS_EXT")]
        NumberUnderlaysExt = 0x2009,
        [NativeName("Name", "WGL_TRANSPARENT_EXT")]
        TransparentExt = 0x200A,
        [NativeName("Name", "WGL_TRANSPARENT_VALUE_EXT")]
        TransparentValueExt = 0x200B,
        [NativeName("Name", "WGL_SHARE_DEPTH_EXT")]
        ShareDepthExt = 0x200C,
        [NativeName("Name", "WGL_SHARE_STENCIL_EXT")]
        ShareStencilExt = 0x200D,
        [NativeName("Name", "WGL_SHARE_ACCUM_EXT")]
        ShareAccumExt = 0x200E,
        [NativeName("Name", "WGL_SUPPORT_GDI_EXT")]
        SupportGdiExt = 0x200F,
        [NativeName("Name", "WGL_SUPPORT_OPENGL_EXT")]
        SupportOpenglExt = 0x2010,
        [NativeName("Name", "WGL_DOUBLE_BUFFER_EXT")]
        DoubleBufferExt = 0x2011,
        [NativeName("Name", "WGL_STEREO_EXT")]
        StereoExt = 0x2012,
        [NativeName("Name", "WGL_PIXEL_TYPE_EXT")]
        PixelTypeExt = 0x2013,
        [NativeName("Name", "WGL_COLOR_BITS_EXT")]
        ColorBitsExt = 0x2014,
        [NativeName("Name", "WGL_RED_BITS_EXT")]
        RedBitsExt = 0x2015,
        [NativeName("Name", "WGL_RED_SHIFT_EXT")]
        RedShiftExt = 0x2016,
        [NativeName("Name", "WGL_GREEN_BITS_EXT")]
        GreenBitsExt = 0x2017,
        [NativeName("Name", "WGL_GREEN_SHIFT_EXT")]
        GreenShiftExt = 0x2018,
        [NativeName("Name", "WGL_BLUE_BITS_EXT")]
        BlueBitsExt = 0x2019,
        [NativeName("Name", "WGL_BLUE_SHIFT_EXT")]
        BlueShiftExt = 0x201A,
        [NativeName("Name", "WGL_ALPHA_BITS_EXT")]
        AlphaBitsExt = 0x201B,
        [NativeName("Name", "WGL_ALPHA_SHIFT_EXT")]
        AlphaShiftExt = 0x201C,
        [NativeName("Name", "WGL_ACCUM_BITS_EXT")]
        AccumBitsExt = 0x201D,
        [NativeName("Name", "WGL_ACCUM_RED_BITS_EXT")]
        AccumRedBitsExt = 0x201E,
        [NativeName("Name", "WGL_ACCUM_GREEN_BITS_EXT")]
        AccumGreenBitsExt = 0x201F,
        [NativeName("Name", "WGL_ACCUM_BLUE_BITS_EXT")]
        AccumBlueBitsExt = 0x2020,
        [NativeName("Name", "WGL_ACCUM_ALPHA_BITS_EXT")]
        AccumAlphaBitsExt = 0x2021,
        [NativeName("Name", "WGL_DEPTH_BITS_EXT")]
        DepthBitsExt = 0x2022,
        [NativeName("Name", "WGL_STENCIL_BITS_EXT")]
        StencilBitsExt = 0x2023,
        [NativeName("Name", "WGL_AUX_BUFFERS_EXT")]
        AuxBuffersExt = 0x2024,
        [NativeName("Name", "WGL_NO_ACCELERATION_EXT")]
        NoAccelerationExt = 0x2025,
        [NativeName("Name", "WGL_GENERIC_ACCELERATION_EXT")]
        GenericAccelerationExt = 0x2026,
        [NativeName("Name", "WGL_FULL_ACCELERATION_EXT")]
        FullAccelerationExt = 0x2027,
        [NativeName("Name", "WGL_SWAP_EXCHANGE_EXT")]
        SwapExchangeExt = 0x2028,
        [NativeName("Name", "WGL_SWAP_COPY_EXT")]
        SwapCopyExt = 0x2029,
        [NativeName("Name", "WGL_SWAP_UNDEFINED_EXT")]
        SwapUndefinedExt = 0x202A,
        [NativeName("Name", "WGL_TYPE_RGBA_EXT")]
        TypeRgbaExt = 0x202B,
        [NativeName("Name", "WGL_TYPE_COLORINDEX_EXT")]
        TypeColorindexExt = 0x202C,
        [NativeName("Name", "WGL_TYPE_RGBA_UNSIGNED_FLOAT_EXT")]
        TypeRgbaUnsignedFloatExt = 0x20A8,
    }
}
