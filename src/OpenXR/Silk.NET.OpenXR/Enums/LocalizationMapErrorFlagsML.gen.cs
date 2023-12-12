// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrLocalizationMapErrorFlagsML")]
    public enum LocalizationMapErrorFlagsML : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"UnknownBitML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_UNKNOWN_BIT_ML")]
        LocalizationMapErrorUnknownBitML = 1,
        [Obsolete("Deprecated in favour of \"OutOfMappedAreaBitML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_OUT_OF_MAPPED_AREA_BIT_ML")]
        LocalizationMapErrorOutOfMappedAreaBitML = 2,
        [Obsolete("Deprecated in favour of \"LowFeatureCountBitML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_LOW_FEATURE_COUNT_BIT_ML")]
        LocalizationMapErrorLowFeatureCountBitML = 4,
        [Obsolete("Deprecated in favour of \"ExcessiveMotionBitML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_EXCESSIVE_MOTION_BIT_ML")]
        LocalizationMapErrorExcessiveMotionBitML = 8,
        [Obsolete("Deprecated in favour of \"LowLightBitML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_LOW_LIGHT_BIT_ML")]
        LocalizationMapErrorLowLightBitML = 16,
        [Obsolete("Deprecated in favour of \"HeadposeBitML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_HEADPOSE_BIT_ML")]
        LocalizationMapErrorHeadposeBitML = 32,
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_UNKNOWN_BIT_ML")]
        UnknownBitML = 1,
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_OUT_OF_MAPPED_AREA_BIT_ML")]
        OutOfMappedAreaBitML = 2,
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_LOW_FEATURE_COUNT_BIT_ML")]
        LowFeatureCountBitML = 4,
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_EXCESSIVE_MOTION_BIT_ML")]
        ExcessiveMotionBitML = 8,
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_LOW_LIGHT_BIT_ML")]
        LowLightBitML = 16,
        [NativeName("Name", "XR_LOCALIZATION_MAP_ERROR_HEADPOSE_BIT_ML")]
        HeadposeBitML = 32,
    }
}
