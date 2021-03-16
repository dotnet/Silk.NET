// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    public unsafe readonly struct PfnFileCloseProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FileIO*, File*, void> Handle => (delegate* unmanaged[Cdecl]<FileIO*, File*, void>) _handle;
        public PfnFileCloseProc
        (
            delegate* unmanaged[Cdecl]<FileIO*, File*, void> ptr
        ) => _handle = ptr;

        public PfnFileCloseProc
        (
             FileCloseProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileCloseProc From(FileCloseProc proc) => new PfnFileCloseProc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFileCloseProc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFileCloseProc(nint pfn)
            => new PfnFileCloseProc((delegate* unmanaged[Cdecl]<FileIO*, File*, void>) pfn);

        public static implicit operator PfnFileCloseProc(FileCloseProc proc)
            => new PfnFileCloseProc(proc);

        public static explicit operator FileCloseProc(PfnFileCloseProc pfn)
            => SilkMarshal.PtrToDelegate<FileCloseProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FileIO*, File*, void>(PfnFileCloseProc pfn) => pfn.Handle;
        public static implicit operator PfnFileCloseProc(delegate* unmanaged[Cdecl]<FileIO*, File*, void> ptr) => new PfnFileCloseProc(ptr);
    }

    public unsafe delegate void FileCloseProc(FileIO* arg0, File* arg1);
}

