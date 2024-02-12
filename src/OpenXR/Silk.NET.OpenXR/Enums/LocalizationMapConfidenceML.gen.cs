// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrLocalizationMapConfidenceML")]
    public enum LocalizationMapConfidenceML : int
    {
        [Obsolete("Deprecated in favour of \"PoorML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_CONFIDENCE_POOR_ML")]
        LocalizationMapConfidencePoorML = 0,
        [Obsolete("Deprecated in favour of \"FairML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_CONFIDENCE_FAIR_ML")]
        LocalizationMapConfidenceFairML = 1,
        [Obsolete("Deprecated in favour of \"GoodML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_CONFIDENCE_GOOD_ML")]
        LocalizationMapConfidenceGoodML = 2,
        [Obsolete("Deprecated in favour of \"ExcellentML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_CONFIDENCE_EXCELLENT_ML")]
        LocalizationMapConfidenceExcellentML = 3,
        [NativeName("Name", "XR_LOCALIZATION_MAP_CONFIDENCE_POOR_ML")]
        PoorML = 0,
        [NativeName("Name", "XR_LOCALIZATION_MAP_CONFIDENCE_FAIR_ML")]
        FairML = 1,
        [NativeName("Name", "XR_LOCALIZATION_MAP_CONFIDENCE_GOOD_ML")]
        GoodML = 2,
        [NativeName("Name", "XR_LOCALIZATION_MAP_CONFIDENCE_EXCELLENT_ML")]
        ExcellentML = 3,
    }
}
