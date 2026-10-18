// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointSetBD")]
[SupportedApiProfile("openxr")]
public enum BodyJointSetBD : uint
{
    [NativeName("XR_BODY_JOINT_SET_BODY_WITHOUT_ARM_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    BodyWithoutArm = 1,

    [NativeName("XR_BODY_JOINT_SET_FULL_BODY_JOINTS_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    FullBodyJoints = 2,
}
