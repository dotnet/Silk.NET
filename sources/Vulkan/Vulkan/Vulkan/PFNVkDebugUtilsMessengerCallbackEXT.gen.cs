// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct PFNVkDebugUtilsMessengerCallbackEXT : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<
        VkDebugUtilsMessageSeverityFlagBitsEXT,
        uint,
        DebugUtilsMessengerCallbackDataEXT*,
        void*,
        uint> Handle =>
        (delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagBitsEXT,
            uint,
            DebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint>)Pointer;

    public PFNVkDebugUtilsMessengerCallbackEXT(
        delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagBitsEXT,
            uint,
            DebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint> ptr
    ) => Pointer = ptr;

    public PFNVkDebugUtilsMessengerCallbackEXT(PFNVkDebugUtilsMessengerCallbackEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PFNVkDebugUtilsMessengerCallbackEXT(
        delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagBitsEXT,
            uint,
            DebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        VkDebugUtilsMessageSeverityFlagBitsEXT,
        uint,
        DebugUtilsMessengerCallbackDataEXT*,
        void*,
        uint>(PFNVkDebugUtilsMessengerCallbackEXT pfn) =>
        (delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagBitsEXT,
            uint,
            DebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint>)
            pfn.Pointer;
}
