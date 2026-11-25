// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateSubDevicesEXT")]
public readonly unsafe struct IcdDispatchCreateSubDevicesEXT : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int> Handle =>
        (delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int>)Pointer;

    public IcdDispatchCreateSubDevicesEXT(
        delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchCreateSubDevicesEXT(IcdDispatchCreateSubDevicesEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchCreateSubDevicesEXT(
        delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        DeviceIdHandle,
        ulong*,
        uint,
        DeviceIdHandle*,
        uint*,
        int>(IcdDispatchCreateSubDevicesEXT pfn) =>
        (delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int>)pfn.Pointer;
}
