// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSessionCreateInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SessionCreateInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.SessionCreateInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("createFlags")]
    [SupportedApiProfile("openxr")]
    public SessionCreateFlags CreateFlags;

    [NativeName("systemId")]
    [SupportedApiProfile("openxr")]
    public ulong SystemId;

    [SupportedApiProfile("openxr")]
    public SessionCreateInfo() { }
}
