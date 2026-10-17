// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSpatialEntityPropertiesFB")]
public unsafe partial struct SystemSpatialEntityPropertiesFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.SystemSpatialEntityPropertiesFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("supportsSpatialEntity")]
    public MaybeBool<uint> SupportsSpatialEntity;

    public SystemSpatialEntityPropertiesFB() { }
}
