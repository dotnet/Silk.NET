// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

public readonly unsafe struct EnumeratePropertiesCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, uint, sbyte*, void> Handle =>
        (delegate* unmanaged<void*, uint, sbyte*, void>)Pointer;

    public EnumeratePropertiesCallback(delegate* unmanaged<void*, uint, sbyte*, void> ptr) =>
        Pointer = ptr;

    public EnumeratePropertiesCallback(EnumeratePropertiesCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EnumeratePropertiesCallback(
        delegate* unmanaged<void*, uint, sbyte*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, uint, sbyte*, void>(
        EnumeratePropertiesCallback pfn
    ) => (delegate* unmanaged<void*, uint, sbyte*, void>)pfn.Pointer;
}
