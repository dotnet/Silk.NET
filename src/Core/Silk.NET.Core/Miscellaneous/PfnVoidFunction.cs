using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Core
{
    public readonly unsafe struct PfnVoidFunction : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<void> Handle => (delegate* unmanaged[Cdecl]<void>) _handle;
        public PfnVoidFunction(delegate* unmanaged[Cdecl]<void> ptr) => _handle = ptr;

        public static implicit operator nint(PfnVoidFunction pfn) => (nint) pfn.Handle;

        public PfnVoidFunction
            (Delegate func) => _handle = (delegate* unmanaged[Cdecl]<void>) SilkMarshal.DelegateToPtr<Delegate>(func);

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator delegate* unmanaged[Cdecl]<void>
            (PfnVoidFunction pfn) => pfn.Handle;

        public static implicit operator PfnVoidFunction
            (delegate* unmanaged[Cdecl]<void> func) => new(func);

        public static implicit operator PfnVoidFunction(Delegate func) => new(func);
    }
}
