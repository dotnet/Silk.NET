namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvVvII : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, int, int> Handle =>
        (delegate* unmanaged<void*, void*, int, int>)Pointer;

    public PfnVvVvII(delegate* unmanaged<void*, void*, int, int> ptr) => Pointer = ptr;

    public PfnVvVvII(VvVvIIProc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvVvII(delegate* unmanaged<void*, void*, int, int> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, int, int>(PfnVvVvII pfn) =>
        (delegate* unmanaged<void*, void*, int, int>)pfn.Pointer;
}
