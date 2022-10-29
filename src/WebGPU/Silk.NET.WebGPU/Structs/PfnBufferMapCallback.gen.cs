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
    public unsafe readonly struct PfnBufferMapCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void> Handle => (delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void>) _handle;
        public PfnBufferMapCallback
        (
            delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void> ptr
        ) => _handle = ptr;

        public PfnBufferMapCallback
        (
             BufferMapCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnBufferMapCallback From(BufferMapCallback proc) => new PfnBufferMapCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnBufferMapCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnBufferMapCallback(nint pfn)
            => new PfnBufferMapCallback((delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void>) pfn);

        public static implicit operator PfnBufferMapCallback(BufferMapCallback proc)
            => new PfnBufferMapCallback(proc);

        public static explicit operator BufferMapCallback(PfnBufferMapCallback pfn)
            => SilkMarshal.PtrToDelegate<BufferMapCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void>(PfnBufferMapCallback pfn) => pfn.Handle;
        public static implicit operator PfnBufferMapCallback(delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void> ptr) => new PfnBufferMapCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void BufferMapCallback(BufferMapAsyncStatus arg0, void* arg1);
}

