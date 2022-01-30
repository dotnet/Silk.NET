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
    public unsafe readonly struct PfnWmidprequest : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Wmidprequestcode, void*, uint*, void*, uint> Handle => (delegate* unmanaged[Cdecl]<Wmidprequestcode, void*, uint*, void*, uint>) _handle;
        public PfnWmidprequest
        (
            delegate* unmanaged[Cdecl]<Wmidprequestcode, void*, uint*, void*, uint> ptr
        ) => _handle = ptr;

        public PfnWmidprequest
        (
             Wmidprequest proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnWmidprequest From(Wmidprequest proc) => new PfnWmidprequest(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnWmidprequest pfn) => (nint) pfn.Handle;
        public static explicit operator PfnWmidprequest(nint pfn)
            => new PfnWmidprequest((delegate* unmanaged[Cdecl]<Wmidprequestcode, void*, uint*, void*, uint>) pfn);

        public static implicit operator PfnWmidprequest(Wmidprequest proc)
            => new PfnWmidprequest(proc);

        public static explicit operator Wmidprequest(PfnWmidprequest pfn)
            => SilkMarshal.PtrToDelegate<Wmidprequest>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Wmidprequestcode, void*, uint*, void*, uint>(PfnWmidprequest pfn) => pfn.Handle;
        public static implicit operator PfnWmidprequest(delegate* unmanaged[Cdecl]<Wmidprequestcode, void*, uint*, void*, uint> ptr) => new PfnWmidprequest(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint Wmidprequest(Wmidprequestcode arg0, void* arg1, uint* arg2, void* arg3);
}

