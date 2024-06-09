// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct VirtualJoystickDescFunction1 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, ushort, ushort, int> Handle =>
        (delegate* unmanaged<void*, ushort, ushort, int>)Pointer;

    public VirtualJoystickDescFunction1(delegate* unmanaged<void*, ushort, ushort, int> ptr) =>
        Pointer = ptr;

    public VirtualJoystickDescFunction1(VirtualJoystickDescFunction1Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator VirtualJoystickDescFunction1(
        delegate* unmanaged<void*, ushort, ushort, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, ushort, ushort, int>(
        VirtualJoystickDescFunction1 pfn
    ) => (delegate* unmanaged<void*, ushort, ushort, int>)pfn.Pointer;
}
