namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvIV : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, int, void> Handle =>
        (delegate* unmanaged<void*, int, void>)Pointer;

    public PfnVvIV(delegate* unmanaged<void*, int, void> ptr) => Pointer = ptr;

    public PfnVvIV(VvIVProc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvIV(delegate* unmanaged<void*, int, void> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, int, void>(PfnVvIV pfn) =>
        (delegate* unmanaged<void*, int, void>)pfn.Pointer;
}
