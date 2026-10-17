// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrQrCodeTrackingModeANDROID")]
public enum QrCodeTrackingModeANDROID : uint
{
    [NativeName("XR_QR_CODE_TRACKING_MODE_DYNAMIC_ANDROID")]
    Dynamic = 0,

    [NativeName("XR_QR_CODE_TRACKING_MODE_STATIC_ANDROID")]
    Static = 1,
}
