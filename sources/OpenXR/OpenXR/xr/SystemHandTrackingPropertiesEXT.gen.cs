// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemHandTrackingPropertiesEXT")]
public unsafe partial struct SystemHandTrackingPropertiesEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.SystemHandTrackingPropertiesEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("supportsHandTracking")]
    public MaybeBool<uint> SupportsHandTracking;

    public SystemHandTrackingPropertiesEXT() { }
}
