// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObjectDistanceAttenuationTypeBD")]
[SupportedApiProfile("openxr")]
public enum SoundObjectDistanceAttenuationTypeBD : uint
{
    [NativeName("XR_SOUND_OBJECT_DISTANCE_ATTENUATION_TYPE_NONE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    None = 0,

    [NativeName("XR_SOUND_OBJECT_DISTANCE_ATTENUATION_TYPE_INVERSE_SQUARE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    InverseSquare = 1,

    [NativeName("XR_SOUND_OBJECT_DISTANCE_ATTENUATION_TYPE_ROLLOFF_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Rolloff = 2,

    [NativeName("XR_SOUND_OBJECT_DISTANCE_ATTENUATION_TYPE_CUSTOMIZED_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Customized = 100,
}
