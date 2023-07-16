// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPWORDPRONOUNCEABLE;

namespace Silk.NET.Windows;
/// <include file='SpeechWordPronounceable.xml' path='doc/member[@name="SpeechWordPronounceable"]/*'/>
public enum SpeechWordPronounceable
{
    /// <include file='SpeechWordPronounceable.xml' path='doc/member[@name="SpeechWordPronounceable.SWPUnknownWordUnpronounceable"]/*'/>
    SWPUnknownWordUnpronounceable = SPWP_UNKNOWN_WORD_UNPRONOUNCEABLE,
    /// <include file='SpeechWordPronounceable.xml' path='doc/member[@name="SpeechWordPronounceable.SWPUnknownWordPronounceable"]/*'/>
    SWPUnknownWordPronounceable = SPWP_UNKNOWN_WORD_PRONOUNCEABLE,
    /// <include file='SpeechWordPronounceable.xml' path='doc/member[@name="SpeechWordPronounceable.SWPKnownWordPronounceable"]/*'/>
    SWPKnownWordPronounceable = SPWP_KNOWN_WORD_PRONOUNCEABLE,
}