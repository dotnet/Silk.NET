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
    public unsafe readonly struct PfnWindowsMessageHook : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void*, uint, ulong, long, void> Handle => (delegate* unmanaged[Cdecl]<void*, void*, uint, ulong, long, void>) _handle;
        public PfnWindowsMessageHook
        (
            delegate* unmanaged[Cdecl]<void*, void*, uint, ulong, long, void> ptr
        ) => _handle = ptr;

        public PfnWindowsMessageHook
        (
             WindowsMessageHook proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnWindowsMessageHook From(WindowsMessageHook proc) => new PfnWindowsMessageHook(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnWindowsMessageHook pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnWindowsMessageHook(IntPtr pfn)
            => new PfnWindowsMessageHook((delegate* unmanaged[Cdecl]<void*, void*, uint, ulong, long, void>) pfn);

        public static implicit operator PfnWindowsMessageHook(WindowsMessageHook proc)
            => new PfnWindowsMessageHook(proc);

        public static explicit operator WindowsMessageHook(PfnWindowsMessageHook pfn)
            => SilkMarshal.PtrToDelegate<WindowsMessageHook>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*, uint, ulong, long, void>(PfnWindowsMessageHook pfn) => pfn.Handle;
        public static implicit operator PfnWindowsMessageHook(delegate* unmanaged[Cdecl]<void*, void*, uint, ulong, long, void> ptr) => new PfnWindowsMessageHook(ptr);
    }

    public unsafe delegate void WindowsMessageHook(void* arg0, void* arg1, uint arg2, ulong arg3, long arg4);
}

