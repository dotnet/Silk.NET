// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBlendOp")]
    public enum BlendOp : int
    {
        [NativeName("Name", "VK_BLEND_OP_ADD")]
        Add = 0,
        [NativeName("Name", "VK_BLEND_OP_SUBTRACT")]
        Subtract = 1,
        [NativeName("Name", "VK_BLEND_OP_REVERSE_SUBTRACT")]
        ReverseSubtract = 2,
        [NativeName("Name", "VK_BLEND_OP_MIN")]
        Min = 3,
        [NativeName("Name", "VK_BLEND_OP_MAX")]
        Max = 4,
        [NativeName("Name", "VK_BLEND_OP_ZERO_EXT")]
        ZeroExt = 1000148000,
        [NativeName("Name", "VK_BLEND_OP_SRC_EXT")]
        SrcExt = 1000148001,
        [NativeName("Name", "VK_BLEND_OP_DST_EXT")]
        DstExt = 1000148002,
        [NativeName("Name", "VK_BLEND_OP_SRC_OVER_EXT")]
        SrcOverExt = 1000148003,
        [NativeName("Name", "VK_BLEND_OP_DST_OVER_EXT")]
        DstOverExt = 1000148004,
        [NativeName("Name", "VK_BLEND_OP_SRC_IN_EXT")]
        SrcInExt = 1000148005,
        [NativeName("Name", "VK_BLEND_OP_DST_IN_EXT")]
        DstInExt = 1000148006,
        [NativeName("Name", "VK_BLEND_OP_SRC_OUT_EXT")]
        SrcOutExt = 1000148007,
        [NativeName("Name", "VK_BLEND_OP_DST_OUT_EXT")]
        DstOutExt = 1000148008,
        [NativeName("Name", "VK_BLEND_OP_SRC_ATOP_EXT")]
        SrcAtopExt = 1000148009,
        [NativeName("Name", "VK_BLEND_OP_DST_ATOP_EXT")]
        DstAtopExt = 1000148010,
        [NativeName("Name", "VK_BLEND_OP_XOR_EXT")]
        XorExt = 1000148011,
        [NativeName("Name", "VK_BLEND_OP_MULTIPLY_EXT")]
        MultiplyExt = 1000148012,
        [NativeName("Name", "VK_BLEND_OP_SCREEN_EXT")]
        ScreenExt = 1000148013,
        [NativeName("Name", "VK_BLEND_OP_OVERLAY_EXT")]
        OverlayExt = 1000148014,
        [NativeName("Name", "VK_BLEND_OP_DARKEN_EXT")]
        DarkenExt = 1000148015,
        [NativeName("Name", "VK_BLEND_OP_LIGHTEN_EXT")]
        LightenExt = 1000148016,
        [NativeName("Name", "VK_BLEND_OP_COLORDODGE_EXT")]
        ColordodgeExt = 1000148017,
        [NativeName("Name", "VK_BLEND_OP_COLORBURN_EXT")]
        ColorburnExt = 1000148018,
        [NativeName("Name", "VK_BLEND_OP_HARDLIGHT_EXT")]
        HardlightExt = 1000148019,
        [NativeName("Name", "VK_BLEND_OP_SOFTLIGHT_EXT")]
        SoftlightExt = 1000148020,
        [NativeName("Name", "VK_BLEND_OP_DIFFERENCE_EXT")]
        DifferenceExt = 1000148021,
        [NativeName("Name", "VK_BLEND_OP_EXCLUSION_EXT")]
        ExclusionExt = 1000148022,
        [NativeName("Name", "VK_BLEND_OP_INVERT_EXT")]
        InvertExt = 1000148023,
        [NativeName("Name", "VK_BLEND_OP_INVERT_RGB_EXT")]
        InvertRgbExt = 1000148024,
        [NativeName("Name", "VK_BLEND_OP_LINEARDODGE_EXT")]
        LineardodgeExt = 1000148025,
        [NativeName("Name", "VK_BLEND_OP_LINEARBURN_EXT")]
        LinearburnExt = 1000148026,
        [NativeName("Name", "VK_BLEND_OP_VIVIDLIGHT_EXT")]
        VividlightExt = 1000148027,
        [NativeName("Name", "VK_BLEND_OP_LINEARLIGHT_EXT")]
        LinearlightExt = 1000148028,
        [NativeName("Name", "VK_BLEND_OP_PINLIGHT_EXT")]
        PinlightExt = 1000148029,
        [NativeName("Name", "VK_BLEND_OP_HARDMIX_EXT")]
        HardmixExt = 1000148030,
        [NativeName("Name", "VK_BLEND_OP_HSL_HUE_EXT")]
        HslHueExt = 1000148031,
        [NativeName("Name", "VK_BLEND_OP_HSL_SATURATION_EXT")]
        HslSaturationExt = 1000148032,
        [NativeName("Name", "VK_BLEND_OP_HSL_COLOR_EXT")]
        HslColorExt = 1000148033,
        [NativeName("Name", "VK_BLEND_OP_HSL_LUMINOSITY_EXT")]
        HslLuminosityExt = 1000148034,
        [NativeName("Name", "VK_BLEND_OP_PLUS_EXT")]
        PlusExt = 1000148035,
        [NativeName("Name", "VK_BLEND_OP_PLUS_CLAMPED_EXT")]
        PlusClampedExt = 1000148036,
        [NativeName("Name", "VK_BLEND_OP_PLUS_CLAMPED_ALPHA_EXT")]
        PlusClampedAlphaExt = 1000148037,
        [NativeName("Name", "VK_BLEND_OP_PLUS_DARKER_EXT")]
        PlusDarkerExt = 1000148038,
        [NativeName("Name", "VK_BLEND_OP_MINUS_EXT")]
        MinusExt = 1000148039,
        [NativeName("Name", "VK_BLEND_OP_MINUS_CLAMPED_EXT")]
        MinusClampedExt = 1000148040,
        [NativeName("Name", "VK_BLEND_OP_CONTRAST_EXT")]
        ContrastExt = 1000148041,
        [NativeName("Name", "VK_BLEND_OP_INVERT_OVG_EXT")]
        InvertOvgExt = 1000148042,
        [NativeName("Name", "VK_BLEND_OP_RED_EXT")]
        RedExt = 1000148043,
        [NativeName("Name", "VK_BLEND_OP_GREEN_EXT")]
        GreenExt = 1000148044,
        [NativeName("Name", "VK_BLEND_OP_BLUE_EXT")]
        BlueExt = 1000148045,
    }
}
