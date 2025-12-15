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
    public unsafe readonly struct PfnStateObjectFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, uint, uint, StateObjectDesc*, void*, uint, void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, uint, uint, StateObjectDesc*, void*, uint, void*, void>) _handle;
        public PfnStateObjectFunc
        (
            delegate* unmanaged[Cdecl]<void*, uint, uint, StateObjectDesc*, void*, uint, void*, void> ptr
        ) => _handle = ptr;

        public PfnStateObjectFunc
        (
             StateObjectFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnStateObjectFunc From(StateObjectFunc proc) => new PfnStateObjectFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnStateObjectFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnStateObjectFunc(nint pfn)
            => new PfnStateObjectFunc((delegate* unmanaged[Cdecl]<void*, uint, uint, StateObjectDesc*, void*, uint, void*, void>) pfn);

        public static implicit operator PfnStateObjectFunc(StateObjectFunc proc)
            => new PfnStateObjectFunc(proc);

        public static explicit operator StateObjectFunc(PfnStateObjectFunc pfn)
            => SilkMarshal.PtrToDelegate<StateObjectFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint, uint, StateObjectDesc*, void*, uint, void*, void>(PfnStateObjectFunc pfn) => pfn.Handle;
        public static implicit operator PfnStateObjectFunc(delegate* unmanaged[Cdecl]<void*, uint, uint, StateObjectDesc*, void*, uint, void*, void> ptr) => new PfnStateObjectFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void StateObjectFunc(void* arg0, uint arg1, uint arg2, StateObjectDesc* arg3, void* arg4, uint arg5, void* arg6);
}

