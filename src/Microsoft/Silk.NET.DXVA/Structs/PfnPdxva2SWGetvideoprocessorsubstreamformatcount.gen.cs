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
    public unsafe readonly struct PfnPdxva2SWGetvideoprocessorsubstreamformatcount : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, int> Handle => (delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, int>) _handle;
        public PfnPdxva2SWGetvideoprocessorsubstreamformatcount
        (
            delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWGetvideoprocessorsubstreamformatcount
        (
             Pdxva2SWGetvideoprocessorsubstreamformatcount proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWGetvideoprocessorsubstreamformatcount From(Pdxva2SWGetvideoprocessorsubstreamformatcount proc) => new PfnPdxva2SWGetvideoprocessorsubstreamformatcount(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWGetvideoprocessorsubstreamformatcount pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWGetvideoprocessorsubstreamformatcount(nint pfn)
            => new PfnPdxva2SWGetvideoprocessorsubstreamformatcount((delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, int>) pfn);

        public static implicit operator PfnPdxva2SWGetvideoprocessorsubstreamformatcount(Pdxva2SWGetvideoprocessorsubstreamformatcount proc)
            => new PfnPdxva2SWGetvideoprocessorsubstreamformatcount(proc);

        public static explicit operator Pdxva2SWGetvideoprocessorsubstreamformatcount(PfnPdxva2SWGetvideoprocessorsubstreamformatcount pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWGetvideoprocessorsubstreamformatcount>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, int>(PfnPdxva2SWGetvideoprocessorsubstreamformatcount pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWGetvideoprocessorsubstreamformatcount(delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint*, int> ptr) => new PfnPdxva2SWGetvideoprocessorsubstreamformatcount(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWGetvideoprocessorsubstreamformatcount(DXVA2VideoDesc* arg0, Silk.NET.Direct3D9.Format arg1, uint* arg2);
}

