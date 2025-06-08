// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public readonly unsafe struct PFN_vkDebugReportCallbackEXT : IDisposable
{
    private readonly void* _pointer;
    public delegate* unmanaged<
        uint,
        VkDebugReportObjectTypeEXT,
        ulong,
        nuint,
        int,
        sbyte*,
        sbyte*,
        void*,
        uint> Handle =>
        (delegate* unmanaged<
            uint,
            VkDebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint>)_pointer;

    public PFN_vkDebugReportCallbackEXT(
        delegate* unmanaged<
            uint,
            VkDebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint> ptr
    ) => _pointer = ptr;

    public PFN_vkDebugReportCallbackEXT(PFN_vkDebugReportCallbackEXTDelegate proc) =>
        _pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(_pointer);

    public static implicit operator PFN_vkDebugReportCallbackEXT(
        delegate* unmanaged<
            uint,
            VkDebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        uint,
        VkDebugReportObjectTypeEXT,
        ulong,
        nuint,
        int,
        sbyte*,
        sbyte*,
        void*,
        uint>(PFN_vkDebugReportCallbackEXT pfn) =>
        (delegate* unmanaged<
            uint,
            VkDebugReportObjectTypeEXT,
            ulong,
            nuint,
            int,
            sbyte*,
            sbyte*,
            void*,
            uint>)
            pfn._pointer;
}
