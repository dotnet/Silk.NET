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
    public unsafe readonly struct PfnPdxva2SWGetvideoprocessorrendertargetcount : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint*, int> Handle => (delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint*, int>) _handle;
        public PfnPdxva2SWGetvideoprocessorrendertargetcount
        (
            delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint*, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWGetvideoprocessorrendertargetcount
        (
             Pdxva2SWGetvideoprocessorrendertargetcount proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWGetvideoprocessorrendertargetcount From(Pdxva2SWGetvideoprocessorrendertargetcount proc) => new PfnPdxva2SWGetvideoprocessorrendertargetcount(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWGetvideoprocessorrendertargetcount pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWGetvideoprocessorrendertargetcount(nint pfn)
            => new PfnPdxva2SWGetvideoprocessorrendertargetcount((delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint*, int>) pfn);

        public static implicit operator PfnPdxva2SWGetvideoprocessorrendertargetcount(Pdxva2SWGetvideoprocessorrendertargetcount proc)
            => new PfnPdxva2SWGetvideoprocessorrendertargetcount(proc);

        public static explicit operator Pdxva2SWGetvideoprocessorrendertargetcount(PfnPdxva2SWGetvideoprocessorrendertargetcount pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWGetvideoprocessorrendertargetcount>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint*, int>(PfnPdxva2SWGetvideoprocessorrendertargetcount pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWGetvideoprocessorrendertargetcount(delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint*, int> ptr) => new PfnPdxva2SWGetvideoprocessorrendertargetcount(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWGetvideoprocessorrendertargetcount(DXVA2VideoDesc* arg0, uint* arg1);
}

