// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_context_info")]
public enum ContextInfo : uint
{
    [NativeName("CL_CONTEXT_REFERENCE_COUNT")]
    ReferenceCount = 4224,

    [NativeName("CL_CONTEXT_DEVICES")]
    Devices = 4225,

    [NativeName("CL_CONTEXT_PROPERTIES")]
    Properties = 4226,

    [NativeName("CL_CONTEXT_NUM_DEVICES")]
    NumDevices = 4227,

    [NativeName("CL_CONTEXT_ADAPTER_D3D9_KHR")]
    AdapterD3D9KHR = 8229,

    [NativeName("CL_CONTEXT_ADAPTER_D3D9EX_KHR")]
    AdapterD3D9ExKHR = 8230,

    [NativeName("CL_CONTEXT_ADAPTER_DXVA_KHR")]
    AdapterDxvaKHR = 8231,

    [NativeName("CL_CONTEXT_D3D10_DEVICE_KHR")]
    D3D10DeviceKHR = 16404,

    [NativeName("CL_CONTEXT_D3D11_DEVICE_KHR")]
    D3D11DeviceKHR = 16413,

    [NativeName("CL_CONTEXT_D3D9_DEVICE_INTEL")]
    D3D9DeviceINTEL = 16422,

    [NativeName("CL_CONTEXT_D3D10_PREFER_SHARED_RESOURCES_KHR")]
    D3D10PreferSharedResourcesKHR = 16428,

    [NativeName("CL_CONTEXT_D3D11_PREFER_SHARED_RESOURCES_KHR")]
    D3D11PreferSharedResourcesKHR = 16429,

    [NativeName("CL_CONTEXT_D3D9EX_DEVICE_INTEL")]
    D3D9ExDeviceINTEL = 16498,

    [NativeName("CL_CONTEXT_DXVA_DEVICE_INTEL")]
    DxvaDeviceINTEL = 16499,

    [NativeName("CL_CONTEXT_VA_API_DISPLAY_INTEL")]
    VaApiDisplayINTEL = 16535,

    [NativeName("CL_CONTEXT_PERF_HINT_QCOM")]
    PerfHintQCOM = 16578,
}
