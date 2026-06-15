// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointLocationsBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BodyJointLocationsBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public StructureType Type = StructureType.TypeBodyJointLocationsBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public void* Next;

    [NativeName("allJointPosesTracked")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public MaybeBool<uint> AllJointPosesTracked;

    [NativeName("jointLocationCount")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public uint JointLocationCount;

    [NativeName("jointLocations")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public BodyJointLocationBD* JointLocations;

    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public BodyJointLocationsBD() { }
}
