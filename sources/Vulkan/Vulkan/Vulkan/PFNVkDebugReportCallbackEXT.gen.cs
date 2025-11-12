// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct PFNVkDebugReportCallbackEXT : IDisposable
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
        MaybeBool<uint>> Handle =>
        (delegate* unmanaged<
            DebugReportFlagsEXT,
            DebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            MaybeBool<uint>>)Pointer;

    public PFNVkDebugReportCallbackEXT(
        delegate* unmanaged<
            DebugReportFlagsEXT,
            DebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            MaybeBool<uint>> ptr
    ) => Pointer = ptr;

    public PFNVkDebugReportCallbackEXT(PFNVkDebugReportCallbackEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PFNVkDebugReportCallbackEXT(
        delegate* unmanaged<
            DebugReportFlagsEXT,
            DebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            MaybeBool<uint>> pfn
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
        MaybeBool<uint>>(PFNVkDebugReportCallbackEXT pfn) =>
        (delegate* unmanaged<
            DebugReportFlagsEXT,
            DebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            MaybeBool<uint>>)
            pfn.Pointer;
}
