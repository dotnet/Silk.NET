// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundFieldFlagsBD")]
[Flags]
public enum SoundFieldFlagsBD : ulong
{
    None = 0x0,

    [NativeName("XR_SOUND_FIELD_ENABLED_BIT_BD")]
    EnabledBit = 0x1,

    [NativeName("XR_SOUND_FIELD_ORIENTATION_BIT_BD")]
    OrientationBit = 0x2,

    [NativeName("XR_SOUND_FIELD_MAIN_VOLUME_BIT_BD")]
    MainVolumeBit = 0x4,

    [NativeName("XR_SOUND_FIELD_LFE_GAIN_BIT_BD")]
    LfeGainBit = 0x8,
}
