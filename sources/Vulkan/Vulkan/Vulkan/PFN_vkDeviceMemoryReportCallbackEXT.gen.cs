// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public readonly unsafe struct PFN_vkDeviceMemoryReportCallbackEXT : IDisposable
{
    private readonly void* _pointer;
    public delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void> Handle =>
        (delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void>)_pointer;

    public PFN_vkDeviceMemoryReportCallbackEXT(
        delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void> ptr
    ) => _pointer = ptr;

    public PFN_vkDeviceMemoryReportCallbackEXT(PFN_vkDeviceMemoryReportCallbackEXTDelegate proc) =>
        _pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(_pointer);

    public static implicit operator PFN_vkDeviceMemoryReportCallbackEXT(
        delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        VkDeviceMemoryReportCallbackDataEXT*,
        void*,
        void>(PFN_vkDeviceMemoryReportCallbackEXT pfn) =>
        (delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void>)pfn._pointer;
}
