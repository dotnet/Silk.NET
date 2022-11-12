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
    public unsafe readonly struct PfnPDXVAHDSWSetVideoProcessBltState : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, HDBltState, uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<void*, HDBltState, uint, void*, int>) _handle;
        public PfnPDXVAHDSWSetVideoProcessBltState
        (
            delegate* unmanaged[Cdecl]<void*, HDBltState, uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWSetVideoProcessBltState
        (
             PDXVAHDSWSetVideoProcessBltState proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWSetVideoProcessBltState From(PDXVAHDSWSetVideoProcessBltState proc) => new PfnPDXVAHDSWSetVideoProcessBltState(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWSetVideoProcessBltState pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWSetVideoProcessBltState(nint pfn)
            => new PfnPDXVAHDSWSetVideoProcessBltState((delegate* unmanaged[Cdecl]<void*, HDBltState, uint, void*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWSetVideoProcessBltState(PDXVAHDSWSetVideoProcessBltState proc)
            => new PfnPDXVAHDSWSetVideoProcessBltState(proc);

        public static explicit operator PDXVAHDSWSetVideoProcessBltState(PfnPDXVAHDSWSetVideoProcessBltState pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWSetVideoProcessBltState>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, HDBltState, uint, void*, int>(PfnPDXVAHDSWSetVideoProcessBltState pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWSetVideoProcessBltState(delegate* unmanaged[Cdecl]<void*, HDBltState, uint, void*, int> ptr) => new PfnPDXVAHDSWSetVideoProcessBltState(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWSetVideoProcessBltState(void* arg0, HDBltState arg1, uint arg2, void* arg3);
}

