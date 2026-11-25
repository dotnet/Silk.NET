// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clReleaseDevice")]
public readonly unsafe struct IcdDispatchReleaseDevice : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<DeviceIdHandle, int> Handle =>
        (delegate* unmanaged<DeviceIdHandle, int>)Pointer;

    public IcdDispatchReleaseDevice(delegate* unmanaged<DeviceIdHandle, int> ptr) => Pointer = ptr;

    public IcdDispatchReleaseDevice(IcdDispatchReleaseDeviceDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchReleaseDevice(
        delegate* unmanaged<DeviceIdHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<DeviceIdHandle, int>(
        IcdDispatchReleaseDevice pfn
    ) => (delegate* unmanaged<DeviceIdHandle, int>)pfn.Pointer;
}
