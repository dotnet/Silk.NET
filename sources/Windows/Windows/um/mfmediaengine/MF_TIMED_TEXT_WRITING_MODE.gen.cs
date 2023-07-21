// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_TIMED_TEXT_WRITING_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_WRITING_MODE"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_WRITING_MODE
{
    /// <include file='MF_TIMED_TEXT_WRITING_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_WRITING_MODE.MF_TIMED_TEXT_WRITING_MODE_LRTB"]/*' />
    MF_TIMED_TEXT_WRITING_MODE_LRTB = 0,

    /// <include file='MF_TIMED_TEXT_WRITING_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_WRITING_MODE.MF_TIMED_TEXT_WRITING_MODE_RLTB"]/*' />
    MF_TIMED_TEXT_WRITING_MODE_RLTB = 1,

    /// <include file='MF_TIMED_TEXT_WRITING_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_WRITING_MODE.MF_TIMED_TEXT_WRITING_MODE_TBRL"]/*' />
    MF_TIMED_TEXT_WRITING_MODE_TBRL = 2,

    /// <include file='MF_TIMED_TEXT_WRITING_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_WRITING_MODE.MF_TIMED_TEXT_WRITING_MODE_TBLR"]/*' />
    MF_TIMED_TEXT_WRITING_MODE_TBLR = 3,

    /// <include file='MF_TIMED_TEXT_WRITING_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_WRITING_MODE.MF_TIMED_TEXT_WRITING_MODE_LR"]/*' />
    MF_TIMED_TEXT_WRITING_MODE_LR = 4,

    /// <include file='MF_TIMED_TEXT_WRITING_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_WRITING_MODE.MF_TIMED_TEXT_WRITING_MODE_RL"]/*' />
    MF_TIMED_TEXT_WRITING_MODE_RL = 5,

    /// <include file='MF_TIMED_TEXT_WRITING_MODE.xml' path='doc/member[@name="MF_TIMED_TEXT_WRITING_MODE.MF_TIMED_TEXT_WRITING_MODE_TB"]/*' />
    MF_TIMED_TEXT_WRITING_MODE_TB = 6,
}
