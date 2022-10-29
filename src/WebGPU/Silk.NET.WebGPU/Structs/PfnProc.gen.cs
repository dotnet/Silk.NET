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

namespace Silk.NET.WebGPU
{
    public unsafe readonly struct PfnProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void> Handle => (delegate* unmanaged[Cdecl]<void>) _handle;
        public PfnProc
        (
            delegate* unmanaged[Cdecl]<void> ptr
        ) => _handle = ptr;

        public PfnProc
        (
             Proc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnProc From(Proc proc) => new PfnProc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnProc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnProc(nint pfn)
            => new PfnProc((delegate* unmanaged[Cdecl]<void>) pfn);

        public static implicit operator PfnProc(Proc proc)
            => new PfnProc(proc);

        public static explicit operator Proc(PfnProc pfn)
            => SilkMarshal.PtrToDelegate<Proc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void>(PfnProc pfn) => pfn.Handle;
        public static implicit operator PfnProc(delegate* unmanaged[Cdecl]<void> ptr) => new PfnProc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Proc();
}

