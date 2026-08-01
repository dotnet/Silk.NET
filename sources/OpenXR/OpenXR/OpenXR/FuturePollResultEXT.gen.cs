// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFuturePollResultEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FuturePollResultEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    public StructureType Type = StructureType.FuturePollResultEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    public void* Next;

    [NativeName("state")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    public FutureStateEXT State;

    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    public FuturePollResultEXT() { }
}
