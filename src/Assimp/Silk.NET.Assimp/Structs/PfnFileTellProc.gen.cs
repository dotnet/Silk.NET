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
    public readonly struct PfnFileTellProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<aiFile*, uint> Handle => (delegate* unmanaged[Cdecl]<aiFile*, uint>) _handle;
        public PfnFileTellProc
        (
            delegate* unmanaged[Cdecl]<aiFile*, uint> ptr
        ) => _handle = ptr;

        public PfnFileTellProc
        (
             FileTellProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr<FileTellProc>(proc);

        public static PfnFileTellProc From(FileTellProc proc) => new PfnFileTellProc(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnFileTellProc pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnFileTellProc(IntPtr pfn)
            => new PfnFileTellProc((delegate* unmanaged[Cdecl]<aiFile*, uint>) pfn);

        public static implicit operator PfnFileTellProc(FileTellProc proc)
            => new PfnFileTellProc((delegate* unmanaged[Cdecl]<aiFile*, uint>) SilkMarshal.DelegateToPtr(proc));

        public static explicit operator FileTellProc(PfnFileTellProc pfn)
            => SilkMarshal.PtrToDelegate<FileTellProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<aiFile*, uint>(PfnFileTellProc pfn) => pfn.Handle;
        public static implicit operator PfnFileTellProc(delegate* unmanaged[Cdecl]<aiFile*, uint> ptr) => new PfnFileTellProc(ptr);
    }

    public delegate unsafe uint FileTellProc(File* arg0);
}

