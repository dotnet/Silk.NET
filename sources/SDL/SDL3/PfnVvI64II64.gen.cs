namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvI64II64 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, long, int, long> Handle =>
        (delegate* unmanaged<void*, long, int, long>)Pointer;

    public PfnVvI64II64(delegate* unmanaged<void*, long, int, long> ptr) => Pointer = ptr;

    public PfnVvI64II64(VvI64II64Proc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvI64II64(delegate* unmanaged<void*, long, int, long> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, long, int, long>(PfnVvI64II64 pfn) =>
        (delegate* unmanaged<void*, long, int, long>)pfn.Pointer;
}
