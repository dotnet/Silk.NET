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

namespace Silk.NET.SPIRV.Cross
{
    public unsafe readonly struct PfnErrorCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, byte*, void> Handle => (delegate* unmanaged[Cdecl]<void*, byte*, void>) _handle;
        public PfnErrorCallback
        (
            delegate* unmanaged[Cdecl]<void*, byte*, void> ptr
        ) => _handle = ptr;

        public PfnErrorCallback
        (
             ErrorCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnErrorCallback From(ErrorCallback proc) => new PfnErrorCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnErrorCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnErrorCallback(nint pfn)
            => new PfnErrorCallback((delegate* unmanaged[Cdecl]<void*, byte*, void>) pfn);

        public static implicit operator PfnErrorCallback(ErrorCallback proc)
            => new PfnErrorCallback(proc);

        public static explicit operator ErrorCallback(PfnErrorCallback pfn)
            => SilkMarshal.PtrToDelegate<ErrorCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, byte*, void>(PfnErrorCallback pfn) => pfn.Handle;
        public static implicit operator PfnErrorCallback(delegate* unmanaged[Cdecl]<void*, byte*, void> ptr) => new PfnErrorCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ErrorCallback(void* arg0, byte* arg1);
}

