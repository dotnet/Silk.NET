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
    public readonly struct PfnFileOpenProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<aiFileIO*, byte*, byte*, aiFile*> Handle => (delegate* unmanaged[Cdecl]<aiFileIO*, byte*, byte*, aiFile*>) _handle;
        public PfnFileOpenProc
        (
            delegate* unmanaged[Cdecl]<aiFileIO*, byte*, byte*, aiFile*> ptr
        ) => _handle = ptr;

        public PfnFileOpenProc
        (
             FileOpenProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr<FileOpenProc>(proc);

        public static PfnFileOpenProc From(FileOpenProc proc) => new PfnFileOpenProc(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnFileOpenProc pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnFileOpenProc(IntPtr pfn)
            => new PfnFileOpenProc((delegate* unmanaged[Cdecl]<aiFileIO*, byte*, byte*, aiFile*>) pfn);

        public static implicit operator PfnFileOpenProc(FileOpenProc proc)
            => new PfnFileOpenProc((delegate* unmanaged[Cdecl]<aiFileIO*, byte*, byte*, aiFile*>) SilkMarshal.DelegateToPtr(proc));

        public static explicit operator FileOpenProc(PfnFileOpenProc pfn)
            => SilkMarshal.PtrToDelegate<FileOpenProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<aiFileIO*, byte*, byte*, aiFile*>(PfnFileOpenProc pfn) => pfn.Handle;
        public static implicit operator PfnFileOpenProc(delegate* unmanaged[Cdecl]<aiFileIO*, byte*, byte*, aiFile*> ptr) => new PfnFileOpenProc(ptr);
    }

    public delegate unsafe File* FileOpenProc(FileIO* arg0, byte* arg1, byte* arg2);
}

