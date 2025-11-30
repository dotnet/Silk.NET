// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct DebugUtilsMessengerCallbackExt : IDisposable
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public delegate* unmanaged<
        DebugUtilsMessageSeverityFlagsExt,
        DebugUtilsMessageTypeFlagsExt,
        DebugUtilsMessengerCallbackDataExt*,
        void*,
        uint> Handle =>
        (delegate* unmanaged<
            DebugUtilsMessageSeverityFlagsExt,
            DebugUtilsMessageTypeFlagsExt,
            DebugUtilsMessengerCallbackDataExt*,
            void*,
            uint>)Pointer;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsMessengerCallbackExt(
        delegate* unmanaged<
            DebugUtilsMessageSeverityFlagsExt,
            DebugUtilsMessageTypeFlagsExt,
            DebugUtilsMessengerCallbackDataExt*,
            void*,
            uint> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsMessengerCallbackExt(DebugUtilsMessengerCallbackExtDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public static implicit operator DebugUtilsMessengerCallbackExt(
        delegate* unmanaged<
            DebugUtilsMessageSeverityFlagsExt,
            DebugUtilsMessageTypeFlagsExt,
            DebugUtilsMessengerCallbackDataExt*,
            void*,
            uint> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public static implicit operator delegate* unmanaged<
        DebugUtilsMessageSeverityFlagsExt,
        DebugUtilsMessageTypeFlagsExt,
        DebugUtilsMessengerCallbackDataExt*,
        void*,
        uint>(DebugUtilsMessengerCallbackExt pfn) =>
        (delegate* unmanaged<
            DebugUtilsMessageSeverityFlagsExt,
            DebugUtilsMessageTypeFlagsExt,
            DebugUtilsMessengerCallbackDataExt*,
            void*,
            uint>)
            pfn.Pointer;
}
