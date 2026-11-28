// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clUnloadPlatformCompiler")]
public readonly unsafe struct IcdDispatchUnloadPlatformCompiler : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<PlatformIdHandle, int> Handle =>
        ref *(delegate* unmanaged<PlatformIdHandle, int>*)Pointer;

    public IcdDispatchUnloadPlatformCompiler(delegate* unmanaged<PlatformIdHandle, int> ptr) =>
        Pointer = ptr;

    public IcdDispatchUnloadPlatformCompiler(IcdDispatchUnloadPlatformCompilerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchUnloadPlatformCompiler(
        delegate* unmanaged<PlatformIdHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<PlatformIdHandle, int>(
        IcdDispatchUnloadPlatformCompiler pfn
    ) => (delegate* unmanaged<PlatformIdHandle, int>)pfn.Pointer;
}
