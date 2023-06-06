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

namespace Silk.NET.Shaderc
{
    public unsafe readonly struct PfnIncludeResultReleaseFn : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, IncludeResult*, void> Handle => (delegate* unmanaged[Cdecl]<void*, IncludeResult*, void>) _handle;
        public PfnIncludeResultReleaseFn
        (
            delegate* unmanaged[Cdecl]<void*, IncludeResult*, void> ptr
        ) => _handle = ptr;

        public PfnIncludeResultReleaseFn
        (
             IncludeResultReleaseFn proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnIncludeResultReleaseFn From(IncludeResultReleaseFn proc) => new PfnIncludeResultReleaseFn(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnIncludeResultReleaseFn pfn) => (nint) pfn.Handle;
        public static explicit operator PfnIncludeResultReleaseFn(nint pfn)
            => new PfnIncludeResultReleaseFn((delegate* unmanaged[Cdecl]<void*, IncludeResult*, void>) pfn);

        public static implicit operator PfnIncludeResultReleaseFn(IncludeResultReleaseFn proc)
            => new PfnIncludeResultReleaseFn(proc);

        public static explicit operator IncludeResultReleaseFn(PfnIncludeResultReleaseFn pfn)
            => SilkMarshal.PtrToDelegate<IncludeResultReleaseFn>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, IncludeResult*, void>(PfnIncludeResultReleaseFn pfn) => pfn.Handle;
        public static implicit operator PfnIncludeResultReleaseFn(delegate* unmanaged[Cdecl]<void*, IncludeResult*, void> ptr) => new PfnIncludeResultReleaseFn(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void IncludeResultReleaseFn(void* arg0, IncludeResult* arg1);
}

