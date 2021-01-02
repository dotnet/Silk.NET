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
    public unsafe readonly struct PfnMallocFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, void*> Handle => (delegate* unmanaged[Cdecl]<uint, void*>) _handle;
        public PfnMallocFunc
        (
            delegate* unmanaged[Cdecl]<uint, void*> ptr
        ) => _handle = ptr;

        public PfnMallocFunc
        (
             MallocFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnMallocFunc From(MallocFunc proc) => new PfnMallocFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnMallocFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnMallocFunc(nint pfn)
            => new PfnMallocFunc((delegate* unmanaged[Cdecl]<uint, void*>) pfn);

        public static implicit operator PfnMallocFunc(MallocFunc proc)
            => new PfnMallocFunc(proc);

        public static explicit operator MallocFunc(PfnMallocFunc pfn)
            => SilkMarshal.PtrToDelegate<MallocFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, void*>(PfnMallocFunc pfn) => pfn.Handle;
        public static implicit operator PfnMallocFunc(delegate* unmanaged[Cdecl]<uint, void*> ptr) => new PfnMallocFunc(ptr);
    }

    public unsafe delegate void* MallocFunc(uint arg0);
}

