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
    public unsafe readonly struct PfnTagEXCEPINFOvI : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<ExcepInfo*, int> Handle => (delegate* unmanaged[Cdecl]<ExcepInfo*, int>) _handle;
        public PfnTagEXCEPINFOvI
        (
            delegate* unmanaged[Cdecl]<ExcepInfo*, int> ptr
        ) => _handle = ptr;

        public PfnTagEXCEPINFOvI
        (
             TagEXCEPINFOvIProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnTagEXCEPINFOvI From(TagEXCEPINFOvIProc proc) => new PfnTagEXCEPINFOvI(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnTagEXCEPINFOvI pfn) => (nint) pfn.Handle;
        public static explicit operator PfnTagEXCEPINFOvI(nint pfn)
            => new PfnTagEXCEPINFOvI((delegate* unmanaged[Cdecl]<ExcepInfo*, int>) pfn);

        public static implicit operator PfnTagEXCEPINFOvI(TagEXCEPINFOvIProc proc)
            => new PfnTagEXCEPINFOvI(proc);

        public static explicit operator TagEXCEPINFOvIProc(PfnTagEXCEPINFOvI pfn)
            => SilkMarshal.PtrToDelegate<TagEXCEPINFOvIProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<ExcepInfo*, int>(PfnTagEXCEPINFOvI pfn) => pfn.Handle;
        public static implicit operator PfnTagEXCEPINFOvI(delegate* unmanaged[Cdecl]<ExcepInfo*, int> ptr) => new PfnTagEXCEPINFOvI(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int TagEXCEPINFOvIProc(ExcepInfo* arg0);
}

