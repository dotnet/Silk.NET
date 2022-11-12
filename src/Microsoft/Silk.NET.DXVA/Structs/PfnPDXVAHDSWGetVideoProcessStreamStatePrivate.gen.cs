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
    public unsafe readonly struct PfnPDXVAHDSWGetVideoProcessStreamStatePrivate : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nint*, uint, HDStreamStatePrivateData*, int> Handle => (delegate* unmanaged[Cdecl]<nint*, uint, HDStreamStatePrivateData*, int>) _handle;
        public PfnPDXVAHDSWGetVideoProcessStreamStatePrivate
        (
            delegate* unmanaged[Cdecl]<nint*, uint, HDStreamStatePrivateData*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWGetVideoProcessStreamStatePrivate
        (
             PDXVAHDSWGetVideoProcessStreamStatePrivate proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWGetVideoProcessStreamStatePrivate From(PDXVAHDSWGetVideoProcessStreamStatePrivate proc) => new PfnPDXVAHDSWGetVideoProcessStreamStatePrivate(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWGetVideoProcessStreamStatePrivate pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWGetVideoProcessStreamStatePrivate(nint pfn)
            => new PfnPDXVAHDSWGetVideoProcessStreamStatePrivate((delegate* unmanaged[Cdecl]<nint*, uint, HDStreamStatePrivateData*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWGetVideoProcessStreamStatePrivate(PDXVAHDSWGetVideoProcessStreamStatePrivate proc)
            => new PfnPDXVAHDSWGetVideoProcessStreamStatePrivate(proc);

        public static explicit operator PDXVAHDSWGetVideoProcessStreamStatePrivate(PfnPDXVAHDSWGetVideoProcessStreamStatePrivate pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWGetVideoProcessStreamStatePrivate>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nint*, uint, HDStreamStatePrivateData*, int>(PfnPDXVAHDSWGetVideoProcessStreamStatePrivate pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWGetVideoProcessStreamStatePrivate(delegate* unmanaged[Cdecl]<nint*, uint, HDStreamStatePrivateData*, int> ptr) => new PfnPDXVAHDSWGetVideoProcessStreamStatePrivate(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWGetVideoProcessStreamStatePrivate(nint* arg0, uint arg1, HDStreamStatePrivateData* arg2);
}

