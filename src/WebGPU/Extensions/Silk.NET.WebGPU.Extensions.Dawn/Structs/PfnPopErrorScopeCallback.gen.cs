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
    public unsafe readonly struct PfnPopErrorScopeCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void>) _handle;
        public PfnPopErrorScopeCallback
        (
            delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnPopErrorScopeCallback
        (
             PopErrorScopeCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPopErrorScopeCallback From(PopErrorScopeCallback proc) => new PfnPopErrorScopeCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPopErrorScopeCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPopErrorScopeCallback(nint pfn)
            => new PfnPopErrorScopeCallback((delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void>) pfn);

        public static implicit operator PfnPopErrorScopeCallback(PopErrorScopeCallback proc)
            => new PfnPopErrorScopeCallback(proc);

        public static explicit operator PopErrorScopeCallback(PfnPopErrorScopeCallback pfn)
            => SilkMarshal.PtrToDelegate<PopErrorScopeCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void>(PfnPopErrorScopeCallback pfn) => pfn.Handle;
        public static implicit operator PfnPopErrorScopeCallback(delegate* unmanaged[Cdecl]<PopErrorScopeStatus, ErrorType, byte*, void*, void> ptr) => new PfnPopErrorScopeCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PopErrorScopeCallback(PopErrorScopeStatus arg0, ErrorType arg1, byte* arg2, void* arg3);
}

