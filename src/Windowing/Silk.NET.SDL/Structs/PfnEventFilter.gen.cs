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
    public unsafe readonly struct PfnEventFilter : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, Event*, int> Handle => (delegate* unmanaged[Cdecl]<void*, Event*, int>) _handle;
        public PfnEventFilter
        (
            delegate* unmanaged[Cdecl]<void*, Event*, int> ptr
        ) => _handle = ptr;

        public PfnEventFilter
        (
             EventFilter proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnEventFilter From(EventFilter proc) => new PfnEventFilter(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnEventFilter pfn) => (nint) pfn.Handle;
        public static explicit operator PfnEventFilter(nint pfn)
            => new PfnEventFilter((delegate* unmanaged[Cdecl]<void*, Event*, int>) pfn);

        public static implicit operator PfnEventFilter(EventFilter proc)
            => new PfnEventFilter(proc);

        public static explicit operator EventFilter(PfnEventFilter pfn)
            => SilkMarshal.PtrToDelegate<EventFilter>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, Event*, int>(PfnEventFilter pfn) => pfn.Handle;
        public static implicit operator PfnEventFilter(delegate* unmanaged[Cdecl]<void*, Event*, int> ptr) => new PfnEventFilter(ptr);
    }

    public unsafe delegate int EventFilter(void* arg0, Event* arg1);
}

