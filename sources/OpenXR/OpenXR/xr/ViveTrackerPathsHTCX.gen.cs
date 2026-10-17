// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViveTrackerPathsHTCX")]
public unsafe partial struct ViveTrackerPathsHTCX
{
    [NativeName("type")]
    public StructureType Type = StructureType.ViveTrackerPathsHTCX;

    [NativeName("next")]
    public void* Next;

    [NativeName("persistentPath")]
    public ulong PersistentPath;

    [NativeName("rolePath")]
    public ulong RolePath;

    public ViveTrackerPathsHTCX() { }
}
