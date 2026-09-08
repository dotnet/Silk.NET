// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataUserPresenceChangedEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataUserPresenceChangedEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public StructureType Type = StructureType.EventDataUserPresenceChangedEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public void* Next;

    [NativeName("session")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public SessionHandle Session;

    [NativeName("isUserPresent")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public MaybeBool<uint> IsUserPresent;

    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public EventDataUserPresenceChangedEXT() { }
}
