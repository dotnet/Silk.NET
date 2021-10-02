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
    public unsafe readonly struct PfnPdxva2SWCreatevideoprocessdevice : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, void**, int> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, void**, int>) _handle;
        public PfnPdxva2SWCreatevideoprocessdevice
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, void**, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWCreatevideoprocessdevice
        (
             Pdxva2SWCreatevideoprocessdevice proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWCreatevideoprocessdevice From(Pdxva2SWCreatevideoprocessdevice proc) => new PfnPdxva2SWCreatevideoprocessdevice(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWCreatevideoprocessdevice pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWCreatevideoprocessdevice(nint pfn)
            => new PfnPdxva2SWCreatevideoprocessdevice((delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, void**, int>) pfn);

        public static implicit operator PfnPdxva2SWCreatevideoprocessdevice(Pdxva2SWCreatevideoprocessdevice proc)
            => new PfnPdxva2SWCreatevideoprocessdevice(proc);

        public static explicit operator Pdxva2SWCreatevideoprocessdevice(PfnPdxva2SWCreatevideoprocessdevice pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWCreatevideoprocessdevice>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, void**, int>(PfnPdxva2SWCreatevideoprocessdevice pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWCreatevideoprocessdevice(delegate* unmanaged[Cdecl]<Silk.NET.Direct3D9.IDirect3DDevice9*, DXVA2VideoDesc*, Silk.NET.Direct3D9.Format, uint, void**, int> ptr) => new PfnPdxva2SWCreatevideoprocessdevice(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWCreatevideoprocessdevice(Silk.NET.Direct3D9.IDirect3DDevice9* arg0, DXVA2VideoDesc* arg1, Silk.NET.Direct3D9.Format arg2, uint arg3, void** arg4);
}

