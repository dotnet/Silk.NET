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
    public readonly struct PfnFileCloseProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<aiFileIO*, aiFile*, void> Handle => (delegate* unmanaged[Cdecl]<aiFileIO*, aiFile*, void>) _handle;
        public PfnFileCloseProc
        (
            delegate* unmanaged[Cdecl]<aiFileIO*, aiFile*, void> ptr
        ) => _handle = ptr;

        public PfnFileCloseProc
        (
             FileCloseProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr<FileCloseProc>(proc);

        public static PfnFileCloseProc From(FileCloseProc proc) => new PfnFileCloseProc(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnFileCloseProc pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnFileCloseProc(IntPtr pfn)
            => new PfnFileCloseProc((delegate* unmanaged[Cdecl]<aiFileIO*, aiFile*, void>) pfn);

        public static implicit operator PfnFileCloseProc(FileCloseProc proc)
            => new PfnFileCloseProc((delegate* unmanaged[Cdecl]<aiFileIO*, aiFile*, void>) SilkMarshal.DelegateToPtr(proc));

        public static explicit operator FileCloseProc(PfnFileCloseProc pfn)
            => SilkMarshal.PtrToDelegate<FileCloseProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<aiFileIO*, aiFile*, void>(PfnFileCloseProc pfn) => pfn.Handle;
        public static implicit operator PfnFileCloseProc(delegate* unmanaged[Cdecl]<aiFileIO*, aiFile*, void> ptr) => new PfnFileCloseProc(ptr);
    }

    public delegate unsafe void FileCloseProc(FileIO* arg0, File* arg1);
}

