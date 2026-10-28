// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSessionState")]
[SupportedApiProfile("openxr")]
public enum SessionState : uint
{
    [NativeName("XR_SESSION_STATE_UNKNOWN")]
    [SupportedApiProfile("openxr")]
    Unknown = 0,

    [NativeName("XR_SESSION_STATE_IDLE")]
    [SupportedApiProfile("openxr")]
    Idle = 1,

    [NativeName("XR_SESSION_STATE_READY")]
    [SupportedApiProfile("openxr")]
    Ready = 2,

    [NativeName("XR_SESSION_STATE_SYNCHRONIZED")]
    [SupportedApiProfile("openxr")]
    Synchronized = 3,

    [NativeName("XR_SESSION_STATE_VISIBLE")]
    [SupportedApiProfile("openxr")]
    Visible = 4,

    [NativeName("XR_SESSION_STATE_FOCUSED")]
    [SupportedApiProfile("openxr")]
    Focused = 5,

    [NativeName("XR_SESSION_STATE_STOPPING")]
    [SupportedApiProfile("openxr")]
    Stopping = 6,

    [NativeName("XR_SESSION_STATE_LOSS_PENDING")]
    [SupportedApiProfile("openxr")]
    LossPending = 7,

    [NativeName("XR_SESSION_STATE_EXITING")]
    [SupportedApiProfile("openxr")]
    Exiting = 8,
}
