namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvUbUbUbI : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, byte, byte, byte, int> Handle =>
        (delegate* unmanaged<void*, byte, byte, byte, int>)Pointer;

    public PfnVvUbUbUbI(delegate* unmanaged<void*, byte, byte, byte, int> ptr) => Pointer = ptr;

    public PfnVvUbUbUbI(VvUbUbUbIProc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvUbUbUbI(
        delegate* unmanaged<void*, byte, byte, byte, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, byte, byte, byte, int>(
        PfnVvUbUbUbI pfn
    ) => (delegate* unmanaged<void*, byte, byte, byte, int>)pfn.Pointer;
}
