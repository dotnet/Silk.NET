// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_Anonymous1_clGetPlatformIDs")]
public readonly unsafe struct IcdDispatchAnonymous1GetPlatformIDs : IDisposable
{
    private readonly void* Pointer;

    [UnscopedRef]
    public ref delegate* unmanaged<uint, PlatformIdHandle*, uint*, int> Handle =>
        ref *(delegate* unmanaged<uint, PlatformIdHandle*, uint*, int>*)Pointer;

    public IcdDispatchAnonymous1GetPlatformIDs(
        delegate* unmanaged<uint, PlatformIdHandle*, uint*, int> ptr
    ) => Pointer = ptr;

    public IcdDispatchAnonymous1GetPlatformIDs(IcdDispatchAnonymous1GetPlatformIDsDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchAnonymous1GetPlatformIDs(
        delegate* unmanaged<uint, PlatformIdHandle*, uint*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<uint, PlatformIdHandle*, uint*, int>(
        IcdDispatchAnonymous1GetPlatformIDs pfn
    ) => (delegate* unmanaged<uint, PlatformIdHandle*, uint*, int>)pfn.Pointer;
}
