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
    public unsafe readonly struct PfnCompareCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void*, int> Handle => (delegate* unmanaged[Cdecl]<void*, void*, int>) _handle;
        public PfnCompareCallback
        (
            delegate* unmanaged[Cdecl]<void*, void*, int> ptr
        ) => _handle = ptr;

        public PfnCompareCallback
        (
             CompareCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCompareCallback From(CompareCallback proc) => new PfnCompareCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCompareCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCompareCallback(nint pfn)
            => new PfnCompareCallback((delegate* unmanaged[Cdecl]<void*, void*, int>) pfn);

        public static implicit operator PfnCompareCallback(CompareCallback proc)
            => new PfnCompareCallback(proc);

        public static explicit operator CompareCallback(PfnCompareCallback pfn)
            => SilkMarshal.PtrToDelegate<CompareCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*, int>(PfnCompareCallback pfn) => pfn.Handle;
        public static implicit operator PfnCompareCallback(delegate* unmanaged[Cdecl]<void*, void*, int> ptr) => new PfnCompareCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int CompareCallback(void* arg0, void* arg1);
}

