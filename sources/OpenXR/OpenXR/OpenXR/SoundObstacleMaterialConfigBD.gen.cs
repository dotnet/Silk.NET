// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObstacleMaterialConfigBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SoundObstacleMaterialConfigBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.TypeSoundObstacleMaterialConfigBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("materialType")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObstacleMaterialTypeBD MaterialType;

    [NativeName("bandCount")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public uint BandCount;

    [NativeName("bandFrequencies")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float* BandFrequencies;

    [NativeName("bandAbsorptions")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float* BandAbsorptions;

    [NativeName("bandScatterings")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float* BandScatterings;

    [NativeName("bandTransmissions")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float* BandTransmissions;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObstacleMaterialConfigBD() { }
}
