// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundFieldChannelMaskAmbixBD")]
[SupportedApiProfile("openxr")]
public enum SoundFieldChannelMaskAmbixBD : uint
{
    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_AMBIX_1ST_ORDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Ambix1StOrder = 1,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_AMBIX_2ND_ORDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Ambix2NdOrder = 2,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_AMBIX_3RD_ORDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Ambix3RdOrder = 3,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_AMBIX_4TH_ORDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Ambix4ThOrder = 4,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_AMBIX_5TH_ORDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Ambix5ThOrder = 5,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_AMBIX_6TH_ORDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Ambix6ThOrder = 6,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_AMBIX_7TH_ORDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Ambix7ThOrder = 7,
}
