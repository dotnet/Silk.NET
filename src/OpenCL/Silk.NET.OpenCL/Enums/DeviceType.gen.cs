// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_device_type")]
    public enum DeviceType : ulong
    {
        [NativeName("Name", "CL_DEVICE_TYPE_DEFAULT")]
        DeviceTypeDefault = 0x1,
        [NativeName("Name", "CL_DEVICE_TYPE_CPU")]
        DeviceTypeCpu = 0x2,
        [NativeName("Name", "CL_DEVICE_TYPE_GPU")]
        DeviceTypeGpu = 0x4,
        [NativeName("Name", "CL_DEVICE_TYPE_ACCELERATOR")]
        DeviceTypeAccelerator = 0x8,
        [NativeName("Name", "CL_DEVICE_TYPE_ALL")]
        DeviceTypeAll = 0xFFFFFFFF,
        [NativeName("Name", "CL_DEVICE_TYPE_CUSTOM")]
        DeviceTypeCustom = 0x10,
    }
}
