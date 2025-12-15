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
    public unsafe readonly struct PfnCompilationInfoCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void> Handle => (delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void>) _handle;
        public PfnCompilationInfoCallback
        (
            delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void> ptr
        ) => _handle = ptr;

        public PfnCompilationInfoCallback
        (
             CompilationInfoCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCompilationInfoCallback From(CompilationInfoCallback proc) => new PfnCompilationInfoCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCompilationInfoCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCompilationInfoCallback(nint pfn)
            => new PfnCompilationInfoCallback((delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void>) pfn);

        public static implicit operator PfnCompilationInfoCallback(CompilationInfoCallback proc)
            => new PfnCompilationInfoCallback(proc);

        public static explicit operator CompilationInfoCallback(PfnCompilationInfoCallback pfn)
            => SilkMarshal.PtrToDelegate<CompilationInfoCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void>(PfnCompilationInfoCallback pfn) => pfn.Handle;
        public static implicit operator PfnCompilationInfoCallback(delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void> ptr) => new PfnCompilationInfoCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CompilationInfoCallback(CompilationInfoRequestStatus arg0, CompilationInfo* arg1, void* arg2);
}

