// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneSubmeshStateANDROID")]
public unsafe partial struct SceneSubmeshStateANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.SceneSubmeshStateANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("submeshId")]
    public Uuid SubmeshId;

    [NativeName("lastUpdatedTime")]
    public long LastUpdatedTime;

    [NativeName("submeshPoseInBaseSpace")]
    public Posef SubmeshPoseInBaseSpace;

    [NativeName("bounds")]
    public Extent3Df Bounds;

    public SceneSubmeshStateANDROID() { }
}
