namespace Silk.NET.SDL;

public readonly unsafe struct VirtualJoystickDescSendEffect : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, int, int> Handle =>
        (delegate* unmanaged<void*, void*, int, int>)Pointer;

    public VirtualJoystickDescSendEffect(delegate* unmanaged<void*, void*, int, int> ptr) =>
        Pointer = ptr;

    public VirtualJoystickDescSendEffect(VirtualJoystickDescSendEffectDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator VirtualJoystickDescSendEffect(
        delegate* unmanaged<void*, void*, int, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, int, int>(
        VirtualJoystickDescSendEffect pfn
    ) => (delegate* unmanaged<void*, void*, int, int>)pfn.Pointer;
}
