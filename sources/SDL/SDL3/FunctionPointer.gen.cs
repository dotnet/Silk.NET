namespace Silk.NET.SDL;

public readonly unsafe struct FunctionPointer : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void> Handle => (delegate* unmanaged<void>)Pointer;

    public FunctionPointer(delegate* unmanaged<void> ptr) => Pointer = ptr;

    public FunctionPointer(FunctionPointerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator FunctionPointer(delegate* unmanaged<void> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void>(FunctionPointer pfn) =>
        (delegate* unmanaged<void>)pfn.Pointer;
}
