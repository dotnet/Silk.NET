// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clGetHostTimer")]
public readonly unsafe struct IcdDispatchWindowsGetHostTimer : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<DeviceIdHandle, ulong*, int> Handle =>
        (delegate* unmanaged<DeviceIdHandle, ulong*, int>)Pointer;

    public IcdDispatchWindowsGetHostTimer(delegate* unmanaged<DeviceIdHandle, ulong*, int> ptr) =>
        Pointer = ptr;

    public IcdDispatchWindowsGetHostTimer(IcdDispatchWindowsGetHostTimerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsGetHostTimer(
        delegate* unmanaged<DeviceIdHandle, ulong*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<DeviceIdHandle, ulong*, int>(
        IcdDispatchWindowsGetHostTimer pfn
    ) => (delegate* unmanaged<DeviceIdHandle, ulong*, int>)pfn.Pointer;
}
