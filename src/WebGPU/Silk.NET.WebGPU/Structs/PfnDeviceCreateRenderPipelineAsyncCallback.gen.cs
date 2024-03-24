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
    public unsafe readonly struct PfnDeviceCreateRenderPipelineAsyncCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void>) _handle;
        public PfnDeviceCreateRenderPipelineAsyncCallback
        (
            delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnDeviceCreateRenderPipelineAsyncCallback
        (
             DeviceCreateRenderPipelineAsyncCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDeviceCreateRenderPipelineAsyncCallback From(DeviceCreateRenderPipelineAsyncCallback proc) => new PfnDeviceCreateRenderPipelineAsyncCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDeviceCreateRenderPipelineAsyncCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDeviceCreateRenderPipelineAsyncCallback(nint pfn)
            => new PfnDeviceCreateRenderPipelineAsyncCallback((delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void>) pfn);

        public static implicit operator PfnDeviceCreateRenderPipelineAsyncCallback(DeviceCreateRenderPipelineAsyncCallback proc)
            => new PfnDeviceCreateRenderPipelineAsyncCallback(proc);

        public static explicit operator DeviceCreateRenderPipelineAsyncCallback(PfnDeviceCreateRenderPipelineAsyncCallback pfn)
            => SilkMarshal.PtrToDelegate<DeviceCreateRenderPipelineAsyncCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void>(PfnDeviceCreateRenderPipelineAsyncCallback pfn) => pfn.Handle;
        public static implicit operator PfnDeviceCreateRenderPipelineAsyncCallback(delegate* unmanaged[Cdecl]<CreatePipelineAsyncStatus, RenderPipeline*, byte*, void*, void> ptr) => new PfnDeviceCreateRenderPipelineAsyncCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DeviceCreateRenderPipelineAsyncCallback(CreatePipelineAsyncStatus arg0, RenderPipeline* arg1, byte* arg2, void* arg3);
}

