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

namespace Silk.NET.Direct3D12
{
    public unsafe readonly struct PfnApplicationDescFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<ApplicationDesc*, void*, void> Handle => (delegate* unmanaged[Cdecl]<ApplicationDesc*, void*, void>) _handle;
        public PfnApplicationDescFunc
        (
            delegate* unmanaged[Cdecl]<ApplicationDesc*, void*, void> ptr
        ) => _handle = ptr;

        public PfnApplicationDescFunc
        (
             ApplicationDescFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnApplicationDescFunc From(ApplicationDescFunc proc) => new PfnApplicationDescFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnApplicationDescFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnApplicationDescFunc(nint pfn)
            => new PfnApplicationDescFunc((delegate* unmanaged[Cdecl]<ApplicationDesc*, void*, void>) pfn);

        public static implicit operator PfnApplicationDescFunc(ApplicationDescFunc proc)
            => new PfnApplicationDescFunc(proc);

        public static explicit operator ApplicationDescFunc(PfnApplicationDescFunc pfn)
            => SilkMarshal.PtrToDelegate<ApplicationDescFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<ApplicationDesc*, void*, void>(PfnApplicationDescFunc pfn) => pfn.Handle;
        public static implicit operator PfnApplicationDescFunc(delegate* unmanaged[Cdecl]<ApplicationDesc*, void*, void> ptr) => new PfnApplicationDescFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ApplicationDescFunc(ApplicationDesc* arg0, void* arg1);
}

