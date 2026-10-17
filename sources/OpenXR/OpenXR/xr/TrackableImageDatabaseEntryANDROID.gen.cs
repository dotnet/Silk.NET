// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackableImageDatabaseEntryANDROID")]
public unsafe partial struct TrackableImageDatabaseEntryANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.TrackableImageDatabaseEntryANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("trackingMode")]
    public TrackableImageTrackingModeANDROID TrackingMode;

    [NativeName("physicalWidth")]
    public float PhysicalWidth;

    [NativeName("imageWidth")]
    public uint ImageWidth;

    [NativeName("imageHeight")]
    public uint ImageHeight;

    [NativeName("format")]
    public TrackableImageFormatANDROID Format;

    [NativeName("bufferSize")]
    public uint BufferSize;

    [NativeName("buffer")]
    public byte* Buffer;

    public TrackableImageDatabaseEntryANDROID() { }
}
