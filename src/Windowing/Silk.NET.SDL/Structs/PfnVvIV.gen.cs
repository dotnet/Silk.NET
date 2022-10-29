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

namespace Silk.NET.SDL
{
    public unsafe readonly struct PfnVvIV : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, int, void> Handle => (delegate* unmanaged[Cdecl]<void*, int, void>) _handle;
        public PfnVvIV
        (
            delegate* unmanaged[Cdecl]<void*, int, void> ptr
        ) => _handle = ptr;

        public PfnVvIV
        (
             VvIVProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVvIV From(VvIVProc proc) => new PfnVvIV(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVvIV pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVvIV(nint pfn)
            => new PfnVvIV((delegate* unmanaged[Cdecl]<void*, int, void>) pfn);

        public static implicit operator PfnVvIV(VvIVProc proc)
            => new PfnVvIV(proc);

        public static explicit operator VvIVProc(PfnVvIV pfn)
            => SilkMarshal.PtrToDelegate<VvIVProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, int, void>(PfnVvIV pfn) => pfn.Handle;
        public static implicit operator PfnVvIV(delegate* unmanaged[Cdecl]<void*, int, void> ptr) => new PfnVvIV(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VvIVProc(void* arg0, int arg1);
}

