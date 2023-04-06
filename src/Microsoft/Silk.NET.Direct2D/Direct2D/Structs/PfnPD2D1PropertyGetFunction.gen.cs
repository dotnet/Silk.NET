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

namespace Silk.NET.Direct2D
{
    public unsafe readonly struct PfnPD2D1PropertyGetFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown*, byte*, uint, uint*, int> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown*, byte*, uint, uint*, int>) _handle;
        public PfnPD2D1PropertyGetFunction
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown*, byte*, uint, uint*, int> ptr
        ) => _handle = ptr;

        public PfnPD2D1PropertyGetFunction
        (
             PD2D1PropertyGetFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPD2D1PropertyGetFunction From(PD2D1PropertyGetFunction proc) => new PfnPD2D1PropertyGetFunction(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPD2D1PropertyGetFunction pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPD2D1PropertyGetFunction(nint pfn)
            => new PfnPD2D1PropertyGetFunction((delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown*, byte*, uint, uint*, int>) pfn);

        public static implicit operator PfnPD2D1PropertyGetFunction(PD2D1PropertyGetFunction proc)
            => new PfnPD2D1PropertyGetFunction(proc);

        public static explicit operator PD2D1PropertyGetFunction(PfnPD2D1PropertyGetFunction pfn)
            => SilkMarshal.PtrToDelegate<PD2D1PropertyGetFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown*, byte*, uint, uint*, int>(PfnPD2D1PropertyGetFunction pfn) => pfn.Handle;
        public static implicit operator PfnPD2D1PropertyGetFunction(delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown*, byte*, uint, uint*, int> ptr) => new PfnPD2D1PropertyGetFunction(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PD2D1PropertyGetFunction(Silk.NET.Core.Native.IUnknown* arg0, byte* arg1, uint arg2, uint* arg3);
}

