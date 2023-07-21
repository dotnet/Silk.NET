// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static Silk.NET.Windows.SPSTREAMFORMATTYPE;

namespace Silk.NET.Windows;

/// <include file='SpeechFormatType.xml' path='doc/member[@name="SpeechFormatType"]/*' />
public enum SpeechFormatType
{
    /// <include file='SpeechFormatType.xml' path='doc/member[@name="SpeechFormatType.SFTInput"]/*' />
    SFTInput = SPWF_INPUT,

    /// <include file='SpeechFormatType.xml' path='doc/member[@name="SpeechFormatType.SFTSREngine"]/*' />
    SFTSREngine = SPWF_SRENGINE,
}
