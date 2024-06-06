namespace Silk.NET.SDL;

public readonly unsafe struct VirtualJoystickDescSetLED : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, byte, byte, byte, int> Handle =>
        (delegate* unmanaged<void*, byte, byte, byte, int>)Pointer;

    public VirtualJoystickDescSetLED(delegate* unmanaged<void*, byte, byte, byte, int> ptr) =>
        Pointer = ptr;

    public VirtualJoystickDescSetLED(VirtualJoystickDescSetLEDDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator VirtualJoystickDescSetLED(
        delegate* unmanaged<void*, byte, byte, byte, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, byte, byte, byte, int>(
        VirtualJoystickDescSetLED pfn
    ) => (delegate* unmanaged<void*, byte, byte, byte, int>)pfn.Pointer;
}
