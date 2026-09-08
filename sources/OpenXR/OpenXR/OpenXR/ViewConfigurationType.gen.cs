// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViewConfigurationType")]
[SupportedApiProfile("openxr")]
public enum ViewConfigurationType : uint
{
    [NativeName("XR_VIEW_CONFIGURATION_TYPE_PRIMARY_MONO")]
    [SupportedApiProfile("openxr")]
    PrimaryMono = 1,

    [NativeName("XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO")]
    [SupportedApiProfile("openxr")]
    PrimaryStereo = 2,

    [NativeName("XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO_WITH_FOVEATED_INSET")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    PrimaryStereoWithFoveatedInset = 1000037000,

    [NativeName("XR_VIEW_CONFIGURATION_TYPE_SECONDARY_MONO_FIRST_PERSON_OBSERVER_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_first_person_observer"],
        ImpliesSets = ["XR_MSFT_secondary_view_configuration", "XR_VERSION_1_0"]
    )]
    SecondaryMonoFirstPersonObserverMSFT = 1000054000,

    [NativeName("XR_VIEW_CONFIGURATION_TYPE_PRIMARY_QUAD_VARJO")]
    [SupportedApiProfile("openxr", ["XR_VARJO_quad_views"])]
    PrimaryQuadVARJO = PrimaryStereoWithFoveatedInset,
}
