// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerPassthroughANDROID")]
public unsafe partial struct CompositionLayerPassthroughANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.CompositionLayerPassthroughANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("layerFlags")]
    public CompositionLayerFlags LayerFlags;

    [NativeName("space")]
    public SpaceHandle Space;

    [NativeName("pose")]
    public Posef Pose;

    [NativeName("scale")]
    public Vector3F Scale;

    [NativeName("opacity")]
    public float Opacity;

    [NativeName("layer")]
    public PassthroughLayerHandleANDROID Layer;

    public CompositionLayerPassthroughANDROID() { }
}
