// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("PFN_vkGetInstanceProcAddr_p2")]
public readonly unsafe struct PfnVkGetInstanceProcAddrP2 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void> Handle => (delegate* unmanaged<void>)Pointer;

    public PfnVkGetInstanceProcAddrP2(delegate* unmanaged<void> ptr) => Pointer = ptr;

    public PfnVkGetInstanceProcAddrP2(PfnVkGetInstanceProcAddrP2Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVkGetInstanceProcAddrP2(delegate* unmanaged<void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void>(PfnVkGetInstanceProcAddrP2 pfn) =>
        (delegate* unmanaged<void>)pfn.Pointer;
}
