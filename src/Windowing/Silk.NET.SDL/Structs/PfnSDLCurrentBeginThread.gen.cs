// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
        public delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, nuint> Handle => (delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, nuint>) _handle;
        public PfnSDLCurrentBeginThread
        (
            delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, nuint> ptr
        ) => _handle = ptr;

        public PfnSDLCurrentBeginThread
        (
             SDLCurrentBeginThread proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnSDLCurrentBeginThread From(SDLCurrentBeginThread proc) => new PfnSDLCurrentBeginThread(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnSDLCurrentBeginThread pfn) => (nint) pfn.Handle;
        public static explicit operator PfnSDLCurrentBeginThread(nint pfn)
            => new PfnSDLCurrentBeginThread((delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, nuint>) pfn);

        public static implicit operator PfnSDLCurrentBeginThread(SDLCurrentBeginThread proc)
            => new PfnSDLCurrentBeginThread(proc);

        public static explicit operator SDLCurrentBeginThread(PfnSDLCurrentBeginThread pfn)
            => SilkMarshal.PtrToDelegate<SDLCurrentBeginThread>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, nuint>(PfnSDLCurrentBeginThread pfn) => pfn.Handle;
        public static implicit operator PfnSDLCurrentBeginThread(delegate* unmanaged[Cdecl]<void*, uint, PfnVvUi, void*, uint, uint*, nuint> ptr) => new PfnSDLCurrentBeginThread(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate nuint SDLCurrentBeginThread(void* arg0, uint arg1, PfnVvUi arg2, void* arg3, uint arg4, uint* arg5);
}

