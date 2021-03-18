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
    public unsafe readonly struct PfnFileReadProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<File*, byte*, nuint, nuint, nuint> Handle => (delegate* unmanaged[Cdecl]<File*, byte*, nuint, nuint, nuint>) _handle;
        public PfnFileReadProc
        (
            delegate* unmanaged[Cdecl]<File*, byte*, nuint, nuint, nuint> ptr
        ) => _handle = ptr;

        public PfnFileReadProc
        (
             FileReadProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileReadProc From(FileReadProc proc) => new PfnFileReadProc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFileReadProc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFileReadProc(nint pfn)
            => new PfnFileReadProc((delegate* unmanaged[Cdecl]<File*, byte*, nuint, nuint, nuint>) pfn);

        public static implicit operator PfnFileReadProc(FileReadProc proc)
            => new PfnFileReadProc(proc);

        public static explicit operator FileReadProc(PfnFileReadProc pfn)
            => SilkMarshal.PtrToDelegate<FileReadProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<File*, byte*, nuint, nuint, nuint>(PfnFileReadProc pfn) => pfn.Handle;
        public static implicit operator PfnFileReadProc(delegate* unmanaged[Cdecl]<File*, byte*, nuint, nuint, nuint> ptr) => new PfnFileReadProc(ptr);
    }

    public unsafe delegate nuint FileReadProc(File* arg0, byte* arg1, nuint arg2, nuint arg3);
}

