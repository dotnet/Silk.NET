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
    public unsafe readonly struct PfnCompilerCacheSessionGroupValuesFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, CompilerCacheTypedConstValue*, void*, void> Handle => (delegate* unmanaged[Cdecl]<uint, CompilerCacheTypedConstValue*, void*, void>) _handle;
        public PfnCompilerCacheSessionGroupValuesFunc
        (
            delegate* unmanaged[Cdecl]<uint, CompilerCacheTypedConstValue*, void*, void> ptr
        ) => _handle = ptr;

        public PfnCompilerCacheSessionGroupValuesFunc
        (
             CompilerCacheSessionGroupValuesFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCompilerCacheSessionGroupValuesFunc From(CompilerCacheSessionGroupValuesFunc proc) => new PfnCompilerCacheSessionGroupValuesFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCompilerCacheSessionGroupValuesFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCompilerCacheSessionGroupValuesFunc(nint pfn)
            => new PfnCompilerCacheSessionGroupValuesFunc((delegate* unmanaged[Cdecl]<uint, CompilerCacheTypedConstValue*, void*, void>) pfn);

        public static implicit operator PfnCompilerCacheSessionGroupValuesFunc(CompilerCacheSessionGroupValuesFunc proc)
            => new PfnCompilerCacheSessionGroupValuesFunc(proc);

        public static explicit operator CompilerCacheSessionGroupValuesFunc(PfnCompilerCacheSessionGroupValuesFunc pfn)
            => SilkMarshal.PtrToDelegate<CompilerCacheSessionGroupValuesFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, CompilerCacheTypedConstValue*, void*, void>(PfnCompilerCacheSessionGroupValuesFunc pfn) => pfn.Handle;
        public static implicit operator PfnCompilerCacheSessionGroupValuesFunc(delegate* unmanaged[Cdecl]<uint, CompilerCacheTypedConstValue*, void*, void> ptr) => new PfnCompilerCacheSessionGroupValuesFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CompilerCacheSessionGroupValuesFunc(uint arg0, CompilerCacheTypedConstValue* arg1, void* arg2);
}

