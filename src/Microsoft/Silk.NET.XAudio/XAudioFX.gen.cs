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

namespace Silk.NET.XAudio
{
    public unsafe partial class XAudioFX : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_FRAMERATE")]
        public const int FXReverbMinFramerate = unchecked((int) 0x4E20);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_FRAMERATE")]
        public const int FXReverbMaxFramerate = unchecked((int) 0xBB80);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_REFLECTIONS_DELAY")]
        public const int FXReverbMinReflectionsDelay = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_REVERB_DELAY")]
        public const int FXReverbMinReverbDelay = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_REAR_DELAY")]
        public const int FXReverbMinRearDelay = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_7POINT1_SIDE_DELAY")]
        public const int FXReverbMin7Point1SideDelay = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_7POINT1_REAR_DELAY")]
        public const int FXReverbMin7Point1RearDelay = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_POSITION")]
        public const int FXReverbMinPosition = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_DIFFUSION")]
        public const int FXReverbMinDiffusion = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_LOW_EQ_GAIN")]
        public const int FXReverbMinLowEQGain = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_LOW_EQ_CUTOFF")]
        public const int FXReverbMinLowEQCutoff = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_HIGH_EQ_GAIN")]
        public const int FXReverbMinHighEQGain = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MIN_HIGH_EQ_CUTOFF")]
        public const int FXReverbMinHighEQCutoff = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_REFLECTIONS_DELAY")]
        public const int FXReverbMaxReflectionsDelay = unchecked((int) 0x12C);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_REVERB_DELAY")]
        public const int FXReverbMaxReverbDelay = unchecked((int) 0x55);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_REAR_DELAY")]
        public const int FXReverbMaxRearDelay = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_7POINT1_SIDE_DELAY")]
        public const int FXReverbMax7Point1SideDelay = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_7POINT1_REAR_DELAY")]
        public const int FXReverbMax7Point1RearDelay = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_POSITION")]
        public const int FXReverbMaxPosition = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_DIFFUSION")]
        public const int FXReverbMaxDiffusion = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_LOW_EQ_GAIN")]
        public const int FXReverbMaxLowEQGain = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_LOW_EQ_CUTOFF")]
        public const int FXReverbMaxLowEQCutoff = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_HIGH_EQ_GAIN")]
        public const int FXReverbMaxHighEQGain = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_MAX_HIGH_EQ_CUTOFF")]
        public const int FXReverbMaxHighEQCutoff = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_REFLECTIONS_DELAY")]
        public const int FXReverbDefaultReflectionsDelay = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_REVERB_DELAY")]
        public const int FXReverbDefaultReverbDelay = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_REAR_DELAY")]
        public const int FXReverbDefaultRearDelay = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_7POINT1_SIDE_DELAY")]
        public const int FXReverbDefault7Point1SideDelay = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_7POINT1_REAR_DELAY")]
        public const int FXReverbDefault7Point1RearDelay = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_POSITION")]
        public const int FXReverbDefaultPosition = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_POSITION_MATRIX")]
        public const int FXReverbDefaultPositionMatrix = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_EARLY_DIFFUSION")]
        public const int FXReverbDefaultEarlyDiffusion = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_LATE_DIFFUSION")]
        public const int FXReverbDefaultLateDiffusion = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_GAIN")]
        public const int FXReverbDefaultLowEQGain = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_LOW_EQ_CUTOFF")]
        public const int FXReverbDefaultLowEQCutoff = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_GAIN")]
        public const int FXReverbDefaultHighEQGain = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_HIGH_EQ_CUTOFF")]
        public const int FXReverbDefaultHighEQCutoff = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2FX_REVERB_DEFAULT_DISABLE_LATE_FIELD")]
        public const int FXReverbDefaultDisableLateField = unchecked((int) 0x0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 18 in xaudio2fx.h")]
        [NativeApi(EntryPoint = "CreateAudioVolumeMeter", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateAudioVolumeMeter(Silk.NET.Core.Native.IUnknown** ppApo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 18 in xaudio2fx.h")]
        [NativeApi(EntryPoint = "CreateAudioVolumeMeter", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateAudioVolumeMeter(ref Silk.NET.Core.Native.IUnknown* ppApo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 18 in xaudio2fx.h")]
        [NativeApi(EntryPoint = "CreateAudioReverb", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateAudioReverb(Silk.NET.Core.Native.IUnknown** ppApo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 18 in xaudio2fx.h")]
        [NativeApi(EntryPoint = "CreateAudioReverb", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateAudioReverb(ref Silk.NET.Core.Native.IUnknown* ppApo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 18 in xaudio2fx.h")]
        public unsafe int CreateAudioVolumeMeter<TI0>(ref ComPtr<TI0> ppApo) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateAudioVolumeMeter((Silk.NET.Core.Native.IUnknown**) ppApo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 18 in xaudio2fx.h")]
        public unsafe int CreateAudioReverb<TI0>(ref ComPtr<TI0> ppApo) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateAudioReverb((Silk.NET.Core.Native.IUnknown**) ppApo.GetAddressOf());
        }


        public XAudioFX(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

