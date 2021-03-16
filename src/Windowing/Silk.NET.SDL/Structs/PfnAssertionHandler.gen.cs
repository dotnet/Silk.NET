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
    public unsafe readonly struct PfnAssertionHandler : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<AssertData*, void*, AssertState> Handle => (delegate* unmanaged[Cdecl]<AssertData*, void*, AssertState>) _handle;
        public PfnAssertionHandler
        (
            delegate* unmanaged[Cdecl]<AssertData*, void*, AssertState> ptr
        ) => _handle = ptr;

        public PfnAssertionHandler
        (
             AssertionHandler proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnAssertionHandler From(AssertionHandler proc) => new PfnAssertionHandler(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnAssertionHandler pfn) => (nint) pfn.Handle;
        public static explicit operator PfnAssertionHandler(nint pfn)
            => new PfnAssertionHandler((delegate* unmanaged[Cdecl]<AssertData*, void*, AssertState>) pfn);

        public static implicit operator PfnAssertionHandler(AssertionHandler proc)
            => new PfnAssertionHandler(proc);

        public static explicit operator AssertionHandler(PfnAssertionHandler pfn)
            => SilkMarshal.PtrToDelegate<AssertionHandler>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<AssertData*, void*, AssertState>(PfnAssertionHandler pfn) => pfn.Handle;
        public static implicit operator PfnAssertionHandler(delegate* unmanaged[Cdecl]<AssertData*, void*, AssertState> ptr) => new PfnAssertionHandler(ptr);
    }

    public unsafe delegate AssertState AssertionHandler(AssertData* arg0, void* arg1);
}

