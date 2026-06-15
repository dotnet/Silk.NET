// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFuturePollResultProgressBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FuturePollResultProgressBD
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeFuturePollResultProgressBD;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("isSupported")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> IsSupported;

    [NativeName("progressPercentage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public uint ProgressPercentage;

    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public FuturePollResultProgressBD() { }
}
