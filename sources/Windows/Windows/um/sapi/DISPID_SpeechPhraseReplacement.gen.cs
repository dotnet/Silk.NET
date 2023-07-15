// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechPhraseReplacement.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacement"]/*'/>
public enum DISPID_SpeechPhraseReplacement
{
    /// <include file='DISPID_SpeechPhraseReplacement.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacement.DISPID_SPRDisplayAttributes"]/*'/>
    DISPID_SPRDisplayAttributes = 1,
    /// <include file='DISPID_SpeechPhraseReplacement.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacement.DISPID_SPRText"]/*'/>
    DISPID_SPRText = (DISPID_SPRDisplayAttributes + 1),
    /// <include file='DISPID_SpeechPhraseReplacement.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacement.DISPID_SPRFirstElement"]/*'/>
    DISPID_SPRFirstElement = (DISPID_SPRText + 1),
    /// <include file='DISPID_SpeechPhraseReplacement.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacement.DISPID_SPRNumberOfElements"]/*'/>
    DISPID_SPRNumberOfElements = (DISPID_SPRFirstElement + 1),
}