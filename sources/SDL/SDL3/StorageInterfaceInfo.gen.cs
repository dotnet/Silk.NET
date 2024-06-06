namespace Silk.NET.SDL;

public readonly unsafe struct StorageInterfaceInfo : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, PathInfo*, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, PathInfo*, int>)Pointer;

    public StorageInterfaceInfo(delegate* unmanaged<void*, sbyte*, PathInfo*, int> ptr) =>
        Pointer = ptr;

    public StorageInterfaceInfo(StorageInterfaceInfoDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceInfo(
        delegate* unmanaged<void*, sbyte*, PathInfo*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, PathInfo*, int>(
        StorageInterfaceInfo pfn
    ) => (delegate* unmanaged<void*, sbyte*, PathInfo*, int>)pfn.Pointer;
}
