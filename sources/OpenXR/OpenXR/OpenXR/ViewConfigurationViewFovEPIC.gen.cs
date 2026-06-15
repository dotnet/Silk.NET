// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViewConfigurationViewFovEPIC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ViewConfigurationViewFovEPIC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    public StructureType Type = StructureType.TypeViewConfigurationViewFovEPIC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    public void* Next;

    [NativeName("recommendedFov")]
    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    public Fovf RecommendedFov;

    [NativeName("maxMutableFov")]
    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    public Fovf MaxMutableFov;

    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    public ViewConfigurationViewFovEPIC() { }
}
