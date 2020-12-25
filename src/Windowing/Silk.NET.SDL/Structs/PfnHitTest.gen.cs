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
    public readonly struct PfnHitTest : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> Handle => (delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult>) _handle;
        public PfnHitTest
        (
            delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> ptr
        ) => _handle = ptr;

        public PfnHitTest
        (
             HitTest proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr<HitTest>(proc);

        public static PfnHitTest From(HitTest proc) => new PfnHitTest(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnHitTest pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnHitTest(IntPtr pfn)
            => new PfnHitTest((delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult>) pfn);

        public static implicit operator PfnHitTest(HitTest proc)
            => new PfnHitTest((delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult>) SilkMarshal.DelegateToPtr(proc));

        public static explicit operator HitTest(PfnHitTest pfn)
            => SilkMarshal.PtrToDelegate<HitTest>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult>(PfnHitTest pfn) => pfn.Handle;
        public static implicit operator PfnHitTest(delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> ptr) => new PfnHitTest(ptr);
    }

    public unsafe delegate HitTestResult HitTest(Window* arg0, Point* arg1, void* arg2);
}

