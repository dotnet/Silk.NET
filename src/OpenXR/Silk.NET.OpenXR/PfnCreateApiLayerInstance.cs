using System;
using Silk.NET.Core;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenXR
{
    public readonly unsafe struct PfnCreateApiLayerInstance : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<InstanceCreateInfo*, ApiLayerCreateInfo*, Instance*, Result> Handle =>
            (delegate* unmanaged[Cdecl]<InstanceCreateInfo*, ApiLayerCreateInfo*, Instance*, Result>) _handle;

        public PfnCreateApiLayerInstance
        (
            delegate* unmanaged[Cdecl]<InstanceCreateInfo*, ApiLayerCreateInfo*, Instance*, Result> ptr
        ) => _handle = ptr;

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator nint(PfnCreateApiLayerInstance pfn) => (nint) pfn.Handle;

        public PfnCreateApiLayerInstance(CreateApiLayerInstanceProc func) => _handle =
            (delegate* unmanaged[Cdecl]<InstanceCreateInfo*, ApiLayerCreateInfo*, Instance*, Result>) SilkMarshal.DelegateToPtr(func);

        public static implicit operator delegate* unmanaged[Cdecl]<InstanceCreateInfo*, ApiLayerCreateInfo*, Instance*, Result>
            (PfnCreateApiLayerInstance pfn) => pfn.Handle;

        public static implicit operator PfnCreateApiLayerInstance
        (
            delegate* unmanaged[Cdecl]<InstanceCreateInfo*, ApiLayerCreateInfo*, Instance*, Result> func
        ) => new(func);

        public static implicit operator PfnCreateApiLayerInstance
            (CreateApiLayerInstanceProc func) => new(func);

        public static explicit operator CreateApiLayerInstanceProc
            (PfnCreateApiLayerInstance pfn) => SilkMarshal.PtrToDelegate<CreateApiLayerInstanceProc>
            ((nint) pfn.Handle);
    }
}
