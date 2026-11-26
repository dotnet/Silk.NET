// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clBuildProgram")]
public readonly unsafe struct IcdDispatchWindowsBuildProgram : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        ProgramHandle,
        uint,
        DeviceIdHandle*,
        sbyte*,
        IcdDispatchWindowsClBuildProgramP4,
        void*,
        int> Handle =>
        ref *(delegate* unmanaged<
            ProgramHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            IcdDispatchWindowsClBuildProgramP4,
            void*,
            int>*)Pointer;

    public IcdDispatchWindowsBuildProgram(
        delegate* unmanaged<
            ProgramHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            IcdDispatchWindowsClBuildProgramP4,
            void*,
            int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsBuildProgram(IcdDispatchWindowsBuildProgramDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsBuildProgram(
        delegate* unmanaged<
            ProgramHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            IcdDispatchWindowsClBuildProgramP4,
            void*,
            int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ProgramHandle,
        uint,
        DeviceIdHandle*,
        sbyte*,
        IcdDispatchWindowsClBuildProgramP4,
        void*,
        int>(IcdDispatchWindowsBuildProgram pfn) =>
        (delegate* unmanaged<
            ProgramHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            IcdDispatchWindowsClBuildProgramP4,
            void*,
            int>)
            pfn.Pointer;
}
