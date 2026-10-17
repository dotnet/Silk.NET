// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrControllerModelPropertiesMSFT")]
public unsafe partial struct ControllerModelPropertiesMSFT
{
    [NativeName("type")]
    public StructureType Type = StructureType.ControllerModelPropertiesMSFT;

    [NativeName("next")]
    public void* Next;

    [NativeName("nodeCapacityInput")]
    public uint NodeCapacityInput;

    [NativeName("nodeCountOutput")]
    public uint NodeCountOutput;

    [NativeName("nodeProperties")]
    public ControllerModelNodePropertiesMSFT* NodeProperties;

    public ControllerModelPropertiesMSFT() { }
}
