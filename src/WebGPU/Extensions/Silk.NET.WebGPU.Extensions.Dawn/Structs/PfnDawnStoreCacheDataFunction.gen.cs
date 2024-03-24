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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    public unsafe readonly struct PfnDawnStoreCacheDataFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, void>) _handle;
        public PfnDawnStoreCacheDataFunction
        (
            delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, void> ptr
        ) => _handle = ptr;

        public PfnDawnStoreCacheDataFunction
        (
             DawnStoreCacheDataFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDawnStoreCacheDataFunction From(DawnStoreCacheDataFunction proc) => new PfnDawnStoreCacheDataFunction(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDawnStoreCacheDataFunction pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDawnStoreCacheDataFunction(nint pfn)
            => new PfnDawnStoreCacheDataFunction((delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, void>) pfn);

        public static implicit operator PfnDawnStoreCacheDataFunction(DawnStoreCacheDataFunction proc)
            => new PfnDawnStoreCacheDataFunction(proc);

        public static explicit operator DawnStoreCacheDataFunction(PfnDawnStoreCacheDataFunction pfn)
            => SilkMarshal.PtrToDelegate<DawnStoreCacheDataFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, void>(PfnDawnStoreCacheDataFunction pfn) => pfn.Handle;
        public static implicit operator PfnDawnStoreCacheDataFunction(delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, void> ptr) => new PfnDawnStoreCacheDataFunction(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DawnStoreCacheDataFunction(void* arg0, nuint arg1, void* arg2, nuint arg3, void* arg4);
}

