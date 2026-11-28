// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_dx9_device_source_intel")]
public enum Dx9DeviceSourceINTEL : uint
{
    [NativeName("CL_D3D9_DEVICE_INTEL")]
    D3D9Device = 16418,

    [NativeName("CL_D3D9EX_DEVICE_INTEL")]
    D3D9ExDevice = 16496,

    [NativeName("CL_DXVA_DEVICE_INTEL")]
    DxvaDevice = 16497,
}
