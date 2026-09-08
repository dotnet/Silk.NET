// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_addressing_mode")]
public enum AddressingMode : uint
{
    [NativeName("CL_ADDRESS_NONE")]
    None = 4400,

    [NativeName("CL_ADDRESS_CLAMP_TO_EDGE")]
    ClampToEdge = 4401,

    [NativeName("CL_ADDRESS_CLAMP")]
    Clamp = 4402,

    [NativeName("CL_ADDRESS_REPEAT")]
    Repeat = 4403,

    [NativeName("CL_ADDRESS_MIRRORED_REPEAT")]
    MirroredRepeat = 4404,
}
