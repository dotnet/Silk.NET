namespace Silk.NET.SDL;

public readonly unsafe struct ClipboardDataCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, nuint*, void*> Handle =>
        (delegate* unmanaged<void*, sbyte*, nuint*, void*>)Pointer;

    public ClipboardDataCallback(delegate* unmanaged<void*, sbyte*, nuint*, void*> ptr) =>
        Pointer = ptr;

    public ClipboardDataCallback(ClipboardDataCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ClipboardDataCallback(
        delegate* unmanaged<void*, sbyte*, nuint*, void*> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, nuint*, void*>(
        ClipboardDataCallback pfn
    ) => (delegate* unmanaged<void*, sbyte*, nuint*, void*>)pfn.Pointer;
}
