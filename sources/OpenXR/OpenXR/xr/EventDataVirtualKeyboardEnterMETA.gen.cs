// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataVirtualKeyboardEnterMETA")]
public unsafe partial struct EventDataVirtualKeyboardEnterMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.EventDataVirtualKeyboardEnterMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("keyboard")]
    public VirtualKeyboardHandleMETA Keyboard;

    public EventDataVirtualKeyboardEnterMETA() { }
}
