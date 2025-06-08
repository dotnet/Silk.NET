// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public readonly unsafe struct PFN_vkDebugUtilsMessengerCallbackEXT : IDisposable
{
    private readonly void* _pointer;
    public delegate* unmanaged<
        VkDebugUtilsMessageSeverityFlagsEXT,
        uint,
        VkDebugUtilsMessengerCallbackDataEXT*,
        void*,
        uint> Handle =>
        (delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagsEXT,
            uint,
            VkDebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint>)_pointer;

    public PFN_vkDebugUtilsMessengerCallbackEXT(
        delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagsEXT,
            uint,
            VkDebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint> ptr
    ) => _pointer = ptr;

    public PFN_vkDebugUtilsMessengerCallbackEXT(
        PFN_vkDebugUtilsMessengerCallbackEXTDelegate proc
    ) => _pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(_pointer);

    public static implicit operator PFN_vkDebugUtilsMessengerCallbackEXT(
        delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagsEXT,
            uint,
            VkDebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        VkDebugUtilsMessageSeverityFlagsEXT,
        uint,
        VkDebugUtilsMessengerCallbackDataEXT*,
        void*,
        uint>(PFN_vkDebugUtilsMessengerCallbackEXT pfn) =>
        (delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagsEXT,
            uint,
            VkDebugUtilsMessengerCallbackDataEXT*,
            void*,
            uint>)
            pfn._pointer;
}
