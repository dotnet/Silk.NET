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
    public unsafe readonly struct PfnSDLCurrentBeginThread : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, uint> Handle => (delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, uint>) _handle;
        public PfnSDLCurrentBeginThread
        (
            delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, uint> ptr
        ) => _handle = ptr;

        public PfnSDLCurrentBeginThread
        (
             SDLCurrentBeginThread proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnSDLCurrentBeginThread From(SDLCurrentBeginThread proc) => new PfnSDLCurrentBeginThread(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnSDLCurrentBeginThread pfn) => (nint) pfn.Handle;
        public static explicit operator PfnSDLCurrentBeginThread(nint pfn)
            => new PfnSDLCurrentBeginThread((delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, uint>) pfn);

        public static implicit operator PfnSDLCurrentBeginThread(SDLCurrentBeginThread proc)
            => new PfnSDLCurrentBeginThread(proc);

        public static explicit operator SDLCurrentBeginThread(PfnSDLCurrentBeginThread pfn)
            => SilkMarshal.PtrToDelegate<SDLCurrentBeginThread>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, uint>(PfnSDLCurrentBeginThread pfn) => pfn.Handle;
        public static implicit operator PfnSDLCurrentBeginThread(delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, uint> ptr) => new PfnSDLCurrentBeginThread(ptr);
    }

    public unsafe delegate uint SDLCurrentBeginThread(void* arg0, uint arg1, PfnVvUi arg2, void* arg3, uint arg4, uint* arg5);
}

