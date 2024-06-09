// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

public readonly unsafe struct TimerCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<uint, void*, uint> Handle =>
        (delegate* unmanaged<uint, void*, uint>)Pointer;

    public TimerCallback(delegate* unmanaged<uint, void*, uint> ptr) => Pointer = ptr;

    public TimerCallback(TimerCallbackDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator TimerCallback(delegate* unmanaged<uint, void*, uint> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<uint, void*, uint>(TimerCallback pfn) =>
        (delegate* unmanaged<uint, void*, uint>)pfn.Pointer;
}
