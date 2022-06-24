// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrPassthroughStateChangedFlagsFB")]
    public enum PassthroughStateChangedFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ReinitRequiredBitFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_STATE_CHANGED_REINIT_REQUIRED_BIT_FB")]
        PassthroughStateChangedReinitRequiredBitFB = 1,
        [Obsolete("Deprecated in favour of \"NonRecoverableErrorBitFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_STATE_CHANGED_NON_RECOVERABLE_ERROR_BIT_FB")]
        PassthroughStateChangedNonRecoverableErrorBitFB = 2,
        [Obsolete("Deprecated in favour of \"RecoverableErrorBitFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_STATE_CHANGED_RECOVERABLE_ERROR_BIT_FB")]
        PassthroughStateChangedRecoverableErrorBitFB = 4,
        [Obsolete("Deprecated in favour of \"RestoredErrorBitFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_STATE_CHANGED_RESTORED_ERROR_BIT_FB")]
        PassthroughStateChangedRestoredErrorBitFB = 8,
        [NativeName("Name", "XR_PASSTHROUGH_STATE_CHANGED_REINIT_REQUIRED_BIT_FB")]
        ReinitRequiredBitFB = 1,
        [NativeName("Name", "XR_PASSTHROUGH_STATE_CHANGED_NON_RECOVERABLE_ERROR_BIT_FB")]
        NonRecoverableErrorBitFB = 2,
        [NativeName("Name", "XR_PASSTHROUGH_STATE_CHANGED_RECOVERABLE_ERROR_BIT_FB")]
        RecoverableErrorBitFB = 4,
        [NativeName("Name", "XR_PASSTHROUGH_STATE_CHANGED_RESTORED_ERROR_BIT_FB")]
        RestoredErrorBitFB = 8,
    }
}
