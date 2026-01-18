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
    public unsafe readonly struct PfnUncapturedErrorCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Device**, ErrorType, StringView, void*, void*, void> Handle => (delegate* unmanaged[Cdecl]<Device**, ErrorType, StringView, void*, void*, void>) _handle;
        public PfnUncapturedErrorCallback
        (
            delegate* unmanaged[Cdecl]<Device**, ErrorType, StringView, void*, void*, void> ptr
        ) => _handle = ptr;

        public PfnUncapturedErrorCallback
        (
             UncapturedErrorCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnUncapturedErrorCallback From(UncapturedErrorCallback proc) => new PfnUncapturedErrorCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnUncapturedErrorCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnUncapturedErrorCallback(nint pfn)
            => new PfnUncapturedErrorCallback((delegate* unmanaged[Cdecl]<Device**, ErrorType, StringView, void*, void*, void>) pfn);

        public static implicit operator PfnUncapturedErrorCallback(UncapturedErrorCallback proc)
            => new PfnUncapturedErrorCallback(proc);

        public static explicit operator UncapturedErrorCallback(PfnUncapturedErrorCallback pfn)
            => SilkMarshal.PtrToDelegate<UncapturedErrorCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Device**, ErrorType, StringView, void*, void*, void>(PfnUncapturedErrorCallback pfn) => pfn.Handle;
        public static implicit operator PfnUncapturedErrorCallback(delegate* unmanaged[Cdecl]<Device**, ErrorType, StringView, void*, void*, void> ptr) => new PfnUncapturedErrorCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void UncapturedErrorCallback(Device** arg0, ErrorType arg1, StringView arg2, void* arg3, void* arg4);
}

