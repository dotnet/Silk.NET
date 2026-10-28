// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("PFN_xrEglGetProcAddressMNDX_p1")]
[SupportedApiProfile("openxr")]
public readonly unsafe struct EglGetProcAddressMndxP1 : IDisposable
{
    [SupportedApiProfile("openxr")]
    private readonly void* Pointer;

    [SupportedApiProfile("openxr")]
    public delegate* unmanaged<void> Handle => (delegate* unmanaged<void>)Pointer;

    [SupportedApiProfile("openxr")]
    public EglGetProcAddressMndxP1(delegate* unmanaged<void> ptr) => Pointer = ptr;

    [SupportedApiProfile("openxr")]
    public EglGetProcAddressMndxP1(EglGetProcAddressMndxP1Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("openxr")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("openxr")]
    public static implicit operator EglGetProcAddressMndxP1(delegate* unmanaged<void> pfn) =>
        new(pfn);

    [SupportedApiProfile("openxr")]
    public static implicit operator delegate* unmanaged<void>(EglGetProcAddressMndxP1 pfn) =>
        (delegate* unmanaged<void>)pfn.Pointer;
}
