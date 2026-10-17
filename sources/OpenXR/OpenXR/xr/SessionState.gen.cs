// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSessionState")]
public enum SessionState : uint
{
    [NativeName("XR_SESSION_STATE_UNKNOWN")]
    Unknown = 0,

    [NativeName("XR_SESSION_STATE_IDLE")]
    Idle = 1,

    [NativeName("XR_SESSION_STATE_READY")]
    Ready = 2,

    [NativeName("XR_SESSION_STATE_SYNCHRONIZED")]
    Synchronized = 3,

    [NativeName("XR_SESSION_STATE_VISIBLE")]
    Visible = 4,

    [NativeName("XR_SESSION_STATE_FOCUSED")]
    Focused = 5,

    [NativeName("XR_SESSION_STATE_STOPPING")]
    Stopping = 6,

    [NativeName("XR_SESSION_STATE_LOSS_PENDING")]
    LossPending = 7,

    [NativeName("XR_SESSION_STATE_EXITING")]
    Exiting = 8,
}
