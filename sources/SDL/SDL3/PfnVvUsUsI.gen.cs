namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvUsUsI : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, ushort, ushort, int> Handle =>
        (delegate* unmanaged<void*, ushort, ushort, int>)Pointer;

    public PfnVvUsUsI(delegate* unmanaged<void*, ushort, ushort, int> ptr) => Pointer = ptr;

    public PfnVvUsUsI(VvUsUsIProc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvUsUsI(
        delegate* unmanaged<void*, ushort, ushort, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, ushort, ushort, int>(
        PfnVvUsUsI pfn
    ) => (delegate* unmanaged<void*, ushort, ushort, int>)pfn.Pointer;
}
