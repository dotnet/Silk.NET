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
    public unsafe readonly struct PfnPDXVAHDSWGetVideoProcessorFilterRange : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nint*, HDFilter, HDFilterRangeData*, int> Handle => (delegate* unmanaged[Cdecl]<nint*, HDFilter, HDFilterRangeData*, int>) _handle;
        public PfnPDXVAHDSWGetVideoProcessorFilterRange
        (
            delegate* unmanaged[Cdecl]<nint*, HDFilter, HDFilterRangeData*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWGetVideoProcessorFilterRange
        (
             PDXVAHDSWGetVideoProcessorFilterRange proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWGetVideoProcessorFilterRange From(PDXVAHDSWGetVideoProcessorFilterRange proc) => new PfnPDXVAHDSWGetVideoProcessorFilterRange(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWGetVideoProcessorFilterRange pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWGetVideoProcessorFilterRange(nint pfn)
            => new PfnPDXVAHDSWGetVideoProcessorFilterRange((delegate* unmanaged[Cdecl]<nint*, HDFilter, HDFilterRangeData*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWGetVideoProcessorFilterRange(PDXVAHDSWGetVideoProcessorFilterRange proc)
            => new PfnPDXVAHDSWGetVideoProcessorFilterRange(proc);

        public static explicit operator PDXVAHDSWGetVideoProcessorFilterRange(PfnPDXVAHDSWGetVideoProcessorFilterRange pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWGetVideoProcessorFilterRange>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nint*, HDFilter, HDFilterRangeData*, int>(PfnPDXVAHDSWGetVideoProcessorFilterRange pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWGetVideoProcessorFilterRange(delegate* unmanaged[Cdecl]<nint*, HDFilter, HDFilterRangeData*, int> ptr) => new PfnPDXVAHDSWGetVideoProcessorFilterRange(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWGetVideoProcessorFilterRange(nint* arg0, HDFilter arg1, HDFilterRangeData* arg2);
}

