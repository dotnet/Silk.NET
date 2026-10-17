// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandJointSetEXT")]
public enum HandJointSetEXT : uint
{
    [NativeName("XR_HAND_JOINT_SET_DEFAULT_EXT")]
    Default = 0,

    [NativeName("XR_HAND_JOINT_SET_HAND_WITH_FOREARM_ULTRALEAP")]
    HandWithForearmULTRALEAP = 1000149000,
}
