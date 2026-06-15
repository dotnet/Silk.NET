// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemUserPresencePropertiesEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemUserPresencePropertiesEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public StructureType Type = StructureType.TypeSystemUserPresencePropertiesEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public void* Next;

    [NativeName("supportsUserPresence")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public MaybeBool<uint> SupportsUserPresence;

    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public SystemUserPresencePropertiesEXT() { }
}
