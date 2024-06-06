namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvVvV : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, void> Handle =>
        (delegate* unmanaged<void*, void*, void>)Pointer;

    public PfnVvVvV(delegate* unmanaged<void*, void*, void> ptr) => Pointer = ptr;

    public PfnVvVvV(VvVvVProc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvVvV(delegate* unmanaged<void*, void*, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, void>(PfnVvVvV pfn) =>
        (delegate* unmanaged<void*, void*, void>)pfn.Pointer;
}
