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
    public unsafe readonly struct PfnPdxva2SWGetvideoprocessorrendertargets : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint, Silk.NET.Direct3D9.Format*, int> Handle => (delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint, Silk.NET.Direct3D9.Format*, int>) _handle;
        public PfnPdxva2SWGetvideoprocessorrendertargets
        (
            delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint, Silk.NET.Direct3D9.Format*, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWGetvideoprocessorrendertargets
        (
             Pdxva2SWGetvideoprocessorrendertargets proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWGetvideoprocessorrendertargets From(Pdxva2SWGetvideoprocessorrendertargets proc) => new PfnPdxva2SWGetvideoprocessorrendertargets(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWGetvideoprocessorrendertargets pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWGetvideoprocessorrendertargets(nint pfn)
            => new PfnPdxva2SWGetvideoprocessorrendertargets((delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint, Silk.NET.Direct3D9.Format*, int>) pfn);

        public static implicit operator PfnPdxva2SWGetvideoprocessorrendertargets(Pdxva2SWGetvideoprocessorrendertargets proc)
            => new PfnPdxva2SWGetvideoprocessorrendertargets(proc);

        public static explicit operator Pdxva2SWGetvideoprocessorrendertargets(PfnPdxva2SWGetvideoprocessorrendertargets pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWGetvideoprocessorrendertargets>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint, Silk.NET.Direct3D9.Format*, int>(PfnPdxva2SWGetvideoprocessorrendertargets pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWGetvideoprocessorrendertargets(delegate* unmanaged[Cdecl]<DXVA2VideoDesc*, uint, Silk.NET.Direct3D9.Format*, int> ptr) => new PfnPdxva2SWGetvideoprocessorrendertargets(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWGetvideoprocessorrendertargets(DXVA2VideoDesc* arg0, uint arg1, Silk.NET.Direct3D9.Format* arg2);
}

