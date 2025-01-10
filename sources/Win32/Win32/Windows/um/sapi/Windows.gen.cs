// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.SPEVENTENUM;
using static Silk.NET.Windows.SPPHRASERNG;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("const float")]
    public const float Speech_Default_Weight = (1);

    [NativeTypeName("const LONG")]
    public const int Speech_Max_Word_Length = (128);

    [NativeTypeName("const LONG")]
    public const int Speech_Max_Pron_Length = (384);

    [NativeTypeName("const LONG")]
    public const int Speech_StreamPos_Asap = (0);

    [NativeTypeName("const LONG")]
    public const int Speech_StreamPos_RealTime = (-1);

    [NativeTypeName("const LONG")]
    public const int SpeechAllElements = (int)(SPPR_ALL_ELEMENTS);

    [NativeTypeName("#define _SAPI_VER 0x054")]
    public const int _SAPI_VER = 0x054;

    [NativeTypeName(
        "#define SPCAT_AUDIOOUT L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput\""
    )]
    public const string SPCAT_AUDIOOUT =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput";

    [NativeTypeName(
        "#define SPCAT_AUDIOIN L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput\""
    )]
    public const string SPCAT_AUDIOIN =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput";

    [NativeTypeName(
        "#define SPCAT_VOICES L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Voices\""
    )]
    public const string SPCAT_VOICES = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Voices";

    [NativeTypeName(
        "#define SPCAT_RECOGNIZERS L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Recognizers\""
    )]
    public const string SPCAT_RECOGNIZERS =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Recognizers";

    [NativeTypeName(
        "#define SPCAT_APPLEXICONS L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AppLexicons\""
    )]
    public const string SPCAT_APPLEXICONS =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AppLexicons";

    [NativeTypeName(
        "#define SPCAT_PHONECONVERTERS L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\PhoneConverters\""
    )]
    public const string SPCAT_PHONECONVERTERS =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\PhoneConverters";

    [NativeTypeName(
        "#define SPCAT_TEXTNORMALIZERS L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\TextNormalizers\""
    )]
    public const string SPCAT_TEXTNORMALIZERS =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\TextNormalizers";

    [NativeTypeName(
        "#define SPCAT_RECOPROFILES L\"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\RecoProfiles\""
    )]
    public const string SPCAT_RECOPROFILES =
        "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\RecoProfiles";

    [NativeTypeName(
        "#define SPMMSYS_AUDIO_IN_TOKEN_ID L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput\\TokenEnums\\MMAudioIn\""
    )]
    public const string SPMMSYS_AUDIO_IN_TOKEN_ID =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput\\TokenEnums\\MMAudioIn\\";

    [NativeTypeName(
        "#define SPMMSYS_AUDIO_OUT_TOKEN_ID L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput\\TokenEnums\\MMAudioOut\""
    )]
    public const string SPMMSYS_AUDIO_OUT_TOKEN_ID =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput\\TokenEnums\\MMAudioOut\\";

    [NativeTypeName(
        "#define SPCURRENT_USER_LEXICON_TOKEN_ID L\"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserLexicon\""
    )]
    public const string SPCURRENT_USER_LEXICON_TOKEN_ID =
        "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserLexicon";

    [NativeTypeName(
        "#define SPCURRENT_USER_SHORTCUT_TOKEN_ID L\"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserShortcut\""
    )]
    public const string SPCURRENT_USER_SHORTCUT_TOKEN_ID =
        "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserShortcut";

    [NativeTypeName("#define SPTOKENVALUE_CLSID L\"CLSID\"")]
    public const string SPTOKENVALUE_CLSID = "CLSID";

    [NativeTypeName("#define SPTOKENKEY_FILES L\"Files\"")]
    public const string SPTOKENKEY_FILES = "Files";

    [NativeTypeName("#define SPTOKENKEY_UI L\"UI\"")]
    public const string SPTOKENKEY_UI = "UI";

    [NativeTypeName("#define SPTOKENKEY_ATTRIBUTES L\"Attributes\"")]
    public const string SPTOKENKEY_ATTRIBUTES = "Attributes";

    [NativeTypeName("#define SPTOKENKEY_RETAINEDAUDIO L\"SecondsPerRetainedAudioEvent\"")]
    public const string SPTOKENKEY_RETAINEDAUDIO = "SecondsPerRetainedAudioEvent";

    [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_WARNING L\"LatencyWarningThreshold\"")]
    public const string SPTOKENKEY_AUDIO_LATENCY_WARNING = "LatencyWarningThreshold";

    [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_TRUNCATE L\"LatencyTruncateThreshold\"")]
    public const string SPTOKENKEY_AUDIO_LATENCY_TRUNCATE = "LatencyTruncateThreshold";

    [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_UPDATE_INTERVAL L\"LatencyUpdateInterval\"")]
    public const string SPTOKENKEY_AUDIO_LATENCY_UPDATE_INTERVAL = "LatencyUpdateInterval";

    [NativeTypeName("#define SPVOICECATEGORY_TTSRATE L\"DefaultTTSRate\"")]
    public const string SPVOICECATEGORY_TTSRATE = "DefaultTTSRate";

    [NativeTypeName("#define SPTOPIC_SPELLING L\"Spelling\"")]
    public const string SPTOPIC_SPELLING = "Spelling";

    [NativeTypeName("#define SPWILDCARD L\"...\"")]
    public const string SPWILDCARD = "...";

    [NativeTypeName("#define SPDICTATION L\"*\"")]
    public const string SPDICTATION = "*";

    [NativeTypeName("#define SPINFDICTATION L\"*+\"")]
    public const string SPINFDICTATION = "*+";

    [NativeTypeName(
        "#define SPFEI_FLAGCHECK ( (1ui64 << SPEI_RESERVED1) | (1ui64 << SPEI_RESERVED2) )"
    )]
    public const ulong SPFEI_FLAGCHECK = (
        (1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2))
    );

    [NativeTypeName("#define SPFEI_ALL_TTS_EVENTS (0x000000000000FFFEui64 | SPFEI_FLAGCHECK)")]
    public const ulong SPFEI_ALL_TTS_EVENTS = (
        0x000000000000FFFEUL | ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2)))
    );

    [NativeTypeName("#define SPFEI_ALL_SR_EVENTS (0x003FFFFC00000000ui64 | SPFEI_FLAGCHECK)")]
    public const ulong SPFEI_ALL_SR_EVENTS = (
        0x003FFFFC00000000UL | ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2)))
    );

    [NativeTypeName("#define SPFEI_ALL_EVENTS 0xEFFFFFFFFFFFFFFFui64")]
    public const ulong SPFEI_ALL_EVENTS = 0xEFFFFFFFFFFFFFFFUL;

    [NativeTypeName("#define SPRR_ALL_ELEMENTS SPPR_ALL_ELEMENTS")]
    public const SPPHRASERNG SPRR_ALL_ELEMENTS = SPPR_ALL_ELEMENTS;

    [NativeTypeName("#define SPRP_NORMAL 0")]
    public const int SPRP_NORMAL = 0;
    public static ref readonly Guid DIID__ISpeechVoiceEvents
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xAC,
                0x72,
                0xA3,
                0xEF,
                0x3B,
                0xBD,
                0x4B,
                0x8F,
                0xFB,
                0xCB,
                0x3E,
                0x2B,
                0x41,
                0x6A,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid DIID__ISpeechRecoContextEvents
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0xCB,
                0x8F,
                0x7B,
                0x9D,
                0x0E,
                0x00,
                0x4F,
                0xA0,
                0x48,
                0x7B,
                0x04,
                0xD6,
                0x17,
                0x9D,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
