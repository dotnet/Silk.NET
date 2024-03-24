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
    public unsafe readonly struct PfnShaderModuleGetCompilationInfoCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void> Handle => (delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void>) _handle;
        public PfnShaderModuleGetCompilationInfoCallback
        (
            delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void> ptr
        ) => _handle = ptr;

        public PfnShaderModuleGetCompilationInfoCallback
        (
             ShaderModuleGetCompilationInfoCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnShaderModuleGetCompilationInfoCallback From(ShaderModuleGetCompilationInfoCallback proc) => new PfnShaderModuleGetCompilationInfoCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnShaderModuleGetCompilationInfoCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnShaderModuleGetCompilationInfoCallback(nint pfn)
            => new PfnShaderModuleGetCompilationInfoCallback((delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void>) pfn);

        public static implicit operator PfnShaderModuleGetCompilationInfoCallback(ShaderModuleGetCompilationInfoCallback proc)
            => new PfnShaderModuleGetCompilationInfoCallback(proc);

        public static explicit operator ShaderModuleGetCompilationInfoCallback(PfnShaderModuleGetCompilationInfoCallback pfn)
            => SilkMarshal.PtrToDelegate<ShaderModuleGetCompilationInfoCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void>(PfnShaderModuleGetCompilationInfoCallback pfn) => pfn.Handle;
        public static implicit operator PfnShaderModuleGetCompilationInfoCallback(delegate* unmanaged[Cdecl]<CompilationInfoRequestStatus, CompilationInfo*, void*, void> ptr) => new PfnShaderModuleGetCompilationInfoCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ShaderModuleGetCompilationInfoCallback(CompilationInfoRequestStatus arg0, CompilationInfo* arg1, void* arg2);
}

