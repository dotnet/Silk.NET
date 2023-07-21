// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SpeechSpecialTransitionType.xml' path='doc/member[@name="SpeechSpecialTransitionType"]/*' />
public enum SpeechSpecialTransitionType
{
    /// <include file='SpeechSpecialTransitionType.xml' path='doc/member[@name="SpeechSpecialTransitionType.SSTTWildcard"]/*' />
    SSTTWildcard = 1,

    /// <include file='SpeechSpecialTransitionType.xml' path='doc/member[@name="SpeechSpecialTransitionType.SSTTDictation"]/*' />
    SSTTDictation = (SSTTWildcard + 1),

    /// <include file='SpeechSpecialTransitionType.xml' path='doc/member[@name="SpeechSpecialTransitionType.SSTTTextBuffer"]/*' />
    SSTTTextBuffer = (SSTTDictation + 1),
}
