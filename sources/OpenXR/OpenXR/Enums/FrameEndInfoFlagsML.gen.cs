// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFrameEndInfoFlagsML")]
[Flags]
public enum FrameEndInfoFlagsML : ulong
{
    None = 0x0,

    [NativeName("XR_FRAME_END_INFO_PROTECTED_BIT_ML")]
    ProtectedBit = 0x1,

    [NativeName("XR_FRAME_END_INFO_VIGNETTE_BIT_ML")]
    VignetteBit = 0x2,
}
