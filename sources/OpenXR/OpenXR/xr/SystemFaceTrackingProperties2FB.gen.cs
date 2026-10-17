// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemFaceTrackingProperties2FB")]
public unsafe partial struct SystemFaceTrackingProperties2FB
{
    [NativeName("type")]
    public StructureType Type = StructureType.SystemFaceTrackingProperties2FB;

    [NativeName("next")]
    public void* Next;

    [NativeName("supportsVisualFaceTracking")]
    public MaybeBool<uint> SupportsVisualFaceTracking;

    [NativeName("supportsAudioFaceTracking")]
    public MaybeBool<uint> SupportsAudioFaceTracking;

    public SystemFaceTrackingProperties2FB() { }
}
