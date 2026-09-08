// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundTriangleMeshBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SoundTriangleMeshBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public StructureType Type = StructureType.SoundTriangleMeshBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public void* Next;

    [NativeName("vertexCount")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public uint VertexCount;

    [NativeName("vertices")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public Vector3F* Vertices;

    [NativeName("indexCount")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public uint IndexCount;

    [NativeName("indices")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public uint* Indices;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public SoundTriangleMeshBD() { }
}
