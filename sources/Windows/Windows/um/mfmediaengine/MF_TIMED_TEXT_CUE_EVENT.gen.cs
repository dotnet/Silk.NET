// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_TIMED_TEXT_CUE_EVENT.xml' path='doc/member[@name="MF_TIMED_TEXT_CUE_EVENT"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_CUE_EVENT
{
    /// <include file='MF_TIMED_TEXT_CUE_EVENT.xml' path='doc/member[@name="MF_TIMED_TEXT_CUE_EVENT.MF_TIMED_TEXT_CUE_EVENT_ACTIVE"]/*' />
    MF_TIMED_TEXT_CUE_EVENT_ACTIVE = 0,

    /// <include file='MF_TIMED_TEXT_CUE_EVENT.xml' path='doc/member[@name="MF_TIMED_TEXT_CUE_EVENT.MF_TIMED_TEXT_CUE_EVENT_INACTIVE"]/*' />
    MF_TIMED_TEXT_CUE_EVENT_INACTIVE = (MF_TIMED_TEXT_CUE_EVENT_ACTIVE + 1),

    /// <include file='MF_TIMED_TEXT_CUE_EVENT.xml' path='doc/member[@name="MF_TIMED_TEXT_CUE_EVENT.MF_TIMED_TEXT_CUE_EVENT_CLEAR"]/*' />
    MF_TIMED_TEXT_CUE_EVENT_CLEAR = (MF_TIMED_TEXT_CUE_EVENT_INACTIVE + 1),
}
