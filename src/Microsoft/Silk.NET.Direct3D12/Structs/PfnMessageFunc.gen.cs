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

namespace Silk.NET.Direct3D12
{
    public unsafe readonly struct PfnMessageFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<MessageCategory, MessageSeverity, MessageID, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<MessageCategory, MessageSeverity, MessageID, byte*, void*, void>) _handle;
        public PfnMessageFunc
        (
            delegate* unmanaged[Cdecl]<MessageCategory, MessageSeverity, MessageID, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnMessageFunc
        (
             MessageFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnMessageFunc From(MessageFunc proc) => new PfnMessageFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnMessageFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnMessageFunc(nint pfn)
            => new PfnMessageFunc((delegate* unmanaged[Cdecl]<MessageCategory, MessageSeverity, MessageID, byte*, void*, void>) pfn);

        public static implicit operator PfnMessageFunc(MessageFunc proc)
            => new PfnMessageFunc(proc);

        public static explicit operator MessageFunc(PfnMessageFunc pfn)
            => SilkMarshal.PtrToDelegate<MessageFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<MessageCategory, MessageSeverity, MessageID, byte*, void*, void>(PfnMessageFunc pfn) => pfn.Handle;
        public static implicit operator PfnMessageFunc(delegate* unmanaged[Cdecl]<MessageCategory, MessageSeverity, MessageID, byte*, void*, void> ptr) => new PfnMessageFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void MessageFunc(MessageCategory arg0, MessageSeverity arg1, MessageID arg2, byte* arg3, void* arg4);
}

