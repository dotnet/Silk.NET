// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInputSourceLocalizedNameFlags")]
[Flags]
public enum InputSourceLocalizedNameFlags : ulong
{
    None = 0x0,

    [NativeName("XR_INPUT_SOURCE_LOCALIZED_NAME_USER_PATH_BIT")]
    UserPathBit = 0x1,

    [NativeName("XR_INPUT_SOURCE_LOCALIZED_NAME_INTERACTION_PROFILE_BIT")]
    InteractionProfileBit = 0x2,

    [NativeName("XR_INPUT_SOURCE_LOCALIZED_NAME_COMPONENT_BIT")]
    ComponentBit = 0x4,
}
