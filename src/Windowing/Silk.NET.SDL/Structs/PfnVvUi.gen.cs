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
    public unsafe readonly struct PfnVvUi : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, uint> Handle => (delegate* unmanaged[Cdecl]<void*, uint>) _handle;
        public PfnVvUi
        (
            delegate* unmanaged[Cdecl]<void*, uint> ptr
        ) => _handle = ptr;

        public PfnVvUi
        (
             VvUiProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVvUi From(VvUiProc proc) => new PfnVvUi(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVvUi pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVvUi(nint pfn)
            => new PfnVvUi((delegate* unmanaged[Cdecl]<void*, uint>) pfn);

        public static implicit operator PfnVvUi(VvUiProc proc)
            => new PfnVvUi(proc);

        public static explicit operator VvUiProc(PfnVvUi pfn)
            => SilkMarshal.PtrToDelegate<VvUiProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint>(PfnVvUi pfn) => pfn.Handle;
        public static implicit operator PfnVvUi(delegate* unmanaged[Cdecl]<void*, uint> ptr) => new PfnVvUi(ptr);
    }

    public unsafe delegate uint VvUiProc(void* arg0);
}

