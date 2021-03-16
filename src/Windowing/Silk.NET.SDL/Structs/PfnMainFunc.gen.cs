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
    public unsafe readonly struct PfnMainFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<int, byte**, int> Handle => (delegate* unmanaged[Cdecl]<int, byte**, int>) _handle;
        public PfnMainFunc
        (
            delegate* unmanaged[Cdecl]<int, byte**, int> ptr
        ) => _handle = ptr;

        public PfnMainFunc
        (
             MainFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnMainFunc From(MainFunc proc) => new PfnMainFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnMainFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnMainFunc(nint pfn)
            => new PfnMainFunc((delegate* unmanaged[Cdecl]<int, byte**, int>) pfn);

        public static implicit operator PfnMainFunc(MainFunc proc)
            => new PfnMainFunc(proc);

        public static explicit operator MainFunc(PfnMainFunc pfn)
            => SilkMarshal.PtrToDelegate<MainFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<int, byte**, int>(PfnMainFunc pfn) => pfn.Handle;
        public static implicit operator PfnMainFunc(delegate* unmanaged[Cdecl]<int, byte**, int> ptr) => new PfnMainFunc(ptr);
    }

    public unsafe delegate int MainFunc(int arg0, byte** arg1);
}

