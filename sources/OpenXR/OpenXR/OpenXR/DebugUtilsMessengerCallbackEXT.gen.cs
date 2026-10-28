// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("PFN_xrDebugUtilsMessengerCallbackEXT")]
[SupportedApiProfile("openxr")]
public readonly unsafe struct DebugUtilsMessengerCallbackEXT : IDisposable
{
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    private readonly void* Pointer;

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public delegate* unmanaged<
        ulong,
        ulong,
        DebugUtilsMessengerCallbackDataEXT*,
        void*,
        uint> Handle =>
        (delegate* unmanaged<
            ulong,
            ulong,
            DebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint>)Pointer;

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsMessengerCallbackEXT(
        delegate* unmanaged<ulong, ulong, DebugUtilsMessengerCallbackDataEXT*, void*, uint> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsMessengerCallbackEXT(DebugUtilsMessengerCallbackEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public static implicit operator DebugUtilsMessengerCallbackEXT(
        delegate* unmanaged<ulong, ulong, DebugUtilsMessengerCallbackDataEXT*, void*, uint> pfn
    ) => new(pfn);

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public static implicit operator delegate* unmanaged<
        ulong,
        ulong,
        DebugUtilsMessengerCallbackDataEXT*,
        void*,
        uint>(DebugUtilsMessengerCallbackEXT pfn) =>
        (delegate* unmanaged<ulong, ulong, DebugUtilsMessengerCallbackDataEXT*, void*, uint>)
            pfn.Pointer;
}
