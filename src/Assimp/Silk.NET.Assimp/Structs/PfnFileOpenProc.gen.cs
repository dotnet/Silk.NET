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
    public unsafe readonly struct PfnFileOpenProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FileIO*, byte*, byte*, File*> Handle => (delegate* unmanaged[Cdecl]<FileIO*, byte*, byte*, File*>) _handle;
        public PfnFileOpenProc
        (
            delegate* unmanaged[Cdecl]<FileIO*, byte*, byte*, File*> ptr
        ) => _handle = ptr;

        public PfnFileOpenProc
        (
             FileOpenProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileOpenProc From(FileOpenProc proc) => new PfnFileOpenProc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFileOpenProc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFileOpenProc(nint pfn)
            => new PfnFileOpenProc((delegate* unmanaged[Cdecl]<FileIO*, byte*, byte*, File*>) pfn);

        public static implicit operator PfnFileOpenProc(FileOpenProc proc)
            => new PfnFileOpenProc(proc);

        public static explicit operator FileOpenProc(PfnFileOpenProc pfn)
            => SilkMarshal.PtrToDelegate<FileOpenProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FileIO*, byte*, byte*, File*>(PfnFileOpenProc pfn) => pfn.Handle;
        public static implicit operator PfnFileOpenProc(delegate* unmanaged[Cdecl]<FileIO*, byte*, byte*, File*> ptr) => new PfnFileOpenProc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate File* FileOpenProc(FileIO* arg0, byte* arg1, byte* arg2);
}

