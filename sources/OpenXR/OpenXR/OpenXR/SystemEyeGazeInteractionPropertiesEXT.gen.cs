// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemEyeGazeInteractionPropertiesEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemEyeGazeInteractionPropertiesEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public StructureType Type = StructureType.SystemEyeGazeInteractionPropertiesEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public void* Next;

    [NativeName("supportsEyeGazeInteraction")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public MaybeBool<uint> SupportsEyeGazeInteraction;

    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public SystemEyeGazeInteractionPropertiesEXT() { }
}
