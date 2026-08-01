// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandJointVelocityEXT")]
[SupportedApiProfile("openxr")]
public partial struct HandJointVelocityEXT
{
    [NativeName("velocityFlags")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public SpaceVelocityFlags VelocityFlags;

    [NativeName("linearVelocity")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public Vector3F LinearVelocity;

    [NativeName("angularVelocity")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public Vector3F AngularVelocity;
}
