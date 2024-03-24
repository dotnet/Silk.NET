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
    public unsafe readonly struct PfnAdapterRequestAdapterInfoCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<AdapterInfo, void*, void> Handle => (delegate* unmanaged[Cdecl]<AdapterInfo, void*, void>) _handle;
        public PfnAdapterRequestAdapterInfoCallback
        (
            delegate* unmanaged[Cdecl]<AdapterInfo, void*, void> ptr
        ) => _handle = ptr;

        public PfnAdapterRequestAdapterInfoCallback
        (
             AdapterRequestAdapterInfoCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnAdapterRequestAdapterInfoCallback From(AdapterRequestAdapterInfoCallback proc) => new PfnAdapterRequestAdapterInfoCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnAdapterRequestAdapterInfoCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnAdapterRequestAdapterInfoCallback(nint pfn)
            => new PfnAdapterRequestAdapterInfoCallback((delegate* unmanaged[Cdecl]<AdapterInfo, void*, void>) pfn);

        public static implicit operator PfnAdapterRequestAdapterInfoCallback(AdapterRequestAdapterInfoCallback proc)
            => new PfnAdapterRequestAdapterInfoCallback(proc);

        public static explicit operator AdapterRequestAdapterInfoCallback(PfnAdapterRequestAdapterInfoCallback pfn)
            => SilkMarshal.PtrToDelegate<AdapterRequestAdapterInfoCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<AdapterInfo, void*, void>(PfnAdapterRequestAdapterInfoCallback pfn) => pfn.Handle;
        public static implicit operator PfnAdapterRequestAdapterInfoCallback(delegate* unmanaged[Cdecl]<AdapterInfo, void*, void> ptr) => new PfnAdapterRequestAdapterInfoCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AdapterRequestAdapterInfoCallback(AdapterInfo arg0, void* arg1);
}

