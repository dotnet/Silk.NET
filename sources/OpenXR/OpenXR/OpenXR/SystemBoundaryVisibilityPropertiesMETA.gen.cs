// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemBoundaryVisibilityPropertiesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemBoundaryVisibilityPropertiesMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    public StructureType Type = StructureType.SystemBoundaryVisibilityPropertiesMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    public void* Next;

    [NativeName("supportsBoundaryVisibility")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    public MaybeBool<uint> SupportsBoundaryVisibility;

    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    public SystemBoundaryVisibilityPropertiesMETA() { }
}
