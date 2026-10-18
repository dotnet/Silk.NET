// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExternalCameraAttachedToDeviceOCULUS")]
[SupportedApiProfile("openxr")]
public enum ExternalCameraAttachedToDeviceOCULUS : uint
{
    [NativeName("XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_NONE_OCULUS")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    None = 0,

    [NativeName("XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_HMD_OCULUS")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    Hmd = 1,

    [NativeName("XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_LTOUCH_OCULUS")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    Ltouch = 2,

    [NativeName("XR_EXTERNAL_CAMERA_ATTACHED_TO_DEVICE_RTOUCH_OCULUS")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    Rtouch = 3,
}
