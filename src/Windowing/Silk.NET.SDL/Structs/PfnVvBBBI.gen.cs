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
    public unsafe readonly struct PfnVvBBBI : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, byte, byte, byte, int> Handle => (delegate* unmanaged[Cdecl]<void*, byte, byte, byte, int>) _handle;
        public PfnVvBBBI
        (
            delegate* unmanaged[Cdecl]<void*, byte, byte, byte, int> ptr
        ) => _handle = ptr;

        public PfnVvBBBI
        (
             VvBBBIProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVvBBBI From(VvBBBIProc proc) => new PfnVvBBBI(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVvBBBI pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVvBBBI(nint pfn)
            => new PfnVvBBBI((delegate* unmanaged[Cdecl]<void*, byte, byte, byte, int>) pfn);

        public static implicit operator PfnVvBBBI(VvBBBIProc proc)
            => new PfnVvBBBI(proc);

        public static explicit operator VvBBBIProc(PfnVvBBBI pfn)
            => SilkMarshal.PtrToDelegate<VvBBBIProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, byte, byte, byte, int>(PfnVvBBBI pfn) => pfn.Handle;
        public static implicit operator PfnVvBBBI(delegate* unmanaged[Cdecl]<void*, byte, byte, byte, int> ptr) => new PfnVvBBBI(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int VvBBBIProc(void* arg0, byte arg1, byte arg2, byte arg3);
}

