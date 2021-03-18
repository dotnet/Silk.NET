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

namespace Silk.NET.Assimp
{
    public unsafe readonly struct PfnFileTellProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<File*, nuint> Handle => (delegate* unmanaged[Cdecl]<File*, nuint>) _handle;
        public PfnFileTellProc
        (
            delegate* unmanaged[Cdecl]<File*, nuint> ptr
        ) => _handle = ptr;

        public PfnFileTellProc
        (
             FileTellProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileTellProc From(FileTellProc proc) => new PfnFileTellProc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFileTellProc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFileTellProc(nint pfn)
            => new PfnFileTellProc((delegate* unmanaged[Cdecl]<File*, nuint>) pfn);

        public static implicit operator PfnFileTellProc(FileTellProc proc)
            => new PfnFileTellProc(proc);

        public static explicit operator FileTellProc(PfnFileTellProc pfn)
            => SilkMarshal.PtrToDelegate<FileTellProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<File*, nuint>(PfnFileTellProc pfn) => pfn.Handle;
        public static implicit operator PfnFileTellProc(delegate* unmanaged[Cdecl]<File*, nuint> ptr) => new PfnFileTellProc(ptr);
    }

    public unsafe delegate nuint FileTellProc(File* arg0);
}

