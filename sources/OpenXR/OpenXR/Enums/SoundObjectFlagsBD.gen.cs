// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObjectFlagsBD")]
[Flags]
public enum SoundObjectFlagsBD : ulong
{
    None = 0x0,

    [NativeName("XR_SOUND_OBJECT_ENABLED_BIT_BD")]
    EnabledBit = 0x1,

    [NativeName("XR_SOUND_OBJECT_POSE_BIT_BD")]
    PoseBit = 0x2,

    [NativeName("XR_SOUND_OBJECT_DIRECTIVITY_BIT_BD")]
    DirectivityBit = 0x4,

    [NativeName("XR_SOUND_OBJECT_SHAPE_BIT_BD")]
    ShapeBit = 0x8,

    [NativeName("XR_SOUND_OBJECT_MAIN_VOLUME_BIT_BD")]
    MainVolumeBit = 0x10,

    [NativeName("XR_SOUND_OBJECT_REFLECTION_GAIN_BIT_BD")]
    ReflectionGainBit = 0x20,

    [NativeName("XR_SOUND_OBJECT_ENABLE_DOPPLER_BIT_BD")]
    EnableDopplerBit = 0x40,

    [NativeName("XR_SOUND_OBJECT_DIRECT_SOUND_ATTENUATION_BIT_BD")]
    DirectSoundAttenuationBit = 0x80,

    [NativeName("XR_SOUND_OBJECT_INDIRECT_SOUND_ATTENUATION_BIT_BD")]
    IndirectSoundAttenuationBit = 0x100,
}
