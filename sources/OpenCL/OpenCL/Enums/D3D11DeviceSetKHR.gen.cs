// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_d3d11_device_set_khr")]
public enum D3D11DeviceSetKHR : uint
{
    [NativeName("CL_PREFERRED_DEVICES_FOR_D3D11_KHR")]
    PreferredDevicesForD3D11 = 16411,

    [NativeName("CL_ALL_DEVICES_FOR_D3D11_KHR")]
    AllDevicesForD3D11 = 16412,
}
