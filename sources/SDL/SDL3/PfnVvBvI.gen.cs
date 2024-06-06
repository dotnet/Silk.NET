namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvBvI : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, int>)Pointer;

    public PfnVvBvI(delegate* unmanaged<void*, sbyte*, int> ptr) => Pointer = ptr;

    public PfnVvBvI(VvBvIProc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvBvI(delegate* unmanaged<void*, sbyte*, int> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, int>(PfnVvBvI pfn) =>
        (delegate* unmanaged<void*, sbyte*, int>)pfn.Pointer;
}
