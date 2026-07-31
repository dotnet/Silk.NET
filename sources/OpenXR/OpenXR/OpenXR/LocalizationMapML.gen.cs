// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLocalizationMapML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct LocalizationMapML
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.LocalizationMapML;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("name")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public LocalizationMapMLName Name;

    [NativeName("mapUuid")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public Uuid MapUuid;

    [NativeName("mapType")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public LocalizationMapTypeML MapType;

    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public LocalizationMapML() { }
}
