// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

public readonly unsafe struct IOStreamInterfaceSeek : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, long, int, long> Handle =>
        (delegate* unmanaged<void*, long, int, long>)Pointer;

    public IOStreamInterfaceSeek(delegate* unmanaged<void*, long, int, long> ptr) => Pointer = ptr;

    public IOStreamInterfaceSeek(IOStreamInterfaceSeekDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IOStreamInterfaceSeek(
        delegate* unmanaged<void*, long, int, long> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, long, int, long>(
        IOStreamInterfaceSeek pfn
    ) => (delegate* unmanaged<void*, long, int, long>)pfn.Pointer;
}
