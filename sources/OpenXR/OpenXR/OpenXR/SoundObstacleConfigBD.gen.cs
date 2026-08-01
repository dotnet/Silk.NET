// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObstacleConfigBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SoundObstacleConfigBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.SoundObstacleConfigBD;

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

    [NativeName("materialCount")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public uint MaterialCount;

    [NativeName("materials")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObstacleMaterialHandleBD* Materials;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObstacleConfigBD() { }
}
