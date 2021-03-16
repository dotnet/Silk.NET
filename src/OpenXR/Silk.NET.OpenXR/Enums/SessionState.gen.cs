// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSessionState")]
    public enum SessionState : int
    {
        [NativeName("Name", "XR_SESSION_STATE_UNKNOWN")]
        Unknown = 0,
        [NativeName("Name", "XR_SESSION_STATE_IDLE")]
        Idle = 1,
        [NativeName("Name", "XR_SESSION_STATE_READY")]
        Ready = 2,
        [NativeName("Name", "XR_SESSION_STATE_SYNCHRONIZED")]
        Synchronized = 3,
        [NativeName("Name", "XR_SESSION_STATE_VISIBLE")]
        Visible = 4,
        [NativeName("Name", "XR_SESSION_STATE_FOCUSED")]
        Focused = 5,
        [NativeName("Name", "XR_SESSION_STATE_STOPPING")]
        Stopping = 6,
        [NativeName("Name", "XR_SESSION_STATE_LOSS_PENDING")]
        LossPending = 7,
        [NativeName("Name", "XR_SESSION_STATE_EXITING")]
        Exiting = 8,
    }
}
