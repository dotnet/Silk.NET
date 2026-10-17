// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRenderModelPropertiesEXT")]
public unsafe partial struct RenderModelPropertiesEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.RenderModelPropertiesEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("cacheId")]
    public Uuid CacheId;

    [NativeName("animatableNodeCount")]
    public uint AnimatableNodeCount;

    public RenderModelPropertiesEXT() { }
}
