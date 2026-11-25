// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clSetProgramReleaseCallback")]
public readonly unsafe struct IcdDispatchSetProgramReleaseCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        ProgramHandle,
        IcdDispatchClSetProgramReleaseCallbackP1,
        void*,
        int> Handle =>
        (delegate* unmanaged<
            ProgramHandle,
            IcdDispatchClSetProgramReleaseCallbackP1,
            void*,
            int>)Pointer;

    public IcdDispatchSetProgramReleaseCallback(
        delegate* unmanaged<ProgramHandle, IcdDispatchClSetProgramReleaseCallbackP1, void*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchSetProgramReleaseCallback(
        IcdDispatchSetProgramReleaseCallbackDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchSetProgramReleaseCallback(
        delegate* unmanaged<ProgramHandle, IcdDispatchClSetProgramReleaseCallbackP1, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        ProgramHandle,
        IcdDispatchClSetProgramReleaseCallbackP1,
        void*,
        int>(IcdDispatchSetProgramReleaseCallback pfn) =>
        (delegate* unmanaged<ProgramHandle, IcdDispatchClSetProgramReleaseCallbackP1, void*, int>)
            pfn.Pointer;
}
