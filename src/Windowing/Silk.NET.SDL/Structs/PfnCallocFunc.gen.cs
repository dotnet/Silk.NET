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
    public unsafe readonly struct PfnCallocFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nuint, nuint, void*> Handle => (delegate* unmanaged[Cdecl]<nuint, nuint, void*>) _handle;
        public PfnCallocFunc
        (
            delegate* unmanaged[Cdecl]<nuint, nuint, void*> ptr
        ) => _handle = ptr;

        public PfnCallocFunc
        (
             CallocFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCallocFunc From(CallocFunc proc) => new PfnCallocFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCallocFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCallocFunc(nint pfn)
            => new PfnCallocFunc((delegate* unmanaged[Cdecl]<nuint, nuint, void*>) pfn);

        public static implicit operator PfnCallocFunc(CallocFunc proc)
            => new PfnCallocFunc(proc);

        public static explicit operator CallocFunc(PfnCallocFunc pfn)
            => SilkMarshal.PtrToDelegate<CallocFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nuint, nuint, void*>(PfnCallocFunc pfn) => pfn.Handle;
        public static implicit operator PfnCallocFunc(delegate* unmanaged[Cdecl]<nuint, nuint, void*> ptr) => new PfnCallocFunc(ptr);
    }

    public unsafe delegate void* CallocFunc(nuint arg0, nuint arg1);
}

