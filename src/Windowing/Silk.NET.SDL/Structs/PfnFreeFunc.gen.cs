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

namespace Silk.NET.SDL
{
    public unsafe readonly struct PfnFreeFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, void>) _handle;
        public PfnFreeFunc
        (
            delegate* unmanaged[Cdecl]<void*, void> ptr
        ) => _handle = ptr;

        public PfnFreeFunc
        (
             FreeFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFreeFunc From(FreeFunc proc) => new PfnFreeFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFreeFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFreeFunc(nint pfn)
            => new PfnFreeFunc((delegate* unmanaged[Cdecl]<void*, void>) pfn);

        public static implicit operator PfnFreeFunc(FreeFunc proc)
            => new PfnFreeFunc(proc);

        public static explicit operator FreeFunc(PfnFreeFunc pfn)
            => SilkMarshal.PtrToDelegate<FreeFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void>(PfnFreeFunc pfn) => pfn.Handle;
        public static implicit operator PfnFreeFunc(delegate* unmanaged[Cdecl]<void*, void> ptr) => new PfnFreeFunc(ptr);
    }

    public unsafe delegate void FreeFunc(void* arg0);
}

