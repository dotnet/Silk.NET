// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
        public delegate* unmanaged[Cdecl]<uint, uint, void*> Handle => (delegate* unmanaged[Cdecl]<uint, uint, void*>) _handle;
        public PfnCallocFunc
        (
            delegate* unmanaged[Cdecl]<uint, uint, void*> ptr
        ) => _handle = ptr;

        public PfnCallocFunc
        (
             CallocFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCallocFunc From(CallocFunc proc) => new PfnCallocFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCallocFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCallocFunc(nint pfn)
            => new PfnCallocFunc((delegate* unmanaged[Cdecl]<uint, uint, void*>) pfn);

        public static implicit operator PfnCallocFunc(CallocFunc proc)
            => new PfnCallocFunc(proc);

        public static explicit operator CallocFunc(PfnCallocFunc pfn)
            => SilkMarshal.PtrToDelegate<CallocFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, uint, void*>(PfnCallocFunc pfn) => pfn.Handle;
        public static implicit operator PfnCallocFunc(delegate* unmanaged[Cdecl]<uint, uint, void*> ptr) => new PfnCallocFunc(ptr);
    }

    public unsafe delegate void* CallocFunc(uint arg0, uint arg1);
}

