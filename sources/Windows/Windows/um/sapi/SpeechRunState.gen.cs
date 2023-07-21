// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static Silk.NET.Windows.SPRUNSTATE;

namespace Silk.NET.Windows;

/// <include file='SpeechRunState.xml' path='doc/member[@name="SpeechRunState"]/*' />
public enum SpeechRunState
{
    /// <include file='SpeechRunState.xml' path='doc/member[@name="SpeechRunState.SRSEDone"]/*' />
    SRSEDone = SPRS_DONE,

    /// <include file='SpeechRunState.xml' path='doc/member[@name="SpeechRunState.SRSEIsSpeaking"]/*' />
    SRSEIsSpeaking = SPRS_IS_SPEAKING,
}
