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
    public unsafe readonly struct PfnPopErrorScopeCallback2 : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void*, void> Handle => (delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void*, void>) _handle;
        public PfnPopErrorScopeCallback2
        (
            delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void*, void> ptr
        ) => _handle = ptr;

        public PfnPopErrorScopeCallback2
        (
             PopErrorScopeCallback2 proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPopErrorScopeCallback2 From(PopErrorScopeCallback2 proc) => new PfnPopErrorScopeCallback2(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPopErrorScopeCallback2 pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPopErrorScopeCallback2(nint pfn)
            => new PfnPopErrorScopeCallback2((delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void*, void>) pfn);

        public static implicit operator PfnPopErrorScopeCallback2(PopErrorScopeCallback2 proc)
            => new PfnPopErrorScopeCallback2(proc);

        public static explicit operator PopErrorScopeCallback2(PfnPopErrorScopeCallback2 pfn)
            => SilkMarshal.PtrToDelegate<PopErrorScopeCallback2>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void*, void>(PfnPopErrorScopeCallback2 pfn) => pfn.Handle;
        public static implicit operator PfnPopErrorScopeCallback2(delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void*, void> ptr) => new PfnPopErrorScopeCallback2(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PopErrorScopeCallback2(PopErrorScopeStatus arg0, ErrorType arg1, byte* arg2, void* arg3, void* arg4);
}

