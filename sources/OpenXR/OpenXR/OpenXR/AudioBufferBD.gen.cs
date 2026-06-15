// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrAudioBufferBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct AudioBufferBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.TypeAudioBufferBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("channelLayout")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public AudioBufferChannelLayoutBD ChannelLayout;

    [NativeName("bufferChannels")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public uint BufferChannels;

    [NativeName("bufferLength")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public uint BufferLength;

    [NativeName("buffer")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float* Buffer;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public AudioBufferBD() { }
}
