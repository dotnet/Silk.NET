// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemProperties")]
public unsafe partial struct SystemProperties
{
    [NativeName("type")]
    public StructureType Type = StructureType.SystemProperties;

    [NativeName("next")]
    public void* Next;

    [NativeName("systemId")]
    public ulong SystemId;

    [NativeName("vendorId")]
    public uint VendorId;

    [NativeName("systemName")]
    public SystemPropertiesSystemName SystemName;

    [NativeName("graphicsProperties")]
    public SystemGraphicsProperties GraphicsProperties;

    [NativeName("trackingProperties")]
    public SystemTrackingProperties TrackingProperties;

    public SystemProperties() { }
}
