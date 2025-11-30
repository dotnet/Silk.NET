// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SyncStatus")]
[Transformed]
public enum SyncStatus : uint
{
    [NativeName("GL_ALREADY_SIGNALED")]
    AlreadySignaled = unchecked((uint)0x911A),

    [NativeName("GL_TIMEOUT_EXPIRED")]
    TimeoutExpired = unchecked((uint)0x911B),

    [NativeName("GL_CONDITION_SATISFIED")]
    ConditionSatisfied = unchecked((uint)0x911C),

    [NativeName("GL_WAIT_FAILED")]
    WaitFailed = unchecked((uint)0x911D),
}
