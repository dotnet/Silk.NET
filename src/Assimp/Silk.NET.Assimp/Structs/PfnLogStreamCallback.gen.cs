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
    public unsafe readonly struct PfnLogStreamCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<byte*, byte*, void> Handle => (delegate* unmanaged[Cdecl]<byte*, byte*, void>) _handle;
        public PfnLogStreamCallback
        (
            delegate* unmanaged[Cdecl]<byte*, byte*, void> ptr
        ) => _handle = ptr;

        public PfnLogStreamCallback
        (
             LogStreamCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnLogStreamCallback From(LogStreamCallback proc) => new PfnLogStreamCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnLogStreamCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnLogStreamCallback(nint pfn)
            => new PfnLogStreamCallback((delegate* unmanaged[Cdecl]<byte*, byte*, void>) pfn);

        public static implicit operator PfnLogStreamCallback(LogStreamCallback proc)
            => new PfnLogStreamCallback(proc);

        public static explicit operator LogStreamCallback(PfnLogStreamCallback pfn)
            => SilkMarshal.PtrToDelegate<LogStreamCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<byte*, byte*, void>(PfnLogStreamCallback pfn) => pfn.Handle;
        public static implicit operator PfnLogStreamCallback(delegate* unmanaged[Cdecl]<byte*, byte*, void> ptr) => new PfnLogStreamCallback(ptr);
    }

    public unsafe delegate void LogStreamCallback(byte* arg0, byte* arg1);
}

