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
    public unsafe readonly struct PfnPDXVAHDSWGetVideoProcessorDeviceCaps : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, HDVpdevcaps*, int> Handle => (delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, HDVpdevcaps*, int>) _handle;
        public PfnPDXVAHDSWGetVideoProcessorDeviceCaps
        (
            delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, HDVpdevcaps*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWGetVideoProcessorDeviceCaps
        (
             PDXVAHDSWGetVideoProcessorDeviceCaps proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWGetVideoProcessorDeviceCaps From(PDXVAHDSWGetVideoProcessorDeviceCaps proc) => new PfnPDXVAHDSWGetVideoProcessorDeviceCaps(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWGetVideoProcessorDeviceCaps pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWGetVideoProcessorDeviceCaps(nint pfn)
            => new PfnPDXVAHDSWGetVideoProcessorDeviceCaps((delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, HDVpdevcaps*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWGetVideoProcessorDeviceCaps(PDXVAHDSWGetVideoProcessorDeviceCaps proc)
            => new PfnPDXVAHDSWGetVideoProcessorDeviceCaps(proc);

        public static explicit operator PDXVAHDSWGetVideoProcessorDeviceCaps(PfnPDXVAHDSWGetVideoProcessorDeviceCaps pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWGetVideoProcessorDeviceCaps>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, HDVpdevcaps*, int>(PfnPDXVAHDSWGetVideoProcessorDeviceCaps pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWGetVideoProcessorDeviceCaps(delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, HDVpdevcaps*, int> ptr) => new PfnPDXVAHDSWGetVideoProcessorDeviceCaps(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWGetVideoProcessorDeviceCaps(void* arg0, HDContentDesc* arg1, HDDeviceUsage arg2, HDVpdevcaps* arg3);
}

