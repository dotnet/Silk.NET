// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExternalCameraOCULUS")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ExternalCameraOCULUS
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public StructureType Type = StructureType.ExternalCameraOCULUS;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public void* Next;

    [NativeName("name")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public ExternalCameraOCULUSName Name;

    [NativeName("intrinsics")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public ExternalCameraIntrinsicsOCULUS Intrinsics;

    [NativeName("extrinsics")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public ExternalCameraExtrinsicsOCULUS Extrinsics;

    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public ExternalCameraOCULUS() { }
}
