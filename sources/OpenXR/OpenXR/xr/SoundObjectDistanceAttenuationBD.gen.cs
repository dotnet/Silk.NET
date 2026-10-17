// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObjectDistanceAttenuationBD")]
public unsafe partial struct SoundObjectDistanceAttenuationBD
{
    [NativeName("type")]
    public StructureType Type = StructureType.SoundObjectDistanceAttenuationBD;

    [NativeName("next")]
    public void* Next;

    [NativeName("distanceAttenuationType")]
    public SoundObjectDistanceAttenuationTypeBD DistanceAttenuationType;

    [NativeName("minAttenuationRange")]
    public float MinAttenuationRange;

    [NativeName("maxAttenuationRange")]
    public float MaxAttenuationRange;

    [NativeName("referenceDistance")]
    public float ReferenceDistance;

    [NativeName("rolloffFactor")]
    public float RolloffFactor;

    [NativeName("customDistanceAttenuationCurve")]
    public SoundObjectDistanceAttenuationCurveBD* CustomDistanceAttenuationCurve;

    public SoundObjectDistanceAttenuationBD() { }
}
