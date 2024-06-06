namespace Silk.NET.SDL;

public readonly unsafe struct VirtualJoystickDescSetPlayerIndex : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, int, void> Handle =>
        (delegate* unmanaged<void*, int, void>)Pointer;

    public VirtualJoystickDescSetPlayerIndex(delegate* unmanaged<void*, int, void> ptr) =>
        Pointer = ptr;

    public VirtualJoystickDescSetPlayerIndex(VirtualJoystickDescSetPlayerIndexDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator VirtualJoystickDescSetPlayerIndex(
        delegate* unmanaged<void*, int, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, int, void>(
        VirtualJoystickDescSetPlayerIndex pfn
    ) => (delegate* unmanaged<void*, int, void>)pfn.Pointer;
}
