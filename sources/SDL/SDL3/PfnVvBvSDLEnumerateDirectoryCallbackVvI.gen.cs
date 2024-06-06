namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvBvSDLEnumerateDirectoryCallbackVvI : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int>)Pointer;

    public PfnVvBvSDLEnumerateDirectoryCallbackVvI(
        delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int> ptr
    ) => Pointer = ptr;

    public PfnVvBvSDLEnumerateDirectoryCallbackVvI(VvBvSDLEnumerateDirectoryCallbackVvIProc proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvBvSDLEnumerateDirectoryCallbackVvI(
        delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        void*,
        sbyte*,
        EnumerateDirectoryCallback,
        void*,
        int>(PfnVvBvSDLEnumerateDirectoryCallbackVvI pfn) =>
        (delegate* unmanaged<void*, sbyte*, EnumerateDirectoryCallback, void*, int>)pfn.Pointer;
}
