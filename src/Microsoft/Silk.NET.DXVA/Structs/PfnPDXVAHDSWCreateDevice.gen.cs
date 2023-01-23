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
    public unsafe readonly struct PfnPDXVAHDSWCreateDevice : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9Ex*, void**, int> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9Ex*, void**, int>) _handle;
        public PfnPDXVAHDSWCreateDevice
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9Ex*, void**, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWCreateDevice
        (
             PDXVAHDSWCreateDevice proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWCreateDevice From(PDXVAHDSWCreateDevice proc) => new PfnPDXVAHDSWCreateDevice(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWCreateDevice pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWCreateDevice(nint pfn)
            => new PfnPDXVAHDSWCreateDevice((delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9Ex*, void**, int>) pfn);

        public static implicit operator PfnPDXVAHDSWCreateDevice(PDXVAHDSWCreateDevice proc)
            => new PfnPDXVAHDSWCreateDevice(proc);

        public static explicit operator PDXVAHDSWCreateDevice(PfnPDXVAHDSWCreateDevice pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWCreateDevice>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9Ex*, void**, int>(PfnPDXVAHDSWCreateDevice pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWCreateDevice(delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9Ex*, void**, int> ptr) => new PfnPDXVAHDSWCreateDevice(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWCreateDevice(Silk.NET.Direct3D9.IDirect3DDevice9Ex* arg0, void** arg1);
}

