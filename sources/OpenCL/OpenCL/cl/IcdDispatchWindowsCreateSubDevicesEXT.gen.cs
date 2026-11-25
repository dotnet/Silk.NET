// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateSubDevicesEXT")]
public readonly unsafe struct IcdDispatchWindowsCreateSubDevicesEXT : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int> Handle =>
        (delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int>)Pointer;

    public IcdDispatchWindowsCreateSubDevicesEXT(
        delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCreateSubDevicesEXT(
        IcdDispatchWindowsCreateSubDevicesEXTDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCreateSubDevicesEXT(
        delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        DeviceIdHandle,
        ulong*,
        uint,
        DeviceIdHandle*,
        uint*,
        int>(IcdDispatchWindowsCreateSubDevicesEXT pfn) =>
        (delegate* unmanaged<DeviceIdHandle, ulong*, uint, DeviceIdHandle*, uint*, int>)pfn.Pointer;
}
