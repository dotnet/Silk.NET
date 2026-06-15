// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSecondaryViewConfigurationFrameEndInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SecondaryViewConfigurationFrameEndInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public StructureType Type = StructureType.TypeSecondaryViewConfigurationFrameEndInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public void* Next;

    [NativeName("viewConfigurationCount")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public uint ViewConfigurationCount;

    [NativeName("viewConfigurationLayersInfo")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public SecondaryViewConfigurationLayerInfoMSFT* ViewConfigurationLayersInfo;

    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public SecondaryViewConfigurationFrameEndInfoMSFT() { }
}
