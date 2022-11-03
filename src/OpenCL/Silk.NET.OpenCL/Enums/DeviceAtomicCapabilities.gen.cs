// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_device_atomic_capabilities")]
    public enum DeviceAtomicCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_RELAXED")]
        OrderRelaxed = 0x1,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_ACQ_REL")]
        OrderAcqRel = 0x2,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_SEQ_CST")]
        OrderSeqCst = 0x4,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM")]
        ScopeWorkItem = 0x8,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP")]
        ScopeWorkGroup = 0x10,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_DEVICE")]
        ScopeDevice = 0x20,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES")]
        ScopeAllDevices = 0x40,
    }
}
