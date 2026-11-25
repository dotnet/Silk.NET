// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clGetDeviceIDsFromDX9MediaAdapterKHR")]
public readonly unsafe struct IcdDispatchWindowsGetDeviceIDsFromDx9MediaAdapterKHR : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        PlatformIdHandle,
        uint,
        uint*,
        void*,
        uint,
        uint,
        DeviceIdHandle*,
        uint*,
        int> Handle =>
        (delegate* unmanaged<
            PlatformIdHandle,
            uint,
            uint*,
            void*,
            uint,
            uint,
            DeviceIdHandle*,
            uint*,
            int>)Pointer;

    public IcdDispatchWindowsGetDeviceIDsFromDx9MediaAdapterKHR(
        delegate* unmanaged<
            PlatformIdHandle,
            uint,
            uint*,
            void*,
            uint,
            uint,
            DeviceIdHandle*,
            uint*,
            int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsGetDeviceIDsFromDx9MediaAdapterKHR(
        IcdDispatchWindowsGetDeviceIDsFromDx9MediaAdapterKHRDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsGetDeviceIDsFromDx9MediaAdapterKHR(
        delegate* unmanaged<
            PlatformIdHandle,
            uint,
            uint*,
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
        uint*,
        void*,
        uint,
        uint,
        DeviceIdHandle*,
        uint*,
        int>(IcdDispatchWindowsGetDeviceIDsFromDx9MediaAdapterKHR pfn) =>
        (delegate* unmanaged<
            PlatformIdHandle,
            uint,
            uint*,
            void*,
            uint,
            uint,
            DeviceIdHandle*,
            uint*,
            int>)
            pfn.Pointer;
}
