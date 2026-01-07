// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SyncStatus")]
public enum SyncStatus : uint
{
    [NativeName("GL_ALREADY_SIGNALED")]
    AlreadySignaled = 37146,

    [NativeName("GL_TIMEOUT_EXPIRED")]
    TimeoutExpired = 37147,

    [NativeName("GL_CONDITION_SATISFIED")]
    ConditionSatisfied = 37148,

    [NativeName("GL_WAIT_FAILED")]
    WaitFailed = 37149,
}
