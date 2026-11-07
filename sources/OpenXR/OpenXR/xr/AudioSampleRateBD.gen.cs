// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrAudioSampleRateBD")]
[SupportedApiProfile("openxr")]
public enum AudioSampleRateBD : uint
{
    [NativeName("XR_AUDIO_SAMPLE_RATE_192000_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate192000Hz = 1,

    [NativeName("XR_AUDIO_SAMPLE_RATE_96000_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate96000Hz = 2,

    [NativeName("XR_AUDIO_SAMPLE_RATE_48000_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate48000Hz = 3,

    [NativeName("XR_AUDIO_SAMPLE_RATE_44100_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate44100Hz = 4,

    [NativeName("XR_AUDIO_SAMPLE_RATE_32000_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate32000Hz = 5,

    [NativeName("XR_AUDIO_SAMPLE_RATE_24000_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate24000Hz = 6,

    [NativeName("XR_AUDIO_SAMPLE_RATE_22050_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate22050Hz = 7,

    [NativeName("XR_AUDIO_SAMPLE_RATE_16000_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate16000Hz = 8,

    [NativeName("XR_AUDIO_SAMPLE_RATE_12000_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate12000Hz = 9,

    [NativeName("XR_AUDIO_SAMPLE_RATE_11025_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate11025Hz = 10,

    [NativeName("XR_AUDIO_SAMPLE_RATE_8000_HZ_BD")]
    [SupportedApiProfile("openxr")]
    Rate8000Hz = 11,
}
