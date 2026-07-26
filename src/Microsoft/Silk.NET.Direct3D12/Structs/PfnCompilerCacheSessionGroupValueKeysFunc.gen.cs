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
    public unsafe readonly struct PfnCompilerCacheSessionGroupValueKeysFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<CompilerCacheValueKey*, void*, void> Handle => (delegate* unmanaged[Cdecl]<CompilerCacheValueKey*, void*, void>) _handle;
        public PfnCompilerCacheSessionGroupValueKeysFunc
        (
            delegate* unmanaged[Cdecl]<CompilerCacheValueKey*, void*, void> ptr
        ) => _handle = ptr;

        public PfnCompilerCacheSessionGroupValueKeysFunc
        (
             CompilerCacheSessionGroupValueKeysFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCompilerCacheSessionGroupValueKeysFunc From(CompilerCacheSessionGroupValueKeysFunc proc) => new PfnCompilerCacheSessionGroupValueKeysFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCompilerCacheSessionGroupValueKeysFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCompilerCacheSessionGroupValueKeysFunc(nint pfn)
            => new PfnCompilerCacheSessionGroupValueKeysFunc((delegate* unmanaged[Cdecl]<CompilerCacheValueKey*, void*, void>) pfn);

        public static implicit operator PfnCompilerCacheSessionGroupValueKeysFunc(CompilerCacheSessionGroupValueKeysFunc proc)
            => new PfnCompilerCacheSessionGroupValueKeysFunc(proc);

        public static explicit operator CompilerCacheSessionGroupValueKeysFunc(PfnCompilerCacheSessionGroupValueKeysFunc pfn)
            => SilkMarshal.PtrToDelegate<CompilerCacheSessionGroupValueKeysFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<CompilerCacheValueKey*, void*, void>(PfnCompilerCacheSessionGroupValueKeysFunc pfn) => pfn.Handle;
        public static implicit operator PfnCompilerCacheSessionGroupValueKeysFunc(delegate* unmanaged[Cdecl]<CompilerCacheValueKey*, void*, void> ptr) => new PfnCompilerCacheSessionGroupValueKeysFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CompilerCacheSessionGroupValueKeysFunc(CompilerCacheValueKey* arg0, void* arg1);
}

