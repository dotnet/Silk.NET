// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFrustumf")]
[SupportedApiProfile("openxr")]
public partial struct Frustumf
{
    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public Posef Pose;

    [NativeName("fov")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public Fovf Fov;

    [NativeName("nearZ")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public float NearZ;

    [NativeName("farZ")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public float FarZ;
}
