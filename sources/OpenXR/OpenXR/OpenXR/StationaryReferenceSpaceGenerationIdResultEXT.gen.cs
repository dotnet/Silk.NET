// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrStationaryReferenceSpaceGenerationIdResultEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct StationaryReferenceSpaceGenerationIdResultEXT
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.StationaryReferenceSpaceGenerationIdResultEXT;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("generationId")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public Uuid GenerationId;

    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public StationaryReferenceSpaceGenerationIdResultEXT() { }
}
