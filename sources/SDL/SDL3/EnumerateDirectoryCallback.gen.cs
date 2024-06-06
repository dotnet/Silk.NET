namespace Silk.NET.SDL;

public readonly unsafe struct EnumerateDirectoryCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, sbyte*, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, sbyte*, int>)Pointer;

    public EnumerateDirectoryCallback(delegate* unmanaged<void*, sbyte*, sbyte*, int> ptr) =>
        Pointer = ptr;

    public EnumerateDirectoryCallback(EnumerateDirectoryCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EnumerateDirectoryCallback(
        delegate* unmanaged<void*, sbyte*, sbyte*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, sbyte*, int>(
        EnumerateDirectoryCallback pfn
    ) => (delegate* unmanaged<void*, sbyte*, sbyte*, int>)pfn.Pointer;
}
