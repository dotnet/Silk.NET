// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObstacleFlagsBD")]
[Flags]
public enum SoundObstacleFlagsBD : ulong
{
    None = 0x0,

    [NativeName("XR_SOUND_OBSTACLE_ENABLED_BIT_BD")]
    EnabledBit = 0x1,

    [NativeName("XR_SOUND_OBSTACLE_POSE_BIT_BD")]
    PoseBit = 0x2,

    [NativeName("XR_SOUND_OBSTACLE_MESH_BIT_BD")]
    MeshBit = 0x4,

    [NativeName("XR_SOUND_OBSTACLE_MATERIALS_BIT_BD")]
    MaterialsBit = 0x8,
}
