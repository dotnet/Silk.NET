namespace Silk.NET.SDL;

public readonly unsafe struct EGLIntArrayCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int*> Handle => (delegate* unmanaged<int*>)Pointer;

    public EGLIntArrayCallback(delegate* unmanaged<int*> ptr) => Pointer = ptr;

    public EGLIntArrayCallback(EGLIntArrayCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EGLIntArrayCallback(delegate* unmanaged<int*> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<int*>(EGLIntArrayCallback pfn) =>
        (delegate* unmanaged<int*>)pfn.Pointer;
}
