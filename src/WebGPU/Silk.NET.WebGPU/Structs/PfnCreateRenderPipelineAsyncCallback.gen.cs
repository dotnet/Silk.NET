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
    public unsafe readonly struct PfnCreateRenderPipelineAsyncCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void>) _handle;
        public PfnCreateRenderPipelineAsyncCallback
        (
            delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnCreateRenderPipelineAsyncCallback
        (
             CreateRenderPipelineAsyncCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnCreateRenderPipelineAsyncCallback From(CreateRenderPipelineAsyncCallback proc) => new PfnCreateRenderPipelineAsyncCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnCreateRenderPipelineAsyncCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnCreateRenderPipelineAsyncCallback(nint pfn)
            => new PfnCreateRenderPipelineAsyncCallback((delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void>) pfn);

        public static implicit operator PfnCreateRenderPipelineAsyncCallback(CreateRenderPipelineAsyncCallback proc)
            => new PfnCreateRenderPipelineAsyncCallback(proc);

        public static explicit operator CreateRenderPipelineAsyncCallback(PfnCreateRenderPipelineAsyncCallback pfn)
            => SilkMarshal.PtrToDelegate<CreateRenderPipelineAsyncCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void>(PfnCreateRenderPipelineAsyncCallback pfn) => pfn.Handle;
        public static implicit operator PfnCreateRenderPipelineAsyncCallback(delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void> ptr) => new PfnCreateRenderPipelineAsyncCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void CreateRenderPipelineAsyncCallback(CreatePipelineAsyncStatus arg0, RenderPipeline* arg1, byte* arg2, void* arg3);
}

