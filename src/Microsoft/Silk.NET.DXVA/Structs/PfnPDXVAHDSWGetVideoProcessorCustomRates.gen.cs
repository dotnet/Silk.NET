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
    public unsafe readonly struct PfnPDXVAHDSWGetVideoProcessorCustomRates : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, Guid*, uint, HDCustomRateData*, int> Handle => (delegate* unmanaged[Cdecl]<void*, Guid*, uint, HDCustomRateData*, int>) _handle;
        public PfnPDXVAHDSWGetVideoProcessorCustomRates
        (
            delegate* unmanaged[Cdecl]<void*, Guid*, uint, HDCustomRateData*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWGetVideoProcessorCustomRates
        (
             PDXVAHDSWGetVideoProcessorCustomRates proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWGetVideoProcessorCustomRates From(PDXVAHDSWGetVideoProcessorCustomRates proc) => new PfnPDXVAHDSWGetVideoProcessorCustomRates(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWGetVideoProcessorCustomRates pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWGetVideoProcessorCustomRates(nint pfn)
            => new PfnPDXVAHDSWGetVideoProcessorCustomRates((delegate* unmanaged[Cdecl]<void*, Guid*, uint, HDCustomRateData*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWGetVideoProcessorCustomRates(PDXVAHDSWGetVideoProcessorCustomRates proc)
            => new PfnPDXVAHDSWGetVideoProcessorCustomRates(proc);

        public static explicit operator PDXVAHDSWGetVideoProcessorCustomRates(PfnPDXVAHDSWGetVideoProcessorCustomRates pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWGetVideoProcessorCustomRates>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, Guid*, uint, HDCustomRateData*, int>(PfnPDXVAHDSWGetVideoProcessorCustomRates pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWGetVideoProcessorCustomRates(delegate* unmanaged[Cdecl]<void*, Guid*, uint, HDCustomRateData*, int> ptr) => new PfnPDXVAHDSWGetVideoProcessorCustomRates(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWGetVideoProcessorCustomRates(void* arg0, Guid* arg1, uint arg2, HDCustomRateData* arg3);
}

