namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct PfnVvVvNuintSdlioStatusvNuint : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> Handle =>
        (delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>)Pointer;

    public PfnVvVvNuintSdlioStatusvNuint(
        delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> ptr
    ) => Pointer = ptr;

    public PfnVvVvNuintSdlioStatusvNuint(VvVvNuintSdlioStatusvNuintProc proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator PfnVvVvNuintSdlioStatusvNuint(
        delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>(
        PfnVvVvNuintSdlioStatusvNuint pfn
    ) => (delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>)pfn.Pointer;
}
