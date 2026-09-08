// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_feature_capabilities_intel")]
[Flags]
public enum DeviceFeatureCapabilitiesINTEL : ulong
{
    None = 0x0,

    [NativeName("CL_DEVICE_FEATURE_FLAG_DP4A_INTEL")]
    Dp4A = 0x1,

    [NativeName("CL_DEVICE_FEATURE_FLAG_DPAS_INTEL")]
    Dpas = 0x2,
}
