namespace Silk.NET.SDL;

public readonly unsafe struct StorageInterfaceSpaceRemaining : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, ulong> Handle => (delegate* unmanaged<void*, ulong>)Pointer;

    public StorageInterfaceSpaceRemaining(delegate* unmanaged<void*, ulong> ptr) => Pointer = ptr;

    public StorageInterfaceSpaceRemaining(StorageInterfaceSpaceRemainingDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceSpaceRemaining(
        delegate* unmanaged<void*, ulong> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, ulong>(
        StorageInterfaceSpaceRemaining pfn
    ) => (delegate* unmanaged<void*, ulong>)pfn.Pointer;
}
