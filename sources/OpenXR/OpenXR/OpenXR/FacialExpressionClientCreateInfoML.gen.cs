// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialExpressionClientCreateInfoML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FacialExpressionClientCreateInfoML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public StructureType Type = StructureType.TypeFacialExpressionClientCreateInfoML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public void* Next;

    [NativeName("requestedCount")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public uint RequestedCount;

    [NativeName("requestedFacialBlendShapes")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public FacialBlendShapeML* RequestedFacialBlendShapes;

    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public FacialExpressionClientCreateInfoML() { }
}
