// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct PFNVkDeviceMemoryReportCallbackEXT : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void> Handle =>
        (delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void>)Pointer;

    public PFNVkDeviceMemoryReportCallbackEXT(
        delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void> ptr
    ) => Pointer = ptr;

    public PFNVkDeviceMemoryReportCallbackEXT(PFNVkDeviceMemoryReportCallbackEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PFNVkDeviceMemoryReportCallbackEXT(
        delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        DeviceMemoryReportCallbackDataEXT*,
        void*,
        void>(PFNVkDeviceMemoryReportCallbackEXT pfn) =>
        (delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void>)pfn.Pointer;
}
