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

namespace Silk.NET.SDL
{
    public unsafe readonly struct PfnLogOutputFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, int, LogPriority, byte*, void> Handle => (delegate* unmanaged[Cdecl]<void*, int, LogPriority, byte*, void>) _handle;
        public PfnLogOutputFunction
        (
            delegate* unmanaged[Cdecl]<void*, int, LogPriority, byte*, void> ptr
        ) => _handle = ptr;

        public PfnLogOutputFunction
        (
             LogOutputFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnLogOutputFunction From(LogOutputFunction proc) => new PfnLogOutputFunction(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnLogOutputFunction pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnLogOutputFunction(IntPtr pfn)
            => new PfnLogOutputFunction((delegate* unmanaged[Cdecl]<void*, int, LogPriority, byte*, void>) pfn);

        public static implicit operator PfnLogOutputFunction(LogOutputFunction proc)
            => new PfnLogOutputFunction(proc);

        public static explicit operator LogOutputFunction(PfnLogOutputFunction pfn)
            => SilkMarshal.PtrToDelegate<LogOutputFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, int, LogPriority, byte*, void>(PfnLogOutputFunction pfn) => pfn.Handle;
        public static implicit operator PfnLogOutputFunction(delegate* unmanaged[Cdecl]<void*, int, LogPriority, byte*, void> ptr) => new PfnLogOutputFunction(ptr);
    }

    public unsafe delegate void LogOutputFunction(void* arg0, int arg1, LogPriority arg2, byte* arg3);
}

