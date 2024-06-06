namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvI64 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, long> Handle => (delegate* unmanaged<void*, long>)Pointer;

    public PfnVvI64(delegate* unmanaged<void*, long> ptr) => Pointer = ptr;

    public PfnVvI64(VvI64Proc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvI64(delegate* unmanaged<void*, long> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, long>(PfnVvI64 pfn) =>
        (delegate* unmanaged<void*, long>)pfn.Pointer;
}
