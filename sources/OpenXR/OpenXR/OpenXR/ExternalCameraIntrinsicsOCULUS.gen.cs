// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExternalCameraIntrinsicsOCULUS")]
[SupportedApiProfile("openxr")]
public partial struct ExternalCameraIntrinsicsOCULUS
{
    [NativeName("lastChangeTime")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public long LastChangeTime;

    [NativeName("fov")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public Fovf Fov;

    [NativeName("virtualNearPlaneDistance")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public float VirtualNearPlaneDistance;

    [NativeName("virtualFarPlaneDistance")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public float VirtualFarPlaneDistance;

    [NativeName("imageSensorPixelResolution")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public Extent2Di ImageSensorPixelResolution;
}
