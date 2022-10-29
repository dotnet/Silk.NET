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
    public unsafe readonly struct PfnCreateComputePipelineAsyncCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, ComputePipeline*, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, ComputePipeline*, byte*, void*, void>) _handle;
        public PfnCreateComputePipelineAsyncCallback
        (
            delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, ComputePipeline*, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnCreateComputePipelineAsyncCallback
        (
             CreateComputePipelineAsyncCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCreateComputePipelineAsyncCallback From(CreateComputePipelineAsyncCallback proc) => new PfnCreateComputePipelineAsyncCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCreateComputePipelineAsyncCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCreateComputePipelineAsyncCallback(nint pfn)
            => new PfnCreateComputePipelineAsyncCallback((delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, ComputePipeline*, byte*, void*, void>) pfn);

        public static implicit operator PfnCreateComputePipelineAsyncCallback(CreateComputePipelineAsyncCallback proc)
            => new PfnCreateComputePipelineAsyncCallback(proc);

        public static explicit operator CreateComputePipelineAsyncCallback(PfnCreateComputePipelineAsyncCallback pfn)
            => SilkMarshal.PtrToDelegate<CreateComputePipelineAsyncCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, ComputePipeline*, byte*, void*, void>(PfnCreateComputePipelineAsyncCallback pfn) => pfn.Handle;
        public static implicit operator PfnCreateComputePipelineAsyncCallback(delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, ComputePipeline*, byte*, void*, void> ptr) => new PfnCreateComputePipelineAsyncCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CreateComputePipelineAsyncCallback(CreatePipelineAsyncStatus arg0, ComputePipeline* arg1, byte* arg2, void* arg3);
}

