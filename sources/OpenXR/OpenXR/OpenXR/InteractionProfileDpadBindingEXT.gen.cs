// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInteractionProfileDpadBindingEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct InteractionProfileDpadBindingEXT
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeInteractionProfileDpadBindingEXT;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("binding")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public ulong Binding;

    [NativeName("actionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public ActionSetHandle ActionSet;

    [NativeName("forceThreshold")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public float ForceThreshold;

    [NativeName("forceThresholdReleased")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public float ForceThresholdReleased;

    [NativeName("centerRegion")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public float CenterRegion;

    [NativeName("wedgeAngle")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public float WedgeAngle;

    [NativeName("isSticky")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> IsSticky;

    [NativeName("onHaptic")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public HapticBaseHeader* OnHaptic;

    [NativeName("offHaptic")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public HapticBaseHeader* OffHaptic;

    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public InteractionProfileDpadBindingEXT() { }
}
