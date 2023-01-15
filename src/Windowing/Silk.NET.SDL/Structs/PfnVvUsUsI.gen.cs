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
    public unsafe readonly struct PfnVvUsUsI : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, ushort, ushort, int> Handle => (delegate* unmanaged[Cdecl]<void*, ushort, ushort, int>) _handle;
        public PfnVvUsUsI
        (
            delegate* unmanaged[Cdecl]<void*, ushort, ushort, int> ptr
        ) => _handle = ptr;

        public PfnVvUsUsI
        (
             VvUsUsIProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVvUsUsI From(VvUsUsIProc proc) => new PfnVvUsUsI(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVvUsUsI pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVvUsUsI(nint pfn)
            => new PfnVvUsUsI((delegate* unmanaged[Cdecl]<void*, ushort, ushort, int>) pfn);

        public static implicit operator PfnVvUsUsI(VvUsUsIProc proc)
            => new PfnVvUsUsI(proc);

        public static explicit operator VvUsUsIProc(PfnVvUsUsI pfn)
            => SilkMarshal.PtrToDelegate<VvUsUsIProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, ushort, ushort, int>(PfnVvUsUsI pfn) => pfn.Handle;
        public static implicit operator PfnVvUsUsI(delegate* unmanaged[Cdecl]<void*, ushort, ushort, int> ptr) => new PfnVvUsUsI(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int VvUsUsIProc(void* arg0, ushort arg1, ushort arg2);
}

