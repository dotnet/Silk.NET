// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialEntityComponentDataSemanticBD")]
public unsafe partial struct SpatialEntityComponentDataSemanticBD
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpatialEntityComponentDataSemanticBD;

    [NativeName("next")]
    public void* Next;

    [NativeName("labelCapacityInput")]
    public uint LabelCapacityInput;

    [NativeName("labelCountOutput")]
    public uint LabelCountOutput;

    [NativeName("labels")]
    public SemanticLabelBD* Labels;

    public SpatialEntityComponentDataSemanticBD() { }
}
