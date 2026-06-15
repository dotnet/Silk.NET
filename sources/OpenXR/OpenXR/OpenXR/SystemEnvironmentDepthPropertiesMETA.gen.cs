// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemEnvironmentDepthPropertiesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemEnvironmentDepthPropertiesMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public StructureType Type = StructureType.TypeSystemEnvironmentDepthPropertiesMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public void* Next;

    [NativeName("supportsEnvironmentDepth")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public MaybeBool<uint> SupportsEnvironmentDepth;

    [NativeName("supportsHandRemoval")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public MaybeBool<uint> SupportsHandRemoval;

    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public SystemEnvironmentDepthPropertiesMETA() { }
}
