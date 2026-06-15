// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionSetCreateInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ActionSetCreateInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeActionSetCreateInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("actionSetName")]
    [SupportedApiProfile("openxr")]
    public ActionSetCreateInfoActionSetName ActionSetName;

    [NativeName("localizedActionSetName")]
    [SupportedApiProfile("openxr")]
    public ActionSetCreateInfoLocalizedActionSetName LocalizedActionSetName;

    [NativeName("priority")]
    [SupportedApiProfile("openxr")]
    public uint Priority;

    [SupportedApiProfile("openxr")]
    public ActionSetCreateInfo() { }
}
