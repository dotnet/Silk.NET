// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_context_info")]
    public enum ContextInfo : int
    {
        [NativeName("Name", "CL_CONTEXT_REFERENCE_COUNT")]
        ReferenceCount = 0x1080,
        [NativeName("Name", "CL_CONTEXT_DEVICES")]
        Devices = 0x1081,
        [NativeName("Name", "CL_CONTEXT_PROPERTIES")]
        Properties = 0x1082,
        [NativeName("Name", "CL_CONTEXT_NUM_DEVICES")]
        NumDevices = 0x1083,
        [NativeName("Name", "CL_CONTEXT_D3D10_DEVICE_KHR")]
        D3D10DeviceKhr = 0x4014,
        [NativeName("Name", "CL_CONTEXT_D3D10_PREFER_SHARED_RESOURCES_KHR")]
        D3D10PreferSharedResourcesKhr = 0x402C,
        [NativeName("Name", "CL_CONTEXT_D3D11_DEVICE_KHR")]
        D3D11DeviceKhr = 0x401D,
        [NativeName("Name", "CL_CONTEXT_D3D11_PREFER_SHARED_RESOURCES_KHR")]
        D3D11PreferSharedResourcesKhr = 0x402D,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9_KHR")]
        AdapterD3D9Khr = 0x2025,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9EX_KHR")]
        AdapterD3D9EXKhr = 0x2026,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_DXVA_KHR")]
        AdapterDxvaKhr = 0x2027,
        [NativeName("Name", "CL_CONTEXT_VA_API_DISPLAY_INTEL")]
        VAApiDisplayIntel = 0x4097,
        [NativeName("Name", "CL_CONTEXT_D3D9_DEVICE_INTEL")]
        D3D9DeviceIntel = 0x4026,
        [NativeName("Name", "CL_CONTEXT_D3D9EX_DEVICE_INTEL")]
        D3D9EXDeviceIntel = 0x4072,
        [NativeName("Name", "CL_CONTEXT_DXVA_DEVICE_INTEL")]
        DxvaDeviceIntel = 0x4073,
        [NativeName("Name", "CL_CONTEXT_PERF_HINT_QCOM")]
        PerfHintQCom = 0x40C2,
    }
}
