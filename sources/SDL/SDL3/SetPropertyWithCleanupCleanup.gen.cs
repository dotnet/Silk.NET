namespace Silk.NET.SDL;

public readonly unsafe struct SetPropertyWithCleanupCleanup : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, void> Handle =>
        (delegate* unmanaged<void*, void*, void>)Pointer;

    public SetPropertyWithCleanupCleanup(delegate* unmanaged<void*, void*, void> ptr) =>
        Pointer = ptr;

    public SetPropertyWithCleanupCleanup(SetPropertyWithCleanupCleanupDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator SetPropertyWithCleanupCleanup(
        delegate* unmanaged<void*, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, void>(
        SetPropertyWithCleanupCleanup pfn
    ) => (delegate* unmanaged<void*, void*, void>)pfn.Pointer;
}
