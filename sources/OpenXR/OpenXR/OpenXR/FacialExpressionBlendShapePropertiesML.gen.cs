// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialExpressionBlendShapePropertiesML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FacialExpressionBlendShapePropertiesML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public StructureType Type = StructureType.TypeFacialExpressionBlendShapePropertiesML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public void* Next;

    [NativeName("requestedFacialBlendShape")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public FacialBlendShapeML RequestedFacialBlendShape;

    [NativeName("weight")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public float Weight;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public FacialExpressionBlendShapePropertiesFlagsML Flags;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public FacialExpressionBlendShapePropertiesML() { }
}
