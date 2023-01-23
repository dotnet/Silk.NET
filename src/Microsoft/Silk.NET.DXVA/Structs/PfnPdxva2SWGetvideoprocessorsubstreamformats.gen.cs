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
    public unsafe readonly struct PfnPdxva2SWGetvideoprocessorsubstreamformats : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, Silk.NET.Direct3D9.Format*, int> Handle => (delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, Silk.NET.Direct3D9.Format*, int>) _handle;
        public PfnPdxva2SWGetvideoprocessorsubstreamformats
        (
            delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, Silk.NET.Direct3D9.Format*, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWGetvideoprocessorsubstreamformats
        (
             Pdxva2SWGetvideoprocessorsubstreamformats proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWGetvideoprocessorsubstreamformats From(Pdxva2SWGetvideoprocessorsubstreamformats proc) => new PfnPdxva2SWGetvideoprocessorsubstreamformats(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWGetvideoprocessorsubstreamformats pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWGetvideoprocessorsubstreamformats(nint pfn)
            => new PfnPdxva2SWGetvideoprocessorsubstreamformats((delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, Silk.NET.Direct3D9.Format*, int>) pfn);

        public static implicit operator PfnPdxva2SWGetvideoprocessorsubstreamformats(Pdxva2SWGetvideoprocessorsubstreamformats proc)
            => new PfnPdxva2SWGetvideoprocessorsubstreamformats(proc);

        public static explicit operator Pdxva2SWGetvideoprocessorsubstreamformats(PfnPdxva2SWGetvideoprocessorsubstreamformats pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWGetvideoprocessorsubstreamformats>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, Silk.NET.Direct3D9.Format*, int>(PfnPdxva2SWGetvideoprocessorsubstreamformats pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWGetvideoprocessorsubstreamformats(delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, Silk.NET.Direct3D9.Format*, int> ptr) => new PfnPdxva2SWGetvideoprocessorsubstreamformats(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWGetvideoprocessorsubstreamformats(DXVA2VideoDesc* arg0, Silk.NET.Direct3D9.Format arg1, uint arg2, Silk.NET.Direct3D9.Format* arg3);
}

