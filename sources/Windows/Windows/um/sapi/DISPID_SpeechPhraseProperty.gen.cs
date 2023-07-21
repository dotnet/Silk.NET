// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty"]/*' />
public enum DISPID_SpeechPhraseProperty
{
    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPName"]/*' />
    DISPID_SPPName = 1,

    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPId"]/*' />
    DISPID_SPPId = (DISPID_SPPName + 1),

    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPValue"]/*' />
    DISPID_SPPValue = (DISPID_SPPId + 1),

    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPFirstElement"]/*' />
    DISPID_SPPFirstElement = (DISPID_SPPValue + 1),

    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPNumberOfElements"]/*' />
    DISPID_SPPNumberOfElements = (DISPID_SPPFirstElement + 1),

    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPEngineConfidence"]/*' />
    DISPID_SPPEngineConfidence = (DISPID_SPPNumberOfElements + 1),

    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPConfidence"]/*' />
    DISPID_SPPConfidence = (DISPID_SPPEngineConfidence + 1),

    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPParent"]/*' />
    DISPID_SPPParent = (DISPID_SPPConfidence + 1),

    /// <include file='DISPID_SpeechPhraseProperty.xml' path='doc/member[@name="DISPID_SpeechPhraseProperty.DISPID_SPPChildren"]/*' />
    DISPID_SPPChildren = (DISPID_SPPParent + 1),
}
