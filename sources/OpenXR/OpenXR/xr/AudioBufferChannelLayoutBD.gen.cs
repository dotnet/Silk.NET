// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrAudioBufferChannelLayoutBD")]
[SupportedApiProfile("openxr")]
public enum AudioBufferChannelLayoutBD : uint
{
    [NativeName("XR_AUDIO_BUFFER_CHANNEL_LAYOUT_INTERLEAVED_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Interleaved = 0,

    [NativeName("XR_AUDIO_BUFFER_CHANNEL_LAYOUT_PLANAR_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Planar = 1,
}
