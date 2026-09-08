// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrOverlayMainSessionFlagsEXTX")]
[Flags]
public enum OverlayMainSessionFlagsEXTX : ulong
{
    None = 0x0,

    [NativeName("XR_OVERLAY_MAIN_SESSION_ENABLED_COMPOSITION_LAYER_INFO_DEPTH_BIT_EXTX")]
    EnabledCompositionLayerInfoDepthBit = 0x1,
}
