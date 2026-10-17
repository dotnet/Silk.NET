// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExternalCameraOCULUS")]
public unsafe partial struct ExternalCameraOCULUS
{
    [NativeName("type")]
    public StructureType Type = StructureType.ExternalCameraOCULUS;

    [NativeName("next")]
    public void* Next;

    [NativeName("name")]
    public ExternalCameraOCULUSName Name;

    [NativeName("intrinsics")]
    public ExternalCameraIntrinsicsOCULUS Intrinsics;

    [NativeName("extrinsics")]
    public ExternalCameraExtrinsicsOCULUS Extrinsics;

    public ExternalCameraOCULUS() { }
}
