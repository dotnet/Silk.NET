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

namespace Silk.NET.DXVA
{
    public unsafe readonly struct PfnPdxva2SWVideoprocessendframe : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<nint*, void**, int> Handle => (delegate* unmanaged[Cdecl]<nint*, void**, int>) _handle;
        public PfnPdxva2SWVideoprocessendframe
        (
            delegate* unmanaged[Cdecl]<nint*, void**, int> ptr
        ) => _handle = ptr;

        public PfnPdxva2SWVideoprocessendframe
        (
             Pdxva2SWVideoprocessendframe proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPdxva2SWVideoprocessendframe From(Pdxva2SWVideoprocessendframe proc) => new PfnPdxva2SWVideoprocessendframe(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPdxva2SWVideoprocessendframe pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPdxva2SWVideoprocessendframe(nint pfn)
            => new PfnPdxva2SWVideoprocessendframe((delegate* unmanaged[Cdecl]<nint*, void**, int>) pfn);

        public static implicit operator PfnPdxva2SWVideoprocessendframe(Pdxva2SWVideoprocessendframe proc)
            => new PfnPdxva2SWVideoprocessendframe(proc);

        public static explicit operator Pdxva2SWVideoprocessendframe(PfnPdxva2SWVideoprocessendframe pfn)
            => SilkMarshal.PtrToDelegate<Pdxva2SWVideoprocessendframe>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<nint*, void**, int>(PfnPdxva2SWVideoprocessendframe pfn) => pfn.Handle;
        public static implicit operator PfnPdxva2SWVideoprocessendframe(delegate* unmanaged[Cdecl]<nint*, void**, int> ptr) => new PfnPdxva2SWVideoprocessendframe(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int Pdxva2SWVideoprocessendframe(nint* arg0, void** arg1);
}

