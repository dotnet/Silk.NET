// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSpatialEntityGroupSharingPropertiesMETA")]
public unsafe partial struct SystemSpatialEntityGroupSharingPropertiesMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.SystemSpatialEntityGroupSharingPropertiesMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("supportsSpatialEntityGroupSharing")]
    public MaybeBool<uint> SupportsSpatialEntityGroupSharing;

    public SystemSpatialEntityGroupSharingPropertiesMETA() { }
}
