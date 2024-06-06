namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct StorageInterfaceFunction1 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, void*, ulong, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, void*, ulong, int>)Pointer;

    public StorageInterfaceFunction1(delegate* unmanaged<void*, sbyte*, void*, ulong, int> ptr) =>
        Pointer = ptr;

    public StorageInterfaceFunction1(StorageInterfaceFunction1Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceFunction1(
        delegate* unmanaged<void*, sbyte*, void*, ulong, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, void*, ulong, int>(
        StorageInterfaceFunction1 pfn
    ) => (delegate* unmanaged<void*, sbyte*, void*, ulong, int>)pfn.Pointer;
}
