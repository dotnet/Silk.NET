// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct DebugReportCallbackEXT : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        DebugReportFlagsEXT,
        DebugReportObjectTypeEXT,
        ulong,
        nuint,
        int,
        sbyte*,
        sbyte*,
        void*,
        uint> Handle =>
        (delegate* unmanaged<
            DebugReportFlagsEXT,
            DebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint>)Pointer;

    public DebugReportCallbackEXT(
        delegate* unmanaged<
            DebugReportFlagsEXT,
            DebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint> ptr
    ) => Pointer = ptr;

    public DebugReportCallbackEXT(DebugReportCallbackEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator DebugReportCallbackEXT(
        delegate* unmanaged<
            DebugReportFlagsEXT,
            DebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        DebugReportFlagsEXT,
        DebugReportObjectTypeEXT,
        ulong,
        nuint,
        int,
        sbyte*,
        sbyte*,
        void*,
        uint>(DebugReportCallbackEXT pfn) =>
        (delegate* unmanaged<
            DebugReportFlagsEXT,
            DebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint>)
            pfn.Pointer;
}
