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
    public unsafe readonly struct PfnPDXVAHDSWGetVideoProcessorCaps : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, HDVpcaps*, int> Handle => (delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, HDVpcaps*, int>) _handle;
        public PfnPDXVAHDSWGetVideoProcessorCaps
        (
            delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, HDVpcaps*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWGetVideoProcessorCaps
        (
             PDXVAHDSWGetVideoProcessorCaps proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWGetVideoProcessorCaps From(PDXVAHDSWGetVideoProcessorCaps proc) => new PfnPDXVAHDSWGetVideoProcessorCaps(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWGetVideoProcessorCaps pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWGetVideoProcessorCaps(nint pfn)
            => new PfnPDXVAHDSWGetVideoProcessorCaps((delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, HDVpcaps*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWGetVideoProcessorCaps(PDXVAHDSWGetVideoProcessorCaps proc)
            => new PfnPDXVAHDSWGetVideoProcessorCaps(proc);

        public static explicit operator PDXVAHDSWGetVideoProcessorCaps(PfnPDXVAHDSWGetVideoProcessorCaps pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWGetVideoProcessorCaps>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, HDVpcaps*, int>(PfnPDXVAHDSWGetVideoProcessorCaps pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWGetVideoProcessorCaps(delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, HDVpcaps*, int> ptr) => new PfnPDXVAHDSWGetVideoProcessorCaps(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWGetVideoProcessorCaps(void* arg0, HDContentDesc* arg1, HDDeviceUsage arg2, uint arg3, HDVpcaps* arg4);
}

