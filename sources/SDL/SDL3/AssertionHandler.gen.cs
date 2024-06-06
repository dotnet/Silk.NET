namespace Silk.NET.SDL;

public readonly unsafe struct AssertionHandler : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<AssertData*, void*, AssertState> Handle =>
        (delegate* unmanaged<AssertData*, void*, AssertState>)Pointer;

    public AssertionHandler(delegate* unmanaged<AssertData*, void*, AssertState> ptr) =>
        Pointer = ptr;

    public AssertionHandler(AssertionHandlerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AssertionHandler(
        delegate* unmanaged<AssertData*, void*, AssertState> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<AssertData*, void*, AssertState>(
        AssertionHandler pfn
    ) => (delegate* unmanaged<AssertData*, void*, AssertState>)pfn.Pointer;
}
