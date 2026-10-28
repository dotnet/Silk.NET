// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceProperties")]
public partial struct PhysicalDeviceProperties
{
    [NativeName("apiVersion")]
    public uint ApiVersion;

    [NativeName("driverVersion")]
    public uint DriverVersion;

    [NativeName("vendorID")]
    public uint VendorID;

    [NativeName("deviceID")]
    public uint DeviceID;

    [NativeName("deviceType")]
    public PhysicalDeviceType DeviceType;

    [NativeName("deviceName")]
    public PhysicalDevicePropertiesDeviceName DeviceName;

    [NativeName("pipelineCacheUUID")]
    public PhysicalDevicePropertiesPipelineCacheUuid PipelineCacheUuid;

    [NativeName("limits")]
    public PhysicalDeviceLimits Limits;

    [NativeName("sparseProperties")]
    public PhysicalDeviceSparseProperties SparseProperties;
}
