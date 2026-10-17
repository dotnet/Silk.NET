// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardLocationInfoMETA")]
public unsafe partial struct VirtualKeyboardLocationInfoMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.VirtualKeyboardLocationInfoMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("locationType")]
    public VirtualKeyboardLocationTypeMETA LocationType;

    [NativeName("space")]
    public SpaceHandle Space;

    [NativeName("poseInSpace")]
    public Posef PoseInSpace;

    [NativeName("scale")]
    public float Scale;

    public VirtualKeyboardLocationInfoMETA() { }
}
