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
    public unsafe readonly struct PfnPDXVAHDSWPlugin : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<uint, void*, int>) _handle;
        public PfnPDXVAHDSWPlugin
        (
            delegate* unmanaged[Cdecl]<uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWPlugin
        (
             PDXVAHDSWPlugin proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWPlugin From(PDXVAHDSWPlugin proc) => new PfnPDXVAHDSWPlugin(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWPlugin pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWPlugin(nint pfn)
            => new PfnPDXVAHDSWPlugin((delegate* unmanaged[Cdecl]<uint, void*, int>) pfn);

        public static implicit operator PfnPDXVAHDSWPlugin(PDXVAHDSWPlugin proc)
            => new PfnPDXVAHDSWPlugin(proc);

        public static explicit operator PDXVAHDSWPlugin(PfnPDXVAHDSWPlugin pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWPlugin>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, void*, int>(PfnPDXVAHDSWPlugin pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWPlugin(delegate* unmanaged[Cdecl]<uint, void*, int> ptr) => new PfnPDXVAHDSWPlugin(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWPlugin(uint arg0, void* arg1);
}

