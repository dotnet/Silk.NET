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
    public unsafe partial class XAudio : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "XAUDIO2_DLL_A")]
        public const string DllA = unchecked((string) "xaudio2_9.dll");
        [NativeName("Type", "")]
        [NativeName("Name", "XAUDIO2_DLL_W")]
        public const string DllW = unchecked((string) "xaudio2_9.dll");
        [NativeName("Type", "")]
        [NativeName("Name", "XAUDIO2D_DLL_A")]
        public const string DDllA = unchecked((string) "xaudio2_9d.dll");
        [NativeName("Type", "")]
        [NativeName("Name", "XAUDIO2D_DLL_W")]
        public const string DDllW = unchecked((string) "xaudio2_9d.dll");
        [NativeName("Type", "")]
        [NativeName("Name", "XAUDIO2_DLL")]
        public const string Dll = unchecked((string) "xaudio2_9.dll");
        [NativeName("Type", "")]
        [NativeName("Name", "XAUDIO2D_DLL")]
        public const string DDll = unchecked((string) "xaudio2_9d.dll");
        [NativeName("Type", "int")]
        [NativeName("Name", "MIDL_ANYSIZE_ARRAY")]
        public const int MidlAnysizeArray = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_STREAMFLAGS_CROSSPROCESS")]
        public const int AudclntStreamflagsCrossprocess = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_STREAMFLAGS_LOOPBACK")]
        public const int AudclntStreamflagsLoopback = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_STREAMFLAGS_EVENTCALLBACK")]
        public const int AudclntStreamflagsEventcallback = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_STREAMFLAGS_NOPERSIST")]
        public const int AudclntStreamflagsNopersist = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_STREAMFLAGS_RATEADJUST")]
        public const int AudclntStreamflagsRateadjust = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_STREAMFLAGS_SRC_DEFAULT_QUALITY")]
        public const int AudclntStreamflagsSrcDefaultQuality = unchecked((int) 0x8000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "AUDCLNT_STREAMFLAGS_AUTOCONVERTPCM")]
        public const uint AudclntStreamflagsAutoconvertpcm = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_SESSIONFLAGS_EXPIREWHENUNOWNED")]
        public const int AudclntSessionflagsExpirewhenunowned = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_SESSIONFLAGS_DISPLAY_HIDE")]
        public const int AudclntSessionflagsDisplayHide = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDCLNT_SESSIONFLAGS_DISPLAY_HIDEWHENEXPIRED")]
        public const int AudclntSessionflagsDisplayHidewhenexpired = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "XAUDIO2_MAX_BUFFER_BYTES")]
        public const uint MaxBufferBytes = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MAX_QUEUED_BUFFERS")]
        public const int MaxQueuedBuffers = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MAX_BUFFERS_SYSTEM")]
        public const int MaxBuffersSystem = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MAX_AUDIO_CHANNELS")]
        public const int MaxAudioChannels = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MIN_SAMPLE_RATE")]
        public const int MinSampleRate = unchecked((int) 0x3E8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MAX_SAMPLE_RATE")]
        public const int MaxSampleRate = unchecked((int) 0x30D40);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MAX_LOOP_COUNT")]
        public const int MaxLoopCount = unchecked((int) 0xFE);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MAX_INSTANCES")]
        public const int MaxInstances = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO")]
        public const int MaxRatioTimesRateXmaMono = unchecked((int) 0x927C0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL")]
        public const int MaxRatioTimesRateXmaMultichannel = unchecked((int) 0x493E0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_COMMIT_NOW")]
        public const int CommitNow = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_COMMIT_ALL")]
        public const int CommitAll = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_NO_LOOP_REGION")]
        public const int NoLoopRegion = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOOP_INFINITE")]
        public const int LoopInfinite = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_DEFAULT_CHANNELS")]
        public const int DefaultChannels = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_DEFAULT_SAMPLERATE")]
        public const int DefaultSamplerate = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_DEBUG_ENGINE")]
        public const int DebugEngine = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_VOICE_NOPITCH")]
        public const int VoiceNopitch = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_VOICE_NOSRC")]
        public const int VoiceNosrc = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_VOICE_USEFILTER")]
        public const int VoiceUsefilter = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_PLAY_TAILS")]
        public const int PlayTails = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_END_OF_STREAM")]
        public const int EndOfStream = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_SEND_USEFILTER")]
        public const int SendUsefilter = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_VOICE_NOSAMPLESPLAYED")]
        public const int VoiceNosamplesplayed = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_STOP_ENGINE_WHEN_IDLE")]
        public const int StopEngineWhenIdle = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_1024_QUANTUM")]
        public const int XAudio21024Quantum = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT")]
        public const int NoVirtualAudioClient = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_QUANTUM_NUMERATOR")]
        public const int QuantumNumerator = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_QUANTUM_DENOMINATOR")]
        public const int QuantumDenominator = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "FACILITY_XAUDIO2")]
        public const int FacilityXaudio2 = unchecked((int) 0x896);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor1")]
        public const int Processor1 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor2")]
        public const int Processor2 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor3")]
        public const int Processor3 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor4")]
        public const int Processor4 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor5")]
        public const int Processor5 = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor6")]
        public const int Processor6 = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor7")]
        public const int Processor7 = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor8")]
        public const int Processor8 = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor9")]
        public const int Processor9 = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor10")]
        public const int Processor10 = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor11")]
        public const int Processor11 = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor12")]
        public const int Processor12 = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor13")]
        public const int Processor13 = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor14")]
        public const int Processor14 = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor15")]
        public const int Processor15 = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor16")]
        public const int Processor16 = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor17")]
        public const int Processor17 = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor18")]
        public const int Processor18 = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor19")]
        public const int Processor19 = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor20")]
        public const int Processor20 = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor21")]
        public const int Processor21 = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor22")]
        public const int Processor22 = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor23")]
        public const int Processor23 = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor24")]
        public const int Processor24 = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor25")]
        public const int Processor25 = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor26")]
        public const int Processor26 = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor27")]
        public const int Processor27 = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor28")]
        public const int Processor28 = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor29")]
        public const int Processor29 = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor30")]
        public const int Processor30 = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "Processor31")]
        public const int Processor31 = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "Processor32")]
        public const uint Processor32 = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "XAUDIO2_ANY_PROCESSOR")]
        public const uint AnyProcessor = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_USE_DEFAULT_PROCESSOR")]
        public const int UseDefaultProcessor = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_DEFAULT_PROCESSOR")]
        public const int DefaultProcessor = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_ERRORS")]
        public const int LogErrors = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_WARNINGS")]
        public const int LogWarnings = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_INFO")]
        public const int LogInfo = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_DETAIL")]
        public const int LogDetail = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_API_CALLS")]
        public const int LogApiCalls = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_FUNC_CALLS")]
        public const int LogFuncCalls = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_TIMING")]
        public const int LogTiming = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_LOCKS")]
        public const int LogLocks = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_MEMORY")]
        public const int LogMemory = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "XAUDIO2_LOG_STREAMING")]
        public const int LogStreaming = unchecked((int) 0x1000);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1270, Column 16 in xaudio2.h")]
        [NativeApi(EntryPoint = "XAudio2CreateWithVersionInfo", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateWithVersionInfo(IXAudio2** ppXAudio2, uint Flags, uint XAudio2Processor, uint ntddiVersion);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1270, Column 16 in xaudio2.h")]
        [NativeApi(EntryPoint = "XAudio2CreateWithVersionInfo", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateWithVersionInfo(ref IXAudio2* ppXAudio2, uint Flags, uint XAudio2Processor, uint ntddiVersion);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1270, Column 16 in xaudio2.h")]
        public unsafe int CreateWithVersionInfo<TI0>(ref ComPtr<TI0> ppXAudio2, uint Flags, uint XAudio2Processor, uint ntddiVersion) where TI0 : unmanaged, IComVtbl<IXAudio2>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateWithVersionInfo((IXAudio2**) ppXAudio2.GetAddressOf(), Flags, XAudio2Processor, ntddiVersion);
        }


        public XAudio(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

