// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrCompositionLayerSettingsFlagsFB")]
    public enum CompositionLayerSettingsFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NormalSuperSamplingBitFB\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_NORMAL_SUPER_SAMPLING_BIT_FB")]
        CompositionLayerSettingsNormalSuperSamplingBitFB = 1,
        [Obsolete("Deprecated in favour of \"QualitySuperSamplingBitFB\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_QUALITY_SUPER_SAMPLING_BIT_FB")]
        CompositionLayerSettingsQualitySuperSamplingBitFB = 2,
        [Obsolete("Deprecated in favour of \"NormalSharpeningBitFB\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_NORMAL_SHARPENING_BIT_FB")]
        CompositionLayerSettingsNormalSharpeningBitFB = 4,
        [Obsolete("Deprecated in favour of \"QualitySharpeningBitFB\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_QUALITY_SHARPENING_BIT_FB")]
        CompositionLayerSettingsQualitySharpeningBitFB = 8,
        [Obsolete("Deprecated in favour of \"AutoLayerFilterBitMeta\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_AUTO_LAYER_FILTER_BIT_META")]
        CompositionLayerSettingsAutoLayerFilterBitMeta = 32,
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_NORMAL_SUPER_SAMPLING_BIT_FB")]
        NormalSuperSamplingBitFB = 1,
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_QUALITY_SUPER_SAMPLING_BIT_FB")]
        QualitySuperSamplingBitFB = 2,
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_NORMAL_SHARPENING_BIT_FB")]
        NormalSharpeningBitFB = 4,
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_QUALITY_SHARPENING_BIT_FB")]
        QualitySharpeningBitFB = 8,
        [NativeName("Name", "XR_COMPOSITION_LAYER_SETTINGS_AUTO_LAYER_FILTER_BIT_META")]
        AutoLayerFilterBitMeta = 32,
    }
}
