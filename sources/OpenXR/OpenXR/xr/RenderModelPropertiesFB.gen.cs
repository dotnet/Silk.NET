// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRenderModelPropertiesFB")]
public unsafe partial struct RenderModelPropertiesFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.RenderModelPropertiesFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("vendorId")]
    public uint VendorId;

    [NativeName("modelName")]
    public RenderModelPropertiesFBModelName ModelName;

    [NativeName("modelKey")]
    public ulong ModelKey;

    [NativeName("modelVersion")]
    public uint ModelVersion;

    [NativeName("flags")]
    public RenderModelFlagsFB Flags;

    public RenderModelPropertiesFB() { }
}
