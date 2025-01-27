using System;
using Silk.NET.Core;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenXR
{
    public readonly unsafe struct PfnGetInstanceProcAddr : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<Instance, byte*, nint> Handle =>
            (delegate* unmanaged[Cdecl]<Instance, byte*, nint>) _handle;

        public PfnGetInstanceProcAddr
        (
            delegate* unmanaged[Cdecl]<Instance, byte*, nint> ptr
        ) => _handle = ptr;

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator nint(PfnGetInstanceProcAddr pfn) => (nint) pfn.Handle;

        public PfnGetInstanceProcAddr(GetInstanceProcAddrProc func) => _handle =
            (delegate* unmanaged[Cdecl]<Instance, byte*, nint>) SilkMarshal.DelegateToPtr(func);

        public static implicit operator delegate* unmanaged[Cdecl]<Instance, byte*, nint>
            (PfnGetInstanceProcAddr pfn) => pfn.Handle;

        public static implicit operator PfnGetInstanceProcAddr
        (
            delegate* unmanaged[Cdecl]<Instance, byte*, nint> func
        ) => new(func);

        public static implicit operator PfnGetInstanceProcAddr
            (GetInstanceProcAddrProc func) => new(func);

        public static explicit operator GetInstanceProcAddrProc
            (PfnGetInstanceProcAddr pfn) => SilkMarshal.PtrToDelegate<GetInstanceProcAddrProc>
            ((nint) pfn.Handle);
    }
}
