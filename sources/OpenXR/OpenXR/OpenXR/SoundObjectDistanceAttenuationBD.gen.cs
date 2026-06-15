// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObjectDistanceAttenuationBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SoundObjectDistanceAttenuationBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.TypeSoundObjectDistanceAttenuationBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("distanceAttenuationType")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObjectDistanceAttenuationTypeBD DistanceAttenuationType;

    [NativeName("minAttenuationRange")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float MinAttenuationRange;

    [NativeName("maxAttenuationRange")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float MaxAttenuationRange;

    [NativeName("referenceDistance")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float ReferenceDistance;

    [NativeName("rolloffFactor")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float RolloffFactor;

    [NativeName("customDistanceAttenuationCurve")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObjectDistanceAttenuationCurveBD* CustomDistanceAttenuationCurve;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObjectDistanceAttenuationBD() { }
}
