namespace Silk.NET.SDL;

public readonly unsafe struct IOStreamInterfaceSize : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, long> Handle => (delegate* unmanaged<void*, long>)Pointer;

    public IOStreamInterfaceSize(delegate* unmanaged<void*, long> ptr) => Pointer = ptr;

    public IOStreamInterfaceSize(IOStreamInterfaceSizeDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IOStreamInterfaceSize(delegate* unmanaged<void*, long> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, long>(IOStreamInterfaceSize pfn) =>
        (delegate* unmanaged<void*, long>)pfn.Pointer;
}
