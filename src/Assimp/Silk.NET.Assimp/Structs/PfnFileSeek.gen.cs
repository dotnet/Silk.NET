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
    public unsafe readonly struct PfnFileSeek : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<File*, nuint, Origin, Return> Handle => (delegate* unmanaged[Cdecl]<File*, nuint, Origin, Return>) _handle;
        public PfnFileSeek
        (
            delegate* unmanaged[Cdecl]<File*, nuint, Origin, Return> ptr
        ) => _handle = ptr;

        public PfnFileSeek
        (
             FileSeek proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileSeek From(FileSeek proc) => new PfnFileSeek(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFileSeek pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFileSeek(nint pfn)
            => new PfnFileSeek((delegate* unmanaged[Cdecl]<File*, nuint, Origin, Return>) pfn);

        public static implicit operator PfnFileSeek(FileSeek proc)
            => new PfnFileSeek(proc);

        public static explicit operator FileSeek(PfnFileSeek pfn)
            => SilkMarshal.PtrToDelegate<FileSeek>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<File*, nuint, Origin, Return>(PfnFileSeek pfn) => pfn.Handle;
        public static implicit operator PfnFileSeek(delegate* unmanaged[Cdecl]<File*, nuint, Origin, Return> ptr) => new PfnFileSeek(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Return FileSeek(File* arg0, nuint arg1, Origin arg2);
}

