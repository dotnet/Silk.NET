// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum SyncStatus
    {
        AlreadySignaled = 0x911A,
        TimeoutExpired = 0x911B,
        ConditionSatisfied = 0x911C,
        WaitFailed = 0x911D,
    }
}
