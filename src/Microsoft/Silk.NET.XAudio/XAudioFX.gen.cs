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

namespace Silk.NET.XAudio
{
    public unsafe partial class XAudioFX : NativeAPI
    {

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 68, Column 18 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\xaudio2fx.h")]
        [NativeApi(EntryPoint = "CreateAudioVolumeMeter")]
        public unsafe partial int CreateAudioVolumeMeter(Silk.NET.Core.Native.IUnknown** ppApo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 68, Column 18 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\xaudio2fx.h")]
        [NativeApi(EntryPoint = "CreateAudioVolumeMeter")]
        public unsafe partial int CreateAudioVolumeMeter(ref Silk.NET.Core.Native.IUnknown* ppApo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 18 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\xaudio2fx.h")]
        [NativeApi(EntryPoint = "CreateAudioReverb")]
        public unsafe partial int CreateAudioReverb(Silk.NET.Core.Native.IUnknown** ppApo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 18 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\xaudio2fx.h")]
        [NativeApi(EntryPoint = "CreateAudioReverb")]
        public unsafe partial int CreateAudioReverb(ref Silk.NET.Core.Native.IUnknown* ppApo);


        public XAudioFX(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

