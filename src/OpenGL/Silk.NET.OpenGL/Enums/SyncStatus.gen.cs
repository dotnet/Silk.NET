// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
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
