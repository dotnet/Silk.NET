// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFutureStateEXT")]
[SupportedApiProfile("openxr")]
public enum FutureStateEXT : uint
{
    [NativeName("XR_FUTURE_STATE_PENDING_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    Pending = 1,

    [NativeName("XR_FUTURE_STATE_READY_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    Ready = 2,
}
