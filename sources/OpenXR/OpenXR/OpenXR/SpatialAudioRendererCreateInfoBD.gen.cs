// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAudioRendererCreateInfoBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAudioRendererCreateInfoBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.SpatialAudioRendererCreateInfoBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("framesPerBuffer")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public uint FramesPerBuffer;

    [NativeName("sampleRate")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public AudioSampleRateBD SampleRate;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SpatialAudioRendererCreateInfoBD() { }
}
