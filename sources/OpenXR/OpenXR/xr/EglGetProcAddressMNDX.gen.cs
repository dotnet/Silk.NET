// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("PFN_xrEglGetProcAddressMNDX")]
public readonly unsafe struct EglGetProcAddressMNDX : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<sbyte*, EglGetProcAddressMndxP1> Handle =>
        (delegate* unmanaged<sbyte*, EglGetProcAddressMndxP1>)Pointer;

    public EglGetProcAddressMNDX(delegate* unmanaged<sbyte*, EglGetProcAddressMndxP1> ptr) =>
        Pointer = ptr;

    public EglGetProcAddressMNDX(EglGetProcAddressMNDXDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EglGetProcAddressMNDX(
        delegate* unmanaged<sbyte*, EglGetProcAddressMndxP1> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<sbyte*, EglGetProcAddressMndxP1>(
        EglGetProcAddressMNDX pfn
    ) => (delegate* unmanaged<sbyte*, EglGetProcAddressMndxP1>)pfn.Pointer;
}
