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
    public unsafe readonly struct PfnBufferMapAsyncCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void> Handle => (delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void>) _handle;
        public PfnBufferMapAsyncCallback
        (
            delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void> ptr
        ) => _handle = ptr;

        public PfnBufferMapAsyncCallback
        (
             BufferMapAsyncCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnBufferMapAsyncCallback From(BufferMapAsyncCallback proc) => new PfnBufferMapAsyncCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnBufferMapAsyncCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnBufferMapAsyncCallback(nint pfn)
            => new PfnBufferMapAsyncCallback((delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void>) pfn);

        public static implicit operator PfnBufferMapAsyncCallback(BufferMapAsyncCallback proc)
            => new PfnBufferMapAsyncCallback(proc);

        public static explicit operator BufferMapAsyncCallback(PfnBufferMapAsyncCallback pfn)
            => SilkMarshal.PtrToDelegate<BufferMapAsyncCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void>(PfnBufferMapAsyncCallback pfn) => pfn.Handle;
        public static implicit operator PfnBufferMapAsyncCallback(delegate* unmanaged[Cdecl]<BufferMapAsyncStatus, void*, void> ptr) => new PfnBufferMapAsyncCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void BufferMapAsyncCallback(BufferMapAsyncStatus arg0, void* arg1);
}

