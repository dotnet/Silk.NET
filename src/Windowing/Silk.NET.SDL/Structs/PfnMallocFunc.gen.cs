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
    public unsafe readonly struct PfnMallocFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nuint, void*> Handle => (delegate* unmanaged[Cdecl]<nuint, void*>) _handle;
        public PfnMallocFunc
        (
            delegate* unmanaged[Cdecl]<nuint, void*> ptr
        ) => _handle = ptr;

        public PfnMallocFunc
        (
             MallocFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnMallocFunc From(MallocFunc proc) => new PfnMallocFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnMallocFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnMallocFunc(nint pfn)
            => new PfnMallocFunc((delegate* unmanaged[Cdecl]<nuint, void*>) pfn);

        public static implicit operator PfnMallocFunc(MallocFunc proc)
            => new PfnMallocFunc(proc);

        public static explicit operator MallocFunc(PfnMallocFunc pfn)
            => SilkMarshal.PtrToDelegate<MallocFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nuint, void*>(PfnMallocFunc pfn) => pfn.Handle;
        public static implicit operator PfnMallocFunc(delegate* unmanaged[Cdecl]<nuint, void*> ptr) => new PfnMallocFunc(ptr);
    }

    public unsafe delegate void* MallocFunc(nuint arg0);
}

