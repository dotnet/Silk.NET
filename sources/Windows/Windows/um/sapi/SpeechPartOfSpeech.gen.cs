// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static Silk.NET.Windows.SPPARTOFSPEECH;

namespace Silk.NET.Windows;

/// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech"]/*' />
public enum SpeechPartOfSpeech
{
    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSNotOverriden"]/*' />
    SPSNotOverriden = SPPS_NotOverriden,

    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSUnknown"]/*' />
    SPSUnknown = SPPS_Unknown,

    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSNoun"]/*' />
    SPSNoun = SPPS_Noun,

    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSVerb"]/*' />
    SPSVerb = SPPS_Verb,

    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSModifier"]/*' />
    SPSModifier = SPPS_Modifier,

    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSFunction"]/*' />
    SPSFunction = SPPS_Function,

    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSInterjection"]/*' />
    SPSInterjection = SPPS_Interjection,

    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSLMA"]/*' />
    SPSLMA = SPPS_LMA,

    /// <include file='SpeechPartOfSpeech.xml' path='doc/member[@name="SpeechPartOfSpeech.SPSSuppressWord"]/*' />
    SPSSuppressWord = SPPS_SuppressWord,
}
