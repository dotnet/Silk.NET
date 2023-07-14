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

namespace Silk.NET.Shaderc
{
    public unsafe readonly struct PfnIncludeResolveFn : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, byte*, int, byte*, nuint, IncludeResult*> Handle => (delegate* unmanaged[Cdecl]<void*, byte*, int, byte*, nuint, IncludeResult*>) _handle;
        public PfnIncludeResolveFn
        (
            delegate* unmanaged[Cdecl]<void*, byte*, int, byte*, nuint, IncludeResult*> ptr
        ) => _handle = ptr;

        public PfnIncludeResolveFn
        (
             IncludeResolveFn proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnIncludeResolveFn From(IncludeResolveFn proc) => new PfnIncludeResolveFn(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnIncludeResolveFn pfn) => (nint) pfn.Handle;
        public static explicit operator PfnIncludeResolveFn(nint pfn)
            => new PfnIncludeResolveFn((delegate* unmanaged[Cdecl]<void*, byte*, int, byte*, nuint, IncludeResult*>) pfn);

        public static implicit operator PfnIncludeResolveFn(IncludeResolveFn proc)
            => new PfnIncludeResolveFn(proc);

        public static explicit operator IncludeResolveFn(PfnIncludeResolveFn pfn)
            => SilkMarshal.PtrToDelegate<IncludeResolveFn>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, byte*, int, byte*, nuint, IncludeResult*>(PfnIncludeResolveFn pfn) => pfn.Handle;
        public static implicit operator PfnIncludeResolveFn(delegate* unmanaged[Cdecl]<void*, byte*, int, byte*, nuint, IncludeResult*> ptr) => new PfnIncludeResolveFn(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate IncludeResult* IncludeResolveFn(void* arg0, byte* arg1, int arg2, byte* arg3, nuint arg4);
}

