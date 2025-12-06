// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum SyncStatus : uint
{
    AlreadySignaled = unchecked((uint)0x911A),
    TimeoutExpired = unchecked((uint)0x911B),
    ConditionSatisfied = unchecked((uint)0x911C),
    WaitFailed = unchecked((uint)0x911D),
}
