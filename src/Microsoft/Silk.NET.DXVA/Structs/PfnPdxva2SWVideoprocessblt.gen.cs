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
    public unsafe readonly struct PfnPdxva2SWVideoprocessblt : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nint*, DXVA2Videoprocessblt*, int> Handle => (delegate* unmanaged[Cdecl]<nint*, DXVA2Videoprocessblt*, int>) _handle;
        public PfnPdxva2SWVideoprocessblt
        (
            delegate* unmanaged[Cdecl]<nint*, DXVA2Videoprocessblt*, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWVideoprocessblt
        (
             Pdxva2SWVideoprocessblt proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWVideoprocessblt From(Pdxva2SWVideoprocessblt proc) => new PfnPdxva2SWVideoprocessblt(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWVideoprocessblt pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWVideoprocessblt(nint pfn)
            => new PfnPdxva2SWVideoprocessblt((delegate* unmanaged[Cdecl]<nint*, DXVA2Videoprocessblt*, int>) pfn);

        public static implicit operator PfnPdxva2SWVideoprocessblt(Pdxva2SWVideoprocessblt proc)
            => new PfnPdxva2SWVideoprocessblt(proc);

        public static explicit operator Pdxva2SWVideoprocessblt(PfnPdxva2SWVideoprocessblt pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWVideoprocessblt>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nint*, DXVA2Videoprocessblt*, int>(PfnPdxva2SWVideoprocessblt pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWVideoprocessblt(delegate* unmanaged[Cdecl]<nint*, DXVA2Videoprocessblt*, int> ptr) => new PfnPdxva2SWVideoprocessblt(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWVideoprocessblt(nint* arg0, DXVA2Videoprocessblt* arg1);
}

