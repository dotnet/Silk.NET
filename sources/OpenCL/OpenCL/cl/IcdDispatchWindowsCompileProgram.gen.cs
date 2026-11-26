// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCompileProgram")]
public readonly unsafe struct IcdDispatchWindowsCompileProgram : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<
        ProgramHandle,
        uint,
        DeviceIdHandle*,
        sbyte*,
        uint,
        ProgramHandle*,
        sbyte**,
        IcdDispatchWindowsClCompileProgramP7,
        void*,
        int> Handle =>
        ref *(delegate* unmanaged<
            ProgramHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            uint,
            ProgramHandle*,
            sbyte**,
            IcdDispatchWindowsClCompileProgramP7,
            void*,
            int>*)Pointer;

    public IcdDispatchWindowsCompileProgram(
        delegate* unmanaged<
            ProgramHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            uint,
            ProgramHandle*,
            sbyte**,
            IcdDispatchWindowsClCompileProgramP7,
            void*,
            int> ptr
    ) => Pointer = ptr;

    public IcdDispatchWindowsCompileProgram(IcdDispatchWindowsCompileProgramDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsCompileProgram(
        delegate* unmanaged<
            ProgramHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            uint,
            ProgramHandle*,
            sbyte**,
            IcdDispatchWindowsClCompileProgramP7,
            void*,
            int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ProgramHandle,
        uint,
        DeviceIdHandle*,
        sbyte*,
        uint,
        ProgramHandle*,
        sbyte**,
        IcdDispatchWindowsClCompileProgramP7,
        void*,
        int>(IcdDispatchWindowsCompileProgram pfn) =>
        (delegate* unmanaged<
            ProgramHandle,
            uint,
            DeviceIdHandle*,
            sbyte*,
            uint,
            ProgramHandle*,
            sbyte**,
            IcdDispatchWindowsClCompileProgramP7,
            void*,
            int>)
            pfn.Pointer;
}
