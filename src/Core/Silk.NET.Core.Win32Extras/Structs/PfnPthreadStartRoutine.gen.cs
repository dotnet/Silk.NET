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

namespace Silk.NET.Core.Win32Extras
{
    public unsafe readonly struct PfnPthreadStartRoutine : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, uint> Handle => (delegate* unmanaged[Cdecl]<void*, uint>) _handle;
        public PfnPthreadStartRoutine
        (
            delegate* unmanaged[Cdecl]<void*, uint> ptr
        ) => _handle = ptr;

        public PfnPthreadStartRoutine
        (
             PthreadStartRoutine proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPthreadStartRoutine From(PthreadStartRoutine proc) => new PfnPthreadStartRoutine(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPthreadStartRoutine pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPthreadStartRoutine(nint pfn)
            => new PfnPthreadStartRoutine((delegate* unmanaged[Cdecl]<void*, uint>) pfn);

        public static implicit operator PfnPthreadStartRoutine(PthreadStartRoutine proc)
            => new PfnPthreadStartRoutine(proc);

        public static explicit operator PthreadStartRoutine(PfnPthreadStartRoutine pfn)
            => SilkMarshal.PtrToDelegate<PthreadStartRoutine>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint>(PfnPthreadStartRoutine pfn) => pfn.Handle;
        public static implicit operator PfnPthreadStartRoutine(delegate* unmanaged[Cdecl]<void*, uint> ptr) => new PfnPthreadStartRoutine(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint PthreadStartRoutine(void* arg0);
}

