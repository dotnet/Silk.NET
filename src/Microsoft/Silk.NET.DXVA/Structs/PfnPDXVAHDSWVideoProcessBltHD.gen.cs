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
    public unsafe readonly struct PfnPDXVAHDSWVideoProcessBltHD : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int> Handle => (delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>) _handle;
        public PfnPDXVAHDSWVideoProcessBltHD
        (
            delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWVideoProcessBltHD
        (
             PDXVAHDSWVideoProcessBltHD proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWVideoProcessBltHD From(PDXVAHDSWVideoProcessBltHD proc) => new PfnPDXVAHDSWVideoProcessBltHD(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWVideoProcessBltHD pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWVideoProcessBltHD(nint pfn)
            => new PfnPDXVAHDSWVideoProcessBltHD((delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWVideoProcessBltHD(PDXVAHDSWVideoProcessBltHD proc)
            => new PfnPDXVAHDSWVideoProcessBltHD(proc);

        public static explicit operator PDXVAHDSWVideoProcessBltHD(PfnPDXVAHDSWVideoProcessBltHD pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWVideoProcessBltHD>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>(PfnPDXVAHDSWVideoProcessBltHD pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWVideoProcessBltHD(delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int> ptr) => new PfnPDXVAHDSWVideoProcessBltHD(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWVideoProcessBltHD(void* arg0, Silk.NET.Direct3D9.IDirect3DSurface9* arg1, uint arg2, uint arg3, HDStreamData* arg4);
}

