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
    public unsafe readonly struct PfnPDXVAHDSWCreateVideoProcessor : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, Guid*, void**, int> Handle => (delegate* unmanaged[Cdecl]<void*, Guid*, void**, int>) _handle;
        public PfnPDXVAHDSWCreateVideoProcessor
        (
            delegate* unmanaged[Cdecl]<void*, Guid*, void**, int> ptr
        ) => _handle = ptr;

        public PfnPDXVAHDSWCreateVideoProcessor
        (
             PDXVAHDSWCreateVideoProcessor proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPDXVAHDSWCreateVideoProcessor From(PDXVAHDSWCreateVideoProcessor proc) => new PfnPDXVAHDSWCreateVideoProcessor(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPDXVAHDSWCreateVideoProcessor pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPDXVAHDSWCreateVideoProcessor(nint pfn)
            => new PfnPDXVAHDSWCreateVideoProcessor((delegate* unmanaged[Cdecl]<void*, Guid*, void**, int>) pfn);

        public static implicit operator PfnPDXVAHDSWCreateVideoProcessor(PDXVAHDSWCreateVideoProcessor proc)
            => new PfnPDXVAHDSWCreateVideoProcessor(proc);

        public static explicit operator PDXVAHDSWCreateVideoProcessor(PfnPDXVAHDSWCreateVideoProcessor pfn)
            => SilkMarshal.PtrToDelegate<PDXVAHDSWCreateVideoProcessor>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, Guid*, void**, int>(PfnPDXVAHDSWCreateVideoProcessor pfn) => pfn.Handle;
        public static implicit operator PfnPDXVAHDSWCreateVideoProcessor(delegate* unmanaged[Cdecl]<void*, Guid*, void**, int> ptr) => new PfnPDXVAHDSWCreateVideoProcessor(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PDXVAHDSWCreateVideoProcessor(void* arg0, Guid* arg1, void** arg2);
}

