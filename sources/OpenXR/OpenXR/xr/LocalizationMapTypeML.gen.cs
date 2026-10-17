// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLocalizationMapTypeML")]
public enum LocalizationMapTypeML : uint
{
    [NativeName("XR_LOCALIZATION_MAP_TYPE_ON_DEVICE_ML")]
    OnDevice = 0,

    [NativeName("XR_LOCALIZATION_MAP_TYPE_CLOUD_ML")]
    Cloud = 1,
}
