// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialComponentDataQueryResultEXT")]
public unsafe partial struct SpatialComponentDataQueryResultEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpatialComponentDataQueryResultEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("entityIdCapacityInput")]
    public uint EntityIdCapacityInput;

    [NativeName("entityIdCountOutput")]
    public uint EntityIdCountOutput;

    [NativeName("entityIds")]
    public ulong* EntityIds;

    [NativeName("entityStateCapacityInput")]
    public uint EntityStateCapacityInput;

    [NativeName("entityStateCountOutput")]
    public uint EntityStateCountOutput;

    [NativeName("entityStates")]
    public SpatialEntityTrackingStateEXT* EntityStates;

    public SpatialComponentDataQueryResultEXT() { }
}
