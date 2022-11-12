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
    public unsafe readonly struct PfnPdxva2SWVideoprocesssetrendertarget : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nint*, Silk.NET.Direct3D9.IDirect3DSurface9*, int> Handle => (delegate* unmanaged[Cdecl]<nint*, Silk.NET.Direct3D9.IDirect3DSurface9*, int>) _handle;
        public PfnPdxva2SWVideoprocesssetrendertarget
        (
            delegate* unmanaged[Cdecl]<nint*, Silk.NET.Direct3D9.IDirect3DSurface9*, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWVideoprocesssetrendertarget
        (
             Pdxva2SWVideoprocesssetrendertarget proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWVideoprocesssetrendertarget From(Pdxva2SWVideoprocesssetrendertarget proc) => new PfnPdxva2SWVideoprocesssetrendertarget(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWVideoprocesssetrendertarget pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWVideoprocesssetrendertarget(nint pfn)
            => new PfnPdxva2SWVideoprocesssetrendertarget((delegate* unmanaged[Cdecl]<nint*, Silk.NET.Direct3D9.IDirect3DSurface9*, int>) pfn);

        public static implicit operator PfnPdxva2SWVideoprocesssetrendertarget(Pdxva2SWVideoprocesssetrendertarget proc)
            => new PfnPdxva2SWVideoprocesssetrendertarget(proc);

        public static explicit operator Pdxva2SWVideoprocesssetrendertarget(PfnPdxva2SWVideoprocesssetrendertarget pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWVideoprocesssetrendertarget>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nint*, Silk.NET.Direct3D9.IDirect3DSurface9*, int>(PfnPdxva2SWVideoprocesssetrendertarget pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWVideoprocesssetrendertarget(delegate* unmanaged[Cdecl]<nint*, Silk.NET.Direct3D9.IDirect3DSurface9*, int> ptr) => new PfnPdxva2SWVideoprocesssetrendertarget(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWVideoprocesssetrendertarget(nint* arg0, Silk.NET.Direct3D9.IDirect3DSurface9* arg1);
}

