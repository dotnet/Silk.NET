// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointLocationsBD")]
public unsafe partial struct BodyJointLocationsBD
{
    [NativeName("type")]
    public StructureType Type = StructureType.BodyJointLocationsBD;

    [NativeName("next")]
    public void* Next;

    [NativeName("allJointPosesTracked")]
    public MaybeBool<uint> AllJointPosesTracked;

    [NativeName("jointLocationCount")]
    public uint JointLocationCount;

    [NativeName("jointLocations")]
    public BodyJointLocationBD* JointLocations;

    public BodyJointLocationsBD() { }
}
