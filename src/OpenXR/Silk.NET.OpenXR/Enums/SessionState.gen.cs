// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
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
