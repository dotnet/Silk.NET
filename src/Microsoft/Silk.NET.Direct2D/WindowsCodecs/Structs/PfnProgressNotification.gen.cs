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

namespace Silk.NET.WindowsCodecs
{
    public unsafe readonly struct PfnProgressNotification : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, uint, ProgressOperation, double, int> Handle => (delegate* unmanaged[Cdecl]<void*, uint, ProgressOperation, double, int>) _handle;
        public PfnProgressNotification
        (
            delegate* unmanaged[Cdecl]<void*, uint, ProgressOperation, double, int> ptr
        ) => _handle = ptr;

        public PfnProgressNotification
        (
             ProgressNotification proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnProgressNotification From(ProgressNotification proc) => new PfnProgressNotification(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnProgressNotification pfn) => (nint) pfn.Handle;
        public static explicit operator PfnProgressNotification(nint pfn)
            => new PfnProgressNotification((delegate* unmanaged[Cdecl]<void*, uint, ProgressOperation, double, int>) pfn);

        public static implicit operator PfnProgressNotification(ProgressNotification proc)
            => new PfnProgressNotification(proc);

        public static explicit operator ProgressNotification(PfnProgressNotification pfn)
            => SilkMarshal.PtrToDelegate<ProgressNotification>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint, ProgressOperation, double, int>(PfnProgressNotification pfn) => pfn.Handle;
        public static implicit operator PfnProgressNotification(delegate* unmanaged[Cdecl]<void*, uint, ProgressOperation, double, int> ptr) => new PfnProgressNotification(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int ProgressNotification(void* arg0, uint arg1, ProgressOperation arg2, double arg3);
}

