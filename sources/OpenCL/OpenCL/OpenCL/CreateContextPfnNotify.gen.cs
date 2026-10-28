// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("clCreateContext_pfn_notify")]
public readonly unsafe struct CreateContextPfnNotify : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<sbyte*, void*, nuint, void*, void> Handle =>
        (delegate* unmanaged<sbyte*, void*, nuint, void*, void>)Pointer;

    public CreateContextPfnNotify(delegate* unmanaged<sbyte*, void*, nuint, void*, void> ptr) =>
        Pointer = ptr;

    public CreateContextPfnNotify(CreateContextPfnNotifyDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator CreateContextPfnNotify(
        delegate* unmanaged<sbyte*, void*, nuint, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<sbyte*, void*, nuint, void*, void>(
        CreateContextPfnNotify pfn
    ) => (delegate* unmanaged<sbyte*, void*, nuint, void*, void>)pfn.Pointer;
}
