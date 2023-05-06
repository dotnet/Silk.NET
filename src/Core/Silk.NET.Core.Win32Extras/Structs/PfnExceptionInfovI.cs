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
    public unsafe readonly struct PfnExceptionInfovI : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<ExceptionInfo*, int> Handle => (delegate* unmanaged[Cdecl]<ExceptionInfo*, int>) _handle;
        public PfnExceptionInfovI
        (
            delegate* unmanaged[Cdecl]<ExceptionInfo*, int> ptr
        ) => _handle = ptr;

        public PfnExceptionInfovI
        (
             ExceptionInfovIProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnExceptionInfovI From(ExceptionInfovIProc proc) => new PfnExceptionInfovI(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnExceptionInfovI pfn) => (nint) pfn.Handle;
        public static explicit operator PfnExceptionInfovI(nint pfn)
            => new PfnExceptionInfovI((delegate* unmanaged[Cdecl]<ExceptionInfo*, int>) pfn);

        public static implicit operator PfnExceptionInfovI(ExceptionInfovIProc proc)
            => new PfnExceptionInfovI(proc);

        public static explicit operator ExceptionInfovIProc(PfnExceptionInfovI pfn)
            => SilkMarshal.PtrToDelegate<ExceptionInfovIProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<ExceptionInfo*, int>(PfnExceptionInfovI pfn) => pfn.Handle;
        public static implicit operator PfnExceptionInfovI(delegate* unmanaged[Cdecl]<ExceptionInfo*, int> ptr) => new PfnExceptionInfovI(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int ExceptionInfovIProc(ExceptionInfo* arg0);
}

