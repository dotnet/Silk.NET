// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerDepthInfoKHR")]
public unsafe partial struct CompositionLayerDepthInfoKHR
{
    [NativeName("type")]
    public StructureType Type = StructureType.CompositionLayerDepthInfoKHR;

    [NativeName("next")]
    public void* Next;

    [NativeName("subImage")]
    public SwapchainSubImage SubImage;

    [NativeName("minDepth")]
    public float MinDepth;

    [NativeName("maxDepth")]
    public float MaxDepth;

    [NativeName("nearZ")]
    public float NearZ;

    [NativeName("farZ")]
    public float FarZ;

    public CompositionLayerDepthInfoKHR() { }
}
