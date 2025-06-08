// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public readonly unsafe struct PFN_vkAllocationFunction : IDisposable
{
    private readonly void* _pointer;
    public delegate* unmanaged<void*, nuint, nuint, VkSystemAllocationScope, void*> Handle =>
        (delegate* unmanaged<void*, nuint, nuint, VkSystemAllocationScope, void*>)_pointer;

    public PFN_vkAllocationFunction(
        delegate* unmanaged<void*, nuint, nuint, VkSystemAllocationScope, void*> ptr
    ) => _pointer = ptr;

    public PFN_vkAllocationFunction(PFN_vkAllocationFunctionDelegate proc) =>
        _pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(_pointer);

    public static implicit operator PFN_vkAllocationFunction(
        delegate* unmanaged<void*, nuint, nuint, VkSystemAllocationScope, void*> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        void*,
        nuint,
        nuint,
        VkSystemAllocationScope,
        void*>(PFN_vkAllocationFunction pfn) =>
        (delegate* unmanaged<void*, nuint, nuint, VkSystemAllocationScope, void*>)pfn._pointer;
}
