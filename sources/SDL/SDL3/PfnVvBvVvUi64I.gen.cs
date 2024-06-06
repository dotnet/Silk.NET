namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvBvVvUi64I : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, void*, ulong, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, void*, ulong, int>)Pointer;

    public PfnVvBvVvUi64I(delegate* unmanaged<void*, sbyte*, void*, ulong, int> ptr) =>
        Pointer = ptr;

    public PfnVvBvVvUi64I(VvBvVvUi64IProc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvBvVvUi64I(
        delegate* unmanaged<void*, sbyte*, void*, ulong, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, void*, ulong, int>(
        PfnVvBvVvUi64I pfn
    ) => (delegate* unmanaged<void*, sbyte*, void*, ulong, int>)pfn.Pointer;
}
