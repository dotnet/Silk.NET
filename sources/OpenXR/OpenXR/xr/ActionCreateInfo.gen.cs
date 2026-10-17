// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionCreateInfo")]
public unsafe partial struct ActionCreateInfo
{
    [NativeName("type")]
    public StructureType Type = StructureType.ActionCreateInfo;

    [NativeName("next")]
    public void* Next;

    [NativeName("actionName")]
    public ActionCreateInfoActionName ActionName;

    [NativeName("actionType")]
    public ActionType ActionType;

    [NativeName("countSubactionPaths")]
    public uint CountSubactionPaths;

    [NativeName("subactionPaths")]
    public ulong* SubactionPaths;

    [NativeName("localizedActionName")]
    public ActionCreateInfoLocalizedActionName LocalizedActionName;

    public ActionCreateInfo() { }
}
