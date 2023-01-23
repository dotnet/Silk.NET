// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    public unsafe readonly struct PfnPDXVAHDSWDestroyDevice : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, int> Handle => (delegate* unmanaged[Cdecl]<void*, int>) _handle;
        public PfnPDXVAHDSWDestroyDevice
        (
            delegate* unmanaged[Cdecl]<void*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWDestroyDevice
        (
             PDXVAHDSWDestroyDevice proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWDestroyDevice From(PDXVAHDSWDestroyDevice proc) => new PfnPDXVAHDSWDestroyDevice(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWDestroyDevice pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWDestroyDevice(nint pfn)
            => new PfnPDXVAHDSWDestroyDevice((delegate* unmanaged[Cdecl]<void*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWDestroyDevice(PDXVAHDSWDestroyDevice proc)
            => new PfnPDXVAHDSWDestroyDevice(proc);

        public static explicit operator PDXVAHDSWDestroyDevice(PfnPDXVAHDSWDestroyDevice pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWDestroyDevice>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, int>(PfnPDXVAHDSWDestroyDevice pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWDestroyDevice(delegate* unmanaged[Cdecl]<void*, int> ptr) => new PfnPDXVAHDSWDestroyDevice(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWDestroyDevice(void* arg0);
}

