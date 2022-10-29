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

namespace Silk.NET.WebGPU
{
    public unsafe readonly struct PfnQueueWorkDoneCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void> Handle => (delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void>) _handle;
        public PfnQueueWorkDoneCallback
        (
            delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void> ptr
        ) => _handle = ptr;

        public PfnQueueWorkDoneCallback
        (
             QueueWorkDoneCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnQueueWorkDoneCallback From(QueueWorkDoneCallback proc) => new PfnQueueWorkDoneCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnQueueWorkDoneCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnQueueWorkDoneCallback(nint pfn)
            => new PfnQueueWorkDoneCallback((delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void>) pfn);

        public static implicit operator PfnQueueWorkDoneCallback(QueueWorkDoneCallback proc)
            => new PfnQueueWorkDoneCallback(proc);

        public static explicit operator QueueWorkDoneCallback(PfnQueueWorkDoneCallback pfn)
            => SilkMarshal.PtrToDelegate<QueueWorkDoneCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void>(PfnQueueWorkDoneCallback pfn) => pfn.Handle;
        public static implicit operator PfnQueueWorkDoneCallback(delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void> ptr) => new PfnQueueWorkDoneCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void QueueWorkDoneCallback(QueueWorkDoneStatus arg0, void* arg1);
}

