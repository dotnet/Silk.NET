// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_Anonymous2_clUnloadCompiler")]
public readonly unsafe struct IcdDispatchWindowsAnonymous2UnloadCompiler : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int> Handle => (delegate* unmanaged<int>)Pointer;

    public IcdDispatchWindowsAnonymous2UnloadCompiler(delegate* unmanaged<int> ptr) =>
        Pointer = ptr;

    public IcdDispatchWindowsAnonymous2UnloadCompiler(
        IcdDispatchWindowsAnonymous2UnloadCompilerDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IcdDispatchWindowsAnonymous2UnloadCompiler(
        delegate* unmanaged<int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<int>(
        IcdDispatchWindowsAnonymous2UnloadCompiler pfn
    ) => (delegate* unmanaged<int>)pfn.Pointer;
}
