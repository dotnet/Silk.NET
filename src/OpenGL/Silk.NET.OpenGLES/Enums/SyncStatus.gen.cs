// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "SyncStatus")]
    public enum SyncStatus : int
    {
        [NativeName("Name", "GL_ALREADY_SIGNALED")]
        AlreadySignaled = 0x911A,
        [NativeName("Name", "GL_TIMEOUT_EXPIRED")]
        TimeoutExpired = 0x911B,
        [NativeName("Name", "GL_CONDITION_SATISFIED")]
        ConditionSatisfied = 0x911C,
        [NativeName("Name", "GL_WAIT_FAILED")]
        WaitFailed = 0x911D,
    }
}
