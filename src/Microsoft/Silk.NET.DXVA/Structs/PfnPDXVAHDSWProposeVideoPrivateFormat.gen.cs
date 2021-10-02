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
    public unsafe readonly struct PfnPDXVAHDSWProposeVideoPrivateFormat : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.Format*, int> Handle => (delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.Format*, int>) _handle;
        public PfnPDXVAHDSWProposeVideoPrivateFormat
        (
            delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.Format*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWProposeVideoPrivateFormat
        (
             PDXVAHDSWProposeVideoPrivateFormat proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWProposeVideoPrivateFormat From(PDXVAHDSWProposeVideoPrivateFormat proc) => new PfnPDXVAHDSWProposeVideoPrivateFormat(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWProposeVideoPrivateFormat pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWProposeVideoPrivateFormat(nint pfn)
            => new PfnPDXVAHDSWProposeVideoPrivateFormat((delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.Format*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWProposeVideoPrivateFormat(PDXVAHDSWProposeVideoPrivateFormat proc)
            => new PfnPDXVAHDSWProposeVideoPrivateFormat(proc);

        public static explicit operator PDXVAHDSWProposeVideoPrivateFormat(PfnPDXVAHDSWProposeVideoPrivateFormat pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWProposeVideoPrivateFormat>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.Format*, int>(PfnPDXVAHDSWProposeVideoPrivateFormat pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWProposeVideoPrivateFormat(delegate* unmanaged[Cdecl]<void*, Silk.NET.Direct3D9.Format*, int> ptr) => new PfnPDXVAHDSWProposeVideoPrivateFormat(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWProposeVideoPrivateFormat(void* arg0, Silk.NET.Direct3D9.Format* arg1);
}

