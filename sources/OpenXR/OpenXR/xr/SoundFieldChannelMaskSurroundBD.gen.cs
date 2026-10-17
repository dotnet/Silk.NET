// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundFieldChannelMaskSurroundBD")]
public enum SoundFieldChannelMaskSurroundBD : uint
{
    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_FRONT_LEFT_BD")]
    FrontLeft = 1,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_FRONT_RIGHT_BD")]
    FrontRight = 2,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_FRONT_CENTER_BD")]
    FrontCenter = 4,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_LOW_FREQUENCY_BD")]
    LowFrequency = 8,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_BACK_LEFT_BD")]
    BackLeft = 16,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_BACK_RIGHT_BD")]
    BackRight = 32,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SIDE_LEFT_BD")]
    SideLeft = 64,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SIDE_RIGHT_BD")]
    SideRight = 128,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_FRONT_LEFT_BD")]
    TopFrontLeft = 256,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_FRONT_RIGHT_BD")]
    TopFrontRight = 512,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_BACK_LEFT_BD")]
    TopBackLeft = 1024,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_BACK_RIGHT_BD")]
    TopBackRight = 2048,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_BACK_CENTER_BD")]
    BackCenter = 4096,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_SIDE_LEFT_BD")]
    TopSideLeft = 8192,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_TOP_SIDE_RIGHT_BD")]
    TopSideRight = 16384,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_STEREO_BD")]
    SetupStereo = 3,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_2_1_BD")]
    Setup2x1 = 11,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_3_0_BD")]
    Setup3x0 = 7,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_4_0_BD")]
    Setup4x0 = 4099,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_BACK_SURROUND_BD")]
    SetupBackSurround = 48,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_QUAD_BD")]
    SetupQuad = 51,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_3_1_BD")]
    Setup3x1 = 15,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_0_BD")]
    Setup5x0 = 55,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_SIDE_SURROUND_BD")]
    SetupSideSurround = 192,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_0_SIDE_BD")]
    Setup5x0Side = 199,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_1_BD")]
    Setup5x1 = 63,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_1_SIDE_BD")]
    Setup5x1Side = 207,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_7_0_BD")]
    Setup7x0 = 247,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_7_1_BD")]
    Setup7x1 = 255,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_1_2_BD")]
    Setup5x1x2 = 831,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_5_1_4_BD")]
    Setup5x1x4 = 3903,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_7_1_2_BD")]
    Setup7x1x2 = 24831,

    [NativeName("XR_SOUND_FIELD_CHANNEL_MASK_SURROUND_SETUP_7_1_4_BD")]
    Setup7x1x4 = 4095,
}
