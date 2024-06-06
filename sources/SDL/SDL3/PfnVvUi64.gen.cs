namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvUi64 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, ulong> Handle => (delegate* unmanaged<void*, ulong>)Pointer;

    public PfnVvUi64(delegate* unmanaged<void*, ulong> ptr) => Pointer = ptr;

    public PfnVvUi64(VvUi64Proc proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvUi64(delegate* unmanaged<void*, ulong> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, ulong>(PfnVvUi64 pfn) =>
        (delegate* unmanaged<void*, ulong>)pfn.Pointer;
}
