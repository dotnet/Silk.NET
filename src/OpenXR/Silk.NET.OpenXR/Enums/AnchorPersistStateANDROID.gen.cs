// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrAnchorPersistStateANDROID")]
    public enum AnchorPersistStateANDROID : int
    {
        [Obsolete("Deprecated in favour of \"NotRequestedAndroid\"")]
        [NativeName("Name", "XR_ANCHOR_PERSIST_STATE_PERSIST_NOT_REQUESTED_ANDROID")]
        AnchorPersistStatePersistNotRequestedAndroid = 0,
        [Obsolete("Deprecated in favour of \"PendingAndroid\"")]
        [NativeName("Name", "XR_ANCHOR_PERSIST_STATE_PERSIST_PENDING_ANDROID")]
        AnchorPersistStatePersistPendingAndroid = 1,
        [Obsolete("Deprecated in favour of \"DAndroid\"")]
        [NativeName("Name", "XR_ANCHOR_PERSIST_STATE_PERSISTED_ANDROID")]
        AnchorPersistStatePersistedAndroid = 2,
        [NativeName("Name", "XR_ANCHOR_PERSIST_STATE_PERSIST_NOT_REQUESTED_ANDROID")]
        NotRequestedAndroid = 0,
        [NativeName("Name", "XR_ANCHOR_PERSIST_STATE_PERSIST_PENDING_ANDROID")]
        PendingAndroid = 1,
        [NativeName("Name", "XR_ANCHOR_PERSIST_STATE_PERSISTED_ANDROID")]
        DAndroid = 2,
    }
}
