// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDriverProperties")]
public unsafe partial struct PhysicalDeviceDriverProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDriverProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("driverID")]
    public DriverId DriverID;

    [NativeName("driverName")]
    public PhysicalDeviceDriverPropertiesDriverName DriverName;

    [NativeName("driverInfo")]
    public PhysicalDeviceDriverPropertiesDriverInfo DriverInfo;

    [NativeName("conformanceVersion")]
    public ConformanceVersion ConformanceVersion;

    public PhysicalDeviceDriverProperties() { }
}
