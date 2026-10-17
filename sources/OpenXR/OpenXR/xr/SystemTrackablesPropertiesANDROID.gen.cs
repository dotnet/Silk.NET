// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemTrackablesPropertiesANDROID")]
public unsafe partial struct SystemTrackablesPropertiesANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.SystemTrackablesPropertiesANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("supportsAnchor")]
    public MaybeBool<uint> SupportsAnchor;

    [NativeName("maxAnchors")]
    public uint MaxAnchors;

    public SystemTrackablesPropertiesANDROID() { }
}
