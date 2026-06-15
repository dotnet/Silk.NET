// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundFieldConfigBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SoundFieldConfigBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.TypeSoundFieldConfigBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("enabled")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public MaybeBool<uint> Enabled;

    [NativeName("orientation")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public Quaternionf Orientation;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SpaceHandle BaseSpace;

    [NativeName("mainVolume")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float MainVolume;

    [NativeName("lfeGain")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float LfeGain;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundFieldConfigBD() { }
}
