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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    public unsafe readonly struct PfnCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, void>) _handle;
        public PfnCallback
        (
            delegate* unmanaged[Cdecl]<void*, void> ptr
        ) => _handle = ptr;

        public PfnCallback
        (
             Callback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCallback From(Callback proc) => new PfnCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCallback(nint pfn)
            => new PfnCallback((delegate* unmanaged[Cdecl]<void*, void>) pfn);

        public static implicit operator PfnCallback(Callback proc)
            => new PfnCallback(proc);

        public static explicit operator Callback(PfnCallback pfn)
            => SilkMarshal.PtrToDelegate<Callback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void>(PfnCallback pfn) => pfn.Handle;
        public static implicit operator PfnCallback(delegate* unmanaged[Cdecl]<void*, void> ptr) => new PfnCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void Callback(void* arg0);
}

