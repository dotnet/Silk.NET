// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_arm_device_svm_capabilities.flags")]
[Flags]
public enum DeviceSvmCapabilitiesFlagsArm : uint
{
    None = 0x0,

    [NativeName("CL_DEVICE_SVM_COARSE_GRAIN_BUFFER_ARM")]
    CoarseGrainBufferARM = 0x1,

    [NativeName("CL_DEVICE_SVM_FINE_GRAIN_BUFFER_ARM")]
    FineGrainBufferARM = 0x2,

    [NativeName("CL_DEVICE_SVM_FINE_GRAIN_SYSTEM_ARM")]
    FineGrainSystemARM = 0x4,

    [NativeName("CL_DEVICE_SVM_ATOMICS_ARM")]
    AtomicsARM = 0x8,
}
