// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using static Silk.NET.DirectX.XAUDIO2_FILTER_TYPE;

namespace Silk.NET.DirectX;

public static partial class XAUDIO2
{
    [NativeTypeName("#define XAUDIO2_DLL_A \"xaudio2_9.dll\"")]
    public static ReadOnlySpan<byte> XAUDIO2_DLL_A => "xaudio2_9.dll"u8;

    [NativeTypeName("#define XAUDIO2_DLL_W L\"xaudio2_9.dll\"")]
    public const string XAUDIO2_DLL_W = "xaudio2_9.dll";

    [NativeTypeName("#define XAUDIO2_DLL XAUDIO2_DLL_W")]
    public const string XAUDIO2_DLL = "xaudio2_9.dll";

    [NativeTypeName("#define XAUDIO2_MAX_BUFFER_BYTES 0x80000000")]
    public const uint XAUDIO2_MAX_BUFFER_BYTES = 0x80000000;

    [NativeTypeName("#define XAUDIO2_MAX_QUEUED_BUFFERS 64")]
    public const int XAUDIO2_MAX_QUEUED_BUFFERS = 64;

    [NativeTypeName("#define XAUDIO2_MAX_BUFFERS_SYSTEM 2")]
    public const int XAUDIO2_MAX_BUFFERS_SYSTEM = 2;

    [NativeTypeName("#define XAUDIO2_MAX_AUDIO_CHANNELS 64")]
    public const int XAUDIO2_MAX_AUDIO_CHANNELS = 64;

    [NativeTypeName("#define XAUDIO2_MIN_SAMPLE_RATE 1000")]
    public const int XAUDIO2_MIN_SAMPLE_RATE = 1000;

    [NativeTypeName("#define XAUDIO2_MAX_SAMPLE_RATE 200000")]
    public const int XAUDIO2_MAX_SAMPLE_RATE = 200000;

    [NativeTypeName("#define XAUDIO2_MAX_VOLUME_LEVEL 16777216.0f")]
    public const float XAUDIO2_MAX_VOLUME_LEVEL = 16777216.0f;

    [NativeTypeName("#define XAUDIO2_MIN_FREQ_RATIO (1/1024.0f)")]
    public const float XAUDIO2_MIN_FREQ_RATIO = (1 / 1024.0f);

    [NativeTypeName("#define XAUDIO2_MAX_FREQ_RATIO 1024.0f")]
    public const float XAUDIO2_MAX_FREQ_RATIO = 1024.0f;

    [NativeTypeName("#define XAUDIO2_DEFAULT_FREQ_RATIO 2.0f")]
    public const float XAUDIO2_DEFAULT_FREQ_RATIO = 2.0f;

    [NativeTypeName("#define XAUDIO2_MAX_FILTER_ONEOVERQ 1.5f")]
    public const float XAUDIO2_MAX_FILTER_ONEOVERQ = 1.5f;

    [NativeTypeName("#define XAUDIO2_MAX_FILTER_FREQUENCY 1.0f")]
    public const float XAUDIO2_MAX_FILTER_FREQUENCY = 1.0f;

    [NativeTypeName("#define XAUDIO2_MAX_LOOP_COUNT 254")]
    public const int XAUDIO2_MAX_LOOP_COUNT = 254;

    [NativeTypeName("#define XAUDIO2_MAX_INSTANCES 8")]
    public const int XAUDIO2_MAX_INSTANCES = 8;

    [NativeTypeName("#define XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO 600000")]
    public const int XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MONO = 600000;

    [NativeTypeName("#define XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL 300000")]
    public const int XAUDIO2_MAX_RATIO_TIMES_RATE_XMA_MULTICHANNEL = 300000;

    [NativeTypeName("#define XAUDIO2_COMMIT_NOW 0")]
    public const int XAUDIO2_COMMIT_NOW = 0;

    [NativeTypeName("#define XAUDIO2_COMMIT_ALL 0")]
    public const int XAUDIO2_COMMIT_ALL = 0;

    [NativeTypeName("#define XAUDIO2_INVALID_OPSET (UINT32)(-1)")]
    public const uint XAUDIO2_INVALID_OPSET = unchecked((uint)(-1));

    [NativeTypeName("#define XAUDIO2_NO_LOOP_REGION 0")]
    public const int XAUDIO2_NO_LOOP_REGION = 0;

    [NativeTypeName("#define XAUDIO2_LOOP_INFINITE 255")]
    public const int XAUDIO2_LOOP_INFINITE = 255;

    [NativeTypeName("#define XAUDIO2_DEFAULT_CHANNELS 0")]
    public const int XAUDIO2_DEFAULT_CHANNELS = 0;

    [NativeTypeName("#define XAUDIO2_DEFAULT_SAMPLERATE 0")]
    public const int XAUDIO2_DEFAULT_SAMPLERATE = 0;

    [NativeTypeName("#define XAUDIO2_DEBUG_ENGINE 0x0001")]
    public const int XAUDIO2_DEBUG_ENGINE = 0x0001;

    [NativeTypeName("#define XAUDIO2_VOICE_NOPITCH 0x0002")]
    public const int XAUDIO2_VOICE_NOPITCH = 0x0002;

    [NativeTypeName("#define XAUDIO2_VOICE_NOSRC 0x0004")]
    public const int XAUDIO2_VOICE_NOSRC = 0x0004;

    [NativeTypeName("#define XAUDIO2_VOICE_USEFILTER 0x0008")]
    public const int XAUDIO2_VOICE_USEFILTER = 0x0008;

    [NativeTypeName("#define XAUDIO2_PLAY_TAILS 0x0020")]
    public const int XAUDIO2_PLAY_TAILS = 0x0020;

    [NativeTypeName("#define XAUDIO2_END_OF_STREAM 0x0040")]
    public const int XAUDIO2_END_OF_STREAM = 0x0040;

    [NativeTypeName("#define XAUDIO2_SEND_USEFILTER 0x0080")]
    public const int XAUDIO2_SEND_USEFILTER = 0x0080;

    [NativeTypeName("#define XAUDIO2_VOICE_NOSAMPLESPLAYED 0x0100")]
    public const int XAUDIO2_VOICE_NOSAMPLESPLAYED = 0x0100;

    [NativeTypeName("#define XAUDIO2_STOP_ENGINE_WHEN_IDLE 0x2000")]
    public const int XAUDIO2_STOP_ENGINE_WHEN_IDLE = 0x2000;

    [NativeTypeName("#define XAUDIO2_1024_QUANTUM 0x8000")]
    public const int XAUDIO2_1024_QUANTUM = 0x8000;

    [NativeTypeName("#define XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT 0x10000")]
    public const int XAUDIO2_NO_VIRTUAL_AUDIO_CLIENT = 0x10000;

    [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_TYPE LowPassFilter")]
    public const XAUDIO2_FILTER_TYPE XAUDIO2_DEFAULT_FILTER_TYPE = LowPassFilter;

    [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_FREQUENCY XAUDIO2_MAX_FILTER_FREQUENCY")]
    public const float XAUDIO2_DEFAULT_FILTER_FREQUENCY = 1.0f;

    [NativeTypeName("#define XAUDIO2_DEFAULT_FILTER_ONEOVERQ 1.0f")]
    public const float XAUDIO2_DEFAULT_FILTER_ONEOVERQ = 1.0f;

    [NativeTypeName("#define XAUDIO2_QUANTUM_NUMERATOR 1")]
    public const int XAUDIO2_QUANTUM_NUMERATOR = 1;

    [NativeTypeName("#define XAUDIO2_QUANTUM_DENOMINATOR 100")]
    public const int XAUDIO2_QUANTUM_DENOMINATOR = 100;

    [NativeTypeName("#define XAUDIO2_QUANTUM_MS (1000.0f * XAUDIO2_QUANTUM_NUMERATOR / XAUDIO2_QUANTUM_DENOMINATOR)")]
    public const float XAUDIO2_QUANTUM_MS = (1000.0f * 1 / 100);

    [NativeTypeName("#define XAUDIO2_E_INVALID_CALL ((HRESULT)0x88960001)")]
    public const int XAUDIO2_E_INVALID_CALL = unchecked((int)(0x88960001));

    [NativeTypeName("#define XAUDIO2_E_XMA_DECODER_ERROR ((HRESULT)0x88960002)")]
    public const int XAUDIO2_E_XMA_DECODER_ERROR = unchecked((int)(0x88960002));

    [NativeTypeName("#define XAUDIO2_E_XAPO_CREATION_FAILED ((HRESULT)0x88960003)")]
    public const int XAUDIO2_E_XAPO_CREATION_FAILED = unchecked((int)(0x88960003));

    [NativeTypeName("#define XAUDIO2_E_DEVICE_INVALIDATED ((HRESULT)0x88960004)")]
    public const int XAUDIO2_E_DEVICE_INVALIDATED = unchecked((int)(0x88960004));

    [NativeTypeName("#define XAUDIO2_ANY_PROCESSOR 0xffffffff")]
    public const uint XAUDIO2_ANY_PROCESSOR = 0xffffffff;

    [NativeTypeName("#define XAUDIO2_USE_DEFAULT_PROCESSOR 0x00000000")]
    public const int XAUDIO2_USE_DEFAULT_PROCESSOR = 0x00000000;

    [NativeTypeName("#define XAUDIO2_DEFAULT_PROCESSOR Processor1")]
    public const int XAUDIO2_DEFAULT_PROCESSOR = 0x00000001;

    [NativeTypeName("#define XAUDIO2_LOG_ERRORS 0x0001")]
    public const int XAUDIO2_LOG_ERRORS = 0x0001;

    [NativeTypeName("#define XAUDIO2_LOG_WARNINGS 0x0002")]
    public const int XAUDIO2_LOG_WARNINGS = 0x0002;

    [NativeTypeName("#define XAUDIO2_LOG_INFO 0x0004")]
    public const int XAUDIO2_LOG_INFO = 0x0004;

    [NativeTypeName("#define XAUDIO2_LOG_DETAIL 0x0008")]
    public const int XAUDIO2_LOG_DETAIL = 0x0008;

    [NativeTypeName("#define XAUDIO2_LOG_API_CALLS 0x0010")]
    public const int XAUDIO2_LOG_API_CALLS = 0x0010;

    [NativeTypeName("#define XAUDIO2_LOG_FUNC_CALLS 0x0020")]
    public const int XAUDIO2_LOG_FUNC_CALLS = 0x0020;

    [NativeTypeName("#define XAUDIO2_LOG_TIMING 0x0040")]
    public const int XAUDIO2_LOG_TIMING = 0x0040;

    [NativeTypeName("#define XAUDIO2_LOG_LOCKS 0x0080")]
    public const int XAUDIO2_LOG_LOCKS = 0x0080;

    [NativeTypeName("#define XAUDIO2_LOG_MEMORY 0x0100")]
    public const int XAUDIO2_LOG_MEMORY = 0x0100;

    [NativeTypeName("#define XAUDIO2_LOG_STREAMING 0x1000")]
    public const int XAUDIO2_LOG_STREAMING = 0x1000;
}
