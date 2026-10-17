// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialComponentBounded3DListEXT")]
public unsafe partial struct SpatialComponentBounded3DListEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpatialComponentBounded3DListEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("boundCount")]
    public uint BoundCount;

    [NativeName("bounds")]
    public Boxf* Bounds;

    public SpatialComponentBounded3DListEXT() { }
}
