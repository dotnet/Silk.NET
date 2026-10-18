// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExternalCameraExtrinsicsOCULUS")]
[SupportedApiProfile("openxr")]
public partial struct ExternalCameraExtrinsicsOCULUS
{
    [NativeName("lastChangeTime")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public long LastChangeTime;

    [NativeName("cameraStatusFlags")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public ExternalCameraStatusFlagsOCULUS CameraStatusFlags;

    [NativeName("attachedToDevice")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public ExternalCameraAttachedToDeviceOCULUS AttachedToDevice;

    [NativeName("relativePose")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public Posef RelativePose;
}
