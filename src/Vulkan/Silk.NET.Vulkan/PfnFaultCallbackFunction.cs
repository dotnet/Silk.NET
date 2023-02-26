using System;
using Silk.NET.Core;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnFaultCallbackFunction : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<Bool32, uint, FaultData*> Handle =>
            (delegate* unmanaged[Cdecl]<Bool32, uint, FaultData*>) _handle;

        public PfnFaultCallbackFunction(delegate* unmanaged[Cdecl]<Bool32, uint, FaultData*> ptr)
            => _handle = ptr;

        public PfnFaultCallbackFunction(FaultCallbackFunction func)
            => _handle = (delegate* unmanaged[Cdecl]<Bool32, uint, FaultData*>) SilkMarshal.DelegateToPtr(func);

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator delegate* unmanaged[Cdecl]<Bool32, uint, FaultData*>
            (PfnFaultCallbackFunction pfn) => pfn.Handle;

        public static implicit operator PfnFaultCallbackFunction
            (delegate* unmanaged[Cdecl]<Bool32, uint, FaultData*> func) => new(func);

        public static implicit operator PfnFaultCallbackFunction(FaultCallbackFunction func) => new(func);

        public static explicit operator FaultCallbackFunction
            (PfnFaultCallbackFunction pfn) => SilkMarshal.PtrToDelegate<FaultCallbackFunction>
            ((nint) pfn.Handle);
    }
}
