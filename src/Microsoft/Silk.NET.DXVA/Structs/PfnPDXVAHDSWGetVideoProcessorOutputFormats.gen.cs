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
    public unsafe readonly struct PfnPDXVAHDSWGetVideoProcessorOutputFormats : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, Silk.NET.Direct3D9.Format*, int> Handle => (delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, Silk.NET.Direct3D9.Format*, int>) _handle;
        public PfnPDXVAHDSWGetVideoProcessorOutputFormats
        (
            delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, Silk.NET.Direct3D9.Format*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWGetVideoProcessorOutputFormats
        (
             PDXVAHDSWGetVideoProcessorOutputFormats proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWGetVideoProcessorOutputFormats From(PDXVAHDSWGetVideoProcessorOutputFormats proc) => new PfnPDXVAHDSWGetVideoProcessorOutputFormats(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWGetVideoProcessorOutputFormats pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWGetVideoProcessorOutputFormats(nint pfn)
            => new PfnPDXVAHDSWGetVideoProcessorOutputFormats((delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, Silk.NET.Direct3D9.Format*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWGetVideoProcessorOutputFormats(PDXVAHDSWGetVideoProcessorOutputFormats proc)
            => new PfnPDXVAHDSWGetVideoProcessorOutputFormats(proc);

        public static explicit operator PDXVAHDSWGetVideoProcessorOutputFormats(PfnPDXVAHDSWGetVideoProcessorOutputFormats pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWGetVideoProcessorOutputFormats>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, Silk.NET.Direct3D9.Format*, int>(PfnPDXVAHDSWGetVideoProcessorOutputFormats pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWGetVideoProcessorOutputFormats(delegate* unmanaged[Cdecl]<void*, HDContentDesc*, HDDeviceUsage, uint, Silk.NET.Direct3D9.Format*, int> ptr) => new PfnPDXVAHDSWGetVideoProcessorOutputFormats(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWGetVideoProcessorOutputFormats(void* arg0, HDContentDesc* arg1, HDDeviceUsage arg2, uint arg3, Silk.NET.Direct3D9.Format* arg4);
}

