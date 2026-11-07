// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplayPropertiesKHR")]
public unsafe partial struct DisplayPropertiesKHR
{
    [NativeName("display")]
    public DisplayHandleKHR Display;

    [NativeName("displayName")]
    public sbyte* DisplayName;

    [NativeName("physicalDimensions")]
    public Extent2D PhysicalDimensions;

    [NativeName("physicalResolution")]
    public Extent2D PhysicalResolution;

    [NativeName("supportedTransforms")]
    public SurfaceTransformFlagsKHR SupportedTransforms;

    [NativeName("planeReorderPossible")]
    public MaybeBool<uint> PlaneReorderPossible;

    [NativeName("persistentContent")]
    public MaybeBool<uint> PersistentContent;
}
