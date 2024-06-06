namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvBvSDLPathInfovI : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, PathInfo*, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, PathInfo*, int>)Pointer;

    public PfnVvBvSDLPathInfovI(delegate* unmanaged<void*, sbyte*, PathInfo*, int> ptr) =>
        Pointer = ptr;

    public PfnVvBvSDLPathInfovI(VvBvSDLPathInfovIProc proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvBvSDLPathInfovI(
        delegate* unmanaged<void*, sbyte*, PathInfo*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, PathInfo*, int>(
        PfnVvBvSDLPathInfovI pfn
    ) => (delegate* unmanaged<void*, sbyte*, PathInfo*, int>)pfn.Pointer;
}
