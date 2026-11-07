// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBlendOp")]
public enum BlendOp : uint
{
    [NativeName("VK_BLEND_OP_ADD")]
    Add = 0,

    [NativeName("VK_BLEND_OP_SUBTRACT")]
    Subtract = 1,

    [NativeName("VK_BLEND_OP_REVERSE_SUBTRACT")]
    ReverseSubtract = 2,

    [NativeName("VK_BLEND_OP_MIN")]
    Min = 3,

    [NativeName("VK_BLEND_OP_MAX")]
    Max = 4,

    [NativeName("VK_BLEND_OP_ZERO_EXT")]
    ZeroEXT = 1000148000,

    [NativeName("VK_BLEND_OP_SRC_EXT")]
    SrcEXT = 1000148001,

    [NativeName("VK_BLEND_OP_DST_EXT")]
    DstEXT = 1000148002,

    [NativeName("VK_BLEND_OP_SRC_OVER_EXT")]
    SrcOverEXT = 1000148003,

    [NativeName("VK_BLEND_OP_DST_OVER_EXT")]
    DstOverEXT = 1000148004,

    [NativeName("VK_BLEND_OP_SRC_IN_EXT")]
    SrcInEXT = 1000148005,

    [NativeName("VK_BLEND_OP_DST_IN_EXT")]
    DstInEXT = 1000148006,

    [NativeName("VK_BLEND_OP_SRC_OUT_EXT")]
    SrcOutEXT = 1000148007,

    [NativeName("VK_BLEND_OP_DST_OUT_EXT")]
    DstOutEXT = 1000148008,

    [NativeName("VK_BLEND_OP_SRC_ATOP_EXT")]
    SrcAtopEXT = 1000148009,

    [NativeName("VK_BLEND_OP_DST_ATOP_EXT")]
    DstAtopEXT = 1000148010,

    [NativeName("VK_BLEND_OP_XOR_EXT")]
    XorEXT = 1000148011,

    [NativeName("VK_BLEND_OP_MULTIPLY_EXT")]
    MultiplyEXT = 1000148012,

    [NativeName("VK_BLEND_OP_SCREEN_EXT")]
    ScreenEXT = 1000148013,

    [NativeName("VK_BLEND_OP_OVERLAY_EXT")]
    OverlayEXT = 1000148014,

    [NativeName("VK_BLEND_OP_DARKEN_EXT")]
    DarkenEXT = 1000148015,

    [NativeName("VK_BLEND_OP_LIGHTEN_EXT")]
    LightenEXT = 1000148016,

    [NativeName("VK_BLEND_OP_COLORDODGE_EXT")]
    ColordodgeEXT = 1000148017,

    [NativeName("VK_BLEND_OP_COLORBURN_EXT")]
    ColorburnEXT = 1000148018,

    [NativeName("VK_BLEND_OP_HARDLIGHT_EXT")]
    HardlightEXT = 1000148019,

    [NativeName("VK_BLEND_OP_SOFTLIGHT_EXT")]
    SoftlightEXT = 1000148020,

    [NativeName("VK_BLEND_OP_DIFFERENCE_EXT")]
    DifferenceEXT = 1000148021,

    [NativeName("VK_BLEND_OP_EXCLUSION_EXT")]
    ExclusionEXT = 1000148022,

    [NativeName("VK_BLEND_OP_INVERT_EXT")]
    InvertEXT = 1000148023,

    [NativeName("VK_BLEND_OP_INVERT_RGB_EXT")]
    InvertRgbEXT = 1000148024,

    [NativeName("VK_BLEND_OP_LINEARDODGE_EXT")]
    LineardodgeEXT = 1000148025,

    [NativeName("VK_BLEND_OP_LINEARBURN_EXT")]
    LinearburnEXT = 1000148026,

    [NativeName("VK_BLEND_OP_VIVIDLIGHT_EXT")]
    VividlightEXT = 1000148027,

    [NativeName("VK_BLEND_OP_LINEARLIGHT_EXT")]
    LinearlightEXT = 1000148028,

    [NativeName("VK_BLEND_OP_PINLIGHT_EXT")]
    PinlightEXT = 1000148029,

    [NativeName("VK_BLEND_OP_HARDMIX_EXT")]
    HardmixEXT = 1000148030,

    [NativeName("VK_BLEND_OP_HSL_HUE_EXT")]
    HslHueEXT = 1000148031,

    [NativeName("VK_BLEND_OP_HSL_SATURATION_EXT")]
    HslSaturationEXT = 1000148032,

    [NativeName("VK_BLEND_OP_HSL_COLOR_EXT")]
    HslColorEXT = 1000148033,

    [NativeName("VK_BLEND_OP_HSL_LUMINOSITY_EXT")]
    HslLuminosityEXT = 1000148034,

    [NativeName("VK_BLEND_OP_PLUS_EXT")]
    PlusEXT = 1000148035,

    [NativeName("VK_BLEND_OP_PLUS_CLAMPED_EXT")]
    PlusClampedEXT = 1000148036,

    [NativeName("VK_BLEND_OP_PLUS_CLAMPED_ALPHA_EXT")]
    PlusClampedAlphaEXT = 1000148037,

    [NativeName("VK_BLEND_OP_PLUS_DARKER_EXT")]
    PlusDarkerEXT = 1000148038,

    [NativeName("VK_BLEND_OP_MINUS_EXT")]
    MinusEXT = 1000148039,

    [NativeName("VK_BLEND_OP_MINUS_CLAMPED_EXT")]
    MinusClampedEXT = 1000148040,

    [NativeName("VK_BLEND_OP_CONTRAST_EXT")]
    ContrastEXT = 1000148041,

    [NativeName("VK_BLEND_OP_INVERT_OVG_EXT")]
    InvertOvgEXT = 1000148042,

    [NativeName("VK_BLEND_OP_RED_EXT")]
    RedEXT = 1000148043,

    [NativeName("VK_BLEND_OP_GREEN_EXT")]
    GreenEXT = 1000148044,

    [NativeName("VK_BLEND_OP_BLUE_EXT")]
    BlueEXT = 1000148045,
}
