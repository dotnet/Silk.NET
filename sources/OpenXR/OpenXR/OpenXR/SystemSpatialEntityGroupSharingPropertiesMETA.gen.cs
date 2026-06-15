// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSpatialEntityGroupSharingPropertiesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemSpatialEntityGroupSharingPropertiesMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    public StructureType Type = StructureType.TypeSystemSpatialEntityGroupSharingPropertiesMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    public void* Next;

    [NativeName("supportsSpatialEntityGroupSharing")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    public MaybeBool<uint> SupportsSpatialEntityGroupSharing;

    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    public SystemSpatialEntityGroupSharingPropertiesMETA() { }
}
