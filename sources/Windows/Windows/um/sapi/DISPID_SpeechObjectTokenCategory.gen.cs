// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechObjectTokenCategory.xml' path='doc/member[@name="DISPID_SpeechObjectTokenCategory"]/*' />
public enum DISPID_SpeechObjectTokenCategory
{
    /// <include file='DISPID_SpeechObjectTokenCategory.xml' path='doc/member[@name="DISPID_SpeechObjectTokenCategory.DISPID_SOTCId"]/*' />
    DISPID_SOTCId = 1,

    /// <include file='DISPID_SpeechObjectTokenCategory.xml' path='doc/member[@name="DISPID_SpeechObjectTokenCategory.DISPID_SOTCDefault"]/*' />
    DISPID_SOTCDefault = (DISPID_SOTCId + 1),

    /// <include file='DISPID_SpeechObjectTokenCategory.xml' path='doc/member[@name="DISPID_SpeechObjectTokenCategory.DISPID_SOTCSetId"]/*' />
    DISPID_SOTCSetId = (DISPID_SOTCDefault + 1),

    /// <include file='DISPID_SpeechObjectTokenCategory.xml' path='doc/member[@name="DISPID_SpeechObjectTokenCategory.DISPID_SOTCGetDataKey"]/*' />
    DISPID_SOTCGetDataKey = (DISPID_SOTCSetId + 1),

    /// <include file='DISPID_SpeechObjectTokenCategory.xml' path='doc/member[@name="DISPID_SpeechObjectTokenCategory.DISPID_SOTCEnumerateTokens"]/*' />
    DISPID_SOTCEnumerateTokens = (DISPID_SOTCGetDataKey + 1),
}
