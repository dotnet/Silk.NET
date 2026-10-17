// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemMarkerTrackingPropertiesANDROID")]
public unsafe partial struct SystemMarkerTrackingPropertiesANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.SystemMarkerTrackingPropertiesANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("supportsMarkerTracking")]
    public MaybeBool<uint> SupportsMarkerTracking;

    [NativeName("supportsMarkerSizeEstimation")]
    public MaybeBool<uint> SupportsMarkerSizeEstimation;

    [NativeName("maxMarkerCount")]
    public ushort MaxMarkerCount;

    public SystemMarkerTrackingPropertiesANDROID() { }
}
