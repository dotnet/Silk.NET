// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public enum SessionState
    {
        Unknown = 0,
        Idle = 1,
        Ready = 2,
        Synchronized = 3,
        Visible = 4,
        Focused = 5,
        Stopping = 6,
        LossPending = 7,
        Exiting = 8,
    }
}
