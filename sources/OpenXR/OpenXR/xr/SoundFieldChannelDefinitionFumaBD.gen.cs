// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundFieldChannelDefinitionFumaBD")]
public unsafe partial struct SoundFieldChannelDefinitionFumaBD
{
    [NativeName("type")]
    public StructureType Type = StructureType.SoundFieldChannelDefinitionFumaBD;

    [NativeName("next")]
    public void* Next;

    [NativeName("channelMask")]
    public SoundFieldChannelMaskFumaBD ChannelMask;

    public SoundFieldChannelDefinitionFumaBD() { }
}
