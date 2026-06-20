// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_advanced_motion_estimation.device_me_version")]
public enum IntelAdvancedMotionEstimationDeviceMeVersion : uint
{
    [NativeName("CL_ME_VERSION_LEGACY_INTEL")]
    LegacyINTEL = 0,

    [NativeName("CL_ME_VERSION_ADVANCED_VER_1_INTEL")]
    AdvancedVer1INTEL = 1,

    [NativeName("CL_ME_VERSION_ADVANCED_VER_2_INTEL")]
    AdvancedVer2INTEL = 2,
}
