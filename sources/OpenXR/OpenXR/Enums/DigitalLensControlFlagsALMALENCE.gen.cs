// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDigitalLensControlFlagsALMALENCE")]
[Flags]
public enum DigitalLensControlFlagsALMALENCE : ulong
{
    None = 0x0,

    [NativeName("XR_DIGITAL_LENS_CONTROL_PROCESSING_DISABLE_BIT_ALMALENCE")]
    ProcessingDisableBit = 0x1,
}
