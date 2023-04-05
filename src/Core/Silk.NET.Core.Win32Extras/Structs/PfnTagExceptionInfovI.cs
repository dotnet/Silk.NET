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
    public unsafe readonly struct PfnTagExceptionInfovI : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<TagExceptionInfo*, int> Handle => (delegate* unmanaged[Cdecl]<TagExceptionInfo*, int>) _handle;
        public PfnTagExceptionInfovI
        (
            delegate* unmanaged[Cdecl]<TagExceptionInfo*, int> ptr
        ) => _handle = ptr;

        public PfnTagExceptionInfovI
        (
             TagExceptionInfovIProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnTagExceptionInfovI From(TagExceptionInfovIProc proc) => new PfnTagExceptionInfovI(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnTagExceptionInfovI pfn) => (nint) pfn.Handle;
        public static explicit operator PfnTagExceptionInfovI(nint pfn)
            => new PfnTagExceptionInfovI((delegate* unmanaged[Cdecl]<TagExceptionInfo*, int>) pfn);

        public static implicit operator PfnTagExceptionInfovI(TagExceptionInfovIProc proc)
            => new PfnTagExceptionInfovI(proc);

        public static explicit operator TagExceptionInfovIProc(PfnTagExceptionInfovI pfn)
            => SilkMarshal.PtrToDelegate<TagExceptionInfovIProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<TagExceptionInfo*, int>(PfnTagExceptionInfovI pfn) => pfn.Handle;
        public static implicit operator PfnTagExceptionInfovI(delegate* unmanaged[Cdecl]<TagExceptionInfo*, int> ptr) => new PfnTagExceptionInfovI(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int TagExceptionInfovIProc(TagExceptionInfo* arg0);
}

