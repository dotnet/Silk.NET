// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrLocalizationMapTypeML")]
    public enum LocalizationMapTypeML : int
    {
        [Obsolete("Deprecated in favour of \"OnDeviceML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_TYPE_ON_DEVICE_ML")]
        LocalizationMapTypeOnDeviceML = 0,
        [Obsolete("Deprecated in favour of \"CloudML\"")]
        [NativeName("Name", "XR_LOCALIZATION_MAP_TYPE_CLOUD_ML")]
        LocalizationMapTypeCloudML = 1,
        [NativeName("Name", "XR_LOCALIZATION_MAP_TYPE_ON_DEVICE_ML")]
        OnDeviceML = 0,
        [NativeName("Name", "XR_LOCALIZATION_MAP_TYPE_CLOUD_ML")]
        CloudML = 1,
    }
}
