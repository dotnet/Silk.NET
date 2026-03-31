// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkDebugReportCallbackEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct PfnVkDebugReportCallbackEXT : IDisposable
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public delegate* unmanaged<
        VkDebugReportFlagsEXT,
        VkDebugReportObjectTypeEXT,
        ulong,
        nuint,
        int,
        sbyte*,
        sbyte*,
        void*,
        uint> Handle =>
        (delegate* unmanaged<
            VkDebugReportFlagsEXT,
            VkDebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint>)Pointer;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public PfnVkDebugReportCallbackEXT(
        delegate* unmanaged<
            VkDebugReportFlagsEXT,
            VkDebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public PfnVkDebugReportCallbackEXT(PfnVkDebugReportCallbackEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public static implicit operator PfnVkDebugReportCallbackEXT(
        delegate* unmanaged<
            VkDebugReportFlagsEXT,
            VkDebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public static implicit operator delegate* unmanaged<
        VkDebugReportFlagsEXT,
        VkDebugReportObjectTypeEXT,
        ulong,
        nuint,
        int,
        sbyte*,
        sbyte*,
        void*,
        uint>(PfnVkDebugReportCallbackEXT pfn) =>
        (delegate* unmanaged<
            VkDebugReportFlagsEXT,
            VkDebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint>)
            pfn.Pointer;
}
