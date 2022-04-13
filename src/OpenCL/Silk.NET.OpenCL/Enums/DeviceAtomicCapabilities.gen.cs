// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_device_atomic_capabilities")]
    public enum DeviceAtomicCapabilities : ulong
    {
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_RELAXED")]
        DeviceAtomicOrderRelaxed = 0x1,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_ACQ_REL")]
        DeviceAtomicOrderAcqRel = 0x2,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_SEQ_CST")]
        DeviceAtomicOrderSeqCst = 0x4,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM")]
        DeviceAtomicScopeWorkItem = 0x8,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP")]
        DeviceAtomicScopeWorkGroup = 0x10,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_DEVICE")]
        DeviceAtomicScopeDevice = 0x20,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES")]
        DeviceAtomicScopeAllDevices = 0x40,
    }
}
