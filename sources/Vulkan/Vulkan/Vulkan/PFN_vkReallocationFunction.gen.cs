// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public readonly unsafe struct PFN_vkReallocationFunction : IDisposable
{
    private readonly void* _pointer;
    public delegate* unmanaged<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> Handle =>
        (delegate* unmanaged<void*, void*, nuint, nuint, VkSystemAllocationScope, void*>)_pointer;

    public PFN_vkReallocationFunction(
        delegate* unmanaged<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> ptr
    ) => _pointer = ptr;

    public PFN_vkReallocationFunction(PFN_vkReallocationFunctionDelegate proc) =>
        _pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(_pointer);

    public static implicit operator PFN_vkReallocationFunction(
        delegate* unmanaged<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        void*,
        void*,
        nuint,
        nuint,
        VkSystemAllocationScope,
        void*>(PFN_vkReallocationFunction pfn) =>
        (delegate* unmanaged<void*, void*, nuint, nuint, VkSystemAllocationScope, void*>)
            pfn._pointer;
}
