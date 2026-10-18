// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObjectConfigBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SoundObjectConfigBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.SoundObjectConfigBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("enabled")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public MaybeBool<uint> Enabled;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public Posef Pose;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SpaceHandle BaseSpace;

    [NativeName("mainVolume")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float MainVolume;

    [NativeName("reflectionGain")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float ReflectionGain;

    [NativeName("enableDoppler")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public MaybeBool<uint> EnableDoppler;

    [NativeName("directSoundAttenuation")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObjectDistanceAttenuationBD* DirectSoundAttenuation;

    [NativeName("indirectSoundAttenuation")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObjectDistanceAttenuationBD* IndirectSoundAttenuation;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObjectConfigBD() { }
}
