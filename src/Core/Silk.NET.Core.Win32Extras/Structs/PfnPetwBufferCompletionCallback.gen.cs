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
    public unsafe readonly struct PfnPetwBufferCompletionCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<EtwBufferHeader*, void*, void> Handle => (delegate* unmanaged[Cdecl]<EtwBufferHeader*, void*, void>) _handle;
        public PfnPetwBufferCompletionCallback
        (
            delegate* unmanaged[Cdecl]<EtwBufferHeader*, void*, void> ptr
        ) => _handle = ptr;

        public PfnPetwBufferCompletionCallback
        (
             PetwBufferCompletionCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPetwBufferCompletionCallback From(PetwBufferCompletionCallback proc) => new PfnPetwBufferCompletionCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPetwBufferCompletionCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPetwBufferCompletionCallback(nint pfn)
            => new PfnPetwBufferCompletionCallback((delegate* unmanaged[Cdecl]<EtwBufferHeader*, void*, void>) pfn);

        public static implicit operator PfnPetwBufferCompletionCallback(PetwBufferCompletionCallback proc)
            => new PfnPetwBufferCompletionCallback(proc);

        public static explicit operator PetwBufferCompletionCallback(PfnPetwBufferCompletionCallback pfn)
            => SilkMarshal.PtrToDelegate<PetwBufferCompletionCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<EtwBufferHeader*, void*, void>(PfnPetwBufferCompletionCallback pfn) => pfn.Handle;
        public static implicit operator PfnPetwBufferCompletionCallback(delegate* unmanaged[Cdecl]<EtwBufferHeader*, void*, void> ptr) => new PfnPetwBufferCompletionCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PetwBufferCompletionCallback(EtwBufferHeader* arg0, void* arg1);
}

