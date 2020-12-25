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

namespace Silk.NET.Core.Native
{
    public unsafe readonly struct PfnDestructionCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, void>) _handle;
        public PfnDestructionCallback
        (
            delegate* unmanaged[Cdecl]<void*, void> ptr
        ) => _handle = ptr;

        public PfnDestructionCallback
        (
             DestructionCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDestructionCallback From(DestructionCallback proc) => new PfnDestructionCallback(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnDestructionCallback pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnDestructionCallback(IntPtr pfn)
            => new PfnDestructionCallback((delegate* unmanaged[Cdecl]<void*, void>) pfn);

        public static implicit operator PfnDestructionCallback(DestructionCallback proc)
            => new PfnDestructionCallback(proc);

        public static explicit operator DestructionCallback(PfnDestructionCallback pfn)
            => SilkMarshal.PtrToDelegate<DestructionCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void>(PfnDestructionCallback pfn) => pfn.Handle;
        public static implicit operator PfnDestructionCallback(delegate* unmanaged[Cdecl]<void*, void> ptr) => new PfnDestructionCallback(ptr);
    }

    public unsafe delegate void DestructionCallback(void* arg0);
}

