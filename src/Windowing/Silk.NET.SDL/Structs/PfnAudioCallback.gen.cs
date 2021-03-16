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
    public unsafe readonly struct PfnAudioCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, byte*, int, void> Handle => (delegate* unmanaged[Cdecl]<void*, byte*, int, void>) _handle;
        public PfnAudioCallback
        (
            delegate* unmanaged[Cdecl]<void*, byte*, int, void> ptr
        ) => _handle = ptr;

        public PfnAudioCallback
        (
             AudioCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnAudioCallback From(AudioCallback proc) => new PfnAudioCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnAudioCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnAudioCallback(nint pfn)
            => new PfnAudioCallback((delegate* unmanaged[Cdecl]<void*, byte*, int, void>) pfn);

        public static implicit operator PfnAudioCallback(AudioCallback proc)
            => new PfnAudioCallback(proc);

        public static explicit operator AudioCallback(PfnAudioCallback pfn)
            => SilkMarshal.PtrToDelegate<AudioCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, byte*, int, void>(PfnAudioCallback pfn) => pfn.Handle;
        public static implicit operator PfnAudioCallback(delegate* unmanaged[Cdecl]<void*, byte*, int, void> ptr) => new PfnAudioCallback(ptr);
    }

    public unsafe delegate void AudioCallback(void* arg0, byte* arg1, int arg2);
}

