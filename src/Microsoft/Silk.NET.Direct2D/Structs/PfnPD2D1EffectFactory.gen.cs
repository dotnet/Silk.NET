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
    public unsafe readonly struct PfnPD2D1EffectFactory : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown**, int> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown**, int>) _handle;
        public PfnPD2D1EffectFactory
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown**, int> ptr
        ) => _handle = ptr;

        public PfnPD2D1EffectFactory
        (
             PD2D1EffectFactory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPD2D1EffectFactory From(PD2D1EffectFactory proc) => new PfnPD2D1EffectFactory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPD2D1EffectFactory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPD2D1EffectFactory(nint pfn)
            => new PfnPD2D1EffectFactory((delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown**, int>) pfn);

        public static implicit operator PfnPD2D1EffectFactory(PD2D1EffectFactory proc)
            => new PfnPD2D1EffectFactory(proc);

        public static explicit operator PD2D1EffectFactory(PfnPD2D1EffectFactory pfn)
            => SilkMarshal.PtrToDelegate<PD2D1EffectFactory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown**, int>(PfnPD2D1EffectFactory pfn) => pfn.Handle;
        public static implicit operator PfnPD2D1EffectFactory(delegate* unmanaged[Cdecl]<Silk.NET.Core.Native.IUnknown**, int> ptr) => new PfnPD2D1EffectFactory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PD2D1EffectFactory(Silk.NET.Core.Native.IUnknown** arg0);
}

