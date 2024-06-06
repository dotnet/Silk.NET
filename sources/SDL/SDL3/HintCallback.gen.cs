namespace Silk.NET.SDL;

public readonly unsafe struct HintCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> Handle =>
        (delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void>)Pointer;

    public HintCallback(delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> ptr) =>
        Pointer = ptr;

    public HintCallback(HintCallbackDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator HintCallback(
        delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void>(
        HintCallback pfn
    ) => (delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void>)pfn.Pointer;
}
