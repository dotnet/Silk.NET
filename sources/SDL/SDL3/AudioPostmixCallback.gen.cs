namespace Silk.NET.SDL;

public readonly unsafe struct AudioPostmixCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, AudioSpec*, float*, int, void> Handle =>
        (delegate* unmanaged<void*, AudioSpec*, float*, int, void>)Pointer;

    public AudioPostmixCallback(delegate* unmanaged<void*, AudioSpec*, float*, int, void> ptr) =>
        Pointer = ptr;

    public AudioPostmixCallback(AudioPostmixCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AudioPostmixCallback(
        delegate* unmanaged<void*, AudioSpec*, float*, int, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, AudioSpec*, float*, int, void>(
        AudioPostmixCallback pfn
    ) => (delegate* unmanaged<void*, AudioSpec*, float*, int, void>)pfn.Pointer;
}
