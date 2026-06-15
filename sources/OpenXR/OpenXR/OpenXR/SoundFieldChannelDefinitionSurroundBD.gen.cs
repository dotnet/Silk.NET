// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundFieldChannelDefinitionSurroundBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SoundFieldChannelDefinitionSurroundBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.TypeSoundFieldChannelDefinitionSurroundBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("channelMask")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundFieldChannelMaskSurroundBD ChannelMask;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundFieldChannelDefinitionSurroundBD() { }
}
