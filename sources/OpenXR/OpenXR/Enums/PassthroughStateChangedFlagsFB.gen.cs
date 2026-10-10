// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughStateChangedFlagsFB")]
[Flags]
public enum PassthroughStateChangedFlagsFB : ulong
{
    None = 0x0,

    [NativeName("XR_PASSTHROUGH_STATE_CHANGED_REINIT_REQUIRED_BIT_FB")]
    ReinitRequiredBit = 0x1,

    [NativeName("XR_PASSTHROUGH_STATE_CHANGED_NON_RECOVERABLE_ERROR_BIT_FB")]
    NonRecoverableErrorBit = 0x2,

    [NativeName("XR_PASSTHROUGH_STATE_CHANGED_RECOVERABLE_ERROR_BIT_FB")]
    RecoverableErrorBit = 0x4,

    [NativeName("XR_PASSTHROUGH_STATE_CHANGED_RESTORED_ERROR_BIT_FB")]
    RestoredErrorBit = 0x8,
}
