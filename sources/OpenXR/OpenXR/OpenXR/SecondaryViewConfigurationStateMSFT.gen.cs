// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSecondaryViewConfigurationStateMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SecondaryViewConfigurationStateMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public StructureType Type = StructureType.TypeSecondaryViewConfigurationStateMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public void* Next;

    [NativeName("viewConfigurationType")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public ViewConfigurationType ViewConfigurationType;

    [NativeName("active")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public MaybeBool<uint> Active;

    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public SecondaryViewConfigurationStateMSFT() { }
}
