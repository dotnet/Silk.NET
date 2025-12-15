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

namespace Silk.NET.Direct3D12
{
    public unsafe readonly struct PfnPipelineStateFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, uint, uint, PipelineStateStreamDesc*, void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, uint, uint, PipelineStateStreamDesc*, void*, void>) _handle;
        public PfnPipelineStateFunc
        (
            delegate* unmanaged[Cdecl]<void*, uint, uint, PipelineStateStreamDesc*, void*, void> ptr
        ) => _handle = ptr;

        public PfnPipelineStateFunc
        (
             PipelineStateFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPipelineStateFunc From(PipelineStateFunc proc) => new PfnPipelineStateFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPipelineStateFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPipelineStateFunc(nint pfn)
            => new PfnPipelineStateFunc((delegate* unmanaged[Cdecl]<void*, uint, uint, PipelineStateStreamDesc*, void*, void>) pfn);

        public static implicit operator PfnPipelineStateFunc(PipelineStateFunc proc)
            => new PfnPipelineStateFunc(proc);

        public static explicit operator PipelineStateFunc(PfnPipelineStateFunc pfn)
            => SilkMarshal.PtrToDelegate<PipelineStateFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint, uint, PipelineStateStreamDesc*, void*, void>(PfnPipelineStateFunc pfn) => pfn.Handle;
        public static implicit operator PfnPipelineStateFunc(delegate* unmanaged[Cdecl]<void*, uint, uint, PipelineStateStreamDesc*, void*, void> ptr) => new PfnPipelineStateFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PipelineStateFunc(void* arg0, uint arg1, uint arg2, PipelineStateStreamDesc* arg3, void* arg4);
}

