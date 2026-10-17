// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRenderModelStateEXT")]
public unsafe partial struct RenderModelStateEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.RenderModelStateEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("nodeStateCount")]
    public uint NodeStateCount;

    [NativeName("nodeStates")]
    public RenderModelNodeStateEXT* NodeStates;

    public RenderModelStateEXT() { }
}
