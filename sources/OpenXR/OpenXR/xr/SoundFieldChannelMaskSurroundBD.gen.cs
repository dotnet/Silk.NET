// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundFieldChannelMaskSurroundBD")]
[SupportedApiProfile("openxr")]
public enum SoundFieldChannelMaskSurroundBD : uint
{
    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_FRONT_LEFT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    FrontLeft = 1,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_FRONT_RIGHT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    FrontRight = 2,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_FRONT_CENTER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    FrontCenter = 4,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_LOW_FREQUENCY_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    LowFrequency = 8,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_BACK_LEFT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    BackLeft = 16,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_BACK_RIGHT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    BackRight = 32,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SIDE_LEFT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SideLeft = 64,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SIDE_RIGHT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SideRight = 128,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_FRONT_LEFT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TopFrontLeft = 256,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_FRONT_RIGHT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TopFrontRight = 512,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_BACK_LEFT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TopBackLeft = 1024,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_BACK_RIGHT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TopBackRight = 2048,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_BACK_CENTER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    BackCenter = 4096,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_SIDE_LEFT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TopSideLeft = 8192,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_SIDE_RIGHT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    TopSideRight = 16384,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_STEREO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SetupStereo = 3,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_2_1_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup2x1 = 11,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_3_0_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup3x0 = 7,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_4_0_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup4x0 = 4099,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_BACK_SURROUND_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SetupBackSurround = 48,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_QUAD_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SetupQuad = 51,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_3_1_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup3x1 = 15,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_0_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup5x0 = 55,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_SIDE_SURROUND_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SetupSideSurround = 192,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_0_SIDE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup5x0Side = 199,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_1_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup5x1 = 63,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_1_SIDE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup5x1Side = 207,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_7_0_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup7x0 = 247,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_7_1_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup7x1 = 255,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_1_2_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup5x1x2 = 831,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_1_4_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup5x1x4 = 3903,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_7_1_2_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup7x1x2 = 24831,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_7_1_4_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Setup7x1x4 = 4095,
}
