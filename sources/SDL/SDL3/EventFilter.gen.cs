namespace Silk.NET.SDL;

public readonly unsafe struct EventFilter : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, Event*, int> Handle =>
        (delegate* unmanaged<void*, Event*, int>)Pointer;

    public EventFilter(delegate* unmanaged<void*, Event*, int> ptr) => Pointer = ptr;

    public EventFilter(EventFilterDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EventFilter(delegate* unmanaged<void*, Event*, int> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, Event*, int>(EventFilter pfn) =>
        (delegate* unmanaged<void*, Event*, int>)pfn.Pointer;
}
