// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerQuad")]
public unsafe partial struct CompositionLayerQuad
{
    [NativeName("type")]
    public StructureType Type = StructureType.CompositionLayerQuad;

    [NativeName("next")]
    public void* Next;

    [NativeName("layerFlags")]
    public CompositionLayerFlags LayerFlags;

    [NativeName("space")]
    public SpaceHandle Space;

    [NativeName("eyeVisibility")]
    public EyeVisibility EyeVisibility;

    [NativeName("subImage")]
    public SwapchainSubImage SubImage;

    [NativeName("pose")]
    public Posef Pose;

    [NativeName("size")]
    public Extent2Df Size;

    public CompositionLayerQuad() { }
}
