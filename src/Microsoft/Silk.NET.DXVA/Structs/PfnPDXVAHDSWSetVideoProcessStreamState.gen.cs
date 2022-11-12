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
    public unsafe readonly struct PfnPDXVAHDSWSetVideoProcessStreamState : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nint*, uint, HDStreamState, uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<nint*, uint, HDStreamState, uint, void*, int>) _handle;
        public PfnPDXVAHDSWSetVideoProcessStreamState
        (
            delegate* unmanaged[Cdecl]<nint*, uint, HDStreamState, uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWSetVideoProcessStreamState
        (
             PDXVAHDSWSetVideoProcessStreamState proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWSetVideoProcessStreamState From(PDXVAHDSWSetVideoProcessStreamState proc) => new PfnPDXVAHDSWSetVideoProcessStreamState(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWSetVideoProcessStreamState pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWSetVideoProcessStreamState(nint pfn)
            => new PfnPDXVAHDSWSetVideoProcessStreamState((delegate* unmanaged[Cdecl]<nint*, uint, HDStreamState, uint, void*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWSetVideoProcessStreamState(PDXVAHDSWSetVideoProcessStreamState proc)
            => new PfnPDXVAHDSWSetVideoProcessStreamState(proc);

        public static explicit operator PDXVAHDSWSetVideoProcessStreamState(PfnPDXVAHDSWSetVideoProcessStreamState pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWSetVideoProcessStreamState>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nint*, uint, HDStreamState, uint, void*, int>(PfnPDXVAHDSWSetVideoProcessStreamState pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWSetVideoProcessStreamState(delegate* unmanaged[Cdecl]<nint*, uint, HDStreamState, uint, void*, int> ptr) => new PfnPDXVAHDSWSetVideoProcessStreamState(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWSetVideoProcessStreamState(nint* arg0, uint arg1, HDStreamState arg2, uint arg3, void* arg4);
}

