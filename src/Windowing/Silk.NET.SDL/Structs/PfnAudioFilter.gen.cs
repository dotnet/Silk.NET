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
    public unsafe readonly struct PfnAudioFilter : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<AudioCVT*, ushort, void> Handle => (delegate* unmanaged[Cdecl]<AudioCVT*, ushort, void>) _handle;
        public PfnAudioFilter
        (
            delegate* unmanaged[Cdecl]<AudioCVT*, ushort, void> ptr
        ) => _handle = ptr;

        public PfnAudioFilter
        (
             AudioFilter proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnAudioFilter From(AudioFilter proc) => new PfnAudioFilter(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnAudioFilter pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnAudioFilter(IntPtr pfn)
            => new PfnAudioFilter((delegate* unmanaged[Cdecl]<AudioCVT*, ushort, void>) pfn);

        public static implicit operator PfnAudioFilter(AudioFilter proc)
            => new PfnAudioFilter(proc);

        public static explicit operator AudioFilter(PfnAudioFilter pfn)
            => SilkMarshal.PtrToDelegate<AudioFilter>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<AudioCVT*, ushort, void>(PfnAudioFilter pfn) => pfn.Handle;
        public static implicit operator PfnAudioFilter(delegate* unmanaged[Cdecl]<AudioCVT*, ushort, void> ptr) => new PfnAudioFilter(ptr);
    }

    public unsafe delegate void AudioFilter(AudioCVT* arg0, ushort arg1);
}

