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
    public unsafe readonly struct PfnDawnLoadCacheDataFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, nuint> Handle => (delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, nuint>) _handle;
        public PfnDawnLoadCacheDataFunction
        (
            delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, nuint> ptr
        ) => _handle = ptr;

        public PfnDawnLoadCacheDataFunction
        (
             DawnLoadCacheDataFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDawnLoadCacheDataFunction From(DawnLoadCacheDataFunction proc) => new PfnDawnLoadCacheDataFunction(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDawnLoadCacheDataFunction pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDawnLoadCacheDataFunction(nint pfn)
            => new PfnDawnLoadCacheDataFunction((delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, nuint>) pfn);

        public static implicit operator PfnDawnLoadCacheDataFunction(DawnLoadCacheDataFunction proc)
            => new PfnDawnLoadCacheDataFunction(proc);

        public static explicit operator DawnLoadCacheDataFunction(PfnDawnLoadCacheDataFunction pfn)
            => SilkMarshal.PtrToDelegate<DawnLoadCacheDataFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, nuint>(PfnDawnLoadCacheDataFunction pfn) => pfn.Handle;
        public static implicit operator PfnDawnLoadCacheDataFunction(delegate* unmanaged[Cdecl]<void*, nuint, void*, nuint, void*, nuint> ptr) => new PfnDawnLoadCacheDataFunction(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate nuint DawnLoadCacheDataFunction(void* arg0, nuint arg1, void* arg2, nuint arg3, void* arg4);
}

