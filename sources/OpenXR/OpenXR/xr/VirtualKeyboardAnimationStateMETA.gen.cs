// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardAnimationStateMETA")]
public unsafe partial struct VirtualKeyboardAnimationStateMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.VirtualKeyboardAnimationStateMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("animationIndex")]
    public int AnimationIndex;

    [NativeName("fraction")]
    public float Fraction;

    public VirtualKeyboardAnimationStateMETA() { }
}
