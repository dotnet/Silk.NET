// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

public readonly unsafe struct ThreadFunction : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, int> Handle => (delegate* unmanaged<void*, int>)Pointer;

    public ThreadFunction(delegate* unmanaged<void*, int> ptr) => Pointer = ptr;

    public ThreadFunction(ThreadFunctionDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ThreadFunction(delegate* unmanaged<void*, int> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, int>(ThreadFunction pfn) =>
        (delegate* unmanaged<void*, int>)pfn.Pointer;
}
