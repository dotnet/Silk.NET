// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("clSetMemObjectDestructorAPPLE_pfn_notify")]
public readonly unsafe struct SetMemObjectDestructorApplePfnNotify : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<MemHandle, void*, void> Handle =>
        (delegate* unmanaged<MemHandle, void*, void>)Pointer;

    public SetMemObjectDestructorApplePfnNotify(delegate* unmanaged<MemHandle, void*, void> ptr) =>
        Pointer = ptr;

    public SetMemObjectDestructorApplePfnNotify(
        SetMemObjectDestructorApplePfnNotifyDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator SetMemObjectDestructorApplePfnNotify(
        delegate* unmanaged<MemHandle, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<MemHandle, void*, void>(
        SetMemObjectDestructorApplePfnNotify pfn
    ) => (delegate* unmanaged<MemHandle, void*, void>)pfn.Pointer;
}
