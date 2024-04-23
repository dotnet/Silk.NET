// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFutureStateEXT")]
    public enum FutureStateEXT : int
    {
        [Obsolete("Deprecated in favour of \"PendingExt\"")]
        [NativeName("Name", "XR_FUTURE_STATE_PENDING_EXT")]
        FutureStatePendingExt = 1,
        [Obsolete("Deprecated in favour of \"ReadyExt\"")]
        [NativeName("Name", "XR_FUTURE_STATE_READY_EXT")]
        FutureStateReadyExt = 2,
        [NativeName("Name", "XR_FUTURE_STATE_PENDING_EXT")]
        PendingExt = 1,
        [NativeName("Name", "XR_FUTURE_STATE_READY_EXT")]
        ReadyExt = 2,
    }
}
