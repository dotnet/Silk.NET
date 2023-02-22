// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    public readonly unsafe struct PfnBufferCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void*, int, int> Handle => (delegate* unmanaged[Cdecl]<void*, void*, int, int>) this._handle;
        public PfnBufferCallback
        (
            delegate* unmanaged[Cdecl]<void*, void*, int, int> ptr
        ) => this._handle = ptr;

        public PfnBufferCallback
        (
            BufferCallbackType proc
        ) => this._handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnBufferCallback From(BufferCallbackType proc) => new PfnBufferCallback(proc);
        public void Dispose()                     => SilkMarshal.Free((nint) this._handle);

        public static implicit operator nint(PfnBufferCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnBufferCallback(nint pfn)
            => new PfnBufferCallback((delegate* unmanaged[Cdecl]<void*, void*, int, int>) pfn);

        public static implicit operator PfnBufferCallback(BufferCallbackType proc)
            => new PfnBufferCallback(proc);

        public static explicit operator BufferCallbackType(PfnBufferCallback pfn)
            => SilkMarshal.PtrToDelegate<BufferCallbackType>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*, int, int>(PfnBufferCallback pfn) => pfn.Handle;
        public static implicit operator PfnBufferCallback(delegate* unmanaged[Cdecl]<void*, void*, int, int> ptr) => new PfnBufferCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int BufferCallbackType(void* userPtr, void* samplerData, int numBytes);
}
