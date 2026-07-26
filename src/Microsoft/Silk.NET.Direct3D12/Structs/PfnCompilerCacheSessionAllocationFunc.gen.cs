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

namespace Silk.NET.Direct3D12
{
    public unsafe readonly struct PfnCompilerCacheSessionAllocationFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nuint, void*, void*> Handle => (delegate* unmanaged[Cdecl]<nuint, void*, void*>) _handle;
        public PfnCompilerCacheSessionAllocationFunc
        (
            delegate* unmanaged[Cdecl]<nuint, void*, void*> ptr
        ) => _handle = ptr;

        public PfnCompilerCacheSessionAllocationFunc
        (
             CompilerCacheSessionAllocationFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCompilerCacheSessionAllocationFunc From(CompilerCacheSessionAllocationFunc proc) => new PfnCompilerCacheSessionAllocationFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCompilerCacheSessionAllocationFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCompilerCacheSessionAllocationFunc(nint pfn)
            => new PfnCompilerCacheSessionAllocationFunc((delegate* unmanaged[Cdecl]<nuint, void*, void*>) pfn);

        public static implicit operator PfnCompilerCacheSessionAllocationFunc(CompilerCacheSessionAllocationFunc proc)
            => new PfnCompilerCacheSessionAllocationFunc(proc);

        public static explicit operator CompilerCacheSessionAllocationFunc(PfnCompilerCacheSessionAllocationFunc pfn)
            => SilkMarshal.PtrToDelegate<CompilerCacheSessionAllocationFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nuint, void*, void*>(PfnCompilerCacheSessionAllocationFunc pfn) => pfn.Handle;
        public static implicit operator PfnCompilerCacheSessionAllocationFunc(delegate* unmanaged[Cdecl]<nuint, void*, void*> ptr) => new PfnCompilerCacheSessionAllocationFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* CompilerCacheSessionAllocationFunc(nuint arg0, void* arg1);
}

