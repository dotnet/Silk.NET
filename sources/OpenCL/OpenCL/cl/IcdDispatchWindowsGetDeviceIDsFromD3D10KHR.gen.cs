// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clGetDeviceIDsFromD3D10KHR")]
public readonly unsafe struct IcdDispatchWindowsGetDeviceIDsFromD3D10KHR : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        PlatformIdHandle,
        uint,
        void*,
        uint,
        uint,
        DeviceIdHandle*,
        uint*,
        int> Handle =>
        (delegate* unmanaged<
            PlatformIdHandle,
            uint,
            void*,
            uint,
            uint,
            DeviceIdHandle*,
            uint*,
            int>)Pointer;

    public IcdDispatchWindowsGetDeviceIDsFromD3D10KHR(
        delegate* unmanaged<
            PlatformIdHandle,
            uint,
            void*,
            uint,
            uint,
            DeviceIdHandle*,
            uint*,
            int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsGetDeviceIDsFromD3D10KHR(
        IcdDispatchWindowsGetDeviceIDsFromD3D10KHRDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsGetDeviceIDsFromD3D10KHR(
        delegate* unmanaged<
            PlatformIdHandle,
            uint,
            void*,
            uint,
            uint,
            DeviceIdHandle*,
            uint*,
            int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        PlatformIdHandle,
        uint,
        void*,
        uint,
        uint,
        DeviceIdHandle*,
        uint*,
        int>(IcdDispatchWindowsGetDeviceIDsFromD3D10KHR pfn) =>
        (delegate* unmanaged<
            PlatformIdHandle,
            uint,
            void*,
            uint,
            uint,
            DeviceIdHandle*,
            uint*,
            int>)
            pfn.Pointer;
}
