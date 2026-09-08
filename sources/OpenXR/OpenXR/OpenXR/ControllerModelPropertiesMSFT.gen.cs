// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrControllerModelPropertiesMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ControllerModelPropertiesMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public StructureType Type = StructureType.ControllerModelPropertiesMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public void* Next;

    [NativeName("nodeCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public uint NodeCapacityInput;

    [NativeName("nodeCountOutput")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public uint NodeCountOutput;

    [NativeName("nodeProperties")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public ControllerModelNodePropertiesMSFT* NodeProperties;

    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public ControllerModelPropertiesMSFT() { }
}
