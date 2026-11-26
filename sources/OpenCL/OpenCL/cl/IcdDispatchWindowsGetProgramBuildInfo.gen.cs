// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clGetProgramBuildInfo")]
public readonly unsafe struct IcdDispatchWindowsGetProgramBuildInfo : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        ProgramHandle,
        DeviceIdHandle,
        uint,
        nuint,
        void*,
        nuint*,
        int> Handle =>
        ref *(delegate* unmanaged<
            ProgramHandle,
            DeviceIdHandle,
            uint,
            nuint,
            void*,
            nuint*,
            int>*)Pointer;

    public IcdDispatchWindowsGetProgramBuildInfo(
        delegate* unmanaged<ProgramHandle, DeviceIdHandle, uint, nuint, void*, nuint*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsGetProgramBuildInfo(
        IcdDispatchWindowsGetProgramBuildInfoDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsGetProgramBuildInfo(
        delegate* unmanaged<ProgramHandle, DeviceIdHandle, uint, nuint, void*, nuint*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ProgramHandle,
        DeviceIdHandle,
        uint,
        nuint,
        void*,
        nuint*,
        int>(IcdDispatchWindowsGetProgramBuildInfo pfn) =>
        (delegate* unmanaged<ProgramHandle, DeviceIdHandle, uint, nuint, void*, nuint*, int>)
            pfn.Pointer;
}
