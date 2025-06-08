// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

public readonly unsafe struct PFN_vkVoidFunction : IDisposable
{
    private readonly void* _pointer;
    public delegate* unmanaged<void> Handle => (delegate* unmanaged<void>)_pointer;

    public PFN_vkVoidFunction(delegate* unmanaged<void> ptr) => _pointer = ptr;

    public PFN_vkVoidFunction(PFN_vkVoidFunctionDelegate proc) =>
        _pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(_pointer);

    public static implicit operator PFN_vkVoidFunction(delegate* unmanaged<void> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void>(PFN_vkVoidFunction pfn) =>
        (delegate* unmanaged<void>)pfn._pointer;
}
