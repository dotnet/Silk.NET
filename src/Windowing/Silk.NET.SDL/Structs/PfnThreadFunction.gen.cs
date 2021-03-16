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
    public unsafe readonly struct PfnThreadFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, int> Handle => (delegate* unmanaged[Cdecl]<void*, int>) _handle;
        public PfnThreadFunction
        (
            delegate* unmanaged[Cdecl]<void*, int> ptr
        ) => _handle = ptr;

        public PfnThreadFunction
        (
             ThreadFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnThreadFunction From(ThreadFunction proc) => new PfnThreadFunction(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnThreadFunction pfn) => (nint) pfn.Handle;
        public static explicit operator PfnThreadFunction(nint pfn)
            => new PfnThreadFunction((delegate* unmanaged[Cdecl]<void*, int>) pfn);

        public static implicit operator PfnThreadFunction(ThreadFunction proc)
            => new PfnThreadFunction(proc);

        public static explicit operator ThreadFunction(PfnThreadFunction pfn)
            => SilkMarshal.PtrToDelegate<ThreadFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, int>(PfnThreadFunction pfn) => pfn.Handle;
        public static implicit operator PfnThreadFunction(delegate* unmanaged[Cdecl]<void*, int> ptr) => new PfnThreadFunction(ptr);
    }

    public unsafe delegate int ThreadFunction(void* arg0);
}

