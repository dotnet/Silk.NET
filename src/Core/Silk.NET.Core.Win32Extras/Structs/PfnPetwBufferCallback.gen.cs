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

namespace Silk.NET.Core.Win32Extras
{
    public unsafe readonly struct PfnPetwBufferCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<EtwBufferHeader*, uint, EtwBufferCallbackInformation*, void*, Silk.NET.Core.Bool32> Handle => (delegate* unmanaged[Cdecl]<EtwBufferHeader*, uint, EtwBufferCallbackInformation*, void*, Silk.NET.Core.Bool32>) _handle;
        public PfnPetwBufferCallback
        (
            delegate* unmanaged[Cdecl]<EtwBufferHeader*, uint, EtwBufferCallbackInformation*, void*, Silk.NET.Core.Bool32> ptr
        ) => _handle = ptr;

        public PfnPetwBufferCallback
        (
             PetwBufferCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPetwBufferCallback From(PetwBufferCallback proc) => new PfnPetwBufferCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPetwBufferCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPetwBufferCallback(nint pfn)
            => new PfnPetwBufferCallback((delegate* unmanaged[Cdecl]<EtwBufferHeader*, uint, EtwBufferCallbackInformation*, void*, Silk.NET.Core.Bool32>) pfn);

        public static implicit operator PfnPetwBufferCallback(PetwBufferCallback proc)
            => new PfnPetwBufferCallback(proc);

        public static explicit operator PetwBufferCallback(PfnPetwBufferCallback pfn)
            => SilkMarshal.PtrToDelegate<PetwBufferCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<EtwBufferHeader*, uint, EtwBufferCallbackInformation*, void*, Silk.NET.Core.Bool32>(PfnPetwBufferCallback pfn) => pfn.Handle;
        public static implicit operator PfnPetwBufferCallback(delegate* unmanaged[Cdecl]<EtwBufferHeader*, uint, EtwBufferCallbackInformation*, void*, Silk.NET.Core.Bool32> ptr) => new PfnPetwBufferCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Core.Bool32 PetwBufferCallback(EtwBufferHeader* arg0, uint arg1, EtwBufferCallbackInformation* arg2, void* arg3);
}

