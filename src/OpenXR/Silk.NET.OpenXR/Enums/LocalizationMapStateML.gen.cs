// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrLocalizationMapStateML")]
    public enum LocalizationMapStateML : int
    {
        [Obsolete("Deprecated in favour of \"NotLocalizedML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_STATE_NOT_LOCALIZED_ML")]
        LocalizationMapStateNotLocalizedML = 0,
        [Obsolete("Deprecated in favour of \"LocalizedML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_STATE_LOCALIZED_ML")]
        LocalizationMapStateLocalizedML = 1,
        [Obsolete("Deprecated in favour of \"LocalizationPendingML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_STATE_LOCALIZATION_PENDING_ML")]
        LocalizationMapStateLocalizationPendingML = 2,
        [Obsolete("Deprecated in favour of \"LocalizationSleepingBeforeRetryML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_STATE_LOCALIZATION_SLEEPING_BEFORE_RETRY_ML")]
        LocalizationMapStateLocalizationSleepingBeforeRetryML = 3,
        [NativeName("Name", "XR_LOCALIZATION_MAP_STATE_NOT_LOCALIZED_ML")]
        NotLocalizedML = 0,
        [NativeName("Name", "XR_LOCALIZATION_MAP_STATE_LOCALIZED_ML")]
        LocalizedML = 1,
        [NativeName("Name", "XR_LOCALIZATION_MAP_STATE_LOCALIZATION_PENDING_ML")]
        LocalizationPendingML = 2,
        [NativeName("Name", "XR_LOCALIZATION_MAP_STATE_LOCALIZATION_SLEEPING_BEFORE_RETRY_ML")]
        LocalizationSleepingBeforeRetryML = 3,
    }
}
