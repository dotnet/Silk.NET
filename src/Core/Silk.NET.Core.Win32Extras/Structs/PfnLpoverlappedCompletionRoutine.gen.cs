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

namespace Silk.NET.Core.Win32Extras
{
    public unsafe readonly struct PfnLpoverlappedCompletionRoutine : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<int, int, Overlapped*, void> Handle => (delegate* unmanaged[Cdecl]<int, int, Overlapped*, void>) _handle;
        public PfnLpoverlappedCompletionRoutine
        (
            delegate* unmanaged[Cdecl]<int, int, Overlapped*, void> ptr
        ) => _handle = ptr;

        public PfnLpoverlappedCompletionRoutine
        (
             LpoverlappedCompletionRoutine proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnLpoverlappedCompletionRoutine From(LpoverlappedCompletionRoutine proc) => new PfnLpoverlappedCompletionRoutine(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnLpoverlappedCompletionRoutine pfn) => (nint) pfn.Handle;
        public static explicit operator PfnLpoverlappedCompletionRoutine(nint pfn)
            => new PfnLpoverlappedCompletionRoutine((delegate* unmanaged[Cdecl]<int, int, Overlapped*, void>) pfn);

        public static implicit operator PfnLpoverlappedCompletionRoutine(LpoverlappedCompletionRoutine proc)
            => new PfnLpoverlappedCompletionRoutine(proc);

        public static explicit operator LpoverlappedCompletionRoutine(PfnLpoverlappedCompletionRoutine pfn)
            => SilkMarshal.PtrToDelegate<LpoverlappedCompletionRoutine>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<int, int, Overlapped*, void>(PfnLpoverlappedCompletionRoutine pfn) => pfn.Handle;
        public static implicit operator PfnLpoverlappedCompletionRoutine(delegate* unmanaged[Cdecl]<int, int, Overlapped*, void> ptr) => new PfnLpoverlappedCompletionRoutine(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void LpoverlappedCompletionRoutine(int arg0, int arg1, Overlapped* arg2);
}

