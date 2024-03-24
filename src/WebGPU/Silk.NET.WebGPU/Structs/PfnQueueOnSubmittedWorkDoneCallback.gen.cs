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
    public unsafe readonly struct PfnQueueOnSubmittedWorkDoneCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void> Handle => (delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void>) _handle;
        public PfnQueueOnSubmittedWorkDoneCallback
        (
            delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void> ptr
        ) => _handle = ptr;

        public PfnQueueOnSubmittedWorkDoneCallback
        (
             QueueOnSubmittedWorkDoneCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnQueueOnSubmittedWorkDoneCallback From(QueueOnSubmittedWorkDoneCallback proc) => new PfnQueueOnSubmittedWorkDoneCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnQueueOnSubmittedWorkDoneCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnQueueOnSubmittedWorkDoneCallback(nint pfn)
            => new PfnQueueOnSubmittedWorkDoneCallback((delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void>) pfn);

        public static implicit operator PfnQueueOnSubmittedWorkDoneCallback(QueueOnSubmittedWorkDoneCallback proc)
            => new PfnQueueOnSubmittedWorkDoneCallback(proc);

        public static explicit operator QueueOnSubmittedWorkDoneCallback(PfnQueueOnSubmittedWorkDoneCallback pfn)
            => SilkMarshal.PtrToDelegate<QueueOnSubmittedWorkDoneCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void>(PfnQueueOnSubmittedWorkDoneCallback pfn) => pfn.Handle;
        public static implicit operator PfnQueueOnSubmittedWorkDoneCallback(delegate* unmanaged[Cdecl]<QueueWorkDoneStatus, void*, void> ptr) => new PfnQueueOnSubmittedWorkDoneCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void QueueOnSubmittedWorkDoneCallback(QueueWorkDoneStatus arg0, void* arg1);
}

