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
    public unsafe readonly struct PfnPdxva2SWGetvideoprocessorcaps : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int> Handle => (delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>) _handle;
        public PfnPdxva2SWGetvideoprocessorcaps
        (
            delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWGetvideoprocessorcaps
        (
             Pdxva2SWGetvideoprocessorcaps proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWGetvideoprocessorcaps From(Pdxva2SWGetvideoprocessorcaps proc) => new PfnPdxva2SWGetvideoprocessorcaps(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWGetvideoprocessorcaps pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWGetvideoprocessorcaps(nint pfn)
            => new PfnPdxva2SWGetvideoprocessorcaps((delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>) pfn);

        public static implicit operator PfnPdxva2SWGetvideoprocessorcaps(Pdxva2SWGetvideoprocessorcaps proc)
            => new PfnPdxva2SWGetvideoprocessorcaps(proc);

        public static explicit operator Pdxva2SWGetvideoprocessorcaps(PfnPdxva2SWGetvideoprocessorcaps pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWGetvideoprocessorcaps>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int>(PfnPdxva2SWGetvideoprocessorcaps pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWGetvideoprocessorcaps(delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, DXVA2VideoProcessorCaps*, int> ptr) => new PfnPdxva2SWGetvideoprocessorcaps(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWGetvideoprocessorcaps(DXVA2VideoDesc* arg0, Silk.NET.Direct3D9.Format arg1, DXVA2VideoProcessorCaps* arg2);
}

