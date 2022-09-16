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
    public unsafe readonly struct PfnVvVvII : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void*, int, int> Handle => (delegate* unmanaged[Cdecl]<void*, void*, int, int>) _handle;
        public PfnVvVvII
        (
            delegate* unmanaged[Cdecl]<void*, void*, int, int> ptr
        ) => _handle = ptr;

        public PfnVvVvII
        (
             VvVvIIProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVvVvII From(VvVvIIProc proc) => new PfnVvVvII(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVvVvII pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVvVvII(nint pfn)
            => new PfnVvVvII((delegate* unmanaged[Cdecl]<void*, void*, int, int>) pfn);

        public static implicit operator PfnVvVvII(VvVvIIProc proc)
            => new PfnVvVvII(proc);

        public static explicit operator VvVvIIProc(PfnVvVvII pfn)
            => SilkMarshal.PtrToDelegate<VvVvIIProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*, int, int>(PfnVvVvII pfn) => pfn.Handle;
        public static implicit operator PfnVvVvII(delegate* unmanaged[Cdecl]<void*, void*, int, int> ptr) => new PfnVvVvII(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int VvVvIIProc(void* arg0, void* arg1, int arg2);
}

