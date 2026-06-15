// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObjectDirectivityCardioidBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SoundObjectDirectivityCardioidBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.TypeSoundObjectDirectivityCardioidBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("alpha")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float Alpha;

    [NativeName("order")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float Order;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundObjectDirectivityCardioidBD() { }
}
