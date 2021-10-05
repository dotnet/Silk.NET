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
    public unsafe readonly struct PfnPdxva2SWGetprocamprange : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int> Handle => (delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>) _handle;
        public PfnPdxva2SWGetprocamprange
        (
            delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWGetprocamprange
        (
             Pdxva2SWGetprocamprange proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWGetprocamprange From(Pdxva2SWGetprocamprange proc) => new PfnPdxva2SWGetprocamprange(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWGetprocamprange pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWGetprocamprange(nint pfn)
            => new PfnPdxva2SWGetprocamprange((delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>) pfn);

        public static implicit operator PfnPdxva2SWGetprocamprange(Pdxva2SWGetprocamprange proc)
            => new PfnPdxva2SWGetprocamprange(proc);

        public static explicit operator Pdxva2SWGetprocamprange(PfnPdxva2SWGetprocamprange pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWGetprocamprange>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int>(PfnPdxva2SWGetprocamprange pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWGetprocamprange(delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, DXVA2ValueRange*, int> ptr) => new PfnPdxva2SWGetprocamprange(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWGetprocamprange(DXVA2VideoDesc* arg0, Silk.NET.Direct3D9.Format arg1, uint arg2, DXVA2ValueRange* arg3);
}

