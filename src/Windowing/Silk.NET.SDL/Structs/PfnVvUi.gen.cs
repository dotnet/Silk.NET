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
    public unsafe readonly struct PfnVvUi : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, uint> Handle => (delegate* unmanaged[Cdecl]<void*, uint>) _handle;
        public PfnVvUi
        (
            delegate* unmanaged[Cdecl]<void*, uint> ptr
        ) => _handle = ptr;

        public PfnVvUi
        (
             VvUiProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVvUi From(VvUiProc proc) => new PfnVvUi(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnVvUi pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnVvUi(IntPtr pfn)
            => new PfnVvUi((delegate* unmanaged[Cdecl]<void*, uint>) pfn);

        public static implicit operator PfnVvUi(VvUiProc proc)
            => new PfnVvUi(proc);

        public static explicit operator VvUiProc(PfnVvUi pfn)
            => SilkMarshal.PtrToDelegate<VvUiProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint>(PfnVvUi pfn) => pfn.Handle;
        public static implicit operator PfnVvUi(delegate* unmanaged[Cdecl]<void*, uint> ptr) => new PfnVvUi(ptr);
    }

    public unsafe delegate uint VvUiProc(void* arg0);
}

