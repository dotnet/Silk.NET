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
    public unsafe readonly struct PfnFileReadProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<File*, byte*, uint, uint, uint> Handle => (delegate* unmanaged[Cdecl]<File*, byte*, uint, uint, uint>) _handle;
        public PfnFileReadProc
        (
            delegate* unmanaged[Cdecl]<File*, byte*, uint, uint, uint> ptr
        ) => _handle = ptr;

        public PfnFileReadProc
        (
             FileReadProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileReadProc From(FileReadProc proc) => new PfnFileReadProc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFileReadProc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFileReadProc(nint pfn)
            => new PfnFileReadProc((delegate* unmanaged[Cdecl]<File*, byte*, uint, uint, uint>) pfn);

        public static implicit operator PfnFileReadProc(FileReadProc proc)
            => new PfnFileReadProc(proc);

        public static explicit operator FileReadProc(PfnFileReadProc pfn)
            => SilkMarshal.PtrToDelegate<FileReadProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<File*, byte*, uint, uint, uint>(PfnFileReadProc pfn) => pfn.Handle;
        public static implicit operator PfnFileReadProc(delegate* unmanaged[Cdecl]<File*, byte*, uint, uint, uint> ptr) => new PfnFileReadProc(ptr);
    }

    public unsafe delegate uint FileReadProc(File* arg0, byte* arg1, uint arg2, uint arg3);
}

