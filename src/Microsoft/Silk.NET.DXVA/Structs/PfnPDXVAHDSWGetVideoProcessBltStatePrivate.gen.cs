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
    public unsafe readonly struct PfnPDXVAHDSWGetVideoProcessBltStatePrivate : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, HDBltStatePrivateData*, int> Handle => (delegate* unmanaged[Cdecl]<void*, HDBltStatePrivateData*, int>) _handle;
        public PfnPDXVAHDSWGetVideoProcessBltStatePrivate
        (
            delegate* unmanaged[Cdecl]<void*, HDBltStatePrivateData*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWGetVideoProcessBltStatePrivate
        (
             PDXVAHDSWGetVideoProcessBltStatePrivate proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWGetVideoProcessBltStatePrivate From(PDXVAHDSWGetVideoProcessBltStatePrivate proc) => new PfnPDXVAHDSWGetVideoProcessBltStatePrivate(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWGetVideoProcessBltStatePrivate pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWGetVideoProcessBltStatePrivate(nint pfn)
            => new PfnPDXVAHDSWGetVideoProcessBltStatePrivate((delegate* unmanaged[Cdecl]<void*, HDBltStatePrivateData*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWGetVideoProcessBltStatePrivate(PDXVAHDSWGetVideoProcessBltStatePrivate proc)
            => new PfnPDXVAHDSWGetVideoProcessBltStatePrivate(proc);

        public static explicit operator PDXVAHDSWGetVideoProcessBltStatePrivate(PfnPDXVAHDSWGetVideoProcessBltStatePrivate pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWGetVideoProcessBltStatePrivate>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, HDBltStatePrivateData*, int>(PfnPDXVAHDSWGetVideoProcessBltStatePrivate pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWGetVideoProcessBltStatePrivate(delegate* unmanaged[Cdecl]<void*, HDBltStatePrivateData*, int> ptr) => new PfnPDXVAHDSWGetVideoProcessBltStatePrivate(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWGetVideoProcessBltStatePrivate(void* arg0, HDBltStatePrivateData* arg1);
}

